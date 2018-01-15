namespace SimpleCrypt_X
{
    partial class password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(password));
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Button2 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.MaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.label6);
            this.GroupBox3.Controls.Add(this.textBox3);
            this.GroupBox3.Controls.Add(this.label4);
            this.GroupBox3.Controls.Add(this.label3);
            this.GroupBox3.Controls.Add(this.trackBar1);
            this.GroupBox3.Controls.Add(this.Button2);
            this.GroupBox3.Controls.Add(this.TextBox2);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.TextBox1);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Controls.Add(this.Button1);
            this.GroupBox3.Controls.Add(this.MaskedTextBox1);
            this.GroupBox3.Location = new System.Drawing.Point(12, 12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(247, 298);
            this.GroupBox3.TabIndex = 25;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Шифрование / Дешифрование";
            this.GroupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Повторите пароль:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(212, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Символов:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(18, 189);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(212, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 26;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(18, 263);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(91, 23);
            this.Button2.TabIndex = 22;
            this.Button2.Text = "Генерировать";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(18, 163);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(212, 20);
            this.TextBox2.TabIndex = 21;
            this.TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(15, 147);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(141, 13);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Сгенерированный пароль:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(15, 107);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(112, 13);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "Надежность пароля:";
            // 
            // TextBox1
            // 
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(18, 123);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(212, 20);
            this.TextBox1.TabIndex = 18;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Пароль:";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(155, 263);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Хорошо";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MaskedTextBox1
            // 
            this.MaskedTextBox1.Location = new System.Drawing.Point(18, 44);
            this.MaskedTextBox1.Name = "MaskedTextBox1";
            this.MaskedTextBox1.PasswordChar = '*';
            this.MaskedTextBox1.Size = new System.Drawing.Size(212, 20);
            this.MaskedTextBox1.TabIndex = 1;
            this.MaskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1_MaskInputRejected);
            this.MaskedTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CalculateMeter);
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 321);
            this.Controls.Add(this.GroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "password";
            this.Text = "Пожалуйста, введите пароль:";
            this.Load += new System.EventHandler(this.password_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.MaskedTextBox MaskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox textBox3;
    }
}