using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBank.Entities
{
    public abstract class Client
	{
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Phone { get; set; }
        public Guid Id { get; set; }
        public Address Address { get; set; }

    }
}
