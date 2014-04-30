/*
 * Paul Hood
 * Lesson 4 Homework
 * 3/13/2013
 * Address Book application
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Address_Book
{
    public partial class frmMain : Form
    {
        // list for storing contacts
        List<Contact> contactList = new List<Contact>();
        
        public frmMain()
        {
            InitializeComponent();
            timer1.Start(); // start timer for clock
        }

        // display time at load
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTime.Text = time();
            lblDate.Text = date();
        }

        // set up for date
        private String date()
        {
            DateTime date = DateTime.Now;
            return date.ToShortDateString();
        }

        // set up for time
        private String time()
        {
            DateTime time = DateTime.Now;
            return time.ToShortTimeString();
        }

        // timer tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = date();
            lblTime.Text = time();
        }

        // add new name
        private void btnNew_Click(object sender, EventArgs e)
        {
            Form updateContact = new frmEdit();
            addName(updateContact); ;
        }

        // add name to listbox
        public void addName(Form edit)
        {
            // checks for valid data
            if (edit.ShowDialog() == DialogResult.OK && edit.Tag != null)
            {
                // add new contact to list
                Contact newName = edit.Tag as Contact;
                contactList.Add(newName);

                // add contact to listview box
                ListViewItem names = new ListViewItem();
                names.Text = newName.Name;
                names.SubItems.Add(newName.address());

                lsvNames.Items.Add(names);
            }
        }

        // method that deletes at selected index
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem remove in lsvNames.SelectedItems)
            {
                contactList.RemoveAt(remove.Index);
                lsvNames.Items.RemoveAt(remove.Index);
            }   
        }

        // edit button
        private void btnEdit_Click(object sender, EventArgs e)
        {
             //search for selected item
            foreach (ListViewItem findSelect in lsvNames.SelectedItems)
            {
                // confirmation box
                if (MessageBox.Show("Edit " + contactList[findSelect.Index].Name + "?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form editContact = new frmEdit(contactList[findSelect.Index]); // opens new form, sends contact info
                    contactList.RemoveAt(findSelect.Index); //removes from list
                    lsvNames.Items.RemoveAt(findSelect.Index); // removes from box
                    addName(editContact); // adds update
                }    
            }       
        }

        // closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
