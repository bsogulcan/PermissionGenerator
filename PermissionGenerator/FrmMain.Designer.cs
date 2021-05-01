namespace PermissionGenerator
{
    partial class FrmMain
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeneratePermissionContexts = new System.Windows.Forms.Button();
            this.btnGeneratePermissionNames = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGetList = new System.Windows.Forms.CheckBox();
            this.cbGet = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbCreate = new System.Windows.Forms.CheckBox();
            this.cbEntitiesName = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEntities = new System.Windows.Forms.RichTextBox();
            this.pnlOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGeneratePermissionContexts);
            this.panel1.Controls.Add(this.btnGeneratePermissionNames);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 0;
            // 
            // btnGeneratePermissionContexts
            // 
            this.btnGeneratePermissionContexts.Location = new System.Drawing.Point(544, 15);
            this.btnGeneratePermissionContexts.Name = "btnGeneratePermissionContexts";
            this.btnGeneratePermissionContexts.Size = new System.Drawing.Size(116, 37);
            this.btnGeneratePermissionContexts.TabIndex = 4;
            this.btnGeneratePermissionContexts.Text = "Generate Permission Contexts!";
            this.btnGeneratePermissionContexts.UseVisualStyleBackColor = true;
            this.btnGeneratePermissionContexts.Click += new System.EventHandler(this.btnGeneratePermissionContexts_Click);
            // 
            // btnGeneratePermissionNames
            // 
            this.btnGeneratePermissionNames.Location = new System.Drawing.Point(422, 15);
            this.btnGeneratePermissionNames.Name = "btnGeneratePermissionNames";
            this.btnGeneratePermissionNames.Size = new System.Drawing.Size(116, 37);
            this.btnGeneratePermissionNames.TabIndex = 3;
            this.btnGeneratePermissionNames.Text = "Generate Permission Names!";
            this.btnGeneratePermissionNames.UseVisualStyleBackColor = true;
            this.btnGeneratePermissionNames.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGetList);
            this.groupBox1.Controls.Add(this.cbGet);
            this.groupBox1.Controls.Add(this.cbDelete);
            this.groupBox1.Controls.Add(this.cbUpdate);
            this.groupBox1.Controls.Add(this.cbCreate);
            this.groupBox1.Controls.Add(this.cbEntitiesName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // cbGetList
            // 
            this.cbGetList.Checked = true;
            this.cbGetList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGetList.Location = new System.Drawing.Point(346, 19);
            this.cbGetList.Name = "cbGetList";
            this.cbGetList.Size = new System.Drawing.Size(61, 25);
            this.cbGetList.TabIndex = 11;
            this.cbGetList.Text = "GetList";
            this.cbGetList.UseVisualStyleBackColor = true;
            // 
            // cbGet
            // 
            this.cbGet.Checked = true;
            this.cbGet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGet.Location = new System.Drawing.Point(297, 19);
            this.cbGet.Name = "cbGet";
            this.cbGet.Size = new System.Drawing.Size(43, 25);
            this.cbGet.TabIndex = 10;
            this.cbGet.Text = "Get";
            this.cbGet.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            this.cbDelete.Checked = true;
            this.cbDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDelete.Location = new System.Drawing.Point(233, 19);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(58, 25);
            this.cbDelete.TabIndex = 9;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.Checked = true;
            this.cbUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpdate.Location = new System.Drawing.Point(166, 19);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(61, 25);
            this.cbUpdate.TabIndex = 8;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbCreate
            // 
            this.cbCreate.Checked = true;
            this.cbCreate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCreate.Location = new System.Drawing.Point(102, 19);
            this.cbCreate.Name = "cbCreate";
            this.cbCreate.Size = new System.Drawing.Size(58, 25);
            this.cbCreate.TabIndex = 7;
            this.cbCreate.Text = "Create";
            this.cbCreate.UseVisualStyleBackColor = true;
            // 
            // cbEntitiesName
            // 
            this.cbEntitiesName.Checked = true;
            this.cbEntitiesName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEntitiesName.Location = new System.Drawing.Point(9, 19);
            this.cbEntitiesName.Name = "cbEntitiesName";
            this.cbEntitiesName.Size = new System.Drawing.Size(95, 24);
            this.cbEntitiesName.TabIndex = 6;
            this.cbEntitiesName.Text = "Entities Name";
            this.cbEntitiesName.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 392);
            this.panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEntities);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 392);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entities";
            // 
            // txtEntities
            // 
            this.txtEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEntities.Location = new System.Drawing.Point(3, 16);
            this.txtEntities.Name = "txtEntities";
            this.txtEntities.Size = new System.Drawing.Size(404, 373);
            this.txtEntities.TabIndex = 6;
            this.txtEntities.Text = "";
            // 
            // pnlOutput
            // 
            this.pnlOutput.Controls.Add(this.txtOutput);
            this.pnlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutput.Location = new System.Drawing.Point(410, 58);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(390, 392);
            this.pnlOutput.TabIndex = 8;
            this.pnlOutput.TabStop = false;
            this.pnlOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 16);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(384, 373);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.Text = "";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlOutput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "Permission Generator";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnlOutput.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnGeneratePermissionContexts;

        private System.Windows.Forms.GroupBox pnlOutput;

        private System.Windows.Forms.RichTextBox txtOutput;

        private System.Windows.Forms.Button btnGeneratePermissionNames;
        private System.Windows.Forms.CheckBox cbEntitiesName;
        private System.Windows.Forms.CheckBox cbCreate;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbGet;
        private System.Windows.Forms.CheckBox cbGetList;
        private System.Windows.Forms.RichTextBox txtEntities;

        private System.Windows.Forms.CheckBox cbDelete;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}