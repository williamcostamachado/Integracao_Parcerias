﻿using System;

namespace Integracao_Parceria
{
    class SoftwareHouseIntegradaViaApi : ISoftwareHouse
    {
        public int Cnpj { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Ramo { get; set; }
        public int Telefone { get; set; }
    }
}
