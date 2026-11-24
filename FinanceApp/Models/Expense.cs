using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using Microsoft.Net.Http.Headers;

namespace FinanceApp.Models;

public class Expense
{
    public int Id {get; set;}

    [Required]
    public string Description {get; set;} = null!;

    [Required]
    [Range(0.01, Double.MaxValue, ErrorMessage = "Amount must be higher than 0.")]
    public double Amount {get; set;}

    [Required]
    public string Category {get; set;} = null!;
    public DateTime Date {get; set;} = DateTime.Now;
}
