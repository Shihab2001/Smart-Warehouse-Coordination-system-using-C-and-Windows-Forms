using System;
using System.ComponentModel.DataAnnotations;

public class WarehouseTask
{
    public Guid TaskID { get; set; } = Guid.NewGuid();
    [Required]
    public string PickLocation { get; set; }
    [Required]
    public string DropLocation { get; set; }
    public float LoadWeight { get; set; }
    public DateTime ScheduledStartTime { get; set; }
    public bool RequiresEmergencyRobot { get; set; }
}
