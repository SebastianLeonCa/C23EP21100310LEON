using System;
using System.Collections.Generic;

namespace Caso2Scaffolding21100310LEON.Data;

public partial class Competency
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Level { get; set; }
}
