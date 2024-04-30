using Android.Content;
using Android.Gestures;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPolitechnicMobile.Repository.Entities
{
    internal class User : EntityBase
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Faculty { get; set; }
        public string Group { get; set; }
        public string Type { get; set; }


        public override bool Equals(object obj)
        {
            User user = obj as User;
            if (user == null) { return false; }

            if (user.Email == this.Email && user.Password == this.Password)
            {
                return true;
            }
            return false;
        }

    }
}
