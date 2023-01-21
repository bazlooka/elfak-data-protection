namespace ZI_17714
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRc4Encrypt = new System.Windows.Forms.Button();
            this.tcAlgorithm = new System.Windows.Forms.TabControl();
            this.RC4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRC4Key = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRc4EncryptBmp = new System.Windows.Forms.Button();
            this.btnRc4DecryptBmp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRc4Decrypt = new System.Windows.Forms.Button();
            this.Enigma = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnEnigmaDecrypt = new System.Windows.Forms.Button();
            this.btnEnigmaEncrypt = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbEnigmaReflector = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEnigmaPlugboard = new System.Windows.Forms.TextBox();
            this.tbEnigmaRotors = new System.Windows.Forms.TextBox();
            this.tbEnigmaRingSettings = new System.Windows.Forms.TextBox();
            this.tbEnigmaKeySettings = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TEA = new System.Windows.Forms.TabPage();
            this.gbCBC = new System.Windows.Forms.GroupBox();
            this.IV = new System.Windows.Forms.Label();
            this.tbIV = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.rbTEAwithCBC = new System.Windows.Forms.RadioButton();
            this.rbTEAMultithreaded = new System.Windows.Forms.RadioButton();
            this.rbTEAStandard = new System.Windows.Forms.RadioButton();
            this.tbTEAKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbMultithread = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTEAThreadCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTEAEncrypt = new System.Windows.Forms.Button();
            this.btnTEADecrypt = new System.Windows.Forms.Button();
            this.CRC = new System.Windows.Forms.TabPage();
            this.btnCRC = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFile2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFile1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tcAlgorithm.SuspendLayout();
            this.RC4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Enigma.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.TEA.SuspendLayout();
            this.gbCBC.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.gbMultithread.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTEAThreadCount)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.CRC.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRc4Encrypt
            // 
            this.btnRc4Encrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRc4Encrypt.Location = new System.Drawing.Point(6, 22);
            this.btnRc4Encrypt.Name = "btnRc4Encrypt";
            this.btnRc4Encrypt.Size = new System.Drawing.Size(90, 53);
            this.btnRc4Encrypt.TabIndex = 0;
            this.btnRc4Encrypt.Text = "Enkriptuj";
            this.btnRc4Encrypt.UseVisualStyleBackColor = true;
            this.btnRc4Encrypt.Click += new System.EventHandler(this.BtnRc4Encrypt_Click);
            // 
            // tcAlgorithm
            // 
            this.tcAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAlgorithm.Controls.Add(this.RC4);
            this.tcAlgorithm.Controls.Add(this.Enigma);
            this.tcAlgorithm.Controls.Add(this.TEA);
            this.tcAlgorithm.Controls.Add(this.CRC);
            this.tcAlgorithm.Location = new System.Drawing.Point(12, 122);
            this.tcAlgorithm.Name = "tcAlgorithm";
            this.tcAlgorithm.SelectedIndex = 0;
            this.tcAlgorithm.Size = new System.Drawing.Size(489, 181);
            this.tcAlgorithm.TabIndex = 1;
            this.tcAlgorithm.SelectedIndexChanged += new System.EventHandler(this.TcAlgorithm_SelectedIndexChanged);
            // 
            // RC4
            // 
            this.RC4.Controls.Add(this.groupBox7);
            this.RC4.Controls.Add(this.groupBox4);
            this.RC4.Controls.Add(this.groupBox3);
            this.RC4.Location = new System.Drawing.Point(4, 24);
            this.RC4.Name = "RC4";
            this.RC4.Padding = new System.Windows.Forms.Padding(3);
            this.RC4.Size = new System.Drawing.Size(481, 153);
            this.RC4.TabIndex = 0;
            this.RC4.Text = "RC4";
            this.RC4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.tbRC4Key);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(252, 141);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Podešavanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ključ:";
            // 
            // tbRC4Key
            // 
            this.tbRC4Key.Location = new System.Drawing.Point(50, 22);
            this.tbRC4Key.Name = "tbRC4Key";
            this.tbRC4Key.Size = new System.Drawing.Size(185, 23);
            this.tbRC4Key.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnRc4EncryptBmp);
            this.groupBox4.Controls.Add(this.btnRc4DecryptBmp);
            this.groupBox4.Location = new System.Drawing.Point(373, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(102, 141);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BMP fajlovi";
            // 
            // btnRc4EncryptBmp
            // 
            this.btnRc4EncryptBmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRc4EncryptBmp.Location = new System.Drawing.Point(6, 22);
            this.btnRc4EncryptBmp.Name = "btnRc4EncryptBmp";
            this.btnRc4EncryptBmp.Size = new System.Drawing.Size(90, 53);
            this.btnRc4EncryptBmp.TabIndex = 4;
            this.btnRc4EncryptBmp.Text = "Enkriptuj";
            this.btnRc4EncryptBmp.UseVisualStyleBackColor = true;
            this.btnRc4EncryptBmp.Click += new System.EventHandler(this.BtnRc4EncryptBmp_Click);
            // 
            // btnRc4DecryptBmp
            // 
            this.btnRc4DecryptBmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRc4DecryptBmp.Location = new System.Drawing.Point(6, 82);
            this.btnRc4DecryptBmp.Name = "btnRc4DecryptBmp";
            this.btnRc4DecryptBmp.Size = new System.Drawing.Size(90, 53);
            this.btnRc4DecryptBmp.TabIndex = 5;
            this.btnRc4DecryptBmp.Text = "Dekriptuj";
            this.btnRc4DecryptBmp.UseVisualStyleBackColor = true;
            this.btnRc4DecryptBmp.Click += new System.EventHandler(this.BtnRc4DecryptBmp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnRc4Encrypt);
            this.groupBox3.Controls.Add(this.btnRc4Decrypt);
            this.groupBox3.Location = new System.Drawing.Point(264, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(102, 141);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Svi fajlovi";
            // 
            // btnRc4Decrypt
            // 
            this.btnRc4Decrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRc4Decrypt.Location = new System.Drawing.Point(6, 82);
            this.btnRc4Decrypt.Name = "btnRc4Decrypt";
            this.btnRc4Decrypt.Size = new System.Drawing.Size(90, 53);
            this.btnRc4Decrypt.TabIndex = 1;
            this.btnRc4Decrypt.Text = "Dekriptuj";
            this.btnRc4Decrypt.UseVisualStyleBackColor = true;
            this.btnRc4Decrypt.Click += new System.EventHandler(this.BtnRc4Decrypt_Click);
            // 
            // Enigma
            // 
            this.Enigma.Controls.Add(this.groupBox9);
            this.Enigma.Controls.Add(this.groupBox8);
            this.Enigma.Location = new System.Drawing.Point(4, 24);
            this.Enigma.Name = "Enigma";
            this.Enigma.Padding = new System.Windows.Forms.Padding(3);
            this.Enigma.Size = new System.Drawing.Size(481, 153);
            this.Enigma.TabIndex = 1;
            this.Enigma.Text = "Enigma";
            this.Enigma.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnEnigmaDecrypt);
            this.groupBox9.Controls.Add(this.btnEnigmaEncrypt);
            this.groupBox9.Location = new System.Drawing.Point(363, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(112, 141);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "TXT Fajlovi";
            // 
            // btnEnigmaDecrypt
            // 
            this.btnEnigmaDecrypt.Location = new System.Drawing.Point(6, 78);
            this.btnEnigmaDecrypt.Name = "btnEnigmaDecrypt";
            this.btnEnigmaDecrypt.Size = new System.Drawing.Size(101, 57);
            this.btnEnigmaDecrypt.TabIndex = 1;
            this.btnEnigmaDecrypt.Text = "Dekriptuj";
            this.btnEnigmaDecrypt.UseVisualStyleBackColor = true;
            this.btnEnigmaDecrypt.Click += new System.EventHandler(this.BtnEnigmaDecrypt_click);
            // 
            // btnEnigmaEncrypt
            // 
            this.btnEnigmaEncrypt.Location = new System.Drawing.Point(6, 17);
            this.btnEnigmaEncrypt.Name = "btnEnigmaEncrypt";
            this.btnEnigmaEncrypt.Size = new System.Drawing.Size(101, 55);
            this.btnEnigmaEncrypt.TabIndex = 0;
            this.btnEnigmaEncrypt.Text = "Enkriptuj";
            this.btnEnigmaEncrypt.UseVisualStyleBackColor = true;
            this.btnEnigmaEncrypt.Click += new System.EventHandler(this.BtnEnigmaEncrypt_click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.cbEnigmaReflector);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.tbEnigmaPlugboard);
            this.groupBox8.Controls.Add(this.tbEnigmaRotors);
            this.groupBox8.Controls.Add(this.tbEnigmaRingSettings);
            this.groupBox8.Controls.Add(this.tbEnigmaKeySettings);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(351, 141);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Podešavanja";
            // 
            // cbEnigmaReflector
            // 
            this.cbEnigmaReflector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnigmaReflector.FormattingEnabled = true;
            this.cbEnigmaReflector.Items.AddRange(new object[] {
            "Reflector A",
            "Reflector B",
            "Reflector C"});
            this.cbEnigmaReflector.Location = new System.Drawing.Point(85, 75);
            this.cbEnigmaReflector.Name = "cbEnigmaReflector";
            this.cbEnigmaReflector.Size = new System.Drawing.Size(97, 23);
            this.cbEnigmaReflector.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Reflector:";
            // 
            // tbEnigmaPlugboard
            // 
            this.tbEnigmaPlugboard.Location = new System.Drawing.Point(85, 104);
            this.tbEnigmaPlugboard.Name = "tbEnigmaPlugboard";
            this.tbEnigmaPlugboard.Size = new System.Drawing.Size(260, 23);
            this.tbEnigmaPlugboard.TabIndex = 7;
            this.tbEnigmaPlugboard.Text = "AB CD EF";
            // 
            // tbEnigmaRotors
            // 
            this.tbEnigmaRotors.Location = new System.Drawing.Point(85, 46);
            this.tbEnigmaRotors.Name = "tbEnigmaRotors";
            this.tbEnigmaRotors.Size = new System.Drawing.Size(97, 23);
            this.tbEnigmaRotors.TabIndex = 6;
            this.tbEnigmaRotors.Text = "123";
            // 
            // tbEnigmaRingSettings
            // 
            this.tbEnigmaRingSettings.Location = new System.Drawing.Point(275, 17);
            this.tbEnigmaRingSettings.Name = "tbEnigmaRingSettings";
            this.tbEnigmaRingSettings.Size = new System.Drawing.Size(70, 23);
            this.tbEnigmaRingSettings.TabIndex = 5;
            this.tbEnigmaRingSettings.Text = "AAA";
            // 
            // tbEnigmaKeySettings
            // 
            this.tbEnigmaKeySettings.Location = new System.Drawing.Point(85, 17);
            this.tbEnigmaKeySettings.Name = "tbEnigmaKeySettings";
            this.tbEnigmaKeySettings.Size = new System.Drawing.Size(97, 23);
            this.tbEnigmaKeySettings.TabIndex = 4;
            this.tbEnigmaKeySettings.Text = "AAA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Plug board:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Rotors (1-5):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ring settings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Key settings:";
            // 
            // TEA
            // 
            this.TEA.Controls.Add(this.gbCBC);
            this.TEA.Controls.Add(this.groupBox10);
            this.TEA.Controls.Add(this.gbMultithread);
            this.TEA.Controls.Add(this.groupBox5);
            this.TEA.Location = new System.Drawing.Point(4, 24);
            this.TEA.Name = "TEA";
            this.TEA.Padding = new System.Windows.Forms.Padding(3);
            this.TEA.Size = new System.Drawing.Size(481, 153);
            this.TEA.TabIndex = 2;
            this.TEA.Text = "TEA";
            this.TEA.UseVisualStyleBackColor = true;
            // 
            // gbCBC
            // 
            this.gbCBC.Controls.Add(this.IV);
            this.gbCBC.Controls.Add(this.tbIV);
            this.gbCBC.Enabled = false;
            this.gbCBC.Location = new System.Drawing.Point(166, 100);
            this.gbCBC.Name = "gbCBC";
            this.gbCBC.Size = new System.Drawing.Size(191, 47);
            this.gbCBC.TabIndex = 8;
            this.gbCBC.TabStop = false;
            this.gbCBC.Text = "CBC";
            // 
            // IV
            // 
            this.IV.AutoSize = true;
            this.IV.Location = new System.Drawing.Point(10, 19);
            this.IV.Name = "IV";
            this.IV.Size = new System.Drawing.Size(50, 15);
            this.IV.TabIndex = 1;
            this.IV.Text = "IV (64b):";
            // 
            // tbIV
            // 
            this.tbIV.Location = new System.Drawing.Point(66, 16);
            this.tbIV.Name = "tbIV";
            this.tbIV.Size = new System.Drawing.Size(119, 23);
            this.tbIV.TabIndex = 0;
            this.tbIV.Text = "0x";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.rbTEAwithCBC);
            this.groupBox10.Controls.Add(this.rbTEAMultithreaded);
            this.groupBox10.Controls.Add(this.rbTEAStandard);
            this.groupBox10.Controls.Add(this.tbTEAKey);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(351, 88);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Podešavanja";
            // 
            // rbTEAwithCBC
            // 
            this.rbTEAwithCBC.AutoSize = true;
            this.rbTEAwithCBC.Location = new System.Drawing.Point(170, 54);
            this.rbTEAwithCBC.Name = "rbTEAwithCBC";
            this.rbTEAwithCBC.Size = new System.Drawing.Size(63, 19);
            this.rbTEAwithCBC.TabIndex = 7;
            this.rbTEAwithCBC.Text = "Sa CBC";
            this.rbTEAwithCBC.UseVisualStyleBackColor = true;
            this.rbTEAwithCBC.CheckedChanged += new System.EventHandler(this.RbTEAwithCBC_CheckedChanged);
            // 
            // rbTEAMultithreaded
            // 
            this.rbTEAMultithreaded.AutoSize = true;
            this.rbTEAMultithreaded.Location = new System.Drawing.Point(98, 54);
            this.rbTEAMultithreaded.Name = "rbTEAMultithreaded";
            this.rbTEAMultithreaded.Size = new System.Drawing.Size(66, 19);
            this.rbTEAMultithreaded.TabIndex = 6;
            this.rbTEAMultithreaded.Text = "Više niti";
            this.rbTEAMultithreaded.UseVisualStyleBackColor = true;
            this.rbTEAMultithreaded.CheckedChanged += new System.EventHandler(this.RbTEAMultithreaded_CheckedChanged);
            // 
            // rbTEAStandard
            // 
            this.rbTEAStandard.AutoSize = true;
            this.rbTEAStandard.Checked = true;
            this.rbTEAStandard.Location = new System.Drawing.Point(10, 54);
            this.rbTEAStandard.Name = "rbTEAStandard";
            this.rbTEAStandard.Size = new System.Drawing.Size(82, 19);
            this.rbTEAStandard.TabIndex = 5;
            this.rbTEAStandard.TabStop = true;
            this.rbTEAStandard.Text = "Standardni";
            this.rbTEAStandard.UseVisualStyleBackColor = true;
            // 
            // tbTEAKey
            // 
            this.tbTEAKey.Location = new System.Drawing.Point(116, 16);
            this.tbTEAKey.Name = "tbTEAKey";
            this.tbTEAKey.Size = new System.Drawing.Size(87, 23);
            this.tbTEAKey.TabIndex = 1;
            this.tbTEAKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTEAKey_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ključ (8 karaktera):";
            // 
            // gbMultithread
            // 
            this.gbMultithread.Controls.Add(this.label5);
            this.gbMultithread.Controls.Add(this.nudTEAThreadCount);
            this.gbMultithread.Enabled = false;
            this.gbMultithread.Location = new System.Drawing.Point(6, 100);
            this.gbMultithread.Name = "gbMultithread";
            this.gbMultithread.Size = new System.Drawing.Size(154, 47);
            this.gbMultithread.TabIndex = 6;
            this.gbMultithread.TabStop = false;
            this.gbMultithread.Text = "Paralelizacija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Broj niti:";
            // 
            // nudTEAThreadCount
            // 
            this.nudTEAThreadCount.Location = new System.Drawing.Point(75, 17);
            this.nudTEAThreadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTEAThreadCount.Name = "nudTEAThreadCount";
            this.nudTEAThreadCount.Size = new System.Drawing.Size(73, 23);
            this.nudTEAThreadCount.TabIndex = 5;
            this.nudTEAThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnTEAEncrypt);
            this.groupBox5.Controls.Add(this.btnTEADecrypt);
            this.groupBox5.Location = new System.Drawing.Point(363, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(112, 141);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Svi fajlovi";
            // 
            // btnTEAEncrypt
            // 
            this.btnTEAEncrypt.Location = new System.Drawing.Point(6, 16);
            this.btnTEAEncrypt.Name = "btnTEAEncrypt";
            this.btnTEAEncrypt.Size = new System.Drawing.Size(100, 57);
            this.btnTEAEncrypt.TabIndex = 2;
            this.btnTEAEncrypt.Text = "Enkriptuj";
            this.btnTEAEncrypt.UseVisualStyleBackColor = true;
            this.btnTEAEncrypt.Click += new System.EventHandler(this.BtnTEAEncrypt_Click);
            // 
            // btnTEADecrypt
            // 
            this.btnTEADecrypt.Location = new System.Drawing.Point(6, 77);
            this.btnTEADecrypt.Name = "btnTEADecrypt";
            this.btnTEADecrypt.Size = new System.Drawing.Size(100, 57);
            this.btnTEADecrypt.TabIndex = 3;
            this.btnTEADecrypt.Text = "Dekriptuj";
            this.btnTEADecrypt.UseVisualStyleBackColor = true;
            this.btnTEADecrypt.Click += new System.EventHandler(this.BtnTEADecrypt_Click);
            // 
            // CRC
            // 
            this.CRC.Controls.Add(this.btnCRC);
            this.CRC.Controls.Add(this.groupBox13);
            this.CRC.Controls.Add(this.groupBox11);
            this.CRC.Location = new System.Drawing.Point(4, 24);
            this.CRC.Name = "CRC";
            this.CRC.Size = new System.Drawing.Size(481, 153);
            this.CRC.TabIndex = 4;
            this.CRC.Text = "CRC";
            this.CRC.UseVisualStyleBackColor = true;
            // 
            // btnCRC
            // 
            this.btnCRC.Location = new System.Drawing.Point(386, 11);
            this.btnCRC.Name = "btnCRC";
            this.btnCRC.Size = new System.Drawing.Size(88, 44);
            this.btnCRC.TabIndex = 0;
            this.btnCRC.Text = "Izračunaj heš";
            this.btnCRC.UseVisualStyleBackColor = true;
            this.btnCRC.Click += new System.EventHandler(this.BtnCRC_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label11);
            this.groupBox13.Controls.Add(this.label13);
            this.groupBox13.Controls.Add(this.label12);
            this.groupBox13.Controls.Add(this.label15);
            this.groupBox13.Controls.Add(this.label14);
            this.groupBox13.Location = new System.Drawing.Point(3, 56);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(475, 94);
            this.groupBox13.TabIndex = 5;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Rezultat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Heš prve datoteke:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Heš druge datoteke:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(366, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 15);
            this.label15.TabIndex = 4;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(7, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 15);
            this.label14.TabIndex = 3;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.radioButton3);
            this.groupBox11.Controls.Add(this.radioButton2);
            this.groupBox11.Controls.Add(this.radioButton1);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Controls.Add(this.textBox6);
            this.groupBox11.Location = new System.Drawing.Point(3, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(377, 52);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Podešavanja:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(72, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 19);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "CRC-16";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(143, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 19);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "CRC-32";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 19);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CRC-8";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(217, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Polinom:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(278, 18);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(88, 23);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "0x";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnFile2);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 51);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izlazna datoteka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // btnFile2
            // 
            this.btnFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile2.Location = new System.Drawing.Point(408, 18);
            this.btnFile2.Name = "btnFile2";
            this.btnFile2.Size = new System.Drawing.Size(75, 23);
            this.btnFile2.TabIndex = 0;
            this.btnFile2.Text = "Izaberi";
            this.btnFile2.UseVisualStyleBackColor = true;
            this.btnFile2.Click += new System.EventHandler(this.BtnFile2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnFile1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulazna datoteka";
            // 
            // btnFile1
            // 
            this.btnFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile1.Location = new System.Drawing.Point(408, 15);
            this.btnFile1.Name = "btnFile1";
            this.btnFile1.Size = new System.Drawing.Size(75, 23);
            this.btnFile1.TabIndex = 2;
            this.btnFile1.Text = "Izaberi";
            this.btnFile1.UseVisualStyleBackColor = true;
            this.btnFile1.Click += new System.EventHandler(this.BtnFile1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Ulazni fajl";
            this.openFileDialog1.Filter = "All files(*.*) | *.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "All files (*.*)|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "All files(*.*) | *.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tcAlgorithm);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaštita informacija - 17714";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcAlgorithm.ResumeLayout(false);
            this.RC4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.Enigma.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.TEA.ResumeLayout(false);
            this.gbCBC.ResumeLayout(false);
            this.gbCBC.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.gbMultithread.ResumeLayout(false);
            this.gbMultithread.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTEAThreadCount)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.CRC.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRc4Encrypt;
        private TabControl tcAlgorithm;
        private TabPage RC4;
        private TabPage Enigma;
        private TabPage TEA;
        private TabPage CRC;
        private Button btnFile1;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Button btnFile2;
        private SaveFileDialog saveFileDialog;
        private Button btnRc4Decrypt;
        private Label label3;
        private TextBox tbRC4Key;
        private Button btnRc4EncryptBmp;
        private GroupBox groupBox4;
        private Button btnRc4DecryptBmp;
        private GroupBox groupBox3;
        private TextBox tbTEAKey;
        private Label label4;
        private Button btnTEAEncrypt;
        private Button btnTEADecrypt;
        private GroupBox gbMultithread;
        private Label label5;
        private NumericUpDown nudTEAThreadCount;
        private GroupBox groupBox5;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private TextBox tbEnigmaPlugboard;
        private TextBox tbEnigmaRotors;
        private TextBox tbEnigmaRingSettings;
        private TextBox tbEnigmaKeySettings;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnEnigmaDecrypt;
        private Button btnEnigmaEncrypt;
        private GroupBox groupBox10;
        private GroupBox groupBox11;
        private ComboBox cbEnigmaReflector;
        private Label label10;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private GroupBox groupBox13;
        private Label label16;
        private TextBox textBox6;
        private Button btnCRC;
        private OpenFileDialog openFileDialog2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton rbTEAwithCBC;
        private RadioButton rbTEAMultithreaded;
        private RadioButton rbTEAStandard;
        private GroupBox gbCBC;
        private Label IV;
        private TextBox tbIV;
    }
}