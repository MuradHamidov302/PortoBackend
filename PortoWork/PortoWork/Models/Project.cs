namespace PortoWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        [Key]
        public int pro_id { get; set; }

        public string pro_name { get; set; }

        [Column(TypeName = "ntext")]
        public string pro_text { get; set; }

        public string img_name { get; set; }

        public int? city_id { get; set; }

        public int? cost { get; set; }

        public int? user_id { get; set; }

        public int? serv_id { get; set; }

        public virtual City City { get; set; }

        public virtual Service Service { get; set; }

        public virtual User1 User1 { get; set; }
    }
}
