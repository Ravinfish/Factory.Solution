using System;
using System.Collections.Generic;

namespace Factory.Models;

public class Machine
{
  public int MachineId { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public DateTime InstallDate { get; set; }
  public string Inspection {  get; set; }
  public string Status { get; set; }
  public List<EngineerMachine> JoinEntities { get; } 
}