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

namespace diplom_example_app
{
    public partial class SimpleExampleUsers : Form
    {
        public SimpleExampleUsers()
        {
            InitializeComponent();
            ClearInput();
        }

        private void ClearInput()
        {
            textBoxName.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
            numericUpDownAge.Value = 0;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                User user = (User)listView1.SelectedItems[0].Tag;

                if (user != null)
                {
                    textBoxName.Text=user.Name;
                    comboBox1.SelectedText = user.Sex;
                    numericUpDownAge.Value = user.Age;
                }
            } 
            else if (listView1.SelectedItems.Count == 0)
            {
                ClearInput();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            User user = new User(textBoxName.Text, comboBox1.SelectedText, (int)numericUpDownAge.Value);

            ListViewItem listViewItem = new ListViewItem(user.Name); //отображаемая часть на форме
            listViewItem.Tag = user; //записать пользователя в listViewItem

            listView1.Items.Add(listViewItem);

            ClearInput();

        }

        public void SerealizeXML(Users usersList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Users));

            using (FileStream fs = new FileStream("Users.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, usersList);
            }
        }

        private void buttonSerealize_Click(object sender, EventArgs e)
        {
            Users users = new Users();

            foreach(ListViewItem item in listView1.Items)
            {
                if(item.Tag != null)
                {
                    users.UserList.Add((User)item.Tag);

                }
            }
            SerealizeXML(users);
            users.UserList.Where(user => user.Sex.Equals(2));

        }

        private Users DeserealizeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Users));
            using (FileStream fs = new FileStream("Users.xml", FileMode.OpenOrCreate))
            {
                Users users = (Users)xml.Deserialize(fs);
                return users;
            }
        }

        private void buttonDeserealize_Click(object sender, EventArgs e)
        {
            ClearInput();
            Users users = DeserealizeXML();
            foreach(User user in users.UserList)
            {
                ListViewItem listViewItem = new ListViewItem(user.Name); //отображаемая часть на форме
                listViewItem.Tag = user; //записать пользователя в listViewItem

                listView1.Items.Add(listViewItem);
            }

        }
    }
}
