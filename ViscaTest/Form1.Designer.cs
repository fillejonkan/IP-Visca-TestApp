namespace ViscaTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Play = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.RelPTZUp = new System.Windows.Forms.Button();
            this.PTZRelDown = new System.Windows.Forms.Button();
            this.PTZRelLeft = new System.Windows.Forms.Button();
            this.PTZRelRight = new System.Windows.Forms.Button();
            this.PTStop = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PresetStore = new System.Windows.Forms.Button();
            this.PresetRecall = new System.Windows.Forms.Button();
            this.PTZRelZoomIn = new System.Windows.Forms.Button();
            this.PTZZoomRelOut = new System.Windows.Forms.Button();
            this.PTZZoomRelStop = new System.Windows.Forms.Button();
            this.PTZRelUpLeft = new System.Windows.Forms.Button();
            this.PTZRelUpright = new System.Windows.Forms.Button();
            this.PTZRelDownLeft = new System.Windows.Forms.Button();
            this.PTZRelDownRight = new System.Windows.Forms.Button();
            this.IrisRelOpen = new System.Windows.Forms.Button();
            this.IrisRelClose = new System.Windows.Forms.Button();
            this.IrisReset = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.IrisDirect = new System.Windows.Forms.Button();
            this.DirectZoomTextBox = new System.Windows.Forms.TextBox();
            this.DirectZoom = new System.Windows.Forms.Button();
            this.AbsPanText = new System.Windows.Forms.TextBox();
            this.Pan = new System.Windows.Forms.Label();
            this.AbsPanTilt = new System.Windows.Forms.Button();
            this.SpeedText = new System.Windows.Forms.TextBox();
            this.AbsTiltText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RelPTDrive = new System.Windows.Forms.Button();
            this.PTHome = new System.Windows.Forms.Button();
            this.PTReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.VarZoomSpeedText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ZoomTele = new System.Windows.Forms.Button();
            this.ZoomWide = new System.Windows.Forms.Button();
            this.FocusText = new System.Windows.Forms.TextBox();
            this.Focus = new System.Windows.Forms.Label();
            this.DirectFocus = new System.Windows.Forms.Button();
            this.RelFocusFar = new System.Windows.Forms.Button();
            this.RelFocusNear = new System.Windows.Forms.Button();
            this.AutofocusOn = new System.Windows.Forms.Button();
            this.AutofocusOff = new System.Windows.Forms.Button();
            this.IrisManual = new System.Windows.Forms.Button();
            this.FlipModeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(1969, 992);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(224, 94);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(2231, 992);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(249, 94);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(2442, 12);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(49, 46);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "";
            // 
            // RelPTZUp
            // 
            this.RelPTZUp.Location = new System.Drawing.Point(2061, 429);
            this.RelPTZUp.Name = "RelPTZUp";
            this.RelPTZUp.Size = new System.Drawing.Size(196, 84);
            this.RelPTZUp.TabIndex = 4;
            this.RelPTZUp.Text = "Up";
            this.RelPTZUp.UseVisualStyleBackColor = true;
            this.RelPTZUp.Click += new System.EventHandler(this.RelPTZUp_Click);
            // 
            // PTZRelDown
            // 
            this.PTZRelDown.Location = new System.Drawing.Point(2070, 641);
            this.PTZRelDown.Name = "PTZRelDown";
            this.PTZRelDown.Size = new System.Drawing.Size(171, 88);
            this.PTZRelDown.TabIndex = 5;
            this.PTZRelDown.Text = "Down";
            this.PTZRelDown.UseVisualStyleBackColor = true;
            this.PTZRelDown.Click += new System.EventHandler(this.PTZRelDown_Click);
            // 
            // PTZRelLeft
            // 
            this.PTZRelLeft.Location = new System.Drawing.Point(1928, 536);
            this.PTZRelLeft.Name = "PTZRelLeft";
            this.PTZRelLeft.Size = new System.Drawing.Size(103, 90);
            this.PTZRelLeft.TabIndex = 6;
            this.PTZRelLeft.Text = "Left";
            this.PTZRelLeft.UseVisualStyleBackColor = true;
            this.PTZRelLeft.Click += new System.EventHandler(this.PTZRelLeft_Click);
            // 
            // PTZRelRight
            // 
            this.PTZRelRight.Location = new System.Drawing.Point(2258, 524);
            this.PTZRelRight.Name = "PTZRelRight";
            this.PTZRelRight.Size = new System.Drawing.Size(151, 107);
            this.PTZRelRight.TabIndex = 7;
            this.PTZRelRight.Text = "Right";
            this.PTZRelRight.UseVisualStyleBackColor = true;
            this.PTZRelRight.Click += new System.EventHandler(this.PTZRelRight_Click);
            // 
            // PTStop
            // 
            this.PTStop.Location = new System.Drawing.Point(2070, 529);
            this.PTStop.Name = "PTStop";
            this.PTStop.Size = new System.Drawing.Size(159, 97);
            this.PTStop.TabIndex = 8;
            this.PTStop.Text = "PTStop";
            this.PTStop.UseVisualStyleBackColor = true;
            this.PTStop.Click += new System.EventHandler(this.PTStop_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listBox1.Location = new System.Drawing.Point(2001, 790);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 97);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PresetStore
            // 
            this.PresetStore.Location = new System.Drawing.Point(2199, 789);
            this.PresetStore.Name = "PresetStore";
            this.PresetStore.Size = new System.Drawing.Size(159, 53);
            this.PresetStore.TabIndex = 10;
            this.PresetStore.Text = "Store";
            this.PresetStore.UseVisualStyleBackColor = true;
            this.PresetStore.Click += new System.EventHandler(this.PresetStore_Click);
            // 
            // PresetRecall
            // 
            this.PresetRecall.Location = new System.Drawing.Point(2199, 848);
            this.PresetRecall.Name = "PresetRecall";
            this.PresetRecall.Size = new System.Drawing.Size(159, 54);
            this.PresetRecall.TabIndex = 11;
            this.PresetRecall.Text = "Recall";
            this.PresetRecall.UseVisualStyleBackColor = true;
            this.PresetRecall.Click += new System.EventHandler(this.PresetRecall_Click);
            // 
            // PTZRelZoomIn
            // 
            this.PTZRelZoomIn.Location = new System.Drawing.Point(2106, 64);
            this.PTZRelZoomIn.Name = "PTZRelZoomIn";
            this.PTZRelZoomIn.Size = new System.Drawing.Size(196, 99);
            this.PTZRelZoomIn.TabIndex = 12;
            this.PTZRelZoomIn.Text = "Zoom +";
            this.PTZRelZoomIn.UseVisualStyleBackColor = true;
            this.PTZRelZoomIn.Click += new System.EventHandler(this.PTZRelZoomIn_Click);
            // 
            // PTZZoomRelOut
            // 
            this.PTZZoomRelOut.Location = new System.Drawing.Point(2107, 169);
            this.PTZZoomRelOut.Name = "PTZZoomRelOut";
            this.PTZZoomRelOut.Size = new System.Drawing.Size(195, 94);
            this.PTZZoomRelOut.TabIndex = 13;
            this.PTZZoomRelOut.Text = "Zoom -";
            this.PTZZoomRelOut.UseVisualStyleBackColor = true;
            this.PTZZoomRelOut.Click += new System.EventHandler(this.PTZZoomRelOut_Click);
            // 
            // PTZZoomRelStop
            // 
            this.PTZZoomRelStop.Location = new System.Drawing.Point(2308, 64);
            this.PTZZoomRelStop.Name = "PTZZoomRelStop";
            this.PTZZoomRelStop.Size = new System.Drawing.Size(153, 99);
            this.PTZZoomRelStop.TabIndex = 14;
            this.PTZZoomRelStop.Text = "Zoom Stop";
            this.PTZZoomRelStop.UseVisualStyleBackColor = true;
            this.PTZZoomRelStop.Click += new System.EventHandler(this.PTZZoomRelStop_Click);
            // 
            // PTZRelUpLeft
            // 
            this.PTZRelUpLeft.Location = new System.Drawing.Point(1928, 429);
            this.PTZRelUpLeft.Name = "PTZRelUpLeft";
            this.PTZRelUpLeft.Size = new System.Drawing.Size(103, 84);
            this.PTZRelUpLeft.TabIndex = 15;
            this.PTZRelUpLeft.Text = "Upleft";
            this.PTZRelUpLeft.UseVisualStyleBackColor = true;
            this.PTZRelUpLeft.Click += new System.EventHandler(this.PTZRelUpLeft_Click);
            // 
            // PTZRelUpright
            // 
            this.PTZRelUpright.Location = new System.Drawing.Point(2264, 429);
            this.PTZRelUpright.Name = "PTZRelUpright";
            this.PTZRelUpright.Size = new System.Drawing.Size(129, 84);
            this.PTZRelUpright.TabIndex = 16;
            this.PTZRelUpright.Text = "Upright";
            this.PTZRelUpright.UseVisualStyleBackColor = true;
            this.PTZRelUpright.Click += new System.EventHandler(this.PTZRelUpright_Click);
            // 
            // PTZRelDownLeft
            // 
            this.PTZRelDownLeft.Location = new System.Drawing.Point(1928, 641);
            this.PTZRelDownLeft.Name = "PTZRelDownLeft";
            this.PTZRelDownLeft.Size = new System.Drawing.Size(109, 96);
            this.PTZRelDownLeft.TabIndex = 17;
            this.PTZRelDownLeft.Text = "DownLeft";
            this.PTZRelDownLeft.UseVisualStyleBackColor = true;
            this.PTZRelDownLeft.Click += new System.EventHandler(this.PTZRelDownLeft_Click);
            // 
            // PTZRelDownRight
            // 
            this.PTZRelDownRight.Location = new System.Drawing.Point(2248, 641);
            this.PTZRelDownRight.Name = "PTZRelDownRight";
            this.PTZRelDownRight.Size = new System.Drawing.Size(178, 96);
            this.PTZRelDownRight.TabIndex = 18;
            this.PTZRelDownRight.Text = "DownRight";
            this.PTZRelDownRight.UseVisualStyleBackColor = true;
            this.PTZRelDownRight.Click += new System.EventHandler(this.PTZRelDownRight_Click);
            // 
            // IrisRelOpen
            // 
            this.IrisRelOpen.Location = new System.Drawing.Point(2106, 270);
            this.IrisRelOpen.Name = "IrisRelOpen";
            this.IrisRelOpen.Size = new System.Drawing.Size(196, 78);
            this.IrisRelOpen.TabIndex = 19;
            this.IrisRelOpen.Text = "Iris Open";
            this.IrisRelOpen.UseVisualStyleBackColor = true;
            this.IrisRelOpen.Click += new System.EventHandler(this.IrisRelOpen_Click);
            // 
            // IrisRelClose
            // 
            this.IrisRelClose.Location = new System.Drawing.Point(2107, 355);
            this.IrisRelClose.Name = "IrisRelClose";
            this.IrisRelClose.Size = new System.Drawing.Size(195, 58);
            this.IrisRelClose.TabIndex = 20;
            this.IrisRelClose.Text = "Iris Close";
            this.IrisRelClose.UseVisualStyleBackColor = true;
            this.IrisRelClose.Click += new System.EventHandler(this.IrisRelClose_Click);
            // 
            // IrisReset
            // 
            this.IrisReset.Location = new System.Drawing.Point(2308, 292);
            this.IrisReset.Name = "IrisReset";
            this.IrisReset.Size = new System.Drawing.Size(153, 74);
            this.IrisReset.TabIndex = 21;
            this.IrisReset.Text = "Iris Auto";
            this.IrisReset.UseVisualStyleBackColor = true;
            this.IrisReset.Click += new System.EventHandler(this.IrisReset_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.listBox2.Location = new System.Drawing.Point(1900, 219);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(172, 97);
            this.listBox2.TabIndex = 22;
            // 
            // IrisDirect
            // 
            this.IrisDirect.Location = new System.Drawing.Point(1900, 324);
            this.IrisDirect.Name = "IrisDirect";
            this.IrisDirect.Size = new System.Drawing.Size(172, 74);
            this.IrisDirect.TabIndex = 23;
            this.IrisDirect.Text = "Iris Direct";
            this.IrisDirect.UseVisualStyleBackColor = true;
            this.IrisDirect.Click += new System.EventHandler(this.IrisDirect_Click);
            // 
            // DirectZoomTextBox
            // 
            this.DirectZoomTextBox.Location = new System.Drawing.Point(1834, 81);
            this.DirectZoomTextBox.Name = "DirectZoomTextBox";
            this.DirectZoomTextBox.Size = new System.Drawing.Size(120, 38);
            this.DirectZoomTextBox.TabIndex = 24;
            // 
            // DirectZoom
            // 
            this.DirectZoom.Location = new System.Drawing.Point(1969, 95);
            this.DirectZoom.Name = "DirectZoom";
            this.DirectZoom.Size = new System.Drawing.Size(121, 87);
            this.DirectZoom.TabIndex = 25;
            this.DirectZoom.Text = "DirectZoom";
            this.DirectZoom.UseVisualStyleBackColor = true;
            this.DirectZoom.Click += new System.EventHandler(this.DirectZoom_Click);
            // 
            // AbsPanText
            // 
            this.AbsPanText.Location = new System.Drawing.Point(1413, 811);
            this.AbsPanText.Name = "AbsPanText";
            this.AbsPanText.Size = new System.Drawing.Size(135, 38);
            this.AbsPanText.TabIndex = 26;
            // 
            // Pan
            // 
            this.Pan.AutoSize = true;
            this.Pan.Location = new System.Drawing.Point(1305, 810);
            this.Pan.Name = "Pan";
            this.Pan.Size = new System.Drawing.Size(66, 32);
            this.Pan.TabIndex = 27;
            this.Pan.Text = "Pan";
            // 
            // AbsPanTilt
            // 
            this.AbsPanTilt.Location = new System.Drawing.Point(1555, 814);
            this.AbsPanTilt.Name = "AbsPanTilt";
            this.AbsPanTilt.Size = new System.Drawing.Size(133, 88);
            this.AbsPanTilt.TabIndex = 28;
            this.AbsPanTilt.Text = "Abs P/T";
            this.AbsPanTilt.UseVisualStyleBackColor = true;
            this.AbsPanTilt.Click += new System.EventHandler(this.AbsPanTilt_Click);
            // 
            // SpeedText
            // 
            this.SpeedText.Location = new System.Drawing.Point(1413, 767);
            this.SpeedText.Name = "SpeedText";
            this.SpeedText.Size = new System.Drawing.Size(135, 38);
            this.SpeedText.TabIndex = 29;
            // 
            // AbsTiltText
            // 
            this.AbsTiltText.Location = new System.Drawing.Point(1413, 852);
            this.AbsTiltText.Name = "AbsTiltText";
            this.AbsTiltText.Size = new System.Drawing.Size(135, 38);
            this.AbsTiltText.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1317, 852);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tilt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1305, 767);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Speed";
            // 
            // RelPTDrive
            // 
            this.RelPTDrive.Location = new System.Drawing.Point(1555, 736);
            this.RelPTDrive.Name = "RelPTDrive";
            this.RelPTDrive.Size = new System.Drawing.Size(133, 72);
            this.RelPTDrive.TabIndex = 33;
            this.RelPTDrive.Text = "Rel P/T";
            this.RelPTDrive.UseVisualStyleBackColor = true;
            this.RelPTDrive.Click += new System.EventHandler(this.RelPTDrive_Click);
            // 
            // PTHome
            // 
            this.PTHome.Location = new System.Drawing.Point(1448, 912);
            this.PTHome.Name = "PTHome";
            this.PTHome.Size = new System.Drawing.Size(119, 61);
            this.PTHome.TabIndex = 34;
            this.PTHome.Text = "Home";
            this.PTHome.UseVisualStyleBackColor = true;
            this.PTHome.Click += new System.EventHandler(this.PTHome_Click);
            // 
            // PTReset
            // 
            this.PTReset.Location = new System.Drawing.Point(1574, 912);
            this.PTReset.Name = "PTReset";
            this.PTReset.Size = new System.Drawing.Size(142, 61);
            this.PTReset.TabIndex = 35;
            this.PTReset.Text = "Reset";
            this.PTReset.UseVisualStyleBackColor = true;
            this.PTReset.Click += new System.EventHandler(this.PTReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1683, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 36;
            this.label3.Text = "ZoomVal";
            // 
            // VarZoomSpeedText
            // 
            this.VarZoomSpeedText.Location = new System.Drawing.Point(2333, 181);
            this.VarZoomSpeedText.Name = "VarZoomSpeedText";
            this.VarZoomSpeedText.Size = new System.Drawing.Size(128, 38);
            this.VarZoomSpeedText.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2327, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "VZSpeed";
            // 
            // ZoomTele
            // 
            this.ZoomTele.Location = new System.Drawing.Point(1689, 169);
            this.ZoomTele.Name = "ZoomTele";
            this.ZoomTele.Size = new System.Drawing.Size(158, 61);
            this.ZoomTele.TabIndex = 39;
            this.ZoomTele.Text = "Tele";
            this.ZoomTele.UseVisualStyleBackColor = true;
            this.ZoomTele.Click += new System.EventHandler(this.ZoomTele_Click);
            // 
            // ZoomWide
            // 
            this.ZoomWide.Location = new System.Drawing.Point(1689, 252);
            this.ZoomWide.Name = "ZoomWide";
            this.ZoomWide.Size = new System.Drawing.Size(158, 64);
            this.ZoomWide.TabIndex = 40;
            this.ZoomWide.Text = "Wide";
            this.ZoomWide.UseVisualStyleBackColor = true;
            this.ZoomWide.Click += new System.EventHandler(this.ZoomWide_Click);
            // 
            // FocusText
            // 
            this.FocusText.Location = new System.Drawing.Point(1689, 389);
            this.FocusText.Name = "FocusText";
            this.FocusText.Size = new System.Drawing.Size(100, 38);
            this.FocusText.TabIndex = 41;
            // 
            // Focus
            // 
            this.Focus.AutoSize = true;
            this.Focus.Location = new System.Drawing.Point(1555, 394);
            this.Focus.Name = "Focus";
            this.Focus.Size = new System.Drawing.Size(134, 32);
            this.Focus.TabIndex = 42;
            this.Focus.Text = "FocusVal";
            // 
            // DirectFocus
            // 
            this.DirectFocus.Location = new System.Drawing.Point(1689, 434);
            this.DirectFocus.Name = "DirectFocus";
            this.DirectFocus.Size = new System.Drawing.Size(158, 79);
            this.DirectFocus.TabIndex = 43;
            this.DirectFocus.Text = "DirectFocus";
            this.DirectFocus.UseVisualStyleBackColor = true;
            this.DirectFocus.Click += new System.EventHandler(this.DirectFocus_Click);
            // 
            // RelFocusFar
            // 
            this.RelFocusFar.Location = new System.Drawing.Point(1689, 520);
            this.RelFocusFar.Name = "RelFocusFar";
            this.RelFocusFar.Size = new System.Drawing.Size(158, 77);
            this.RelFocusFar.TabIndex = 44;
            this.RelFocusFar.Text = "Focus +";
            this.RelFocusFar.UseVisualStyleBackColor = true;
            this.RelFocusFar.Click += new System.EventHandler(this.RelFocusFar_Click);
            // 
            // RelFocusNear
            // 
            this.RelFocusNear.Location = new System.Drawing.Point(1689, 604);
            this.RelFocusNear.Name = "RelFocusNear";
            this.RelFocusNear.Size = new System.Drawing.Size(158, 82);
            this.RelFocusNear.TabIndex = 45;
            this.RelFocusNear.Text = "Focus -";
            this.RelFocusNear.UseVisualStyleBackColor = true;
            this.RelFocusNear.Click += new System.EventHandler(this.RelFocusNear_Click);
            // 
            // AutofocusOn
            // 
            this.AutofocusOn.Location = new System.Drawing.Point(1555, 520);
            this.AutofocusOn.Name = "AutofocusOn";
            this.AutofocusOn.Size = new System.Drawing.Size(128, 77);
            this.AutofocusOn.TabIndex = 46;
            this.AutofocusOn.Text = "AF ON";
            this.AutofocusOn.UseVisualStyleBackColor = true;
            this.AutofocusOn.Click += new System.EventHandler(this.AutofocusOn_Click);
            // 
            // AutofocusOff
            // 
            this.AutofocusOff.Location = new System.Drawing.Point(1555, 604);
            this.AutofocusOff.Name = "AutofocusOff";
            this.AutofocusOff.Size = new System.Drawing.Size(128, 82);
            this.AutofocusOff.TabIndex = 47;
            this.AutofocusOff.Text = "AF OFF";
            this.AutofocusOff.UseVisualStyleBackColor = true;
            this.AutofocusOff.Click += new System.EventHandler(this.AutofocusOff_Click);
            // 
            // IrisManual
            // 
            this.IrisManual.Location = new System.Drawing.Point(2309, 389);
            this.IrisManual.Name = "IrisManual";
            this.IrisManual.Size = new System.Drawing.Size(152, 34);
            this.IrisManual.TabIndex = 48;
            this.IrisManual.Text = "Man Iris";
            this.IrisManual.UseVisualStyleBackColor = true;
            this.IrisManual.Click += new System.EventHandler(this.IrisManual_Click);
            // 
            // FlipModeCheckBox
            // 
            this.FlipModeCheckBox.AutoSize = true;
            this.FlipModeCheckBox.Location = new System.Drawing.Point(1480, 155);
            this.FlipModeCheckBox.Name = "FlipModeCheckBox";
            this.FlipModeCheckBox.Size = new System.Drawing.Size(171, 36);
            this.FlipModeCheckBox.TabIndex = 49;
            this.FlipModeCheckBox.Text = "FlipMode";
            this.FlipModeCheckBox.UseVisualStyleBackColor = true;
            this.FlipModeCheckBox.CheckedChanged += new System.EventHandler(this.FlipModeCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2527, 1350);
            this.Controls.Add(this.FlipModeCheckBox);
            this.Controls.Add(this.IrisManual);
            this.Controls.Add(this.AutofocusOff);
            this.Controls.Add(this.AutofocusOn);
            this.Controls.Add(this.RelFocusNear);
            this.Controls.Add(this.RelFocusFar);
            this.Controls.Add(this.DirectFocus);
            this.Controls.Add(this.Focus);
            this.Controls.Add(this.FocusText);
            this.Controls.Add(this.ZoomWide);
            this.Controls.Add(this.ZoomTele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VarZoomSpeedText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PTReset);
            this.Controls.Add(this.PTHome);
            this.Controls.Add(this.RelPTDrive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AbsTiltText);
            this.Controls.Add(this.SpeedText);
            this.Controls.Add(this.AbsPanTilt);
            this.Controls.Add(this.Pan);
            this.Controls.Add(this.AbsPanText);
            this.Controls.Add(this.DirectZoom);
            this.Controls.Add(this.DirectZoomTextBox);
            this.Controls.Add(this.IrisDirect);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.IrisReset);
            this.Controls.Add(this.IrisRelClose);
            this.Controls.Add(this.IrisRelOpen);
            this.Controls.Add(this.PTZRelDownRight);
            this.Controls.Add(this.PTZRelDownLeft);
            this.Controls.Add(this.PTZRelUpright);
            this.Controls.Add(this.PTZRelUpLeft);
            this.Controls.Add(this.PTZZoomRelStop);
            this.Controls.Add(this.PTZZoomRelOut);
            this.Controls.Add(this.PTZRelZoomIn);
            this.Controls.Add(this.PresetRecall);
            this.Controls.Add(this.PresetStore);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PTStop);
            this.Controls.Add(this.PTZRelRight);
            this.Controls.Add(this.PTZRelLeft);
            this.Controls.Add(this.PTZRelDown);
            this.Controls.Add(this.RelPTZUp);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button RelPTZUp;
        private System.Windows.Forms.Button PTZRelDown;
        private System.Windows.Forms.Button PTZRelLeft;
        private System.Windows.Forms.Button PTZRelRight;
        private System.Windows.Forms.Button PTStop;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button PresetStore;
        private System.Windows.Forms.Button PresetRecall;
        private System.Windows.Forms.Button PTZRelZoomIn;
        private System.Windows.Forms.Button PTZZoomRelOut;
        private System.Windows.Forms.Button PTZZoomRelStop;
        private System.Windows.Forms.Button PTZRelUpLeft;
        private System.Windows.Forms.Button PTZRelUpright;
        private System.Windows.Forms.Button PTZRelDownLeft;
        private System.Windows.Forms.Button PTZRelDownRight;
        private System.Windows.Forms.Button IrisRelOpen;
        private System.Windows.Forms.Button IrisRelClose;
        private System.Windows.Forms.Button IrisReset;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button IrisDirect;
        private System.Windows.Forms.TextBox DirectZoomTextBox;
        private System.Windows.Forms.Button DirectZoom;
        private System.Windows.Forms.TextBox AbsPanText;
        private System.Windows.Forms.Label Pan;
        private System.Windows.Forms.Button AbsPanTilt;
        private System.Windows.Forms.TextBox SpeedText;
        private System.Windows.Forms.TextBox AbsTiltText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RelPTDrive;
        private System.Windows.Forms.Button PTHome;
        private System.Windows.Forms.Button PTReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VarZoomSpeedText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ZoomTele;
        private System.Windows.Forms.Button ZoomWide;
        private System.Windows.Forms.TextBox FocusText;
        private System.Windows.Forms.Label Focus;
        private System.Windows.Forms.Button DirectFocus;
        private System.Windows.Forms.Button RelFocusFar;
        private System.Windows.Forms.Button RelFocusNear;
        private System.Windows.Forms.Button AutofocusOn;
        private System.Windows.Forms.Button AutofocusOff;
        private System.Windows.Forms.Button IrisManual;
        private System.Windows.Forms.CheckBox FlipModeCheckBox;
    }
}

