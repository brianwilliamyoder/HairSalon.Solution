using System.ComponentModel;

namespace HairSalon.Models
{
  public class Client
  {
    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
    public int ClientId { get; set; }
    [DisplayName("Enter Client's Name:")]
    public string ClientName { get; set; }
    public string ClientNote { get; set; }
    }
  }
