using System;

namespace RegistrationPage
{
    public partial class Default : System.Web.UI.Page
    {
        public HelpClass helpClass = new HelpClass();

        public void ClearData()
        {
            this.textBoxName.Text = String.Empty;
            this.textBoxEmail.Text = String.Empty;
            this.textBoxJob.Text = String.Empty;
        }

        public void buttonSubmit_Click(object sender, EventArgs args)
        {
            helpClass.InsertUserData(this.textBoxName.Text.Trim(), this.textBoxEmail.Text.Trim(), this.textBoxJob.Text.Trim());
            this.ClearData();
            helpClass.Alert("User is inserted");
        }

        public void buttonLoadData_Click(object sender, EventArgs args)
        {
            this.ClearData();
            this.GridViewUser.DataSource = helpClass.SelectUserData();
            this.GridViewUser.DataBind();
        }
    }
}
