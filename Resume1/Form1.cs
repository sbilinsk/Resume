using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resume1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstSection.Items.Add("Contact Info");
            lstSection.Items.Add("About Me");
            lstSection.Items.Add("Summary");
            lstSection.Items.Add("Education");
            lstSection.Items.Add("Skills/Qualifications");
            lstSection.Items.Add("Experience");
            display("Thanks for taking a look at my interactive resume, written in C#. Please choose a section to view from the drop down list above, then click display");

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            if (lstSection.Text == "Contact Info")
            {
                display(
                "Full Name: Shane Bilinski " + "\r\n" +
                "Address: 550 W Surf St, Chicago, IL 60657" + "\r\n" +
                "Cell: (312) 982 - 1200" + "\r\n" +
                "Email: shaneb1393@gmail.com");
            }

            else if (lstSection.Text == "Summary")
            {
                display("Currently a Technical Consultant employed in SAP financial supply chain automation." + "\r\n" +
                        "Experienced with database administration, network engineering, C, C#, SQL, and Java");
                return;
            }

            else if (lstSection.Text == "About Me")
            {
                display("I'm a recent graduate currently living in Chicago, employed as a technical consulant. ");
            }


            else if (lstSection.Text == "Education")
            {
                display("Purdue University - West Lafayette" + "\r\n" +
                        "College of Technology" + "\r\n" +
                        "Major: Computer and Information Technology" + "\r\n" +
                        "Concentration: Systems Analysis & Design" + "\r\n" +
                        "2012 - 2016");
                return;

            }

            else if (lstSection.Text == "Skills/Qualifications")
            {
                display("Programming languages: C#, SQL, C, Python, and Java" + "\r\n" +
                        "Databases: Oracle SQL Developer, PL / SQL, Access" + "\r\n" +
                        "Other: SAP, Visio, Microsoft Project, TCP / IP, Visual Studio," +"\r\n" +
                        "OCR Software, UML, Windows Server, VMWare, IBM SPSS");
                return;

            }

            else if (lstSection.Text == "Experience")
            {
                display("Current Employer: Hanse Orga Group" + "\r\n" +
                        "Location: Chicago, IL" + "\r\n" +
                        "Date: July 2016 - Present" + "\r\n" +
                        "Position: Technical Consultant" + "\r\n" +
                        "Duties:" + "\r\n" +
                        "Automate accounting processes in SAP FICO" + "\r\n" +
                        "Act as technical lead on projects with clients across a wide industry spectrum" + "\r\n" +
                        "Frequent presentations to key business users" + "\r\n" +
                        "Work with client technical teams to configure and implement software" + "\r\n" +
                        "Troubleshoot software configuration" + "\r\n" +
                        "Work with a team on a project from launch to go - live" + "\r\n" + "\r\n" +
                        "Employer: Purdue University" + "\r\n" +
                        "Location: West Lafayette, IN" + "\r\n" +
                        "Date: January 2015 – May 2016" + "\r\n" +
                        "Position: Senior Lab Assistant" + "\r\n" +
                        "Duties:" + "\r\n" +
                        "Supervised lab assistants and trained new employees" + "\r\n" +
                        "Managed computer lab staffing and employee performance" + "\r\n" +
                        "Promoted from lab assistant in minimum time allowed by policy" + "\r\n" +
                        "Provided technical support for campus computer labs" + "\r\n" + "\r\n" +
                        "Employer: University of Notre Dame" + "\r\n" +
                        "Location: South Bend, IN" + "\r\n" +
                        "Date: Summer 2014 – 2015" + "\r\n" +
                        "Position: Intern - Office of Development, Information Technology" + "\r\n" +
                        "Duties:" + "\r\n" +
                        "Gained meaningful business experience as part of an IT team" + "\r\n" +
                        "Aided in troubleshooting departmental technology problems" + "\r\n" +
                        "Installed new computer systems for employees" + "\r\n" +
                        "Visited employees to assess their needs" + "\r\n" + "\r\n" +
                        "Employer: University of Notre Dame" + "\r\n" +
                        "Location: South Bend, IN" + "\r\n" +
                        "Date: Summer 2015" + "\r\n" +
                        "Position: Computer Service Technician" + "\r\n" +
                        "Duties: " + "\r\n" +
                        "Improved CRM by automating performance surveys, reducing time taken by 90 %" + "\r\n" +
                        "Repaired software and hardware problems for student and faculty computers" + "\r\n" +
                        "Created and maintained databases for service records and campus computer orders");
                return;
            }

        }

        private void display(string textToOutput)
        {
            txtOutput.Text = textToOutput;
            return;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
