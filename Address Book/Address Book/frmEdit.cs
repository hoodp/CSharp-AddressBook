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
    public partial class frmEdit : Form
    {
        OpenFileDialog image;

        public frmEdit()
        {
            InitializeComponent();
            imageMethod();

        }

        // constuctor with contact parameter
        public frmEdit(Contact edit)
        {
            InitializeComponent();
            setDetails(edit);
            imageMethod();
        }

        // gets details from edit button
        private void setDetails(Contact update)
        {
            txtName.Text = update.Name;
            txtStreet.Text = update.Street;
            txtCity.Text = update.City;
            txtState.Text = update.State;
            txtZip.Text = update.ZipCode;
            // check to see if image is null
            if (update.ImageFileName.Length > 0)
            {
                picPhoto.Image = Image.FromFile(update.ImageFileName);
            }
            else
            {
                picPhoto.Image = null;
            }    
        }

        // sets photo properties, copied method from ImageLoader but I do understand how it works
        private void imageMethod()
        {
            image = new OpenFileDialog();
            image.Filter = ".gif (Graphics Interchange Format)|*.gif|"
                + ".jpg (Joint Photographic Experts Group)|*.jpg;*.jpeg|"
                + ".png (Portable Network Graphics)|*.png";
            image.FilterIndex = 2;
            image.Title = "Please select an image file"; 
        }

        // method for uploading image
        private void btnImage_Click(object sender, EventArgs e)
        {
            if (image.ShowDialog() == DialogResult.OK && image.FileName != null)
            {
                try
                {
                    picPhoto.Image = Image.FromFile(image.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem while trying to load " + image.FileName + "\n" + ex.Message, "File System Error");
                }
            }
        }

        // method for confirming zip code
        private Boolean confirmZip(TextBox text)
        {
            string s = text.Text.Trim(); // text from textbox
            bool decimalCheck = true; // boolean for check
                foreach (char c in s)
                {
                    // check for decimal
                    if (c == '1' || c == '2' || c == '3' ||
                        c == '4' || c == '5' || c == '6' ||
                        c == '7' || c == '8' || c == '9')
                    {
                        // check for length
                        if (s.Length == 5)
                        {
                            decimalCheck = true;
                        }
                        // if length not 5
                        else
                        {
                            decimalCheck = false;
                            MessageBox.Show("Please enter a 5 Digit Zip Code.", "Error");
                            text.Focus();
                            break;
                        }
                    }
                    // text not integer
                    else
                    {
                        decimalCheck = false;
                        MessageBox.Show("Please enter a 5 Digit Zip Code.", "Error");
                        text.Clear();
                        text.Focus();
                        break;
                    }
                }      
            return decimalCheck;
        }

        // method for confirming state
        private bool confirmState(TextBox stateBox)
        {
            bool validState = false;
            string s = stateBox.Text.Trim().ToUpper(); // trim state and change to upperCase
            string[] stateArray = {"AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA","HI",
                                   "ID","IL","IN","IA","KS","KY","LA","ME","MD","MA","MI",
                                   "MN","MS","MO","MT","NE","NV","NH","NJ","NM","NY","NC",
                                   "ND","OH","OK","OR","PA","RI","SC","SD","TN","TX","UT",
                                   "VT", "VA", "WA", "WV", "WI", "WY"};
            // check for valid state in string
            foreach (String state in stateArray)
            {
                if (s == state)
                {
                    validState = true;
                    this.txtState.Text = s; // change entry to uppercase
                    break;
                }
                else
                {
                    validState = false;
                }
            }
            
            if (validState == false)
            {
                stateBox.Clear();
                stateBox.Focus();
                MessageBox.Show("Please enter a valid State Abbrev.", "Error");
            }
            
            return validState;
        }

        // check for data inside Name or address box
        private bool confirmText(TextBox text)
        {
            string s = text.Text.Trim();
            if (s.Length > 0)
            {
                return true;    
            }
            else
            {
                MessageBox.Show("All fields are required.", "Error");
                return false;
            }
        }

        // check for confirming city
        private bool checkCity(TextBox text)
        {
            string s = text.Text.Trim();
            bool checkCity = true;

            //checks for mistakes in city
            foreach (char c in s)
            {
                if (c == '1' || c == '2' || c == '3' ||
                    c == '4' || c == '5' || c == '6' ||
                    c == '7' || c == '1' || c == '1' ||
                    c == '$' || c == '&' || c == '!' ||
                    c == ',' || c == '%' || c == '#')
                {
                    checkCity = false;
                    MessageBox.Show("Please enter a valid city", "Error");
                    text.Focus();
                    text.Clear();   
                    break; // breaks any number or special character is found
                }
                else
                {
                    checkCity = true;
                }
            }
            return checkCity;
        }

        // run all validation methods
        public bool validData()
        {
            if (confirmText(txtName) && confirmText(txtStreet) && checkCity(txtCity) && 
                confirmState(txtState) && confirmZip(txtZip))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // cancels current edit
        private void btnClose_Click(object sender, EventArgs e)
        {
            // confirmation box
            if (MessageBox.Show("Are you sure you wish to exit?\nContact will be lost.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validData())
            {
                // new contact
                Contact contact = new Contact();

                // set values of new contact
                contact.Name = txtName.Text;
                contact.State = txtState.Text;
                contact.Street = txtStreet.Text;
                contact.ZipCode = txtZip.Text;
                contact.City = txtCity.Text;
                contact.ImageFileName = image.FileName;

                // send back dialog result and contact info
                this.Tag = contact;
                this.DialogResult = DialogResult.OK;    
            }
            
        }
    }
}