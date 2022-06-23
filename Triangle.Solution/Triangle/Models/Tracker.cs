namespace Triangle.Models
{
  public class Tracker
  {
    public bool IsTriangle(int sideOne, int sideTwo, int sideThree)
    {
        return (sideOne > (sideTwo + sideThree) || sideTwo > (sideOne + sideThree) || sideThree > (sideOne + sideTwo));
    }
  }
}
