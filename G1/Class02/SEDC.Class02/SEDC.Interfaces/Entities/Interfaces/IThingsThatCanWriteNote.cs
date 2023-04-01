namespace SEDC.Interfaces.Entities.Interfaces
{
    public interface IThingsThatCanWriteNote
    {
        string Type { get; set; }
        void WriteNote();
    }
}
