using SEDC.Interfaces.Entities.Interfaces;

namespace SEDC.Interfaces.Entities
{
    public class Computer : IThingsThatCanWriteNote //NoteWriter
    {
        public string Type { get; set; }

        //public override void WriteNote()
        //{
        //    Console.WriteLine("Writing a note with a computer.");
        //}

        public void WriteNote()
        {
            Console.WriteLine("Writing a note with a computer.");
        }
    }
}
