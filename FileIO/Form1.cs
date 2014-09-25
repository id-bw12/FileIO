using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileIO
{
    public partial class Form1 : Form
    {
        // the name of the File 
        string fileName = "File.Txt";

        public Form1()
        {
            InitializeComponent();
        }

        //An action event
        private void TextBoxes_Changed(object sender, EventArgs e)
        {
            if (enterBox.Text != "")
                writeBttn.Enabled = true;
            else
                writeBttn.Enabled = false;
        }

        private void writeBttn_Click(object sender, EventArgs e)
        {
            //StreamWriter wr = new StreamWriter(fileName);

            //TO not overwite the file.
            StreamWriter wr = File.AppendText(fileName);

            wr.WriteLine(enterBox.Text);
            
            //closes the file
            wr.Close();

            //makes the enterbox blank
            enterBox.Text = "";
        }

        private void readBttn_Click(object sender, EventArgs e)
        {
            string input,
                fileHistory = "";

            StreamReader sr = new StreamReader(fileName); // Reads the file.

            ////////////////////////////////////////////////////////////////////////

            //Loop through the file to get whats written
            while ((input = sr.ReadLine()) != null)
            {
                fileHistory += input + "\n";
            }


            //Show what is in the file
            MessageBox.Show(fileHistory);


            //Closes the reader
            sr.Close();
        }
    }
}
