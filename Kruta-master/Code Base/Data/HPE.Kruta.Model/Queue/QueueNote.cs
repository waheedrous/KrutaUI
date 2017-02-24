namespace HPE.Kruta.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Serializable]
    [Table("QueueNote")]
    public partial class QueueNote
    {
        public int QueueNoteID { get; set; }

        public int? QueueID { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Queue Queue { get; set; }
    }
}
