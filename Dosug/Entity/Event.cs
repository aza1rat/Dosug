namespace Dosug.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventId { get; set; }

        [Required]
        [StringLength(200)]
        public string EventName { get; set; }

        public int EventDirection { get; set; }

        [Column(TypeName = "date")]
        public DateTime EventDate { get; set; }

        public TimeSpan EventTime { get; set; }

        public int EventDuration { get; set; }

        [Column(TypeName = "image")]
        public byte[] EventPhoto { get; set; }

        public virtual Direction Direction { get; set; }
    }
}
