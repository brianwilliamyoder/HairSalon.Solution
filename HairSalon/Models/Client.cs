namespace HairSalon.Models
{
  public class Client
  {
    public int StylistId { get; set; }
    public Stylist stylist { get; set; }
    public int ClientId { get; set; }
    public string ClientName { get; set; }
  }
}