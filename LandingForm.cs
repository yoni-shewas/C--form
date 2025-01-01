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
    public partial class LandingForm : Form
    {
        private string firstName;
        private string lastName;
        private int age;
        private string type;
        public LandingForm(Dictionary<string, object> data)
        {
            InitializeComponent();
            firstNameShowBox.Text = data["FirstName"].ToString();
            lastNameShowBox.Text = data["LastName"].ToString();
            ageShow.Text = data["Age"].ToString();
            typeShow.Text = data["Type"].ToString();
            this.Text = data["Type"] + " Page";

        }

        private void LandingForm_Load(object sender, EventArgs e)
        {

        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
