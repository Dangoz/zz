using System;
using System.ComponentModel.DataAnnotations;

namespace lab.Models;
public class Student
{
  [Key]
  public string? Id { get; set; }
  public string? FirstName { get; set; }
  public string? LastName { get; set; }
  public string? Department { get; set; }
}