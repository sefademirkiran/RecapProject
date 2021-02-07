using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order: IEntity
    {
        public int OrderId { get; set; }
        public string CarId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime LeaseDate { get; set; }
        public string LeaseCity { get; set; }

    }
}
