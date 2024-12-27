using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    [Table("Tasks")]
    public class TodoTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public DateTime? DueDate { get; set; }

        public PriorityLevel Priority { get; set; }

        public TodoTaskStatus Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;
    }

    public enum PriorityLevel
    {
        Low,
        Medium,
        High,
        Urgent
    }

    public enum TodoTaskStatus
    {
        Todo,
        InProgress,
        Complete,
        OnHold
    }
}
