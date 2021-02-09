using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Programmer: Lisa Duong
// Project: Duong_2
// Due Date: 3/13/2020
// Description: Individual Assignment #2

namespace Duong_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void CheckChange(object sender, EventArgs e)                    
        {
        int inState = 49;
        int outState = 99;
        int numberOfCourses = +0;
        bool inStateCheck = inStateRadioButton.Checked;
        bool outStateCheck = outOfStateRadioButton.Checked;
            //check which boxes are checked, and compute total courses and price
            if (frenchCheckBox.Checked)
            {
                numberOfCourses++;
            }
            if (germanCheckBox.Checked)
            {
                numberOfCourses++;
            }
            if (italianCheckBox.Checked)
            {
                numberOfCourses++;
            }
            if (russianCheckBox.Checked)
            {
                numberOfCourses++;
            }
            if (spanishCheckBox.Checked)
            {
                numberOfCourses++;
            }
            if (numberOfCourses <= 3)
            {
                coursesLabel.Text = "# of courses purchased: " + numberOfCourses.ToString();
            }
            //check if number of courses is greater than 3
            // I tried to find a way to not let user click on a course after the third one
            else
            {
                MessageBox.Show("You cannot purchase more than 3 courses per order.");
            }
            // check residence and compute order total
            if (inStateCheck && numberOfCourses <= 3)
            {
                int inTotal = inState * numberOfCourses;
                totalLabel.Text = "Order total: " + inTotal.ToString("c");
            }
            if (outStateCheck && numberOfCourses <= 3)
            {
                int outTotal = outState * numberOfCourses;
                totalLabel.Text = "Order total: " + outTotal.ToString("c");
            }
        }
        private void coursesLabel_Click(object sender, EventArgs e)
        {

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            // I could not figure how to display messagebox if user has less than 1 courses or more than 3 courses.
            bool fallCheck = fallRadioButton.Checked;
            bool springCheck = springRadioButton.Checked;
            bool inStateButton = inStateRadioButton.Checked;
            bool outStateButton = outOfStateRadioButton.Checked;
            string orderTitle = "Purchase Order";
            MessageBoxIcon iconPicture = MessageBoxIcon.Information;
            // Display registration, ID, Name, Residence, Price per course, order total, cc type, card #, card exp date
            if (fallCheck && inStateButton && masterCardRadioButton.Checked)
            {
                DialogResult result1 = MessageBox.Show("Registration term: " + fallRadioButton.Text  + ", " 
                    + comboBox.Text + "\nStudent ID: " + idMaskedTextBox.Text + "\nStudent Name: " 
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: "
                    + emailTextBox.Text + "\nResidence status: In-State" + "\n"
                    + coursesLabel.Text + "\nPrice per course: $49" + "\n" +
                    totalLabel.Text + "\nCredit card type: Master Card" + "\nCard number: " + cardTextBox.Text
                    + "\nCard exp date: " + dateTextBox.Text, orderTitle);
            // I cannot add a information icon without the use of buttons in the messagebox 
            //",purchase order" is the title on messagebox
            }
            if (fallCheck && inStateRadioButton.Checked && visaRadioButton.Checked)
            {
                MessageBox.Show("Registration term: " + fallRadioButton.Text + ", "
                    + comboBox.Text + "\nStudent ID: " + idMaskedTextBox.Text + "\nStudent Name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: "
                    + emailTextBox.Text + "\nResidence status: In-State" + "\n"
                    + coursesLabel.Text + "\nPrice per course: $49" + "\n" +
                    totalLabel.Text + "\nCredit card type: Visa Credit Card" + "\nCard number: " + cardTextBox.Text
                    + "\nCard exp date: " + dateTextBox.Text, orderTitle);
            }
            if (fallCheck && outStateButton && masterCardRadioButton.Checked)
            {
                MessageBox.Show("Registration term: " + fallRadioButton.Text + ", "
                    + comboBox.Text + "\nStudent ID: " + idMaskedTextBox.Text + "\nStudent Name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: "
                    + emailTextBox.Text + "\nResidence status: Out-Of-State" + "\n: "
                    + coursesLabel.Text + "\nPrice per course: $99" + "\n" +
                    totalLabel.Text + "\nCredit card type: Master Card" + "\nCard number: " + cardTextBox.Text
                    + "\nCard exp date: " + dateTextBox.Text, orderTitle);
            }
            if (fallCheck && outStateButton && visaRadioButton.Checked)
            {
                MessageBox.Show("Registration term: " + fallRadioButton.Text + ", "
                    + comboBox.Text + "\nStudent ID: " + idMaskedTextBox.Text + "\nStudent Name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: "
                    + emailTextBox.Text + "\nResidence status: Out-Of-State" + "\n"
                    + coursesLabel.Text + "\nPrice per course: $99" + "\n" +
                    totalLabel.Text + "\nCredit card type: Visa Credit Card" + "\nCard number: " + cardTextBox.Text
                    + "\nCard exp date: " + dateTextBox.Text, orderTitle);
            }
            if (springCheck && inStateRadioButton.Checked && masterCardRadioButton.Checked)
            {
                MessageBox.Show("Registration term: " + springRadioButton.Text + ", "
                    + comboBox.Text + "\nStudent ID: " + idMaskedTextBox.Text + "\nStudent Name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: "
                    + emailTextBox.Text + "\nResidence status: In-State" + "\n"
                    + coursesLabel.Text + "\nPrice per course: $49" + "\n" +
                    totalLabel.Text + "\nCredit card type: Master Card" + "\nCard number: " + cardTextBox.Text
                    + "\nCard exp date: " + dateTextBox.Text, orderTitle);
            }
            if (springCheck && inStateRadioButton.Checked && visaRadioButton.Checked)
            {
                MessageBox.Show("Registration term: " + springRadioButton.Text + ", "
                    + comboBox.Text + "\nStudent ID: " + idMaskedTextBox.Text + "\nStudent Name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: "
                    + emailTextBox.Text + "\nResidence status: In-State" + "\n"
                    + coursesLabel.Text + "\nPrice per course: $49" + "\n" +
                    totalLabel.Text + "\nCredit card type: Visa Credit Card" + "\nCard number: " + cardTextBox.Text
                    + "\nCard exp date: " + dateTextBox.Text, orderTitle);
            }
            if (springCheck && outStateButton && masterCardRadioButton.Checked)
            {
                MessageBox.Show("Registration term: " + springRadioButton.Text + ", "
                    + comboBox.Text + "\nStudent ID: " + idMaskedTextBox.Text + "\nStudent Name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: "
                    + emailTextBox.Text + "\nResidence status: Out-Of-State" + "\n"
                    + coursesLabel.Text + "\nPrice per course: $99" + "\n" +
                    totalLabel.Text + "\nCredit card type: Master Card" + "\nCard number: " + cardTextBox.Text
                    + "\nCard exp date: " + dateTextBox.Text, orderTitle);
            }
            if (springCheck && outStateButton && visaRadioButton.Checked)
            {
                MessageBox.Show("Registration term: " + springRadioButton.Text + ", "
                    + comboBox.Text + "\nStudent ID: " + idMaskedTextBox.Text + "\nStudent Name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: "
                    + emailTextBox.Text + "\nResidence status: Out-Of-State" + "\n"
                    + coursesLabel.Text + "\nPrice per course: $99" + "\n" +
                    totalLabel.Text + "\nCredit card type: Visa Credit Card" + "\nCard number: " + cardTextBox.Text
                    + "\nCard exp date: " + dateTextBox.Text, orderTitle);
            }

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // ask if user is certain, if yes close form, if no stay on form
            // title, message, buttons & question icon
            string message = "Are you sure you wish to quit?";
            string title = "Exit form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            coursesLabel.Text = "# of courses purchased: 0";
            totalLabel.Text = "Order total: $0.00";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void courseOrderInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear input/outputs and focus on fall radio button
            fallRadioButton.Checked = true;
            comboBox.SelectedIndex = -1;
            idMaskedTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            inStateRadioButton.Checked = true;
            frenchCheckBox.Checked = false;
            germanCheckBox.Checked = false;
            italianCheckBox.Checked = false;
            spanishCheckBox.Checked = false;
            russianCheckBox.Checked = false;
            coursesLabel.Text = "# of courses purchased: 0";
            totalLabel.Text = "Order total: $0.00";
            masterCardRadioButton.Checked = true;
            cardTextBox.Text = "";
            dateTextBox.Text = "";
            fallRadioButton.Focus();

        }
    }
}
