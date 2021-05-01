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
                var entityName = StringParser.GetEntityNameFromRow(entity);
                if (!string.IsNullOrEmpty(entityName))
                {
                    txtOutput.Text += entityName + Environment.NewLine;
                }
            }
        }
    }
}