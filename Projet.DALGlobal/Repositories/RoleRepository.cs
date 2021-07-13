using Projet.DALGlobal.Mapper;
using Projet.DALGlobal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.ADO;

namespace Projet.DALGlobal.Repositories
{
    public class RoleRepository : BasicRepository, IRole<int, Role>
    {
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Role WHERE Id = @Id");
            command.AddParameter("Id", id);
            _connection.ExecuteNonQuery(command);
            return true;
        }
        public IEnumerable<Role> Get()
        {
            Command command = new Command("SELECT Id, Nom FROM Role");
            return _connection.ExecuteReader(command, (reader) => reader.ToRole());
        }
        public Role Get(int id)
        {
            Command command = new Command("SELECT Id, Nom FROM Role WHERE id = @id");
            command.AddParameter("id", id);
            return _connection.ExecuteReader(command, (reader) => reader.ToRole()).SingleOrDefault();
        }
        public int Insert(Role entity)
        {
            Command command = new Command("Insert INTO Role(Nom) VALUES(@Nom)");
            command.AddParameter("Nom", entity.Nom);
            
            return _connection.ExecuteNonQuery(command);
        }
        public int Update(int id, Role entity)
        {
            Command command = new Command("Update Role SET Nom=@Nom Where Id=@Id");
            command.AddParameter("Id", id);
            command.AddParameter("Nom", entity.Nom);
           
            return _connection.ExecuteNonQuery(command);
        }
    }
}
