namespace Integracao_Parceria
{
   public interface ISoftwareHouse
    {
        int Id { get; set; }
        string nome { get; set; }
        string Email { get; set; }
        int Telefone { get; set; }
        int Cnpj { get; set; }
        string Ramo { get; set; }
    }
}
