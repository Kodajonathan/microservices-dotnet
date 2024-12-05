using System.ComponentModel.DataAnnotations;

namespace StudentRecordService.Models;

public class StudentRecordServiceModel
{
    public int Id { get; set; }
    
    [StringLength(50)]public string FirstName { get; set; }
    
    [StringLength(50)]public string LastName { get; set; }
    
    [Required]public int StudentNumber { get; set; }
    
    [EmailAddress]public string Email { get; set; }
}