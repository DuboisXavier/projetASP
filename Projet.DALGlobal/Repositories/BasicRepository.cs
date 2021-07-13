using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.ADO;

namespace Projet.DALGlobal.Repositories
{
    public abstract class BasicRepository
    {
        protected Connection _connection;
        private ConnectionStringSettings ConnectionString { get { return ConfigurationManager.ConnectionStrings["Projet"]; } }

        public BasicRepository()
        {
            _connection = new Connection(ConnectionString.ConnectionString, ConnectionString.ProviderName);
        }
    }
}
