﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Threading;
using AngularJS__Member_Registration;
using AngularJS__Member_Registration.DAL;
using AngularJS__Member_Registration.DAL.Interfaces;


namespace AngularJS__Member_Registration.Controllers.REST
{
    [RoutePrefix("REST/MEMBERS")]
    public class MembersController : ApiController
    {
        private IMembers members;
        public MembersController(IMembers members)
        {
            this.members = members;
        }

        public MembersController()
        {
            
        }

        [HttpGet]
        [AcceptVerbs("GET")]
        [Route("READ/{id}")]
        [AllowAnonymous]
        public bool Get(int id)
        {
            bool status = true;



            return status;
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("CREATE")]
        [AllowAnonymous]
        public bool Create(Member model)
        {
            bool status = true;

            try
            {
                Member tempMember = new Member();
                tempMember.Firstname = model.Firstname;
                tempMember.Lastname = model.Lastname;
                tempMember.Age = model.Age;
                tempMember.Gender = model.Gender;

                this.members.Create(tempMember);
            }
            catch(Exception ex)
            {
                status = false;
            }

            return status;
        }
    }
}