using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularJS__Member_Registration.DAL.Interfaces;

namespace AngularJS__Member_Registration.DAL
{
    public class Members:IMembers
    {
        private RiverClubEntities entities;
        public Members(IEntities entities)
        {
            this.entities = entities.GetInstance();
        }

        public Member Read(int id)
        {
            return this.entities.Members.Where(w => w.Id == id).FirstOrDefault();
        }

        public IQueryable<Member> ReadAll()
        {
            return this.entities.Members.AsQueryable<Member>();
        }

        public bool Create(Member model)
        {
            bool status = true;
            try
            {
                this.entities.Members.Add(model);
            }
            catch(Exception ex)
            {
                status = false;
            }
            
            return status;
        }


        public bool Update(Member model)
        {
            bool status = false;


            return status;
        }
    }
}