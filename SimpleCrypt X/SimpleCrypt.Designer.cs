namespace SimpleCrypt_X
{
    partial class SimpleCrypt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleCrypt));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.Label3 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Label4 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EncryptButton = new System.Windows.Forms.ToolStripButton();
            this.DecryptButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Encrypted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecryptFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveAllFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.ProgressBar2);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.ProgressBar1);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(660, 95);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(159, 454);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "RuSimpleCrypt Прогресс:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(7, 220);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(84, 13);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Текущий файл:";
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.Location = new System.Drawing.Point(7, 240);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(148, 204);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Пусто";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::RuSimpleCrypt.Properties.Resources._698630_icon_114_lock_128;
            this.PictureBox1.Location = new System.Drawing.Point(7, 20);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(146, 109);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.Location = new System.Drawing.Point(7, 190);
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.Size = new System.Drawing.Size(146, 23);
            this.ProgressBar2.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(4, 174);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Общий прогресс:";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressBar1.Location = new System.Drawing.Point(7, 148);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(146, 23);
            this.ProgressBar1.TabIndex = 6;
            this.ProgressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(4, 132);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(94, 13);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Прогресс файла:";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EncryptButton,
            this.DecryptButton,
            this.toolStripButton1,
            this.ToolStripButton3,
            this.ToolStripSeparator1,
            this.ToolStripButton4});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(827, 54);
            this.ToolStrip1.TabIndex = 12;
            this.ToolStrip1.Text = "ToolStrip1";
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Image = ((System.Drawing.Image)(resources.GetObject("EncryptButton.Image")));
            this.EncryptButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EncryptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 51);
            this.EncryptButton.Text = "Шифровать";
            this.EncryptButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Image = ((System.Drawing.Image)(resources.GetObject("DecryptButton.Image")));
            this.DecryptButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DecryptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(89, 51);
            this.DecryptButton.Text = "Дешифровать";
            this.DecryptButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 51);
            this.toolStripButton1.Text = "Удалить";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton3.Image")));
            this.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(105, 51);
            this.ToolStripButton3.Text = "Очистить список";
            this.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton4.Image")));
            this.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(86, 51);
            this.ToolStripButton4.Text = "О программе";
            this.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton4.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Location = new System.Drawing.Point(0, 81);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(654, 468);
            this.TabControl1.TabIndex = 11;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Transparent;
            this.TabPage1.Controls.Add(this.ListView1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(646, 442);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Шифрование файлов";
            // 
            // ListView1
            // 
            this.ListView1.AllowDrop = true;
            this.ListView1.AutoArrange = false;
            this.ListView1.BackgroundImageTiled = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader5,
            this.Encrypted});
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(3, 3);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(640, 436);
            this.ListView1.SmallImageList = this.imageList1;
            this.ListView1.TabIndex = 3;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.ListView1.Resize += new System.EventHandler(this.ResizeListView);
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Tag = "1";
            this.ColumnHeader5.Text = "Имя файла";
            this.ColumnHeader5.Width = 650;
            // 
            // Encrypted
            // 
            this.Encrypted.Tag = "2";
            this.Encrypted.Text = "Зашифровано";
            this.Encrypted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Encrypted.Width = 95;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel4,
            this.ToolStripStatusLabel5,
            this.ToolStripStatusLabel2,
            this.ToolStripStatusLabel3});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 552);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(827, 22);
            this.StatusStrip1.TabIndex = 9;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(230, 17);
            this.ToolStripStatusLabel1.Text = "RuSimpleCrypt © КонтинентСвободы.рф";
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(258, 17);
            this.ToolStripStatusLabel4.Spring = true;
            // 
            // ToolStripStatusLabel5
            // 
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(258, 17);
            this.ToolStripStatusLabel5.Spring = true;
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(52, 17);
            this.ToolStripStatusLabel2.Text = "Файлов:";
            this.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(13, 17);
            this.ToolStripStatusLabel3.Text = "0";
            this.ToolStripStatusLabel3.Click += new System.EventHandler(this.ToolStripStatusLabel3_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.OptionToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(827, 24);
            this.MenuStrip1.TabIndex = 10;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EncryptFilesToolStripMenuItem,
            this.DecryptFilesToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.FileToolStripMenuItem.Text = "Шифрование";
            // 
            // EncryptFilesToolStripMenuItem
            // 
            this.EncryptFilesToolStripMenuItem.Name = "EncryptFilesToolStripMenuItem";
            this.EncryptFilesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.EncryptFilesToolStripMenuItem.Text = "Шифровать все файлы";
            this.EncryptFilesToolStripMenuItem.Click += new System.EventHandler(this.EncryptFilesToolStripMenuItem_Click);
            // 
            // DecryptFilesToolStripMenuItem
            // 
            this.DecryptFilesToolStripMenuItem.Name = "DecryptFilesToolStripMenuItem";
            this.DecryptFilesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.DecryptFilesToolStripMenuItem.Text = "Дешифровать все файлы";
            this.DecryptFilesToolStripMenuItem.Click += new System.EventHandler(this.DecryptFilesToolStripMenuItem_Click);
            // 
            // OptionToolStripMenuItem
            // 
            this.OptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveFromListToolStripMenuItem,
            this.RemoveAllFromListToolStripMenuItem});
            this.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem";
            this.OptionToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.OptionToolStripMenuItem.Text = "Удалить";
            // 
            // RemoveFromListToolStripMenuItem
            // 
            this.RemoveFromListToolStripMenuItem.Name = "RemoveFromListToolStripMenuItem";
            this.RemoveFromListToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.RemoveFromListToolStripMenuItem.Text = "Удалить из списка";
            this.RemoveFromListToolStripMenuItem.Click += new System.EventHandler(this.RemoveFromListToolStripMenuItem_Click);
            // 
            // RemoveAllFromListToolStripMenuItem
            // 
            this.RemoveAllFromListToolStripMenuItem.Name = "RemoveAllFromListToolStripMenuItem";
            this.RemoveAllFromListToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.RemoveAllFromListToolStripMenuItem.Text = "Очистить список";
            this.RemoveAllFromListToolStripMenuItem.Click += new System.EventHandler(this.RemoveAllFromListToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.HelpToolStripMenuItem.Text = "Помощь";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // SimpleCrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 574);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleCrypt";
            this.Text = "RuSimpleCrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ProgressBar ProgressBar2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton EncryptButton;
        internal System.Windows.Forms.ToolStripButton DecryptButton;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton4;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.ColumnHeader Encrypted;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel4;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel5;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EncryptFilesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DecryptFilesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OptionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RemoveFromListToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RemoveAllFromListToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

