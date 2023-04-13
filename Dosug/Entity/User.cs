namespace Dosug.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        public int UserNumberId { get; set; }

        public int UserRole { get; set; }

        [Required]
        [StringLength(50)]
        public string UserLastName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserFirstName { get; set; }

        [StringLength(50)]
        public string UserPatronymic { get; set; }

        public int UserGender { get; set; }

        [StringLength(18)]
        public string UserPhone { get; set; }

        [StringLength(150)]
        public string UserEmail { get; set; }

        [Column(TypeName = "date")]
        public DateTime UserBirthday { get; set; }

        [Required]
        [StringLength(50)]
        public string UserPassword { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Role Role { get; set; }
    }
}
