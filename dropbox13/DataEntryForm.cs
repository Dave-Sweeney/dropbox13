using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox13
{
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            scoreTextBox.Clear();
            idTextBox.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText("student.txt"))
            {
                if(!((string.IsNullOrWhiteSpace(idTextBox.Text)) ||
                    (string.IsNullOrWhiteSpace(nameTextBox.Text)) ||
                    (string.IsNullOrWhiteSpace(scoreTextBox.Text))))
                {
                    sw.WriteLine(idTextBox.Text);
                    sw.WriteLine(nameTextBox.Text);
                    sw.WriteLine(scoreTextBox.Text);

                    clearButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("All fields must be filled");
                }
            }
        }
    }
}
