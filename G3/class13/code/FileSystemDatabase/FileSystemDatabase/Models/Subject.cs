using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemDatabase.Models
{
    public class Subject : BaseEntity
    {
        public string Title { get; set; }
        public int Classes { get; set; }
        public Academy Academy { get; set; }

        public Subject() {}
        public Subject(string title, int classes, Academy academy)
        {
            Title = title;
            Classes = classes; 
            Academy = academy;
        }

        public override string Info()
        {
            return $"{Title} from the {Academy} last for {Classes} classes";
        }
    }
}
