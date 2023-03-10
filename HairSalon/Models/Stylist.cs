using System.Collections.Generic;
using System.ComponentModel;

namespace HairSalon.Models
{
  public class Stylist
  {
    
    public int StylistId { get; set; }
    [DisplayName("Enter the name of the stylist:")]
    public string StylistName { get; set; }
    public List<Client> Items { get; set; }
  }
}