using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Emergency
{
    public string Id { get; set; }
    public string Symptoms { get; set; }
    public string Diagnosis { get; set; }
    public DateTime Date { get; set; }
    public bool IsEmergency { get; set; }
}
