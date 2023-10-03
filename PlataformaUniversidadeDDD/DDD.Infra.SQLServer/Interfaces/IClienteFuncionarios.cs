using DDD.Domain.ContabilidadeContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IClienteFuncionarioRepository
    {
        public List<ClienteFuncionario> GetClienteFuncionario();
        public ClienteFuncionario GetClienteFuncionarioById(int id);

        //public void InsertMatricula(Matricula matricula);*/
        public ClienteFuncionario InsertClienteFuncionario(int ClienteId, int FuncionarioId);
        public void UpdateClienteFuncionario(ClienteFuncionario clienteFuncionario);
        public void DeleteClienteFuncionario(ClienteFuncionario clienteFuncionario);
    }
}
