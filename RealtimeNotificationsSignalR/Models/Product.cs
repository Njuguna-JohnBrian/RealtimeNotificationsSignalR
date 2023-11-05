using System.ComponentModel.DataAnnotations;

namespace RealtimeNotificationsSignalR.Models;

public class Product
{
    [Key] public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; } = decimal.Zero;
}