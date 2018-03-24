namespace Integracao_Parceria
{
    public abstract class RegisterOfSoftwareHouses<IntegrationType> where IntegrationType : ISoftwareHouse, new()
    {
        // mudar nome de classe pois esta confuso  RegisterOfSoftwareHouses<IntegrationType> where IntegrationType : ISoftwareHouse, new()
        //  public void Add(IntegrationType type )
        public abstract string TableName { get; }

        public void Add(IntegrationType type )
        {

        }
    }
}
