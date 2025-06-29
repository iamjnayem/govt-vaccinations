using System;
using System.Collections.Generic;

namespace GovtVaccination.Models;

public partial class Vaccinees
{
    public long Id { get; set; }

    public string Contact { get; set; } = null!;

    public int Status { get; set; }

    public long VaccineCenterId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
