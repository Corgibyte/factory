using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public enum MachineStatus
  {
    [Display(Name = "Machine operational")]
    Up,

    [Display(Name = "Machine not operational")]
    Down,

    [Display(Name = "Machine undergoing unscheduled repair")]
    Repair,

    [Display(Name = "Machine undergoing scheduled maintenance")]
    Maintenance
  }
}