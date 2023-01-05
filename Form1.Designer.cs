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
            this.Enigma = new System.Windows.Forms.TabPage();
            this.TEA = new System.Windows.Forms.TabPage();
            this.CBC = new System.Windows.Forms.TabPage();
            this.CRC = new System.Windows.Forms.TabPage();
            this.Paralelizacija = new System.Windows.Forms.TabPage();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "TEST";
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
            this.tabControl1.Controls.Add(this.Paralelizacija);
            this.tabControl1.Location = new System.Drawing.Point(12, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 316);
            this.tabControl1.TabIndex = 1;
            // 
            // RC4
            // 
            this.RC4.Controls.Add(this.button1);
            this.RC4.Location = new System.Drawing.Point(4, 24);
            this.RC4.Name = "RC4";
            this.RC4.Padding = new System.Windows.Forms.Padding(3);
            this.RC4.Size = new System.Drawing.Size(623, 288);
            this.RC4.TabIndex = 0;
            this.RC4.Text = "RC4";
            this.RC4.UseVisualStyleBackColor = true;
            this.RC4.Click += new System.EventHandler(this.RC4_Click);
            // 
            // Enigma
            // 
            this.Enigma.Location = new System.Drawing.Point(4, 24);
            this.Enigma.Name = "Enigma";
            this.Enigma.Padding = new System.Windows.Forms.Padding(3);
            this.Enigma.Size = new System.Drawing.Size(768, 288);
            this.Enigma.TabIndex = 1;
            this.Enigma.Text = "Enigma";
            this.Enigma.UseVisualStyleBackColor = true;
            // 
            // TEA
            // 
            this.TEA.Location = new System.Drawing.Point(4, 24);
            this.TEA.Name = "TEA";
            this.TEA.Padding = new System.Windows.Forms.Padding(3);
            this.TEA.Size = new System.Drawing.Size(768, 288);
            this.TEA.TabIndex = 2;
            this.TEA.Text = "TEA";
            this.TEA.UseVisualStyleBackColor = true;
            // 
            // CBC
            // 
            this.CBC.Location = new System.Drawing.Point(4, 24);
            this.CBC.Name = "CBC";
            this.CBC.Size = new System.Drawing.Size(768, 288);
            this.CBC.TabIndex = 3;
            this.CBC.Text = "CBC";
            this.CBC.UseVisualStyleBackColor = true;
            // 
            // CRC
            // 
            this.CRC.Location = new System.Drawing.Point(4, 24);
            this.CRC.Name = "CRC";
            this.CRC.Size = new System.Drawing.Size(768, 288);
            this.CRC.TabIndex = 4;
            this.CRC.Text = "CRC";
            this.CRC.UseVisualStyleBackColor = true;
            // 
            // Paralelizacija
            // 
            this.Paralelizacija.Location = new System.Drawing.Point(4, 24);
            this.Paralelizacija.Name = "Paralelizacija";
            this.Paralelizacija.Size = new System.Drawing.Size(768, 288);
            this.Paralelizacija.TabIndex = 5;
            this.Paralelizacija.Text = "Paralelizacija";
            this.Paralelizacija.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 51);
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
            this.button3.Location = new System.Drawing.Point(550, 18);
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
            this.groupBox1.Size = new System.Drawing.Size(631, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulazni fajl";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(550, 15);
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
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaštita informacija - 17714";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.RC4.ResumeLayout(false);
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
        private TabPage Paralelizacija;
        private Button button2;
        private Label label1;
        private OpenFileDialog openFileDialog;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Button button3;
        private SaveFileDialog saveFileDialog;
    }
}