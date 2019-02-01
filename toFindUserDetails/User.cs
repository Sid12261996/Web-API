using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toFindUserDetails
{
    class User
    {
        public string userid { get; set; }
        public double Lat { get; set; }
        public double Longitude { get; set; }
        public int AcceptDist { get; set; }
         }

        class UserExtension : User
        {


            IEnumerable<User> userDetail = new List<User>
            {
            new User { userid="Sid", AcceptDist=5, Lat=28.6213, Longitude=77.0613 },
            new User { userid="ut", AcceptDist=5, Lat=38.6213, Longitude=7.0613 },
            new User { userid="taani", AcceptDist=5, Lat=28.6213, Longitude=77.0613 },
            new User { userid="Joy", AcceptDist=5, Lat=28.6213, Longitude=77.0613 },
            new User { userid="John", AcceptDist=5, Lat=28.6213, Longitude=77.0613 }
            };
        }
    }

