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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RC4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRC4Key = new System.Windows.Forms.TextBox();
            this.Enigma = new System.Windows.Forms.TabPage();
            this.TEA = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBC = new System.Windows.Forms.TabPage();
            this.CRC = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.RC4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.TEA.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enkriptuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.RC4);
            this.tabControl1.Controls.Add(this.Enigma);
            this.tabControl1.Controls.Add(this.TEA);
            this.tabControl1.Controls.Add(this.CBC);
            this.tabControl1.Controls.Add(this.CRC);
            this.tabControl1.Location = new System.Drawing.Point(12, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 181);
            this.tabControl1.TabIndex = 1;
            // 
            // RC4
            // 
            this.RC4.Controls.Add(this.groupBox4);
            this.RC4.Controls.Add(this.groupBox3);
            this.RC4.Controls.Add(this.label3);
            this.RC4.Controls.Add(this.tbRC4Key);
            this.RC4.Location = new System.Drawing.Point(4, 24);
            this.RC4.Name = "RC4";
            this.RC4.Padding = new System.Windows.Forms.Padding(3);
            this.RC4.Size = new System.Drawing.Size(481, 153);
            this.RC4.TabIndex = 0;
            this.RC4.Text = "RC4";
            this.RC4.UseVisualStyleBackColor = true;
            this.RC4.Click += new System.EventHandler(this.RC4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Location = new System.Drawing.Point(368, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(98, 118);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BMP fajlovi";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Enkriptuj";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dekriptuj";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(264, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 118);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Svi fajlovi";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "Dekriptuj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ključ:";
            // 
            // tbRC4Key
            // 
            this.tbRC4Key.Location = new System.Drawing.Point(48, 15);
            this.tbRC4Key.Name = "tbRC4Key";
            this.tbRC4Key.Size = new System.Drawing.Size(100, 23);
            this.tbRC4Key.TabIndex = 2;
            this.tbRC4Key.Text = "  ";
            // 
            // Enigma
            // 
            this.Enigma.Location = new System.Drawing.Point(4, 24);
            this.Enigma.Name = "Enigma";
            this.Enigma.Padding = new System.Windows.Forms.Padding(3);
            this.Enigma.Size = new System.Drawing.Size(481, 153);
            this.Enigma.TabIndex = 1;
            this.Enigma.Text = "Enigma";
            this.Enigma.UseVisualStyleBackColor = true;
            // 
            // TEA
            // 
            this.TEA.Controls.Add(this.groupBox6);
            this.TEA.Controls.Add(this.groupBox5);
            this.TEA.Controls.Add(this.textBox1);
            this.TEA.Controls.Add(this.label4);
            this.TEA.Location = new System.Drawing.Point(4, 24);
            this.TEA.Name = "TEA";
            this.TEA.Padding = new System.Windows.Forms.Padding(3);
            this.TEA.Size = new System.Drawing.Size(481, 153);
            this.TEA.TabIndex = 2;
            this.TEA.Text = "TEA";
            this.TEA.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.numericUpDown1);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Location = new System.Drawing.Point(6, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(238, 47);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Paralelizacija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Broj niti:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(167, 15);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Više niti?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Location = new System.Drawing.Point(368, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(98, 122);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Svi fajlovi";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 40);
            this.button7.TabIndex = 2;
            this.button7.Text = "Enkriptuj";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 70);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 40);
            this.button8.TabIndex = 3;
            this.button8.Text = "Dekriptuj";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ključ (8 karaktera):";
            // 
            // CBC
            // 
            this.CBC.Location = new System.Drawing.Point(4, 24);
            this.CBC.Name = "CBC";
            this.CBC.Size = new System.Drawing.Size(481, 153);
            this.CBC.TabIndex = 3;
            this.CBC.Text = "CBC";
            this.CBC.UseVisualStyleBackColor = true;
            // 
            // CRC
            // 
            this.CRC.Location = new System.Drawing.Point(4, 24);
            this.CRC.Name = "CRC";
            this.CRC.Size = new System.Drawing.Size(481, 153);
            this.CRC.TabIndex = 4;
            this.CRC.Text = "CRC";
            this.CRC.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 51);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izlazni fajl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(408, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Izaberi fajl";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulazni fajl";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(408, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Izaberi fajl";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Ulazni fajl";
            this.openFileDialog.Filter = "All files(*.*) | *.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaštita informacija - 17714";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.RC4.ResumeLayout(false);
            this.RC4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.TEA.ResumeLayout(false);
            this.TEA.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private TabControl tabControl1;
        private TabPage RC4;
        private TabPage Enigma;
        private TabPage TEA;
        private TabPage CBC;
        private TabPage CRC;
        private Button button2;
        private Label label1;
        private OpenFileDialog openFileDialog;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Button button3;
        private SaveFileDialog saveFileDialog;
        private Button button4;
        private Label label3;
        private TextBox tbRC4Key;
        private Button button5;
        private GroupBox groupBox4;
        private Button button6;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Label label4;
        private Button button7;
        private Button button8;
        private GroupBox groupBox6;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private GroupBox groupBox5;
    }
}