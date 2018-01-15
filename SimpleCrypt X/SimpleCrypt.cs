using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrypt_X
{



    public partial class SimpleCrypt : Form
    {


        // for drag and drop support

       // for temporary storage and checking, saves up time :D

        List<String> files = new List<String>();

        void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        // this deals with listviews

        void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData("FileDrop", false);

            try
            {

                // now loop though all files and add it to the ListView


                for (int i = 0; i <= s.Length - 1; i++)
                {

                    if (Directory.Exists(s[i]))
                    {

                        List<string> list = FileHelper.GetFilesRecursive(s[i]);
                        foreach (string path in list)
                        {


                            // this peice of code extracts the icon
                            // and than adds it to the listbox :D

                            // we doo a little check to see if the file exists but first we check if it is greater than 1

                            // we quickly check if the file exists
                            if (files.Contains(path.ToString()))
                            {
                                MessageBox.Show(path.ToString() + " уже есть");
                            }
                            else
                            {
                                Icon iconForFile = SystemIcons.WinLogo;
                                ListViewItem item = new ListViewItem(path.ToString());
                                item.ImageIndex = 1;
                                iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(path.ToString());
                                imageList1.Images.Add(path.ToString(), iconForFile);
                                item.ImageKey = path.ToString();
                                item.Text = path.ToString();

                                files.Add(path.ToString());

                                // now to update the file count

                                ToolStripStatusLabel3.Text = ListView1.Items.Count.ToString();


                                ListView1.BeginUpdate();

                                if (path.EndsWith(".aes"))
                                {
                                    ListView1.Items.Add(item).SubItems.Add("Да");
                                }
                                else
                                {
                                    ListView1.Items.Add(item).SubItems.Add("Нет");
                                }

                                ListView1.EndUpdate();
                            }
                        }
                    }


                    else
                    {

                        // must be a file, owell we will import it, yay... lets extract the files.

                        if (files.Contains(s[i].ToString()))
                        {
                            MessageBox.Show(s[i].ToString() + " уже есть");
                        }
                        else
                        {

                            Icon iconForFile = SystemIcons.WinLogo;
                            ListViewItem item = new ListViewItem(s[i].ToString());
                            item.ImageIndex = 1;
                            iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(s[i].ToString());
                            imageList1.Images.Add(s[i].ToString(), iconForFile);
                            item.ImageKey = s[i].ToString();
                            item.Text = s[i].ToString();

                            files.Add(s[i].ToString());

                            // now to update the file count

                            ToolStripStatusLabel3.Text = ListView1.Items.Count.ToString();


                            ListView1.BeginUpdate();

                            if (s[i].EndsWith(".aes"))
                            {
                                ListView1.Items.Add(item).SubItems.Add("Да");
                            }
                            else
                            {
                                ListView1.Items.Add(item).SubItems.Add("Нет");
                            }

                            ListView1.EndUpdate();
                        }
                    }
                    ToolStripStatusLabel3.Text = ListView1.Items.Count.ToString(); 
                    
                }

                }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }


        }


        


    


        public SimpleCrypt()
        {
            InitializeComponent();
            ListView1.AllowDrop = true;
            ListView1.DragDrop += new DragEventHandler(listView1_DragDrop);
            ListView1.DragEnter += new DragEventHandler(listView1_DragEnter);
		


        }

		// this decrypts everythiung


        // this is a global function for encrypting files

        private void encrypt_files()
        {

            // handles crashes, we need this.. for now

            try {

                if (ListView1.Items.Count > 0)
                {
                    password passform = new password();

                    if (passform.ShowDialog(this) == DialogResult.OK)
                    {


                        int total_files = ListView1.Items.Count;
                        int files = 0;
                        foreach (ListViewItem item in ListView1.Items)
                        {
                            if (!item.Text.ToString().EndsWith("aes"))
                            {
                                Label6.Text = Path.GetFileName(item.Text.ToString());

                                // we have to setup cryptofunctions

                                CryptoFunctions encryption = new CryptoFunctions();
                                encryption.setFile(item.Text.ToString());
                                encryption.setPass(passform.MaskedTextBox1.Text.ToString());
                                encryption.init_progressbar(ProgressBar1);
                                encryption.encrypt();
                                files = files + 1;

                                ProgressBar2.Value = (int)(files / ListView1.Items.Count) * 100;



                            }

                        }



                        // loop though listview and remove anything amd update everything

                        foreach (ListViewItem item in ListView1.Items)
                        {
                            for (int i = 0; i < ListView1.Items.Count; i++)
                            {
                                // checks if the filename in the list box doesn't edit with .aes
                                if (!ListView1.Items[i].Text.EndsWith("aes"))
                                {
                                    // okay passed the check, lets add .encrypt to the filename
                                    // also delete the original file
                                    string filename = ListView1.Items[i].Text.ToString();
                                    File.Delete(filename);

                                    ListView1.BeginUpdate();

                                    ListView1.Items.RemoveAt(i);
                                    //  laod icon and add it to the list view;
                                    Icon iconForFile = SystemIcons.WinLogo;
                                    ListViewItem item_fixed = new ListViewItem(filename + ".aes", 1);
                                    item_fixed.ImageIndex = 1;
                                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(filename + ".aes");


                                    imageList1.Images.Add(filename + ".aes", iconForFile);
                                    item_fixed.ImageKey = filename + ".aes";
                                    item_fixed.Text = filename + ".aes".ToString();
                                    ListView1.Items.Add(item_fixed).SubItems.Add("Да");
                                    ListView1.EndUpdate();



                                }
                            }
                        }

                        MessageBox.Show("Шифрование успешно завершено");



                        // reset the progress barss

                        ProgressBar1.Value = 0;
                        ProgressBar2.Value = 0;

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // this is a global function for decrypting files

        private void decrypt_files()
        {
            try {
                if (ListView1.Items.Count > 0)
                {
                    password passform = new password();
                    if (passform.ShowDialog(this) == DialogResult.OK)
                    {


                        int total_files = ListView1.Items.Count;
                        int files = 0;
                        foreach (ListViewItem item in ListView1.Items)
                        {
                            if (item.Text.ToString().EndsWith("aes"))
                            {
                                Label6.Text = Path.GetFileName(item.Text.ToString());
                                // we have to setup the crypto functions

                                CryptoFunctions encryption = new CryptoFunctions();

                                encryption.setFile(item.Text.ToString());
                                encryption.setPass(passform.MaskedTextBox1.Text.ToString());
                                encryption.init_progressbar(ProgressBar1);
                                encryption.decrypt();
                                files = files + 1;


                                ProgressBar2.Value = (int)(files / ListView1.Items.Count) * 100;
                            }

                        }



                        // loop though listview and remove anything amd update everything

                        foreach (ListViewItem item in ListView1.Items)
                        {
                            for (int i = 0; i < ListView1.Items.Count; i++)
                            {
                                // checks if the filename in the list box doesn't edit with .aes
                                if (ListView1.Items[i].Text.EndsWith("aes"))
                                {
                                    // okay passed the check, lets add .encrypt to the filename
                                    // also delete the original file
                                    string filename = ListView1.Items[i].Text.ToString();
                                    File.Delete(filename);

                                    ListView1.BeginUpdate();



                                    ListView1.Items.RemoveAt(i);
                                    //  laod icon and add it to the list view;
                                    Icon iconForFile = SystemIcons.WinLogo;
                                    ListViewItem item_fixed = new ListViewItem(filename.Replace(".aes", ""), 1);
                                    item_fixed.ImageIndex = 1;
                                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(filename.Replace(".aes", ""));


                                    imageList1.Images.Add(filename.Replace(".aes", ""), iconForFile);
                                    item_fixed.ImageKey = filename.Replace(".aes", "");
                                    item_fixed.Text = filename.Replace(".aes", "").ToString();
                                    ListView1.Items.Add(item_fixed).SubItems.Add("Нет");
                                    ListView1.EndUpdate();



                                }
                            }
                        }

                        MessageBox.Show("Дешифрование успешно завершено");
                        // reset the progress barss

                        ProgressBar1.Value = 0;
                        ProgressBar2.Value = 0;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void ToolStripButton2_Click(object sender, EventArgs e)
        {

		

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // simple resize :D
            ListView1.Columns[0].Width = (int)ListView1.ClientRectangle.Width - (int)ListView1.Columns[1].Width;
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

  

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // little easter egg.. :D

            string[] quotes =
            {
                "Без мощного шифрования, ваши данные будут под угрозой - Диффи",
"Если вы  в кафе или в аэропорту, и используете открытую беспроводную сеть, лучше использовать сервис VPN, который вы могли бы получить за 10 баксов в месяц. Все, что зашифровано в туннеле, с тем хакер не сможет ничего подделать - Митник ",
"Шифрование должно быть бесплатным и простым в использовании для всех без каких-либо бэкдоров и должно быть безопасными - Дилан Моршид"

            };

                Random random_quote = new Random();

                MessageBox.Show(quotes[random_quote.Next(0, quotes.Length - 1)]);


        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            encrypt_files();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            decrypt_files();
        }

        private void EncryptFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encrypt_files();
        }

        private void DecryptFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decrypt_files();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.ShowDialog();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.ShowDialog();
        }

        private void ResizeListView(object sender, EventArgs e)
        {
            // simple resize :D
            ListView1.Columns[0].Width = (int)ListView1.ClientRectangle.Width - (int)ListView1.Columns[1].Width;
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // this clears the list duh...

        private void clear_list()
        {
            ListView1.Items.Clear();
            ToolStripStatusLabel3.Text = "0";

        }

        // this removes a item from list

        public void remove_list()
        {
            for (int i = 0; i < ListView1.Items.Count; i++)
            {
                if (ListView1.Items[i].Selected)
                {
                    ListView1.Items.RemoveAt(i);
                }

                // now update the list count

                ToolStripStatusLabel3.Text = ListView1.Items.Count.ToString();
            }
        

        }


        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            clear_list();
        }

        private void ToolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            remove_list();
        }

        private void RemoveFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remove_list();
        }

        private void RemoveAllFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear_list();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
           

        }

        private void Button1_Click(object sender, EventArgs e)
        {


        }

        private void ToolStripStatusLabel6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("bitcoin:12FG9873SoqKiPL1NVYEugfPy3MjFK4V41");
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("bitcoin:12FG9873SoqKiPL1NVYEugfPy3MjFK4V41");
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
