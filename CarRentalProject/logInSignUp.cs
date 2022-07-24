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
    static class logInSignUp
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void logInAdmin(TextBox loginTextBox, TextBox passwordTextBox, Form1 form)
        {
            string[] data = new string[100];
            string line;
            int i = 0;
            string path = @"..\adminLogins.txt";

            if (!File.Exists(path))
            {
                MessageBox.Show("No login save file found! Try creating adminLogins.txt file and fill out the info.", "Login error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            for (int j = 0; j < i; j += 2)
            {
                //Check if login and password match data
                if (loginTextBox.Text == data[j] && passwordTextBox.Text == data[j + 1])
                {
                    MessageBox.Show("Logged-in!", "Logged-in!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1.name = loginTextBox.Text;
                    form.signedInAdmin();
                    return;
                }
                //Check if login matches the data, but the password is different
                else if (loginTextBox.Text == data[j] && passwordTextBox.Text != data[j + 1])
                {
                    MessageBox.Show("Password doesnt match the login!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }else if(loginTextBox.Text=="" || passwordTextBox.Text == "")
                {
                    MessageBox.Show("Login or password is missing!", "No data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public static void logIn(TextBox loginTextBox, TextBox passwordTextBox, Form1 form)
        {
            string[] data = new string[100];
            string line;
            int i = 0;
            string path = @"..\logins.txt";
            //This is for debugging purposes only, de-comment for the proper functionality
            if (!File.Exists(path))
            {
                MessageBox.Show("No login save file found! Try signing up first.", "Login error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            for (int j = 0; j < i; j += 2)
            {
                //Check if login and password match data
                if (loginTextBox.Text == data[j] && passwordTextBox.Text == data[j + 1])
                {
                    MessageBox.Show("Logged-in!", "Logged-in!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1.name = loginTextBox.Text;
                    //Form1.signedIn();
                    return;
                }
                //Check if login matches the data, but the password is different
                else if (loginTextBox.Text == data[j] && passwordTextBox.Text != data[j + 1])
                {
                    MessageBox.Show("Password does not match the login!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (loginTextBox.Text == "" || passwordTextBox.Text == "")
                {
                    MessageBox.Show("Login or password is missing!", "No data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("No user found!", "Login error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static  void signUp(TextBox loginTextBox, TextBox passwordTextBox, Form1 form)
        {
            //Check if text boxes are empty
            if (loginTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Login or password is missing!", "No Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] data = new string[100];
            //Make the path for the logins file
            string path = @"..\logins.txt";
            if (File.Exists(path) != true)
            {
                FileStream tempFile = File.Create(path);
                tempFile.Close();
            }

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
