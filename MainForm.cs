using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormAssesment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            logInPanel.Visible = false;
            typeBox.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerPanel.Visible = true;
            logInPanel.Visible = false;
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            
            Boolean isLogin = false;
            Dictionary<string, object> data;

            (isLogin, data ) = db.login(usernameBox.Text,loginPasswordBox.Text);

            if (isLogin)
            {
                LandingForm landingForm = new LandingForm(data);
                landingForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Password or username does not exist");
            }
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logInPanel.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            DateTime now = DateTime.Now;
            int age = now.Year - dateTimePicker.Value.Year;


            int row = db.InsertData("InfoTbl", firstNameBox.Text, lastNameBox.Text, age, typeBox.Text, passwordRegBox.Text);

            if (row > 0)
            {
                logInPanel.Visible = true;
                registerPanel.Visible = false;
                MessageBox.Show("Data inserted successfully");
            }
            else
            {
                MessageBox.Show("Data not inserted");
            }

        }

        private void registerLink_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = true;
            logInPanel.Visible = false;

        }
    }
}
