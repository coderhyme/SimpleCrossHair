namespace SimpleCrossHair
{
    partial class Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.PosXText = new System.Windows.Forms.TextBox();
            this.PosXTrack = new System.Windows.Forms.TrackBar();
            this.PosYTrack = new System.Windows.Forms.TrackBar();
            this.PosYText = new System.Windows.Forms.TextBox();
            this.CrossOpacityTrack = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CircleDiameterTrack = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.CrossColorBox = new System.Windows.Forms.PictureBox();
            this.CircleCheck = new System.Windows.Forms.CheckBox();
            this.CrossCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CrossThicknessText = new System.Windows.Forms.TextBox();
            this.CrossThicknessTrack = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.CrossGapText = new System.Windows.Forms.TextBox();
            this.CrossGapTrack = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.CrossLengthText = new System.Windows.Forms.TextBox();
            this.CrossLengthTrack = new System.Windows.Forms.TrackBar();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.CrossSettingPage = new System.Windows.Forms.TabPage();
            this.CrossPanel = new System.Windows.Forms.Panel();
            this.labelColor = new System.Windows.Forms.Label();
            this.CrossOpacityText = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CirclePanel = new System.Windows.Forms.Panel();
            this.CircleRotateText = new System.Windows.Forms.TextBox();
            this.CircleRotateTrack = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.CircleGrooveAngleText = new System.Windows.Forms.TextBox();
            this.CircleGrooveAngleTrack = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.GrooveCountText = new System.Windows.Forms.TextBox();
            this.GrooveCountTrack = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.CircleThicknessText = new System.Windows.Forms.TextBox();
            this.CircleThicknessTrack = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CircleOpacityText = new System.Windows.Forms.TextBox();
            this.CircleOpacityTrack = new System.Windows.Forms.TrackBar();
            this.CircleColorBox = new System.Windows.Forms.PictureBox();
            this.CircleDiameterText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PosXTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosYTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossOpacityTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleDiameterTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossThicknessTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossGapTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossLengthTrack)).BeginInit();
            this.TabControl.SuspendLayout();
            this.CrossSettingPage.SuspendLayout();
            this.CrossPanel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.CirclePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CircleRotateTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleGrooveAngleTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrooveCountTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleThicknessTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleOpacityTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // PosXText
            // 
            this.PosXText.HideSelection = false;
            this.PosXText.Location = new System.Drawing.Point(430, 18);
            this.PosXText.MaxLength = 10;
            this.PosXText.Name = "PosXText";
            this.PosXText.Size = new System.Drawing.Size(100, 21);
            this.PosXText.TabIndex = 2;
            this.PosXText.Tag = this.PosXTrack;
            this.PosXText.WordWrap = false;
            this.PosXText.TextChanged += new System.EventHandler(this.OnNumberTextChanged);
            this.PosXText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumberTextKeyPress);
            // 
            // PosXTrack
            // 
            this.PosXTrack.AutoSize = false;
            this.PosXTrack.Location = new System.Drawing.Point(61, 13);
            this.PosXTrack.Name = "PosXTrack";
            this.PosXTrack.Size = new System.Drawing.Size(363, 30);
            this.PosXTrack.TabIndex = 1;
            this.PosXTrack.TickFrequency = 0;
            this.PosXTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // PosYTrack
            // 
            this.PosYTrack.AutoSize = false;
            this.PosYTrack.Location = new System.Drawing.Point(61, 46);
            this.PosYTrack.Name = "PosYTrack";
            this.PosYTrack.Size = new System.Drawing.Size(363, 30);
            this.PosYTrack.TabIndex = 3;
            this.PosYTrack.TickFrequency = 0;
            this.PosYTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // PosYText
            // 
            this.PosYText.HideSelection = false;
            this.PosYText.Location = new System.Drawing.Point(430, 51);
            this.PosYText.MaxLength = 10;
            this.PosYText.Name = "PosYText";
            this.PosYText.Size = new System.Drawing.Size(100, 21);
            this.PosYText.TabIndex = 4;
            this.PosYText.Tag = this.PosYTrack;
            this.PosYText.WordWrap = false;
            this.PosYText.TextChanged += new System.EventHandler(this.OnNumberTextChanged);
            this.PosYText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumberTextKeyPress);
            // 
            // CrossOpacityTrack
            // 
            this.CrossOpacityTrack.AutoSize = false;
            this.CrossOpacityTrack.Location = new System.Drawing.Point(47, 102);
            this.CrossOpacityTrack.Maximum = 100;
            this.CrossOpacityTrack.Minimum = 1;
            this.CrossOpacityTrack.Name = "CrossOpacityTrack";
            this.CrossOpacityTrack.Size = new System.Drawing.Size(363, 30);
            this.CrossOpacityTrack.TabIndex = 5;
            this.CrossOpacityTrack.TickFrequency = 0;
            this.CrossOpacityTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CrossOpacityTrack.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "투명도";
            // 
            // CircleDiameterTrack
            // 
            this.CircleDiameterTrack.AutoSize = false;
            this.CircleDiameterTrack.Location = new System.Drawing.Point(43, 2);
            this.CircleDiameterTrack.Maximum = 200;
            this.CircleDiameterTrack.Minimum = 1;
            this.CircleDiameterTrack.Name = "CircleDiameterTrack";
            this.CircleDiameterTrack.Size = new System.Drawing.Size(363, 30);
            this.CircleDiameterTrack.TabIndex = 16;
            this.CircleDiameterTrack.TickFrequency = 0;
            this.CircleDiameterTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CircleDiameterTrack.Value = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "크기";
            // 
            // CrossColorBox
            // 
            this.CrossColorBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CrossColorBox.Location = new System.Drawing.Point(52, 140);
            this.CrossColorBox.Name = "CrossColorBox";
            this.CrossColorBox.Size = new System.Drawing.Size(56, 21);
            this.CrossColorBox.TabIndex = 12;
            this.CrossColorBox.TabStop = false;
            this.CrossColorBox.Click += new System.EventHandler(this.OnColorBoxClick);
            // 
            // CircleCheck
            // 
            this.CircleCheck.AutoSize = true;
            this.CircleCheck.Location = new System.Drawing.Point(3, 6);
            this.CircleCheck.Name = "CircleCheck";
            this.CircleCheck.Size = new System.Drawing.Size(72, 16);
            this.CircleCheck.TabIndex = 15;
            this.CircleCheck.Text = "사용하기";
            this.CircleCheck.UseVisualStyleBackColor = true;
            // 
            // CrossCheck
            // 
            this.CrossCheck.AutoSize = true;
            this.CrossCheck.Location = new System.Drawing.Point(3, 6);
            this.CrossCheck.Name = "CrossCheck";
            this.CrossCheck.Size = new System.Drawing.Size(72, 16);
            this.CrossCheck.TabIndex = 8;
            this.CrossCheck.Text = "사용하기";
            this.CrossCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "두께";
            // 
            // CrossThicknessText
            // 
            this.CrossThicknessText.HideSelection = false;
            this.CrossThicknessText.Location = new System.Drawing.Point(412, 41);
            this.CrossThicknessText.MaxLength = 10;
            this.CrossThicknessText.Name = "CrossThicknessText";
            this.CrossThicknessText.Size = new System.Drawing.Size(100, 21);
            this.CrossThicknessText.TabIndex = 12;
            this.CrossThicknessText.Tag = this.CrossThicknessTrack;
            this.CrossThicknessText.WordWrap = false;
            this.CrossThicknessText.TextChanged += new System.EventHandler(this.OnNumberTextChanged);
            this.CrossThicknessText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumberTextKeyPress);
            // 
            // CrossThicknessTrack
            // 
            this.CrossThicknessTrack.AutoSize = false;
            this.CrossThicknessTrack.Location = new System.Drawing.Point(47, 36);
            this.CrossThicknessTrack.Maximum = 100;
            this.CrossThicknessTrack.Minimum = 1;
            this.CrossThicknessTrack.Name = "CrossThicknessTrack";
            this.CrossThicknessTrack.Size = new System.Drawing.Size(363, 30);
            this.CrossThicknessTrack.TabIndex = 11;
            this.CrossThicknessTrack.TickFrequency = 0;
            this.CrossThicknessTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CrossThicknessTrack.Value = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "거리";
            // 
            // CrossGapText
            // 
            this.CrossGapText.HideSelection = false;
            this.CrossGapText.Location = new System.Drawing.Point(412, 74);
            this.CrossGapText.MaxLength = 10;
            this.CrossGapText.Name = "CrossGapText";
            this.CrossGapText.Size = new System.Drawing.Size(100, 21);
            this.CrossGapText.TabIndex = 14;
            this.CrossGapText.Tag = this.CrossGapTrack;
            this.CrossGapText.WordWrap = false;
            this.CrossGapText.TextChanged += new System.EventHandler(this.OnNumberTextChanged);
            this.CrossGapText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumberTextKeyPress);
            // 
            // CrossGapTrack
            // 
            this.CrossGapTrack.AutoSize = false;
            this.CrossGapTrack.Location = new System.Drawing.Point(47, 69);
            this.CrossGapTrack.Maximum = 50;
            this.CrossGapTrack.Minimum = 1;
            this.CrossGapTrack.Name = "CrossGapTrack";
            this.CrossGapTrack.Size = new System.Drawing.Size(363, 30);
            this.CrossGapTrack.TabIndex = 13;
            this.CrossGapTrack.TickFrequency = 0;
            this.CrossGapTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CrossGapTrack.Value = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "길이";
            // 
            // CrossLengthText
            // 
            this.CrossLengthText.HideSelection = false;
            this.CrossLengthText.Location = new System.Drawing.Point(412, 8);
            this.CrossLengthText.MaxLength = 10;
            this.CrossLengthText.Name = "CrossLengthText";
            this.CrossLengthText.Size = new System.Drawing.Size(100, 21);
            this.CrossLengthText.TabIndex = 10;
            this.CrossLengthText.Tag = this.CrossLengthTrack;
            this.CrossLengthText.WordWrap = false;
            this.CrossLengthText.TextChanged += new System.EventHandler(this.OnNumberTextChanged);
            this.CrossLengthText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumberTextKeyPress);
            // 
            // CrossLengthTrack
            // 
            this.CrossLengthTrack.AutoSize = false;
            this.CrossLengthTrack.Location = new System.Drawing.Point(47, 3);
            this.CrossLengthTrack.Maximum = 100;
            this.CrossLengthTrack.Minimum = 1;
            this.CrossLengthTrack.Name = "CrossLengthTrack";
            this.CrossLengthTrack.Size = new System.Drawing.Size(363, 30);
            this.CrossLengthTrack.TabIndex = 9;
            this.CrossLengthTrack.TickFrequency = 0;
            this.CrossLengthTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CrossLengthTrack.Value = 1;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CrossSettingPage);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(12, 84);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(519, 301);
            this.TabControl.TabIndex = 7;
            // 
            // CrossSettingPage
            // 
            this.CrossSettingPage.BackColor = System.Drawing.SystemColors.Control;
            this.CrossSettingPage.Controls.Add(this.CrossPanel);
            this.CrossSettingPage.Controls.Add(this.CrossCheck);
            this.CrossSettingPage.Location = new System.Drawing.Point(4, 22);
            this.CrossSettingPage.Name = "CrossSettingPage";
            this.CrossSettingPage.Padding = new System.Windows.Forms.Padding(3);
            this.CrossSettingPage.Size = new System.Drawing.Size(511, 275);
            this.CrossSettingPage.TabIndex = 0;
            this.CrossSettingPage.Text = "십자선";
            // 
            // CrossPanel
            // 
            this.CrossPanel.Controls.Add(this.labelColor);
            this.CrossPanel.Controls.Add(this.label7);
            this.CrossPanel.Controls.Add(this.CrossOpacityText);
            this.CrossPanel.Controls.Add(this.CrossColorBox);
            this.CrossPanel.Controls.Add(this.CrossLengthText);
            this.CrossPanel.Controls.Add(this.label6);
            this.CrossPanel.Controls.Add(this.CrossLengthTrack);
            this.CrossPanel.Controls.Add(this.label3);
            this.CrossPanel.Controls.Add(this.CrossGapText);
            this.CrossPanel.Controls.Add(this.CrossGapTrack);
            this.CrossPanel.Controls.Add(this.CrossOpacityTrack);
            this.CrossPanel.Controls.Add(this.CrossThicknessText);
            this.CrossPanel.Controls.Add(this.CrossThicknessTrack);
            this.CrossPanel.Controls.Add(this.label5);
            this.CrossPanel.Location = new System.Drawing.Point(-4, 28);
            this.CrossPanel.Name = "CrossPanel";
            this.CrossPanel.Size = new System.Drawing.Size(530, 245);
            this.CrossPanel.TabIndex = 26;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(17, 144);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(29, 12);
            this.labelColor.TabIndex = 29;
            this.labelColor.Text = "색상";
            // 
            // CrossOpacityText
            // 
            this.CrossOpacityText.HideSelection = false;
            this.CrossOpacityText.Location = new System.Drawing.Point(412, 107);
            this.CrossOpacityText.MaxLength = 10;
            this.CrossOpacityText.Name = "CrossOpacityText";
            this.CrossOpacityText.Size = new System.Drawing.Size(100, 21);
            this.CrossOpacityText.TabIndex = 6;
            this.CrossOpacityText.Tag = this.CrossOpacityTrack;
            this.CrossOpacityText.WordWrap = false;
            this.CrossOpacityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumberTextKeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.CirclePanel);
            this.tabPage3.Controls.Add(this.CircleCheck);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(511, 275);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "원";
            // 
            // CirclePanel
            // 
            this.CirclePanel.Controls.Add(this.CircleRotateText);
            this.CirclePanel.Controls.Add(this.label13);
            this.CirclePanel.Controls.Add(this.CircleRotateTrack);
            this.CirclePanel.Controls.Add(this.CircleGrooveAngleText);
            this.CirclePanel.Controls.Add(this.label12);
            this.CirclePanel.Controls.Add(this.CircleGrooveAngleTrack);
            this.CirclePanel.Controls.Add(this.GrooveCountText);
            this.CirclePanel.Controls.Add(this.label11);
            this.CirclePanel.Controls.Add(this.GrooveCountTrack);
            this.CirclePanel.Controls.Add(this.CircleThicknessText);
            this.CirclePanel.Controls.Add(this.CircleThicknessTrack);
            this.CirclePanel.Controls.Add(this.label10);
            this.CirclePanel.Controls.Add(this.label9);
            this.CirclePanel.Controls.Add(this.CircleOpacityText);
            this.CirclePanel.Controls.Add(this.CircleColorBox);
            this.CirclePanel.Controls.Add(this.CircleDiameterText);
            this.CirclePanel.Controls.Add(this.label8);
            this.CirclePanel.Controls.Add(this.CircleDiameterTrack);
            this.CirclePanel.Controls.Add(this.CircleOpacityTrack);
            this.CirclePanel.Controls.Add(this.label4);
            this.CirclePanel.Location = new System.Drawing.Point(0, 29);
            this.CirclePanel.Name = "CirclePanel";
            this.CirclePanel.Size = new System.Drawing.Size(519, 268);
            this.CirclePanel.TabIndex = 16;
            // 
            // CircleRotateText
            // 
            this.CircleRotateText.HideSelection = false;
            this.CircleRotateText.Location = new System.Drawing.Point(407, 172);
            this.CircleRotateText.MaxLength = 10;
            this.CircleRotateText.Name = "CircleRotateText";
            this.CircleRotateText.Size = new System.Drawing.Size(100, 21);
            this.CircleRotateText.TabIndex = 43;
            this.CircleRotateText.Tag = this.CircleRotateTrack;
            this.CircleRotateText.WordWrap = false;
            this.CircleRotateText.TextChanged += new System.EventHandler(this.OnNumberTextChanged);
            this.CircleRotateText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumberTextKeyPress);
            // 
            // CircleRotateTrack
            // 
            this.CircleRotateTrack.AutoSize = false;
            this.CircleRotateTrack.Location = new System.Drawing.Point(43, 167);
            this.CircleRotateTrack.Maximum = 359;
            this.CircleRotateTrack.Name = "CircleRotateTrack";
            this.CircleRotateTrack.Size = new System.Drawing.Size(363, 30);
            this.CircleRotateTrack.TabIndex = 42;
            this.CircleRotateTrack.TickFrequency = 0;
            this.CircleRotateTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CircleRotateTrack.Value = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 44;
            this.label13.Text = "회전";
            // 
            // CircleGrooveAngleText
            // 
            this.CircleGrooveAngleText.HideSelection = false;
            this.CircleGrooveAngleText.Location = new System.Drawing.Point(407, 139);
            this.CircleGrooveAngleText.MaxLength = 10;
            this.CircleGrooveAngleText.Name = "CircleGrooveAngleText";
            this.CircleGrooveAngleText.Size = new System.Drawing.Size(100, 21);
            this.CircleGrooveAngleText.TabIndex = 40;
            this.CircleGrooveAngleText.Tag = this.CircleGrooveAngleTrack;
            this.CircleGrooveAngleText.WordWrap = false;
            this.CircleGrooveAngleText.TextChanged += new System.EventHandler(this.OnNumberTextChanged);
            this.CircleGrooveAngleText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumberTextKeyPress);
            // 
            // CircleGrooveAngleTrack
            // 
            this.CircleGrooveAngleTrack.AutoSize = false;
            this.CircleGrooveAngleTrack.Location = new System.Drawing.Point(43, 134);
            this.CircleGrooveAngleTrack.Maximum = 100;
            this.CircleGrooveAngleTrack.Minimum = 1;
            this.CircleGrooveAngleTrack.Name = "CircleGrooveAngleTrack";
            this.CircleGrooveAngleTrack.Size = new System.Drawing.Size(363, 30);
            this.CircleGrooveAngleTrack.TabIndex = 39;
            this.CircleGrooveAngleTrack.TickFrequency = 0;
            this.CircleGrooveAngleTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CircleGrooveAngleTrack.Value = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 12);
            this.label12.TabIndex = 41;
            this.label12.Text = "홈 크기";
            // 
            // GrooveCountText
            // 
            this.GrooveCountText.HideSelection = false;
            this.GrooveCountText.Location = new System.Drawing.Point(407, 106);
            this.GrooveCountText.MaxLength = 10;
            this.GrooveCountText.Name = "GrooveCountText";
            this.GrooveCountText.Size = new System.Drawing.Size(100, 21);
            this.GrooveCountText.TabIndex = 37;
            this.GrooveCountText.Tag = this.GrooveCountTrack;
            this.GrooveCountText.WordWrap = false;
            this.GrooveCountText.TextChanged += new System.EventHandler(this.OnNumberTextChanged);
            this.GrooveCountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumberTextKeyPress);
            // 
            // GrooveCountTrack
            // 
            this.GrooveCountTrack.AutoSize = false;
            this.GrooveCountTrack.Location = new System.Drawing.Point(43, 101);
            this.GrooveCountTrack.Maximum = 60;
            this.GrooveCountTrack.Name = "GrooveCountTrack";
            this.GrooveCountTrack.Size = new System.Drawing.Size(363, 30);
            this.GrooveCountTrack.TabIndex = 36;
            this.GrooveCountTrack.TickFrequency = 0;
            this.GrooveCountTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 12);
            this.label11.TabIndex = 38;
            this.label11.Text = "홈 개수";
            // 
            // CircleThicknessText
            // 
            this.CircleThicknessText.HideSelection = false;
            this.CircleThicknessText.Location = new System.Drawing.Point(407, 40);
            this.CircleThicknessText.MaxLength = 10;
            this.CircleThicknessText.Name = "CircleThicknessText";
            this.CircleThicknessText.Size = new System.Drawing.Size(100, 21);
            this.CircleThicknessText.TabIndex = 35;
            this.CircleThicknessText.Tag = "";
            this.CircleThicknessText.WordWrap = false;
            // 
            // CircleThicknessTrack
            // 
            this.CircleThicknessTrack.AutoSize = false;
            this.CircleThicknessTrack.Location = new System.Drawing.Point(43, 35);
            this.CircleThicknessTrack.Maximum = 100;
            this.CircleThicknessTrack.Minimum = 1;
            this.CircleThicknessTrack.Name = "CircleThicknessTrack";
            this.CircleThicknessTrack.Size = new System.Drawing.Size(363, 30);
            this.CircleThicknessTrack.TabIndex = 34;
            this.CircleThicknessTrack.TickFrequency = 0;
            this.CircleThicknessTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CircleThicknessTrack.Value = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "두께";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "색상";
            // 
            // CircleOpacityText
            // 
            this.CircleOpacityText.HideSelection = false;
            this.CircleOpacityText.Location = new System.Drawing.Point(407, 73);
            this.CircleOpacityText.MaxLength = 10;
            this.CircleOpacityText.Name = "CircleOpacityText";
            this.CircleOpacityText.Size = new System.Drawing.Size(100, 21);
            this.CircleOpacityText.TabIndex = 31;
            this.CircleOpacityText.Tag = this.CircleOpacityTrack;
            this.CircleOpacityText.WordWrap = false;
            this.CircleOpacityText.TextChanged += new System.EventHandler(this.OnNumberTextChanged);
            this.CircleOpacityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumberTextKeyPress);
            // 
            // CircleOpacityTrack
            // 
            this.CircleOpacityTrack.AutoSize = false;
            this.CircleOpacityTrack.Location = new System.Drawing.Point(43, 68);
            this.CircleOpacityTrack.Maximum = 100;
            this.CircleOpacityTrack.Minimum = 1;
            this.CircleOpacityTrack.Name = "CircleOpacityTrack";
            this.CircleOpacityTrack.Size = new System.Drawing.Size(363, 30);
            this.CircleOpacityTrack.TabIndex = 30;
            this.CircleOpacityTrack.TickFrequency = 0;
            this.CircleOpacityTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CircleOpacityTrack.Value = 1;
            // 
            // CircleColorBox
            // 
            this.CircleColorBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CircleColorBox.Location = new System.Drawing.Point(53, 205);
            this.CircleColorBox.Name = "CircleColorBox";
            this.CircleColorBox.Size = new System.Drawing.Size(56, 21);
            this.CircleColorBox.TabIndex = 30;
            this.CircleColorBox.TabStop = false;
            this.CircleColorBox.Click += new System.EventHandler(this.OnColorBoxClick);
            // 
            // CircleDiameterText
            // 
            this.CircleDiameterText.HideSelection = false;
            this.CircleDiameterText.Location = new System.Drawing.Point(407, 7);
            this.CircleDiameterText.MaxLength = 10;
            this.CircleDiameterText.Name = "CircleDiameterText";
            this.CircleDiameterText.Size = new System.Drawing.Size(100, 21);
            this.CircleDiameterText.TabIndex = 17;
            this.CircleDiameterText.Tag = this.CircleDiameterTrack;
            this.CircleDiameterText.WordWrap = false;
            this.CircleDiameterText.TextChanged += new System.EventHandler(this.OnNumberTextChanged);
            this.CircleDiameterText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumberTextKeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "투명도";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 389);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PosYText);
            this.Controls.Add(this.PosYTrack);
            this.Controls.Add(this.PosXText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PosXTrack);
            this.MaximizeBox = false;
            this.Name = "Setting";
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.PosXTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosYTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossOpacityTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleDiameterTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossThicknessTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossGapTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossLengthTrack)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.CrossSettingPage.ResumeLayout(false);
            this.CrossSettingPage.PerformLayout();
            this.CrossPanel.ResumeLayout(false);
            this.CrossPanel.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.CirclePanel.ResumeLayout(false);
            this.CirclePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CircleRotateTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleGrooveAngleTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrooveCountTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleThicknessTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleOpacityTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar PosXTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PosXText;
        private System.Windows.Forms.TrackBar PosYTrack;
        private System.Windows.Forms.TextBox PosYText;
        private System.Windows.Forms.TrackBar CrossOpacityTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar CircleDiameterTrack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox CrossColorBox;
        private System.Windows.Forms.CheckBox CircleCheck;
        private System.Windows.Forms.CheckBox CrossCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CrossThicknessText;
        private System.Windows.Forms.TrackBar CrossThicknessTrack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CrossGapText;
        private System.Windows.Forms.TrackBar CrossGapTrack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CrossLengthText;
        private System.Windows.Forms.TrackBar CrossLengthTrack;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CrossSettingPage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel CrossPanel;
        private System.Windows.Forms.Panel CirclePanel;
        private System.Windows.Forms.TextBox CircleDiameterText;
        private System.Windows.Forms.TextBox CrossOpacityText;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox CircleOpacityText;
        private System.Windows.Forms.TrackBar CircleOpacityTrack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox CircleColorBox;
        private System.Windows.Forms.TextBox CircleThicknessText;
        private System.Windows.Forms.TrackBar CircleThicknessTrack;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CircleGrooveAngleText;
        private System.Windows.Forms.TrackBar CircleGrooveAngleTrack;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox GrooveCountText;
        private System.Windows.Forms.TrackBar GrooveCountTrack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CircleRotateText;
        private System.Windows.Forms.TrackBar CircleRotateTrack;
        private System.Windows.Forms.Label label13;
    }
}