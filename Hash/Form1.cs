using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtText.Text)) return;
            if (!System.IO.File.Exists(txtText.Text)) return;

            if (md5HashOption.Checked)
            {
                hashMD5 md5Algo = new hashMD5();
                txtValue.Text = md5Algo.ComputeHash(txtText.Text);
            }
            else if (sha1HashOption.Checked)
            {
                hashSHA1 sha1Algo = new hashSHA1();
                txtValue.Text = sha1Algo.ComputeHash(txtText.Text);
            }
            else if (sha256HashOption.Checked)
            {
                hashSHA256 sha256Algo = new hashSHA256();
                txtValue.Text = sha256Algo.ComputeHash(txtText.Text);
            }
            else if (sha512HashOption.Checked)
            {
                hashSHA512 sha512Algo = new hashSHA512();
                txtValue.Text = sha512Algo.ComputeHash(txtText.Text);
            }
        }

        private void pickFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.Title = "Select a file to compute Hash value.";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtText.Text = openFileDialog.FileName;
                    txtValue.Text = "";
                }
            }
        }
    }
}
