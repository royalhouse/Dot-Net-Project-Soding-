using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Task_Dot_Net.DAL.Gateway;
using Web_Task_Dot_Net.DAL.Model;

namespace Web_Task_Dot_Net.BLL
{
    public class SystemManager
    {

         SystemGateway aSystemGateway  = new SystemGateway();

        public string CreateTask(SystemModel aSystem)
        {


            int affectedRow = aSystemGateway.CreateTask(aSystem);
            if (affectedRow > 0)
            {
                return "Task Created successfuly";
            }
            else
            {
                return "Sorry, Task creation fail!";
            }
        }


        public string DeleteTask(string id)
        {
            int affectedRow = aSystemGateway.DeleteTask(id);
            if (affectedRow > 0)
            {
                return "Deleted successfuly";
            }
            else
            {
                return "Sorry, Delete fail!";
            }
        }
        public string EditTask(SystemModel aSystem)
        {
            bool isIdExists = aSystemGateway.IsIdExist(aSystem);

            if (isIdExists)
            
            {
                int rowAffected = aSystemGateway.EditTask(aSystem);

                if (rowAffected > 0)
                {
                    return "Edited successfully";
                }
                return "Edit failed";
            }
            else 
            {

                return "ID Not exists";
            }
          }

        public List<SystemModel> ListAllTasks()
        {
            return aSystemGateway.ListAllTasks();
        }
    }
}