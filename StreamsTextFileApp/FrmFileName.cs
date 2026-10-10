using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StreamsTextFileApp
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName = "";
        public FrmFileName()
        {
            InitializeComponent();
        }
        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("Error: File name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFileName.Focus();
                return;
            }
            SetFileName = txtFileName.Text + ".txt";
            this.Close();
        }
    }
}