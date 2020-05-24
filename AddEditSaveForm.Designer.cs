namespace SpeedTools___Save_Manager
{
    partial class AddEditSaveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_AddOrEdit = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.customSaveName = new System.Windows.Forms.TextBox();
            this.btn_FinishEdit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_AddOrEdit
            // 
            this.lb_AddOrEdit.AutoSize = true;
            this.lb_AddOrEdit.Location = new System.Drawing.Point(12, 9);
            this.lb_AddOrEdit.Name = "lb_AddOrEdit";
            this.lb_AddOrEdit.Size = new System.Drawing.Size(62, 15);
            this.lb_AddOrEdit.TabIndex = 0;
            this.lb_AddOrEdit.Text = "AddOrEdit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(12, 77);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(337, 23);
            this.filePath.TabIndex = 2;
            // 
            // customSaveName
            // 
            this.customSaveName.Location = new System.Drawing.Point(12, 139);
            this.customSaveName.Name = "customSaveName";
            this.customSaveName.Size = new System.Drawing.Size(198, 23);
            this.customSaveName.TabIndex = 2;
            // 
            // btn_FinishEdit
            // 
            this.btn_FinishEdit.Location = new System.Drawing.Point(274, 118);
            this.btn_FinishEdit.Name = "btn_FinishEdit";
            this.btn_FinishEdit.Size = new System.Drawing.Size(75, 63);
            this.btn_FinishEdit.TabIndex = 3;
            this.btn_FinishEdit.Text = "Finish";
            this.btn_FinishEdit.UseVisualStyleBackColor = true;
            this.btn_FinishEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select save file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Custom Save Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save file to copy";
            // 
            // AddEditSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 219);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_FinishEdit);
            this.Controls.Add(this.customSaveName);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_AddOrEdit);
            this.Name = "AddEditSaveForm";
            this.Text = "AddEditSaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_AddOrEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.TextBox customSaveName;
        private System.Windows.Forms.Button btn_FinishEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}