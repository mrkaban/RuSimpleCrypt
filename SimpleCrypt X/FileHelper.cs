using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SimpleCrypt_X
{

    // this is the port of FileHelper from the original SimpleCrypt Platform...

    class FileHelper
    {
        public static List<string> GetFilesRecursive(string initial)
        {
            List<String> result = new List<String>();

            // the stack stores the directories to process

            Stack<string> stack = new Stack<string>();
            stack.Push(initial);

            while(stack.Count >0)
            {
                // get the top directory string
                string dir = stack.Pop();

                try
                {

                    // add all the imeditate file paths
                    result.AddRange(Directory.GetFiles(dir, "*.*"));

                    // now loop though all subdirectories and add them to the stack

                    foreach(string directoryName in Directory.GetDirectories(dir))
                    {
                        stack.Push(directoryName);
                    }

                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                

            }

            return result;

        }
    }
}
