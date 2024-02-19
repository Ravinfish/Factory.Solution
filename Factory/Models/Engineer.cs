using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models;

public class Engineer
{
  public int EngineerId { get; set; }
  [Required(ErrorMessage = "You must enter a name")]
  public string Name { get; set; }
  [Required(ErrorMessage = "You must enter a phone number")]
  public string Phone { get; set; }
  public DateTime HireDate { get; set; } = DateTime.Now;
  public bool IsActive { get; set; }
  [Required(ErrorMessage = "You must enter your license expiration date")]
  public string Renewal { get; set; }
  public List<EngineerMachine> JoinEntities { get; }
}