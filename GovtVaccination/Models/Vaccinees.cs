using System;
using System.Collections.Generic;

namespace GovtVaccination.Models;

public partial class Vaccinees
{
    public long Id { get; set; }

    public string Contact { get; set; } = null!;

    public int Status { get; set; }

    public int CreatedAt { get; set; }

    public int UpdatedAt { get; set; }
}
