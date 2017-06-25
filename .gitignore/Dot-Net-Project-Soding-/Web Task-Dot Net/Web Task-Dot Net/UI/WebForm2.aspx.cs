using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_Task_Dot_Net.BLL;
using Web_Task_Dot_Net.DAL.Model;

namespace Web_Task_Dot_Net.UI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SystemManager aSystemManager = new SystemManager();

        protected void createTaskButton_Click(object sender, EventArgs e)
        {
            SystemModel aSystem=new SystemModel();

            aSystem.Id = id.Text;
            aSystem.Name = name.Text;
            aSystem.Description = description.Text;
            aSystem.DateCreated =  Convert.ToDateTime(dateCreated.Text);
            aSystem.DateUpdated = Convert.ToDateTime(dateUpdated.Text);

            messageLabel.Text = aSystemManager.CreateTask(aSystem );

            PopulatedGridView();
        }

        protected void editTaskButton_Click(object sender, EventArgs e)
        {
            SystemModel aSystem = new SystemModel();

            aSystem.Id = id.Text;
            aSystem.Name = name.Text;
            aSystem.Description = description.Text;
            aSystem.DateCreated = Convert.ToDateTime(dateCreated.Text);
            aSystem.DateUpdated = Convert.ToDateTime(dateUpdated.Text);

            messageLabel.Text = aSystemManager.EditTask(aSystem);

            PopulatedGridView();
        }

        protected void deleteTaskButton_Click(object sender, EventArgs e)
        {
            SystemModel aSystem = new SystemModel();

            aSystem.Id = id.Text;

            messageLabel.Text = aSystemManager.DeleteTask(aSystem.Id);

            PopulatedGridView();
        }


        private void PopulatedGridView()
        {
                List<SystemModel> systems = aSystemManager.ListAllTasks();
                employeeGridView.DataSource = systems;
                employeeGridView.DataBind();
         }
         protected void listAllTaskButton_Click(object sender, EventArgs e)
         {
             PopulatedGridView();
         }


       
      
    }
}