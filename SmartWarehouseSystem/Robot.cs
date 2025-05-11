using System;
using System.ComponentModel.DataAnnotations;

public class Robot
{
    public Guid RobotID { get; set; } = Guid.NewGuid();
    [Required]
    public string RobotModel { get; set; }
    [Range(10, 1000)]
    public float MaxLoadCapacity { get; set; }
    [Range(0, 100)]
    public float CurrentBatteryLevel { get; set; }
    public DateTime LastServiceDate { get; set; }
    public bool IsEmergencyRobot { get; set; }

    public bool IsLowBattery => CurrentBatteryLevel < 25;
    public bool IsServiceOverdue => (DateTime.Now - LastServiceDate).TotalDays > 45;
    public bool IsServiceDueSoon => (DateTime.Now - LastServiceDate).TotalDays >= 38 && !IsServiceOverdue;
}
