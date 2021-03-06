﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace Trabalho.Models
{
    public class TPContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TPContext() : base("name=TPContext")
        {
        }
        

        public System.Data.Entity.DbSet<Trabalho.Models.Instituicao> Instituicaos { get; set; }

        public System.Data.Entity.DbSet<Trabalho.Models.Crianca> Criancas { get; set; }

        public System.Data.Entity.DbSet<Trabalho.Models.Candidatura> Candidaturas { get; set; }

        //public System.Data.Entity.DbSet<Trabalho.Models.Crianca> Criancas { get; set; }
    }
}
