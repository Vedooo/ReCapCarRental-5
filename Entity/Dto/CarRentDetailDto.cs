using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class CarRentDetailDto : IDto
    {
        public int CarId { get; set; }
        public int RentId { get; set; }
        public string CarName { get; set; }
        public Nullable<DateTime> RentDate { get; set; }
        public Nullable<DateTime> ReturnDate { get; set; }

    }
}
