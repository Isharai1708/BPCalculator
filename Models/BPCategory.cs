namespace BPCalculator { 
    public enum BPCategory 
    { 
        [System.ComponentModel.DataAnnotations.Display(Name="Low Blood Pressure")] Low, 
        [System.ComponentModel.DataAnnotations.Display(Name="Ideal Blood Pressure")] Ideal, 
        [System.ComponentModel.DataAnnotations.Display(Name="Pre-High Blood Pressure")] PreHigh, 
        [System.ComponentModel.DataAnnotations.Display(Name="High Blood Pressure")] High 
    } 
} 
