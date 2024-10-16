using System;
using System.Collections.Generic;

namespace Caso2Scaffolding21100310LEON.Data;

public partial class JobOffer
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Salary { get; set; }

    public string? Location { get; set; }
}
