using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypt_Csharp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPlain.Text.Trim() == "")
            {
                MessageBox.Show("Please input the plain text to test cryting.");
                return;
            }
            Crypt crypt = new Crypt();
            this.txtDES.Text = crypt.EnDES(this.txtPlain.Text.Trim());
            this.txtDeDES.Text = crypt.DeDES(this.txtDES.Text.Trim());
            this.txtMD5.Text = crypt.MD5(this.txtPlain.Text.Trim());

        }
    }
}
