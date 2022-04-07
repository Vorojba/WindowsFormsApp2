namespace WindowsFormsApp2.Moduls
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string login { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string psw { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string role { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string name { get; set; }
    }
}
