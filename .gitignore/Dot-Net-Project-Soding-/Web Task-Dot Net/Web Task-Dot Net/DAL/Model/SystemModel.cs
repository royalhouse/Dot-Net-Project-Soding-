using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Task_Dot_Net.DAL.Model
{
    public class SystemModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

    }
}