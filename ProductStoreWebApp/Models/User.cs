using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStoreWebApp.Models
{
    public class User
    {
        public string Name{get;set;}

        
        public string Password{get;set;}

        public override bool Equals(object nu)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            User newuser=(User)nu;
            if ((newuser == null )|| (this.Name!=newuser.Name)||(this.Password!=newuser.Password))
            {
                return false;
            }
            else if((this.Name==newuser.Name)&&(this.Password==newuser.Password))
            {
                return true;
            }
            // TODO: write your implementation of Equals() here
            throw new System.NotImplementedException();
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new System.NotImplementedException();
            return base.GetHashCode();
        }
        public User(string Name,string Password)
        {
            this.Name=Name;
            this.Password=Password;
        }
    }
}