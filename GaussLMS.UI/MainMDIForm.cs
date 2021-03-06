﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaussLMS.UI.Forms;


namespace GaussLMS.UI
{
    public partial class MainMDIForm : Form
    {
        Dictionary<TreeNode, GroupBox> showControls;
        public MainMDIForm()
        {
            InitializeComponent();
            showControls = new Dictionary<TreeNode, GroupBox>();
            InitializeDictionary();
        }

        private void InitializeDictionary()
        {

            // Add some elements to the dictionary. There are no  
            // duplicate keys, but some of the values are duplicates.
            //this.showControls.Add(this.trvwMainTree.Nodes.Find("ndRegister", true)[0], this.grpbxRegisterMembers);
            //this.showControls.Add(this.trvwMainTree.Nodes.Find("ndReport", true)[0], this.grpbxReportMembers);
            //this.showControls.Add(this.trvwMainTree.Nodes.Find("ndMember", true)[0], this.grpbxMembers);
        }

        //private void trvwMainTree_Click(object sender, EventArgs e)
        //{
        //    //if (trvwMainTree.SelectedNode.Name == "Members") 
        //    ShowContainerFromDictionary(trvwMainTree.SelectedNode);
        //}
        //private void ShowContainer (String Name)
        //{
        //    grpbxMembers.Hide();
        //    grpbxRegisterMembers.Hide();
        //    grpbxReportMembers.Hide();

        //    switch (Name)
        //    {
        //        case "Members":
        //            grpbxMembers.Show();
        //            break;
        //        case "Register":
        //            grpbxRegisterMembers.Show();
        //            break;
        //        case "Report":
        //            grpbxReportMembers.Show();
        //            break;
        //        default:
        //            grpbxReportMembers.Show();
        //            break;  
        //    }
        //}
        //private void ShowContainerFromDictionary(TreeNode Node)
        //{
        //    grpbxMembers.Hide();
        //    grpbxRegisterMembers.Hide();
        //    grpbxReportMembers.Hide();

        //    // When you use foreach to enumerate dictionary elements, 
        //    // the elements are retrieved as KeyValuePair objects.
        //    foreach (KeyValuePair<TreeNode, GroupBox> kvp in showControls)
        //    {
        //        kvp.Value.Hide();
        //        if (kvp.Key == Node)
        //            kvp.Value.Show();
        //    }    
        //}

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ribbonStudentsButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(StudentsForm))
                {
                    f.Activate();
                    return;
                }
            }
            var studentsForm = new StudentsForm();
            studentsForm.MdiParent = this;
            //studentsForm.tabControl1.Visible = false;
            studentsForm.Show();

        }

        private void ribbonTeachersButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(TeachersForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form teachersForm = new TeachersForm();
            teachersForm.MdiParent = this;
            teachersForm.Show();
        }

        private void ribbonParentsButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ParentsForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form parentsForm = new ParentsForm();
            parentsForm.MdiParent = this;
            parentsForm.Show();
        }

        private void ribbonLessonsButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(LessonsForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form lessonsForm = new LessonsForm();
            lessonsForm.MdiParent = this;
            lessonsForm.Show();
        }

        private void MainMDIForm_Load(object sender, EventArgs e)
        {

        }

        private void ribbonButtonNewStudent_Click(object sender, EventArgs e)
        {
            var studentResigrationForm = new StudentRegistration();
            studentResigrationForm.Show();
        }

        private void ribbonButtonNewMember_Click(object sender, EventArgs e)
        {
            var newMemberForm = new CreateNewMember();
            newMemberForm.Show();
        }

        private void ribbonButtonNewContributor_Click(object sender, EventArgs e)
        {
            var newContributorForm = new CreateNewContributor();
            newContributorForm.Show();
        }

        private void ribbonTimetablesButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(CalendarForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form calendarForm = new CalendarForm();
            calendarForm.MdiParent = this;
            calendarForm.Show();
        }
    }
}
