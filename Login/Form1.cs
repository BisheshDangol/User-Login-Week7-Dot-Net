using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Login
{
    public partial class Form1 : Form
    {
        XmlSerializer xmlSerializer;
        List<User> users;
        public Form1()
        {
            users = new List<User>();
            xmlSerializer = new XmlSerializer(typeof(List<User>));
            InitializeComponent();

        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("C:/Users/bisheshdangol/Desktop/Application Development/Login/login.xml", FileMode.Create, FileAccess.Write);
            User user = new User();

            user.FirstName = first_name_txt.Text;
            user.LastName = last_name_txt.Text;
            user.Email = email_txt.Text;
            user.Password = password_txt.Text;

            // Add user objects in users list.
            users.Add(user);

            // Serialize helps to write in XML file.
            xmlSerializer.Serialize(fileStream, users);

            // Must close 
            fileStream.Close();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            first_name_txt.Text = String.Empty;
            last_name_txt.Text = String.Empty;
            email_txt.Text = String.Empty;
            password_txt.Text = String.Empty;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var loginForm = new Sub();
            loginForm.Show();
        }
    }
}
