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
                Blog user = (Blog)listView1.SelectedItems[0].Tag;

                if (user != null)
                {
                    textBoxName.Text=user.Name;
                    comboBox1.SelectedText = user.Author;
                    numericUpDownAge.Value = user.Rate;
                }
            } 
            else if (listView1.SelectedItems.Count == 0)
            {
                ClearInput();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Blog user = new Blog(textBoxName.Text, comboBox1.SelectedText, (int)numericUpDownAge.Value);

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
                    users.BlogsList.Add((Blog)item.Tag);

                }
            }
            SerealizeXML(users);
            users.BlogsList.Where(user => user.Author.Equals(2));

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
            foreach(Blog user in users.BlogsList)
            {
                ListViewItem listViewItem = new ListViewItem(user.Name); //отображаемая часть на форме
                listViewItem.Tag = user; //записать пользователя в listViewItem

                listView1.Items.Add(listViewItem);
            }

        }
    }
}
