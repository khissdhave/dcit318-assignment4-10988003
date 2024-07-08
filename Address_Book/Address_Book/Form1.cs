using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address_Book
{
    public partial class Form1 : Form
    {
        List<AddressBookEntry> entries = new List<AddressBookEntry>();

        public Form1()
        {
            InitializeComponent();
            entries = new List<AddressBookEntry>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string contact = txtContact.Text;

            AddressBookEntry entry = new AddressBookEntry { Name = name, Email = email, Contact = contact };
            entries.Add(entry);

            listBoxEntires.Items.Add(entry.ToString());
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();

            foreach (var i in entries)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }

    public class AddressBookEntry
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Contact: {Contact}";
        }
    }
}
