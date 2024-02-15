using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ViscaTest
{
    public partial class Form1 : Form
    {
        int listenPort;
        Int32 msg_idx = 0;
        int cur_preset = 0;

        UdpClient listener;
        IPEndPoint groupEP;

        IPAddress device;
        IPEndPoint deviceEP;

        private AxAXISMEDIACONTROLLib.AxAxisMediaControl DynAMC = new AxAXISMEDIACONTROLLib.AxAxisMediaControl();

        private void printBuf(byte[] buf)
        {
            var sb = new StringBuilder("{ ");
            foreach (var b in buf)
            {
                sb.Append(String.Format("0x{0:X2}, ", b));
            }
            sb.Append("}");
            TextBox.AppendText(sb.ToString() + "\n\n");
            Console.WriteLine(sb.ToString());
        }

        private void SendPTZCommand(byte [] buf)
        {
            byte cmd_len = (byte) buf.Length;

            byte[] header = { 0x01, 0x00, 0x00, cmd_len, 0x00, 0x00, 0x00, (byte) msg_idx };

            byte[] command = header.Concat(buf).ToArray();

            SendReceive(command, true);
        }

        private byte[] SendReceive(byte[] buf, Boolean double_response=false)
        {
            msg_idx++;
            listener.Send(buf, buf.Length, deviceEP);
            Console.WriteLine("Message sent to the device");
            TextBox.AppendText("S - ");
            printBuf(buf);

            byte[] rec = listener.Receive(ref groupEP);
            Console.WriteLine("Message received from the device: ");
            TextBox.AppendText("R - ");
            printBuf(rec);

            if (double_response)
            {
                rec = listener.Receive(ref groupEP);
                Console.WriteLine("Message received from the device: ");
                TextBox.AppendText("R - ");
                printBuf(rec);
            }

            return rec;
        }

        public Form1()
        {
            InitializeComponent();

            listenPort = 52381;

            listener = new UdpClient(listenPort);
            groupEP = new IPEndPoint(IPAddress.Any, listenPort);

            device = IPAddress.Parse("192.168.2.4");
            deviceEP = new IPEndPoint(device, listenPort);

            // Send Clear_IF Request
            byte[] sendbuf = { 0x01, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x02, 0x81, 0x01, 0x00, 0x01, 0xFF };
            SendReceive(sendbuf);

            // Send Cam Version Inquiry Request
            byte[] sendbuf2 = { 0x01, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x03, 0x81, 0x09, 0x00, 0x02, 0xFF };

            SendReceive(sendbuf2);

            // Send Camera Flip mode Inquiry Request
            byte[] sendbuf3 = { 0x01, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x07, 0x81, 0x09, 0x04, 0x66, 0xFF };

            byte[] rec = SendReceive(sendbuf3);

            int flip_mode_byte = rec[10] & 0x0F;

            if (flip_mode_byte == 0x02)
            {
                FlipModeCheckBox.Checked = true;
            } else if (flip_mode_byte == 0x03) {
                FlipModeCheckBox.Checked = false;
            } else
            {
                System.Environment.Exit(1);
            }

            // Send Camera AF mode Inquiry request
            byte[] sendbuf4 = { 0x01, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x07, 0x81, 0x09, 0x04, 0x38, 0xFF };

            SendReceive(sendbuf4);

            // Send Camera PT Position Inq request
            byte[] sendbuf5 = { 0x01, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x07, 0x81, 0x09, 0x06, 0x12, 0xFF };

            rec = SendReceive(sendbuf5);

            String pan = String.Format("0x{0:X1}{1:X1}{2:X1}{3:X1}{4:X1}", rec[10], rec[11], rec[12], rec[13], rec[14]);
            String tilt = String.Format("0x{0:X1}{1:X1}{2:X1}{3:X1}", rec[15], rec[16], rec[17], rec[18]);

            byte[] sendbuf6 = { 0x01, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x07, 0x81, 0x09, 0x04, 0x47, 0xFF };

            rec = SendReceive(sendbuf6);

            String Zoom = String.Format("0x{0:X1}{1:X1}{2:X1}{3:X1}", rec[10], rec[11], rec[12], rec[13]);

            AbsPanText.Text  = pan;
            AbsTiltText.Text = tilt;
            DirectZoomTextBox.Text = Zoom;
            SpeedText.Text = "10";
            VarZoomSpeedText.Text = "7";
        }

        private void Play_Click(object sender, EventArgs e)
        {
            DynAMC.Size = new System.Drawing.Size(640, 360);
            DynAMC.Location = new System.Drawing.Point(0, 0);

            Controls.Add(DynAMC);

            DynAMC.MediaURL = "rtsp://root:Wojyxy87@192.168.1.84/axis-media/media.amp?videocodec=jpeg&resolution=320x240";
            DynAMC.MediaType = "mjpeg";
            DynAMC.Play();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            DynAMC.Stop();
        }

        private void RelPTZUp_Click(object sender, EventArgs e)
        {
            byte Speed = (byte)Convert.ToInt32(SpeedText.Text);

            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x01, Speed, Speed, 0x03, 0x01, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PTZRelDown_Click(object sender, EventArgs e)
        {
            byte Speed = (byte)Convert.ToInt32(SpeedText.Text);

            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x01, Speed, Speed, 0x03, 0x02, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PTZRelLeft_Click(object sender, EventArgs e)
        {
            byte Speed = (byte)Convert.ToInt32(SpeedText.Text);

            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x01, Speed, Speed, 0x01, 0x03, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PTZRelRight_Click(object sender, EventArgs e)
        {
            byte Speed = (byte)Convert.ToInt32(SpeedText.Text);

            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x01, Speed, Speed, 0x02, 0x03, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PTStop_Click(object sender, EventArgs e)
        {
            byte Speed = (byte)Convert.ToInt32(SpeedText.Text);

            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x01, 7, 7, 0x03, 0x03, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PresetStore_Click(object sender, EventArgs e)
        {
            int preset = Convert.ToInt32(listBox1.SelectedItem.ToString());

            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x3F, 0x01, (byte)preset, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PresetRecall_Click(object sender, EventArgs e)
        {
            int preset = Convert.ToInt32(listBox1.SelectedItem.ToString());

            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x3F, 0x02, (byte)preset, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PTZRelZoomIn_Click(object sender, EventArgs e)
        {
            byte Speed = (byte) (Convert.ToInt32(VarZoomSpeedText.Text) & 0x0F);

            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x07, (byte) (0x20 | Speed), 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PTZZoomRelOut_Click(object sender, EventArgs e)
        {
            byte Speed = (byte)(Convert.ToInt32(VarZoomSpeedText.Text) & 0x0F);

            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x07, (byte) (0x30 | Speed), 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PTZZoomRelStop_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x07, 0x00, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PTZRelUpLeft_Click(object sender, EventArgs e)
        {
            byte Speed = (byte)Convert.ToInt32(SpeedText.Text);

            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x01, Speed, Speed, 0x01, 0x01, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PTZRelUpright_Click(object sender, EventArgs e)
        {
            byte Speed = (byte)Convert.ToInt32(SpeedText.Text);

            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x01, Speed, Speed, 0x02, 0x01, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PTZRelDownLeft_Click(object sender, EventArgs e)
        {
            byte Speed = (byte)Convert.ToInt32(SpeedText.Text);

            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x01, Speed, Speed, 0x01, 0x02, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void PTZRelDownRight_Click(object sender, EventArgs e)
        {
            byte Speed = (byte)Convert.ToInt32(SpeedText.Text);

            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x01, Speed, Speed, 0x02, 0x02, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void IrisRelOpen_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x0B, 0x02, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void IrisRelClose_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x0B, 0x03, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void IrisReset_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x39, 0x00, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void IrisDirect_Click(object sender, EventArgs e)
        {
            int F = Convert.ToInt32(listBox2.SelectedItem.ToString());
            byte p = (byte) ((F & 0xF0) >> 4);
            byte q = (byte)(F & 0x0F);

            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x4B, 0x00, 0x00, p, q, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void DirectZoom_Click(object sender, EventArgs e)
        {
            int Z = Convert.ToInt32(DirectZoomTextBox.Text, 16);

            byte p = (byte)((Z & 0xF000) >> 12);
            byte q = (byte)((Z & 0x0F00) >> 8);
            byte r = (byte)((Z & 0x00F0) >> 4);
            byte s = (byte)(Z & 0x000F);

            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x47, p, q, r, s, 0xFF };

            SendPTZCommand(visca_cmd);
        }

        private void AbsPanTilt_Click(object sender, EventArgs e)
        {
            int Pan = Convert.ToInt32(AbsPanText.Text, 16);
            int Tilt = Convert.ToInt32(AbsTiltText.Text, 16);

            byte Speed = (byte)Convert.ToInt32(SpeedText.Text);

            byte z = (byte)((Pan & 0xF0000) >> 16);
            byte p = (byte)((Pan & 0x0F000) >> 12);
            byte q = (byte)((Pan & 0x00F00) >> 8);
            byte r = (byte)((Pan & 0x000F0) >> 4);
            byte s = (byte)(Pan &  0x0000F);

            byte t = (byte)((Tilt & 0xF000) >> 12);
            byte v = (byte)((Tilt & 0x0F00) >> 8);
            byte w = (byte)((Tilt & 0x00F0) >> 4);
            byte u = (byte)(Tilt & 0x000F);

            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x02, Speed, Speed, z, p, q, r, s, t, v, w, u, 0xFF };

            SendPTZCommand(visca_cmd);
        }

        private void RelPTDrive_Click(object sender, EventArgs e)
        {
            int Pan = Convert.ToInt32(AbsPanText.Text, 16);
            int Tilt = Convert.ToInt32(AbsTiltText.Text, 16);

            byte Speed = (byte)Convert.ToInt32(SpeedText.Text);

            byte z = (byte)((Pan & 0xF0000) >> 16);
            byte p = (byte)((Pan & 0x0F000) >> 12);
            byte q = (byte)((Pan & 0x00F00) >> 8);
            byte r = (byte)((Pan & 0x000F0) >> 4);
            byte s = (byte)(Pan & 0x0000F);

            byte t = (byte)((Tilt & 0xF000) >> 12);
            byte v = (byte)((Tilt & 0x0F00) >> 8);
            byte w = (byte)((Tilt & 0x00F0) >> 4);
            byte u = (byte)(Tilt & 0x000F);

            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x03, Speed, Speed, z, p, q, r, s, t, v, w, u, 0xFF };

            SendPTZCommand(visca_cmd);
        }

        private void PTHome_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x04, 0xFF};

            SendPTZCommand(visca_cmd);
        }

        private void PTReset_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x06, 0x05, 0xFF };

            SendPTZCommand(visca_cmd);
        }

        private void ZoomTele_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x07, 0x02, 0xFF };

            SendPTZCommand(visca_cmd);
        }

        private void ZoomWide_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x07, 0x03, 0xFF };

            SendPTZCommand(visca_cmd);
        }

        private void DirectFocus_Click(object sender, EventArgs e)
        {
            int Focus = Convert.ToInt32(FocusText.Text, 16);

            byte p = (byte)((Focus & 0xF000) >> 12);
            byte q = (byte)((Focus & 0x0F00) >> 8);
            byte r = (byte)((Focus & 0x00F0) >> 4);
            byte s = (byte)(Focus & 0x000F);

            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x48, p, q, r, s, 0xFF };

            SendPTZCommand(visca_cmd);
        }

        private void RelFocusFar_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x08, 0x27, 0xFF };

            SendPTZCommand(visca_cmd);
        }

        private void RelFocusNear_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x08, 0x37, 0xFF };

            SendPTZCommand(visca_cmd);
        }

        private void AutofocusOn_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x38, 0x02, 0xFF };

            SendPTZCommand(visca_cmd);
        }

        private void AutofocusOff_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x38, 0x03, 0xFF };

            SendPTZCommand(visca_cmd);
        }

        private void IrisManual_Click(object sender, EventArgs e)
        {
            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x39, 0x03, 0xFF };
            SendPTZCommand(visca_cmd);
        }

        private void FlipModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool ischecked = FlipModeCheckBox.Checked;

            byte flip_mode_byte;

            if (ischecked)
            {
                flip_mode_byte = 0x02;
            } else
            {
                flip_mode_byte = 0x03;
            }

            byte[] visca_cmd = { 0x81, 0x01, 0x04, 0x66, flip_mode_byte, 0xFF };

            SendPTZCommand(visca_cmd);
        }
    }
}
