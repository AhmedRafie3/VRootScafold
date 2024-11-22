using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Employeeshift
{
    public int EmployeeShiftId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int Status { get; set; }

    public int? EmployeeId { get; set; }

    public int? BranchId { get; set; }

    public int Flag { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Employee? Employee { get; set; }


    public virtual ICollection<Transactionflow> Transactionflows { get; } = new List<Transactionflow>();
}
