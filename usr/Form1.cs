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
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.textBox1.Visible = true;
            this.textBox2.Visible = true;
            this.textBox3.Visible = true;
        }

        private void exit_CheckedChanged(object sender, EventArgs e)
        {
            this.name_textbox.Visible = false;
            this.name.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.textBox1.Visible = false;
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
        }



        private void admin_CheckedChanged(object sender, EventArgs e)
        {
            
        }



        private void check_button_Click(object sender, EventArgs e)
        {
            if(this.user.Checked)
            {
                if (login_textbox != '' && password_textbox != '')
                {
                    this.comment_create.Visible = true;
                    this.create.Visible = true;
                    for(int i = 0;i < Comment.comments_list.Length; i++)
                    {
                        this.Stats.Text = Comment.comments_list[i];
                    }
                }
            }

            else if (this.moder.Checked)
            {
                if (login_textbox != '' && password_textbox != '')
                {
                    this.articles_create.Visible = true;
                    this.create.Visible = true;
                    for (int i = 0; i < Articl.articles_list.Length; i++)
                    {
                        this.Stats.Text = Articl.articles_list[i];
                    }
                }
            }

            else if (this.admin.Checked)
            {
                if (login_textbox != '' && password_textbox != '')
                {
                    this.ban_users_create.Visible = true;
                    this.create.Visible = true;
                    for (int i = 0; i < Banned_users.Banned_users_list.Length; i++)
                    {
                        this.Stats.Text = Banned_users.Banned_users_list[i];
                    }
                }
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            
        }

        private void comment_create_Click(object sender, EventArgs e)
        {
            Comment.comments_create(create.Text);
        }

        private void articles_create_Click(object sender, EventArgs e)
        {
            Articl.articles_create(create.Text);
        }

        private void ban_users_create_Click(object sender, EventArgs e)
        {
            Banned_users.Banned_users_create(create.Text);
        }
    }
}
