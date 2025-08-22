using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_lucky_seven
{
    public partial class AddWallet: Form
    {
        public string userWalletBalance
        { 
            get; 
            private set; 
        }
        public AddWallet()
        {
            InitializeComponent();
        }

        private void AddWallet_Load(object sender, EventArgs e)
        {

        }

        private void textBox_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            userWalletBalance = textBox_num.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
