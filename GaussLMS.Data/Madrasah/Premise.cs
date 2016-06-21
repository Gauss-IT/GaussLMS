namespace GaussLMS.Data.Madrasah
{
    public class Premise
    {
       string addreess;
       int floor;
       char PremiseIndex;
       string PremiseName { get { return floor.ToString() + PremiseIndex; } } 
    }
}
