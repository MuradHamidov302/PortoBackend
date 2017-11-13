namespace PortoWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        public int com_id { get; set; }

        public int? user_id { get; set; }

        public int? blog_id { get; set; }

        [Column(TypeName = "ntext")]
        public string text { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual Blog Blog1 { get; set; }

        public virtual User1 User1 { get; set; }
    }
}
