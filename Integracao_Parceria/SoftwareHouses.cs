namespace Integracao_Parceria
{
   public interface ISoftwareHouse
    {
        string Name { get; set; }
        string Email { get; set; }
        int Telefone { get; set; }
        int Cnpj { get; set; }
        string Ramo { get; set; }
    }
}
