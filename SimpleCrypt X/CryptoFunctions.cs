using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrypt_X
{
    public class CryptoFunctions
    {

        private string password;
        private string filename;
        private double percentage;

        ProgressBar progress;

        public void init_progressbar(ProgressBar progress)
        {
            this.progress = progress;
        }

        public void update_progressbar(double value)
        {
            if(progress != null)
            {
                progress.Value = (int)value;
            }
        }



        public void encrypt()
        {
            // we do this to handle any errors
            
            try {
                SharpAESCrypt.SharpAESCrypt.Extension_CreatedByIdentifier = "RuSimpleCrypt";
                using (FileStream output = new FileStream(@filename + ".aes", FileMode.Create, FileAccess.ReadWrite))
                {
                    SharpAESCrypt.SharpAESCrypt aesStream = new SharpAESCrypt.SharpAESCrypt(password, output, SharpAESCrypt.OperationMode.Encrypt);
                    // now we set the extension information

                    byte[] buffer = new byte[1024 * 4];

                    using (FileStream input = new FileStream(@filename, FileMode.Open, FileAccess.Read))
                    {

                        long fileLength = input.Length;
                        long totalBytes = 0;
                        int currentBlockSize = 0;

                        while ((currentBlockSize = input.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            totalBytes += currentBlockSize;
                            percentage = (double)totalBytes * 100.0 / fileLength;
                            update_progressbar(percentage);

                            aesStream.Write(buffer, 0, currentBlockSize);
                        }

                        aesStream.FlushFinalBlock();

                    }

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void decrypt()
        {

            // now we use try catch, in the event something bad happens <3

            try {
                SharpAESCrypt.SharpAESCrypt.Extension_CreatedByIdentifier = "RuSimpleCrypt";

                using (FileStream output = new FileStream(@filename.Replace(".aes", ""), FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {



                    byte[] buffer = new byte[1024 * 4];

                    Stream input = new FileStream(@filename, FileMode.Open, FileAccess.Read);
                    SharpAESCrypt.SharpAESCrypt aesStream = new SharpAESCrypt.SharpAESCrypt(password, input, SharpAESCrypt.OperationMode.Decrypt);
                    long fileLength = input.Length;
                    long totalBytes = 0;
                    int currentBlockSize = 0;



                    while ((currentBlockSize = aesStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        totalBytes += currentBlockSize;
                        percentage = (double)totalBytes * 100.0 / fileLength;
                        update_progressbar(percentage);
                        output.Write(buffer, 0, currentBlockSize);
                    }

                    input.Close();
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void setFile(string filename)
        {
            this.filename = filename;
        }

        public void setPass(string password)
        {
            this.password = password;
        }
    }
}
