using System;

namespace _07._04_Zadanie_prtaktyczne___pokrywanie_się_dat;

public class Reservation
{
  public DateTime From { get; set; }
  public DateTime To { get; set; }

  public Reservation(DateTime @from, DateTime to)
  {
    From = @from;
    To = to;
  }
}
