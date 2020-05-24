using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;

namespace SpeedTools___Save_Manager
{
    public partial class AddEditSaveForm : Form
    {
        StagSaveManager theSSM;
        string fileDestination;
        public TextBox customName;
        public TextBox theFilePath;
        string dirShortCut = "";
        public AddEditSaveForm()
        {
            InitializeComponent();
        }

        public AddEditSaveForm(StagSaveManager ssm)
        {
            InitializeComponent();
            customName = customSaveName;
            theFilePath = filePath;
            theSSM = ssm;
            lb_AddOrEdit.Text = ssm.addOrEdit;
        }

        //Finish
        private void button2_Click(object sender, EventArgs e)
        {
            if(theSSM.wrapper.saves.Find(x => x.SaveName == customName.Text) == null)
            {
                theSSM.wrapper.saves.Add(new Save(customName.Text, filePath.Text));
                System.Diagnostics.Debug.WriteLine("Adding to the list");
                theSSM.SaveWrapper();
            }
            else
            {
                theSSM.wrapper.saves[theSSM.wrapper.saves.FindIndex(x => x.SaveName == customName.Text)].Filepath = filePath.Text;
                System.Diagnostics.Debug.WriteLine("updating value");
                theSSM.UpdateList();
            }
            Hide();
        }

        //Browse
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = dirShortCut == "" ? @"C:\" : dirShortCut,
                Title = "Select Save File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dirShortCut = openFileDialog1.FileName;
                filePath.Text = openFileDialog1.FileName;
                fileDestination = openFileDialog1.FileName;
            }

        }
    }
}
