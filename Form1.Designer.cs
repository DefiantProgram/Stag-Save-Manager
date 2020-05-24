namespace SpeedTools___Save_Manager
{
    partial class StagSaveManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StagSaveManager));
            this.label1 = new System.Windows.Forms.Label();
            this.SavesList = new System.Windows.Forms.ListBox();
            this.bt_ImportSave = new System.Windows.Forms.Button();
            this.bt_AddSave = new System.Windows.Forms.Button();
            this.bt_SetSave = new System.Windows.Forms.Button();
            this.tb_SaveDestinationFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_EditSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lb_FilepathToCopy = new System.Windows.Forms.Label();
            this.btn_RemoveSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Stag Save Manager";
            // 
            // SavesList
            // 
            this.SavesList.FormattingEnabled = true;
            this.SavesList.ItemHeight = 15;
            this.SavesList.Location = new System.Drawing.Point(12, 177);
            this.SavesList.Name = "SavesList";
            this.SavesList.Size = new System.Drawing.Size(263, 184);
            this.SavesList.TabIndex = 1;
            this.SavesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bt_ImportSave
            // 
            this.bt_ImportSave.Location = new System.Drawing.Point(488, 361);
            this.bt_ImportSave.Name = "bt_ImportSave";
            this.bt_ImportSave.Size = new System.Drawing.Size(162, 64);
            this.bt_ImportSave.TabIndex = 3;
            this.bt_ImportSave.Text = "Import Save";
            this.bt_ImportSave.UseVisualStyleBackColor = true;
            this.bt_ImportSave.Click += new System.EventHandler(this.bt_ImportSave_Click);
            // 
            // bt_AddSave
            // 
            this.bt_AddSave.Location = new System.Drawing.Point(12, 107);
            this.bt_AddSave.Name = "bt_AddSave";
            this.bt_AddSave.Size = new System.Drawing.Size(79, 64);
            this.bt_AddSave.TabIndex = 3;
            this.bt_AddSave.Text = "Add Save";
            this.bt_AddSave.UseVisualStyleBackColor = true;
            this.bt_AddSave.Click += new System.EventHandler(this.bt_AddSave_Click);
            // 
            // bt_SetSave
            // 
            this.bt_SetSave.Location = new System.Drawing.Point(386, 107);
            this.bt_SetSave.Name = "bt_SetSave";
            this.bt_SetSave.Size = new System.Drawing.Size(162, 64);
            this.bt_SetSave.TabIndex = 3;
            this.bt_SetSave.Text = "Set Save Destination";
            this.bt_SetSave.UseVisualStyleBackColor = true;
            this.bt_SetSave.Click += new System.EventHandler(this.bt_SetSave_Click);
            // 
            // tb_SaveDestinationFilePath
            // 
            this.tb_SaveDestinationFilePath.Location = new System.Drawing.Point(281, 300);
            this.tb_SaveDestinationFilePath.Name = "tb_SaveDestinationFilePath";
            this.tb_SaveDestinationFilePath.Size = new System.Drawing.Size(369, 23);
            this.tb_SaveDestinationFilePath.TabIndex = 4;
            this.tb_SaveDestinationFilePath.Text = "FilePath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save Destination File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(517, 60);
            this.label3.TabIndex = 5;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // bt_EditSave
            // 
            this.bt_EditSave.Location = new System.Drawing.Point(12, 367);
            this.bt_EditSave.Name = "bt_EditSave";
            this.bt_EditSave.Size = new System.Drawing.Size(79, 64);
            this.bt_EditSave.TabIndex = 3;
            this.bt_EditSave.Text = "Edit Save";
            this.bt_EditSave.UseVisualStyleBackColor = true;
            this.bt_EditSave.Click += new System.EventHandler(this.bt_EditSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Change the name or source location of the selected save here";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select Save Folder Destination";
            // 
            // lb_FilepathToCopy
            // 
            this.lb_FilepathToCopy.AutoSize = true;
            this.lb_FilepathToCopy.Location = new System.Drawing.Point(281, 224);
            this.lb_FilepathToCopy.Name = "lb_FilepathToCopy";
            this.lb_FilepathToCopy.Size = new System.Drawing.Size(101, 15);
            this.lb_FilepathToCopy.TabIndex = 7;
            this.lb_FilepathToCopy.Text = "File will be sent to";
            // 
            // btn_RemoveSave
            // 
            this.btn_RemoveSave.Location = new System.Drawing.Point(175, 107);
            this.btn_RemoveSave.Name = "btn_RemoveSave";
            this.btn_RemoveSave.Size = new System.Drawing.Size(100, 64);
            this.btn_RemoveSave.TabIndex = 3;
            this.btn_RemoveSave.Text = "Remove Save";
            this.btn_RemoveSave.UseVisualStyleBackColor = true;
            this.btn_RemoveSave.Click += new System.EventHandler(this.bt_RemoveSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Listen for the beep!";
            // 
            // StagSaveManager
            // 
            this.ClientSize = new System.Drawing.Size(662, 437);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_RemoveSave);
            this.Controls.Add(this.lb_FilepathToCopy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_EditSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_SaveDestinationFilePath);
            this.Controls.Add(this.bt_SetSave);
            this.Controls.Add(this.bt_AddSave);
            this.Controls.Add(this.bt_ImportSave);
            this.Controls.Add(this.SavesList);
            this.Controls.Add(this.label1);
            this.Name = "StagSaveManager";
            this.Text = "Stag Save Manager";
            this.Load += new System.EventHandler(this.StagSaveManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SavesList;
        private System.Windows.Forms.Button bt_ImportSave;
        private System.Windows.Forms.Button bt_AddSave;
        private System.Windows.Forms.Button bt_SetSave;
        private System.Windows.Forms.TextBox tb_SaveDestinationFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_EditSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lb_FilepathToCopy;
        private System.Windows.Forms.Button btn_RemoveSave;
        private System.Windows.Forms.Label label6;
    }
}

