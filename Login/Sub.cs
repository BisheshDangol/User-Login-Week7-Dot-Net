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
    
    public partial class Sub : Form
    {
        XmlSerializer xmlSerializer;
        List<User> users;
        
        public Sub()
        {
            users = new List<User>();
            xmlSerializer = new XmlSerializer(typeof(List<User>));
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("C:/Users/bisheshdangol/Desktop/Application Development/Login/login.xml", FileMode.Open, FileAccess.Read);
            users = (List<User>)xmlSerializer.Deserialize(fileStream);

            dataGridView.DataSource = employees;
            fileStream.Close();
        }
    }
}
