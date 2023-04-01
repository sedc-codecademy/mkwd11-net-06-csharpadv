using SEDC.Interfaces.Entities.Interfaces;

namespace SEDC.Interfaces.Entities
{
    public class Phone : IThingsThatCanWriteNote //NoteWriter
    {
        //public override void WriteNote()
        //{
        //    Console.WriteLine("Writing a note with a phone.");
        //}
        public string Type { get; set; }
        public void WriteNote()
        {
            Console.WriteLine("Writing a note with a phone.");
        }
    }
}
