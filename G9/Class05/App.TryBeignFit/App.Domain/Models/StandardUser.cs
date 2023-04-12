using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models
{
    public class StandardUser : User
    {
        public StandardUser()
        {
            Role = Role.StandardUser;
        }

        public List<VideoTraining> VideoTrainings { get; set; }
    }
}
