using SEDC.Interfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Interfaces.Entities
{
    public class Pen : IThingsThatCanWriteNote //NoteWriter
    {
        //public override void WriteNote()
        //{
        //    Console.WriteLine("Writing a note with a pen.");
        //}

        public string Type { get; set; }

        public void WriteNote()
        {
            Console.WriteLine("Writing a note with a pen.");
        }
    }
}
