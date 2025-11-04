using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;

namespace Weakest_Z_Cheats___LoginForm__
{
    public partial class Form1 : Form
    {
        public static api KeyAuthApp = new api(
            name: "Weakest Z Cheats", // App name
            ownerid: "D5pfCtJAeV", // Account ID
            version: "1.0" // Application version
        );

        private TextBox usernameField;
        private TextBox passwordField;
        private TextBox tfaField;

        public Form1()
        {
            InitializeComponent();

            // Initialize the fields (replace with your actual control names if different)
            usernameField = this.Controls["usernameField"] as TextBox;
            passwordField = this.Controls.Find("passwordField", true).FirstOrDefault() as TextBox;
            tfaField = this.Controls["tfaField"] as TextBox;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Status: " + KeyAuthApp.response.message);
        }
        

        private async void Form1_Load(object sender, EventArgs e)
        {
            await KeyAuthApp.init();
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (usernameField != null) {
                // You can add logic here if needed
            }
        }

        private async void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            await KeyAuthApp.login(usernameField.Text, passwordField.Text, tfaField.Text);
            if (KeyAuthApp.response.success)
            {
                // Main main = new Main();
                // main.Show();
                // this.Hide();
                MessageBox.Show("Login successful! (Main form not implemented)");
                this.Hide();
            }
            else
                MessageBox.Show("Status: " + KeyAuthApp.response.message);
        }
    }
}
