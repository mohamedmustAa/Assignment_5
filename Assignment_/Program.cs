using System.Linq.Expressions;

namespace Assignment_
{
    class Person
    {
        //public string Name { get; set; }
    }
    internal class Program
    {
        #region question1
        //public static void ValueType(int num)
        //{
        //    num += 10;
        //    Console.WriteLine(num);
        //}
        //public static void ReferenceTypeFun(ref int num)
        //{
        //    num += 10;
        //    Console.WriteLine(num);
        //}
        #endregion
        #region question2
        //public static void ValuTypeByReference(Person p)
        //{
        //    p.Name = "Changed inside By Value";
        //    p = new Person { Name = "new person by value" };
        //}
        //public static void ReferenceType(ref Person p) {
        //    p.Name = "Changed inside By Reference";
        //    p = new Person { Name = "new person by Reference" };
        //}
        #endregion
        #region question3
        //public static void SumSub(int x, int y ,out int sum,out int sub)
        //{
        //    sum = x+ y;
        //    sub = x - y;
        //}
        #endregion
        #region question4
        public static void OddNumberSumation(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;

                }

            }
            Console.WriteLine(sum);
            #endregion
            static void Main(string[] args)
            {
                #region question1
                //int num = 20;
                //ValueType(num);
                //Console.WriteLine(num);
                //ReferenceTypeFun(ref num);
                //Console.WriteLine(num);

                #endregion
                #region question2
                //Person p1 = new Person { Name = "mohamed" };
                //Console.WriteLine(p1.Name);
                //ValuTypeByReference(p1);
                //Console.WriteLine(p1.Name);
                //Console.WriteLine("==================");
                //Console.WriteLine(p1.Name);
                //ReferenceType(ref p1);
                //Console.WriteLine(p1.Name);
                #endregion
                #region question3
                //int a = 10, b = 5;
                //int sumResult, subResult;
                //SumSub(a,b, out sumResult, out subResult);
                //Console.WriteLine(sumResult);
                //Console.WriteLine(subResult);
                #endregion
                #region question4
                OddNumberSumation(25);
                #endregion
            }
        }
    }
}
