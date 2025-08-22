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
    public partial class InsertMoneyForm: Form
    {
        public string userMoneyAmount { get; private set; }
        public InsertMoneyForm()
        {
            InitializeComponent();
        }
        
        private void InsertMoneyForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            userMoneyAmount = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
