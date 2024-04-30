using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPolitechnicMobile.Repository.Entities
{
    internal class News : EntityBase
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

    }
}
