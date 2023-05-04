using static projectCSharp.deligatemini;


namespace projectCSharp
{
    public class Program
    {
       public static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //DataTypes.datatypes();
            //Operators.operators();
            //Conversions.conversions();
            //Arrays.arrays();
            // Statements.ifstatements();
            // loops.loopss();

            //value parameters

            //int a = 1; int b = 2;
            //parameters par = new parameters();
            //par.para(a, b);
            //Console.WriteLine("a and b values are {0} {1}", a, b);

            //ref parameters

            //int c = 1; int d = 2;
            //parameters pare = new parameters();
            //pare.para1(ref c, ref d);
            //Console.WriteLine("c and d values are {0} {1}", c, d);

            // out parameters

            //int e = 1; int f = 2; int g, h;
            //parameters parr = new parameters();
            //parr.para2(e, f, out g, out h);
            //Console.WriteLine("e and f values are {0} {1}", g, h);

            // params

            //parameters parrr = new parameters();
            //parrr.resultofparas(1, 2, 3, 4,5,7,9);

            //Constructor ctor = new Constructor("venkatesh", "averi");
            //ctor.constructor();

            // Coordinate str = new Coordinate(10, 11);
            //str.GetOrigin();

            //enums enu = new enums();
            //enu.GetAge();

            //adstarct class

            //cls cls = new cls();
            //cls.MyProperty();
            //cls.admethod();

            //inheretance

            //deriveclas deriveclas = new deriveclas();
            //deriveclas.method1();
            //deriveclas.method2();

            //polimorpisam

            //poly_overloading poly_Overloading = new poly_overloading();
            //poly_Overloading.overload1();
            //poly_Overloading.overload1(10);

            //poly-averriding

            //poly_overriding poly_Overriding1 = new poly_overriding1();

            //poly_Overriding1.method1();

            //deligates
            deligatemini deligatemini = new deligatemini();
            deligatemethod del1 = new deligatemethod(deligatemini.methoddeligate);
            del1 += new deligatemethod(deligatemini.methoddeligate1);
            del1(1);

            //interfaceabc itr = new interfaceabc();
            //itr.bike();
            //itr.car();

            //generics by method

            //generics generics = new generics();
            //generics.genericmethod<int>(2, 3);
            //generics.genericmethod<string>("venkatesh", "averi");


            //generics.stringmethod("hi", "venky");
            //generics.genmethod(5, 6);

            ////generics by class

            //genericsbyclass<int> genericsbyclass = new genericsbyclass<int>();
            //genericsbyclass.genbyclassmethod(2, 3);

            //genericsbyclass<string> genericsbyclass1 = new genericsbyclass<string>();
            //genericsbyclass1.genbyclassmethod("hi", "generics");

            //////calling static generic class

            //genericsbyclass<int>.genbyclassmethod11(2);
            //genericsbyclass<string>.genbyclassmethod11("venky");


            //partial classes

            //partialclass2 prc = new partialclass2();
            //prc.partialclass1();

            //Parcialclass1 ppp = new Parcialclass1();
            //ppp.classes1();

            //lists

            //lists lst = new lists();
            //lst.listvalues();

            //dictonary
            //Dictonary dic = new Dictonary();
            //dic.dictmethod();
            //dic.customer2();

            //Lambda lmd = new Lambda();
            //lmd.lambdamethod();


            //Async_await
            //Async_Await asy = new Async_Await();
            //asy.Method1();
            //asy.Method2();
            //Console.ReadKey();

        }

    }
}