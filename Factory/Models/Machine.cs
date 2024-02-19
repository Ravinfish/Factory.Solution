using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models;

public class Machine
{
  public int MachineId { get; set; }
  [Required(ErrorMessage = "You must enter a name")]
  public string Name { get; set; }
  [Required(ErrorMessage = "You must enter a description")]
  public string Description { get; set; }
  public DateTime InstallDate { get; set; } = DateTime.Now;
  public string Inspection {  get; set; }
  public string Status { get; set; }
  public List<EngineerMachine> JoinEntities { get; } 
}