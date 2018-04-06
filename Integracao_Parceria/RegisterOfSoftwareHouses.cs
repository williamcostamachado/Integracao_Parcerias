using Integracao_Parceria.Connection;
using System.Data.OleDb;
using System.Collections.Generic;

namespace Integracao_Parceria
{
    public abstract class RegisterOfSoftwareHouses<TSoftWareHouseType> where TSoftWareHouseType : ISoftwareHouse, new()
    {
        public abstract string TableName { get; }

        public void Add(TSoftWareHouseType softwareHouse )
        {
            using (var dataBaseConectionOpen = DataBaseConnection.Open())
            {
                var insertQuery =@"insert into" + TableName + "(nome, email,telefone,cnpj,ramo) values (@nome,@email,@telefone,@cnpj,@ramo)";
                var oleDbComand = new OleDbCommand(insertQuery,dataBaseConectionOpen);
                oleDbComand.Parameters.AddWithValue("@nome",softwareHouse.nome);
                oleDbComand.Parameters.AddWithValue("@email", softwareHouse.Email);
                oleDbComand.Parameters.AddWithValue("@telefone", softwareHouse.Telefone);
                oleDbComand.Parameters.AddWithValue("@cnpj", softwareHouse.Cnpj);
                oleDbComand.Parameters.AddWithValue("@ramo", softwareHouse.Ramo);
                oleDbComand.ExecuteNonQuery();
            }
        }
        public void Delete(int identifier)
        {
            using (var dataBaseConectioOpen =DataBaseConnection.Open())
            {
                var deleteQuery = @"delete from" + TableName + "where id = @codigo";
                var oleDbComand = new OleDbCommand(deleteQuery,dataBaseConectioOpen);
                oleDbComand.Parameters.AddWithValue("@codigo",identifier);
                oleDbComand.ExecuteNonQuery();
            }
        }
        public IEnumerable<TSoftWareHouseType> GetAllSh()
        {
            using (var dataBaseConectioOpen = DataBaseConnection.Open())
            {
                var selectQuery = "select*from " + TableName;
                var oleDbComand = new OleDbCommand(selectQuery,dataBaseConectioOpen);
                var executeReader = oleDbComand.ExecuteReader();

                while (executeReader.Read())
                {
                    var softwareHouse = new TSoftWareHouseType();
                  //  softwareHouse.Id = executeReader.GetInt32("id");
                    
                    yield return softwareHouse;              
                }
            }
        }
    }
}
