using System;
using System.Collections.Generic;

namespace GovtVaccination.Models;

public partial class VaccineCenters
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int DailyLimit { get; set; }

    public int Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
