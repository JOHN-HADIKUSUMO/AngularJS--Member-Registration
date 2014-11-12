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
                this.entities.SaveChanges();
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

            try
            {
                Member tempMember = this.entities.Members.Where(w => w.Id == model.Id).FirstOrDefault<Member>();
                if(tempMember != null)
                {
                    tempMember.Firstname = model.Firstname;
                    tempMember.Lastname = model.Lastname;
                    tempMember.Age = model.Age;
                    tempMember.Gender = model.Gender;
                    this.entities.SaveChanges();
                    status = true;
                    this.entities.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

            return status;
        }
    }
}