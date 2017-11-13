namespace PortoWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Blog")]
    public partial class Blog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blog()
        {
            Comments = new HashSet<Comment>();
            Comments1 = new HashSet<Comment>();
        }

        [Key]
        public int blog_id { get; set; }

        public string title { get; set; }

        [Column(TypeName = "ntext")]
        public string head_text { get; set; }

        [Column(TypeName = "ntext")]
        public string main_text { get; set; }

        public string img_name { get; set; }

        public int? user_id { get; set; }

        public DateTime add_date1 { get; set; }

        public virtual User1 User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual User1 User11 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments1 { get; set; }
    }
}
