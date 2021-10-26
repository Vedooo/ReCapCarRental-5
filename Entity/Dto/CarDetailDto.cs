using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class CarDetailDto : IDto
    {
        public string CarModelName { get; set; }
        public string CarBrandName { get; set; }
        public decimal CarDailyPrice { get; set; }
        public string ColorName { get; set; }
        public string CarModelYear { get; set; }

    }
}
