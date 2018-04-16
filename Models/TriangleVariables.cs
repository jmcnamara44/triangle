namespace Triangle.Models

{
  public class TriangleVariable
  {
    private int _side1;
    private int _side2;
    private int _side3;


    public int GetSide1()
    {
      return _side1;
    }

    public void SetSide1(int newSide1) /*Set Recipient*/
    {
      _side1 = newSide1;
    }

    public int GetSide2()
    {
      return _side2;
    }

    public void SetSide2(int newSide2)
    {
      _side2 = newSide2;
    }

    public int GetSide3()
    {
      return _side3;
    }

    public void SetSide3(int newSide3)
    {
      _side3 = newSide3;
    }

    // public int GetTriangleType(int newSide1, int newSide2, int newSide3)
    // {
    //   if (newSide1 == newSide2 && newSide1 == newSide3)
    //   {
    //     return "equilateral";
    //   }
    //
    //   else if (newSide1 == newSide2 || newSide1 == newSide3 || newSide2 == newSide3)
    //   {
    //     return "isosceles";
    //   }
    //
    //   else
    //   {
    //     return "scalene";
    //   }
    //
    // }
    // GetTriangleType(GetSide1, GetSide2, GetSide3);
  }
}
