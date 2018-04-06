using System;

namespace Integracao_Parceria
{
    class SoftwareHouseIntegradaViaIntpos :  ISoftwareHouse
    {
        public int Cnpj { get; set; }
        public string Email { get; set; }

        public int Id { get; set; }
        public string nome { get; set; }
        public string Ramo { get; set; }
        public int Telefone { get; set; }
    }
}
