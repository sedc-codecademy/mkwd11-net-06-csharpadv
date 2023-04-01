using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Domain.Interfaces
{
    public interface IPerson
    {
        void Greet();
        void SendGift(string nameOfGift);
    }
}
