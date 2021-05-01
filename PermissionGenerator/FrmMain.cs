using System;
using System.Windows.Forms;
using PermissionGenerator.Helpers;

namespace PermissionGenerator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string[] entityList = txtEntities.Text.Split('\n');
            if (entityList.Length == 0)
                return;

            txtOutput.Text = string.Empty;
            foreach (var entity in entityList)
            {
                var entityName = StringHelper.GetEntityNameFromRow(entity);
                if (!string.IsNullOrEmpty(entityName))
                {
                    if (cbEntitiesName.Checked)
                        txtOutput.Text += StringHelper.CreatePermissionName(entityName, entityName) +
                                          Environment.NewLine;

                    if (cbCreate.Checked)
                        txtOutput.Text +=
                            StringHelper.CreatePermissionName(entityName + "_Create", entityName + ".Create") +
                            Environment.NewLine;

                    if (cbUpdate.Checked)
                        txtOutput.Text +=
                            StringHelper.CreatePermissionName(entityName + "_Update", entityName + ".Update") +
                            Environment.NewLine;

                    if (cbGetList.Checked)
                        txtOutput.Text +=
                            StringHelper.CreatePermissionName(entityName + "_GetList", entityName + ".GetList") +
                            Environment.NewLine;

                    if (cbGet.Checked)
                        txtOutput.Text +=
                            StringHelper.CreatePermissionName(entityName + "_Get", entityName + ".Get") +
                            Environment.NewLine;


                    if (cbDelete.Checked)
                        txtOutput.Text +=
                            StringHelper.CreatePermissionName(entityName + "_Delete", entityName + ".Delete") +
                            Environment.NewLine;

                    txtOutput.Text += Environment.NewLine;
                }
            }
        }
    }
}