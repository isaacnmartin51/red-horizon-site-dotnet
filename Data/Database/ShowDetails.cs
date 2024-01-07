using Microsoft.AspNetCore.SignalR;

namespace RedHorizonSite.Data;

public class ShowDetails
{
    public Guid Id {get; set; }
    public string Name { get; set; }
    public DateTime Time { get; set; }
    public string Details { get; set; }
    public double Price { get; set; }
    //public Uri GoogleMapsLink { get; set; }
    //public Uri ShareLink { get; set; }
    //public string Photo { get; set; }
}