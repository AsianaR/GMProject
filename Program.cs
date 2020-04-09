using System;
using System.Collections.Generic;

class LongAr
{
    byte[] Number;
    public int Length
    {
        get
        {
            return Number.Length;
        }
    }

    private LongAr(int Len)
    {
        Number = new byte[Len];
        for (int i = 0; i < Len; i++)
        {
            Number[i] = 0;
        }
    }

    public LongAr(string Num)
    {
        Number = new byte[Num.Length];
        for (int i = Num.Length - 1, j = 0; i >= 0; i--, j++)
        {
            Number[j] = (byte)((int)Num[i] - 48);
        }
    }
    public void Show()
    {
        for (int i = Number.Length - 1; i >= 0; i--)
        {
            if (i == (Number.Length - 1) && Number[i] == 0) continue;
            Console.Write(Number[i]);
        }
        Console.WriteLine();
    }
    public static bool operator ==(LongAr ob1, LongAr ob2)
    {
        if (ob1.Length != ob2.Length) return false;
        for (int i = 0; i < ob1.Length; i++)
            if (ob1.Number[i] != ob2.Number[i]) return false;
        return true;
    }
    public static bool operator !=(LongAr ob1, LongAr ob2)
    {
        if (ob1.Length != ob2.Length) return true;
        for (int i = 0; i < ob1.Length; i++)
            if (ob1.Number[i] != ob2.Number[i]) return true;
        return false;
    }
    public static bool operator >(LongAr ob1, LongAr ob2)
    {
        if (ob1.Length > ob2.Length) return true;
        else if (ob1.Length < ob2.Length) return false;
        else if (ob1.Length == ob2.Length)
        {
            for (int i = ob1.Length - 1; i >= 0; i--)
            {
                if (ob1.Number[i] > ob2.Number[i]) return true;
                else if (ob1.Number[i] < ob2.Number[i]) continue;

            }
        }
        return false;
    }
    public static bool operator <(LongAr ob1, LongAr ob2)
    {
        if (ob1.Length < ob2.Length) return true;
        else if (ob1.Length > ob2.Length) return false;
        else if (ob1.Length == ob2.Length)
        {
            for (int i = ob1.Length - 1; i >= 0; i--)
            {
                if (ob1.Number[i] < ob2.Number[i]) return true;
                else if (ob1.Number[i] > ob2.Number[i]) continue;

            }
        }
        return false;
    }
    public static bool operator <=(LongAr ob1, LongAr ob2)
    {
        int count = 0;
        if (ob1.Length < ob2.Length) return true;
        else if (ob1.Length > ob2.Length) return false;
        else if (ob1.Length == ob2.Length)
        {
            for (int i = ob1.Length - 1; i >= 0; i--)
            {
                if (ob1.Number[i] < ob2.Number[i]) return true;
                else if (ob1.Number[i] > ob2.Number[i]) continue;
                if (ob1.Number[i] == ob2.Number[i])
                    count++;
            }
        }
        if (count == ob1.Length)
            return true;
        return false;


        //            if (ob1.Number[i] != ob2.Number[i]) return false;



    }
    public static bool operator >=(LongAr ob1, LongAr ob2)
    {
        int count = 0;
        if (ob1.Length > ob2.Length) return true;
        else if (ob1.Length < ob2.Length) return false;
        else if (ob1.Length == ob2.Length)
        {
            for (int i = ob1.Length - 1; i >= 0; i--)
            {
                if (ob1.Number[i] > ob2.Number[i]) return true;
                else if (ob1.Number[i] < ob2.Number[i]) continue;
                if (ob1.Number[i] == ob2.Number[i])
                    count++;
            }
        }
        if (count == ob1.Length)
            return true;
        return false;
    }

    /*  public static LongAr operator +(LongAr ob1, LongAr ob2)
      {
          int length;
          if (ob1.Length > ob2.Length)
              length = ob1.Length + 1;
          else
              length = ob2.Length + 1;

          for (int ix = 0; ix < length; ix++)
          {
              ob2.Number[ix] += ob1.Number[ix];
              ob2.Number[ix + 1] += (byte)(ob2.Number[ix] / 10); 
              ob2.Number[ix] %= 10; 
          }

          if (ob2.Number[length - 1] == 0)
              length--;

      }

      public static LongAr operator -(LongAr ob1, LongAr ob2)
      {
          
          int k = 3; 
          int length = ob1.Length;
          if (ob1.Length > ob2.Length)
          {
              length = ob1.Length;
              k = 1; 
          }
          else
              if (ob2.Length > ob1.Length)
          {
              length = ob2.Length;
              k = 2; 
          }
          else 
              for (int ix = 0; ix < length;) 
              {
                  if (ob1.Number[ix] > ob2.Number[ix]) 
                  {
                      k = 1; 
                      break; 
                  }

                  if (ob2.Number[ix] > ob1.Number[ix]) 
                  {
                      k = 2; 
                      break; 
                  }
                  result.Number[Len] = ;
              }
              return result;


    public static LongAr operator *(LongAr a, LongAr b)
    {
       
    }*/

    class DemonStr
    {
        static void Main()
        {
            LongAr num1 = new LongAr("23123");
            LongAr num2 = new LongAr("1312");
            //LongAr Lab result = num1 + num2;
            //result.Show();
            //Console.WriteLine(num1 == num2);
            //Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 <= num2);
            // Console.WriteLine(num1 > num2);
            //    Console.WriteLine(num1 <= num2);
            //   Console.WriteLine(num1 >= num2);
        //    Console.WriteLine(num1 * num2);
            num1.Show();
            Console.ReadKey();
        }
    }
}