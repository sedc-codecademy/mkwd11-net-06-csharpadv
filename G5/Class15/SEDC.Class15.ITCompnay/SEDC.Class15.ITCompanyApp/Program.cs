using SEDC.Class15.ITCompnay.Domain.Enums;
using SEDC.Class15.ITCompnay.Domain.Models;
using SEDC.Class15.ITCompnayService.Implementations;
using SEDC.Class15.ITCompnayService.Interface;

namespace SEDC.Class15.ITCompanyApp
{
    class Program
    {
        private static IUserService<ProjectManager> _projcetManagerDb = new UserService<ProjectManager>();
        private static IUserService<SoftwareEngeneer> _softwareEngeneerDb = new UserService<SoftwareEngeneer>();
        private static IUserService<NetworkEngeneer> _networkEngeneerDb = new UserService<NetworkEngeneer>();
        private static IUserService<QATester> _qATesterDb = new UserService<QATester>();

        static void Main(string[] args)
        {
            _softwareEngeneerDb.AddUser(new SoftwareEngeneer()
            {
                FirstName = "Danilo",
                LastName = "Borozan",
                Age = 25,
                Email = "danilo123",
                Password = "Dajo123",
                Experience = 3,
                Level = Level.Middle
            });
            _networkEngeneerDb.AddUser(new NetworkEngeneer()
            {
                FirstName = "Angel",
                LastName = "Mitrov",
                Age = 21,
                Email = "angel1",
                Password = "angelM2001",
                Experience = 2,
                Level = Level.Middle
            });
            _qATesterDb.AddUser(new QATester()
            {
                FirstName = "John",
                LastName = "Snow",
                Age = 32,
                Email = "john1",
                Password = "johnSnow1",
                QAType = QAType.Automatic
            });
            _projcetManagerDb.AddUser(new ProjectManager()
            {
                FirstName = "Smith",
                LastName = "Row",
                Age = 19,
                Email = "smith12",
                Password = "roWsmith12",
                Company = "Seavus",
                SoftwareEngeneers = new List<SoftwareEngeneer>()
                {
                   new SoftwareEngeneer()
                   {
                       FirstName = "Danilo",
                        LastName = "Borozan",
                        Age = 25,
                        Email = "danilo123",
                        Password = "Dajo123",
                        Experience = 3,
                        Level = Level.Middle
                   }
                }
            });

            _qATesterDb.ChangeFirstName(1, "Angela");

            _softwareEngeneerDb.GetAllUser();
        }
    }
}