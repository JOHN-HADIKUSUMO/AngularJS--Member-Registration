using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularJS__Member_Registration.DAL.Interfaces;

namespace AngularJS__Member_Registration.DAL
{
    public class Entities:IEntities
    {
        public RiverClubEntities GetInstance()
        {
            return new RiverClubEntities();
        }
    }
}