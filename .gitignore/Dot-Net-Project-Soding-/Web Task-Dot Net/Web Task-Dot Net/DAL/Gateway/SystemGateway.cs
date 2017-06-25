using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Web_Task_Dot_Net.DAL.Model;

namespace Web_Task_Dot_Net.DAL.Gateway
{
    public class SystemGateway:Gateway
    {
        public int CreateTask(SystemModel  aSystem)
        {
            Query = "INSERT INTO SystemTable VALUES (@aId, @aName ,  @aDescription ,@aDateCreated, @aDateUpdated)";

            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();

            Command.Parameters.Add("aId", SqlDbType.VarChar);
            Command.Parameters["aId"].Value = aSystem.Id;
            Command.Parameters.Add("aName", SqlDbType.VarChar);
            Command.Parameters["aName"].Value = aSystem.Name;
            Command.Parameters.Add("aDescription", SqlDbType.VarChar);
            Command.Parameters["aDescription"].Value = aSystem.Description;

            Command.Parameters.Add("aDateCreated", SqlDbType.DateTime);
            Command.Parameters["aDateCreated"].Value = aSystem.DateCreated;

            Command.Parameters.Add("aDateUpdated", SqlDbType.DateTime);
            Command.Parameters["aDateUpdated"].Value = aSystem.DateUpdated;

            Connection.Open();
            int effectedRow = Command.ExecuteNonQuery();
            Connection.Close();
            return effectedRow;
        }

        public int DeleteTask(string id)
        {
            Query = "DELETE FROM SystemTable WHERE id = '" + id + "'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            int rowAffected = Command.ExecuteNonQuery();

            Connection.Close();

            return rowAffected;
        }

        public int EditTask(SystemModel aSystem)
        {
            Query = "UPDATE SystemTable SET Name = @aName, Description = @aDescription, DateCreated = @aDateCreated, DateUpdated= @aDateUpdated WHERE Id = @aId";

            Command = new SqlCommand();
            Command = new SqlCommand(Query, Connection);

            Command.Parameters.Clear();

            Command.Parameters.Add("aId", SqlDbType.VarChar);
            Command.Parameters["aId"].Value = aSystem.Id;

            Command.Parameters.Add("aName", SqlDbType.VarChar);
            Command.Parameters["aName"].Value = aSystem.Name;
            Command.Parameters.Add("aDescription", SqlDbType.VarChar);
            Command.Parameters["aDescription"].Value = aSystem.Description;

            Command.Parameters.Add("aDateCreated", SqlDbType.DateTime);
            Command.Parameters["aDateCreated"].Value = aSystem.DateCreated;

            Command.Parameters.Add("aDateUpdated", SqlDbType.DateTime);
            Command.Parameters["aDateUpdated"].Value = aSystem.DateUpdated;

            Connection.Open();

            int rowAffected = Command.ExecuteNonQuery();

            Connection.Close();

            return rowAffected;
        }


        public bool IsIdExist(SystemModel aSystem)
        {
            Query = "SELECT * FROM SystemTable WHERE Id= '" + aSystem.Id + "'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            bool isIdExist = Reader.HasRows;

            Reader.Close();
            Connection.Close();

            return isIdExist;
        }


        public List<SystemModel> ListAllTasks()
        {
            Query = "SELECT * FROM SystemTable";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<SystemModel> systems = new List<SystemModel>();

            while (Reader.Read())
            {
                SystemModel aSystem= new SystemModel();

                aSystem.Id = Reader["Id"].ToString() ;
                aSystem.Name = Reader["Name"].ToString();
                aSystem.Description = Reader["Description"].ToString();
                aSystem.DateCreated = (DateTime) Reader["DateCreated"];
                aSystem.DateUpdated = (DateTime)Reader["DateUpdated"];


                systems.Add(aSystem);
            }

            Reader.Close();
            Connection.Close();

            return systems;
        }
    }
}