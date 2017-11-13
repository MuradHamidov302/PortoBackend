namespace PortoWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            Projects = new HashSet<Project>();
        }

        [Key]
        public int serv_id { get; set; }

        [StringLength(50)]
        public string serv_name { get; set; }

        [Column(TypeName = "ntext")]
        public string serv_about { get; set; }

        [StringLength(50)]
        public string serv_icon { get; set; }

        public string img_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Projects { get; set; }
    }
}
