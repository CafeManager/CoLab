
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace CoLab.Models;

    public class Comments
    {

    [Key]    
    public int Id { get; set; }
    [Required]
    public string commentText { get; set; }

    [DataType(DataType.Date)]
    [DisplayName("Date Created")]
    public DateTime dateCreated { get; set; } = DateTime.Now;

    [DisplayName("Created By")]
    public string createdBy { get; set; }

    [Range(1,100, ErrorMessage ="There's no way to have less that one or more than one.")]
    public int totalYes { get; set; }
    public int totalNo { get; set; }
    public int totalAbstain { get; set; }
}

