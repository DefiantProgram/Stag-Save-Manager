using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Media;

namespace SpeedTools___Save_Manager
{
    public partial class StagSaveManager : Form
    {
        public string addOrEdit = "";

        public TextBox filePath;
        string jsonString = "";

        public JSONWrapper wrapper = new JSONWrapper();

        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + "Saves.JSON";

        AddEditSaveForm newForm;

        public StagSaveManager()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (SavesList.SelectedIndex < wrapper.saves.Count && SavesList.SelectedIndex >= 0)
                lb_FilepathToCopy.Text = wrapper.saves[SavesList.SelectedIndex].Filepath + " will be moved to: ";
        }

        private void StagSaveManager_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(dirParameter);
            try
            {
                wrapper = JsonConvert.DeserializeObject<JSONWrapper>(File.ReadAllText(dirParameter));              
                tb_SaveDestinationFilePath.Text = wrapper.SD.FilePath;
            }
            catch (Exception except)
            {
                Console.WriteLine(except);
            }

            UpdateList();

            filePath = tb_SaveDestinationFilePath;

            newForm = new AddEditSaveForm(this);


        }

        private void bt_AddSave_Click(object sender, EventArgs e)
        {
            addOrEdit = "Add";
            newForm.Show();
        }

        private void bt_EditSave_Click(object sender, EventArgs e)
        {
            addOrEdit = "Edit";
            if (SavesList.SelectedIndex < wrapper.saves.Count && SavesList.SelectedIndex >= 0)
            {
                newForm.customName.Text = wrapper.saves[SavesList.SelectedIndex].SaveName;
                newForm.theFilePath.Text = wrapper.saves[SavesList.SelectedIndex].Filepath;
                wrapper.saves.RemoveAt(SavesList.SelectedIndex);
            }
            newForm.Show();
        }

        private void bt_RemoveSave_Click(object sender, EventArgs e)
        {
            if(SavesList.SelectedIndex < wrapper.saves.Count)
                wrapper.saves.RemoveAt(SavesList.SelectedIndex);
            UpdateList();
        }

        private void bt_SetSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_SaveDestinationFilePath.Text = folderDlg.SelectedPath;
                wrapper.SD.FilePath = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        public void SaveWrapper()
        {
            jsonString = JsonConvert.SerializeObject(wrapper);
            File.WriteAllText(dirParameter, jsonString);
            UpdateList();
        }

        public void UpdateList()
        {
            SavesList.Items.Clear();
            SavesList.BeginUpdate();
            System.Object[] ItemObject = new System.Object[wrapper.saves.Count];
            for (int i = 0; i < wrapper.saves.Count; i++)
            {
                ItemObject[i] = wrapper.saves[i].SaveName;
            }
            SavesList.Items.AddRange(ItemObject);
            SavesList.EndUpdate();
        }

        private void bt_ImportSave_Click(object sender, EventArgs e)
        {
            if (SavesList.SelectedIndex < wrapper.saves.Count && SavesList.SelectedIndex >= 0)
            {
                string fileToCopy = wrapper.saves[SavesList.SelectedIndex].Filepath;
                string fileDestination = wrapper.SD.FilePath+"\\";

                Debug.WriteLine(fileToCopy);
                Debug.WriteLine(fileDestination);



                // To copy a file to another location and
                // overwrite the destination file if it already exists.
                try
                {
                    System.IO.File.Copy(fileToCopy, fileDestination + Path.GetFileName(fileToCopy), true);                
                } catch(Exception except)
                {
                    Debug.WriteLine(except);
                }
                SystemSounds.Beep.Play();
            }


        }
    }

    [System.Serializable]
    public class JSONWrapper
    {
        public List<Save> saves = new List<Save>();
        public SaveDestination SD = new SaveDestination("");
    }

    [System.Serializable]
    public class Save
    {
        public string SaveName;
        public string Filepath;

        public Save(string newSaveName, string newFilePath)
        {
            SaveName = newSaveName;
            Filepath = newFilePath;
        }
    }

    //Where the saves are transported to
    [System.Serializable]
    public class SaveDestination
    {
        public string FilePath;

        public SaveDestination(string newFilePath)
        {
            FilePath = newFilePath;
        }
    }
}
