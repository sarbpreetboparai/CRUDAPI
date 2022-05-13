namespace CRUDAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Street { get; set; }

        [StringLength(10)]
        public string City { get; set; }

        [StringLength(10)]
        public string Province { get; set; }

        [StringLength(10)]
        public string Postal { get; set; }
    }
}
