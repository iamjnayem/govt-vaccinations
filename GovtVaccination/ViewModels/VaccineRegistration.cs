using System.ComponentModel.DataAnnotations;

namespace GovtVaccination.ViewModels;

public class VaccineRegistration
{
    
    
    public long? Id { get; set; }
    [Required]
    public string Contact { get; set; }
    
    [Required]
    public string CenterId { get; set; }
    public int? Status { get; set; }
}
