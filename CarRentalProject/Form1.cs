using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarRentalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string[] data = new string[100];
            string line;
            int i = 0;
            string path = @"C:\Users\vixu1\source\repos\CarRentalProject\logins.txt";
            
            //Make filestream for reading the file
            FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read);
            
            using (StreamReader sr = new StreamReader(fsRead))
            {
                //Write contents of file to data array
                while ((line = sr.ReadLine()) != null)
                {
                    data[i] = line;
                    i += 1;
                }
            }

            for(int j = 0; j<i; j += 2)
            {
                //Check if login and password match data
                if (loginTextBox.Text == data[j] && passwordTextBox.Text == data[j + 1])
                {
                    MessageBox.Show("Logged-in!", "Logged-in!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Check if login matches the data, but the password is different
                else if (loginTextBox.Text == data[j] && passwordTextBox.Text != data[j + 1])
                {
                    MessageBox.Show("Password doesnt match the login!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //No user of that name found
            MessageBox.Show("User of that login already exists!", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Registration process
        private void signupButton_Click(object sender, EventArgs e)
        {
            //Check if text boxes are empty
            if (loginTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Login or password is missing!", "No Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] data = new string[100];
            //Make the path for the logins file
            string path = @"C:\Users\vixu1\source\repos\CarRentalProject\logins.txt";
            FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read);
            string line;
            int i = 0;

            //Write contents of file to data array
            using (StreamReader sr = new StreamReader(fsRead))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    data[i] = line;
                    i += 1;

                }
            }
            fsRead.Close();
            
            FileStream fsWrite = new FileStream(path, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fsWrite)) 
            { 
                //Check if the login already exists
                for (int j = 0; j < i; j += 2)
                {
                    if (loginTextBox.Text == data[j])
                    {
                        MessageBox.Show("This login already exists!", "Registery Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //Write login and password to file
                sw.WriteLine(loginTextBox.Text);
                sw.WriteLine(passwordTextBox.Text);
                MessageBox.Show("Successfully registered!", "Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            fsWrite.Close();
        } 
    }
}
