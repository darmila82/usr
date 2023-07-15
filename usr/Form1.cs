using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usr.Else;

namespace usr
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            this.name_textbox.Text = "";
            this.password_textbox.Text = "";
            this.login_textbox.Text = "";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_CheckedChanged(object sender, EventArgs e)
        {
            this.name_textbox.Visible = true;
            this.name.Visible = true;
        }

        private void exit_CheckedChanged(object sender, EventArgs e)
        {
            this.name_textbox.Visible = false;
            this.name.Visible = false;
        }



        private void admin_CheckedChanged(object sender, EventArgs e)
        {
            
        }



        private void check_button_Click(object sender, EventArgs e)
        {
            if(this.user.Checked)
            {
                if (exit.Checked)
                {
                    

                }
            }
        }
    }
}
