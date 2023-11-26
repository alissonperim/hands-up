using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Base
{
    public Base()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
        UpdatedAt = null;
        DeletedAt = null;
    }

    protected Guid Id { get; set; }
    protected DateTime CreatedAt { get; set; }
    protected DateTime? UpdatedAt { get; set; }
    protected DateTime? DeletedAt { get; set; }
}
