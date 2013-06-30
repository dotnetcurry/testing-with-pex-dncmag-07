using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Class1
{
    public void Demo(int[] numbers)
    {
        if (numbers[12345] == 12345)
            throw new Exception("boom!");
    }
}

