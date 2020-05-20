using System;
using System.Linq;

class Dinosaur
{
    public string Name { get; set; }

    public string DietType { get; set; }

    public DateTime WhenAcquired { get; set; }

    public string Weight { get; set; }

    public int EnclouserNumber { get; set; }

    public string Description()
    {
        var dinosaurDescription = $"{Name} is a {DietType} that weights {Weight} is located in the Enclouser {EnclouserNumber} and was brought to the park on {WhenAcquired}";
        return dinosaurDescription;
    }
}