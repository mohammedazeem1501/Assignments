using System;


namespace Exercise_02
{
    class Program: AreaClass,Perimeter // inheriting an abstract class and an interface
    {
        public override int Area() // overriding the abstract method the abstract class
        {
            Console.WriteLine("Enter length and breadth for the rectangle: \n");
            int length = int.Parse(Console.ReadLine());
            int breadth = int.Parse(Console.ReadLine());
            return (length*breadth);
        }

        public int Peri() // implmenting the method from the interface
        {
            Console.WriteLine("Enter length and breadth for the rectangle: \n");
            int length = int.Parse(Console.ReadLine());
            int breadth = int.Parse(Console.ReadLine());
            return 2 * (length + breadth);
        }


        // ***********************************ENTRY POINT **************************************//


        static void Main(string[] args)

        {


            //******************************** Ques - 01 **********************************************//



            Program obj = new Program();
            Console.WriteLine("\nArea of the rectangle : " + obj.Area()); // calling an overrided method from an abstract class
            Console.WriteLine("\nPrimeter of the rectangle : " + obj.Peri()); // calling an overrided method of interface
            obj.display();    // calling a non-abstracted method from abstract class


            //******************** Ques - 02 and Ques - 04 ***********************************//


            Ques_04 obj1 = new Ques_04();
            Console.WriteLine("\n\nMethod overloading is implemented as : ");
            Console.WriteLine("\nFunction 1 invoked is implemented as :" + obj1.Sum(10, 20));  // function 1 is invoked
            Console.WriteLine("Function 2 is invoked : " + obj1.Sum(40, 30, 50));        // function 2 is invoked
            Console.WriteLine("Function 3 is invoked : " + obj1.Sum(100.04f, 200.7f));      // function 3 is invoked
            Console.WriteLine("Function 4 is invoked : " + obj1.Sum(10, 200.08f));           // function 4 is invoked


            // ************************ method over-riding is implemented **************************//
            Ques_02 obj2 = new Ques_02();
            Console.WriteLine("\n\nOver-rided function is invoked : " + obj2.Product(10,10));  // over-rided function is invoked from question 4

            //***************************** Ques - 03 *************************************//
            first obj3 = new Ques_03();
            obj3.display();

            second obj8 = new Ques_03();
            obj8.display();

            //**************************************** Ques - 05 and Ques - 06 *************************//

            Ques_05 obj5 = new Ques_05();
            obj5.show();
            obj5.SetData();

            //***************************************** Ques - 07 *********************************//
            Console.WriteLine("\n\nConstructors invoked from the object of the derived class....");
            //B ob = new B();
            Console.WriteLine("\n\nConstructors invoked from the object of the derived class when we pass a paramter to a constructor....");
            //B ob1 = new B(10);
            Console.WriteLine("\n\nAn error occurred when we tried to create an instance of the  derived class with the help the reference of the Parent Class....");
            // B ob2 = new A();    ............ Derived class object cannot be created using Parent class reference.
            Console.WriteLine("\n\nConstructors invoked from the object of the base class which is created with the help of the reference of the derived class....");
            A ob3 = new B();


            //***************************** Ques - 08 ********************************//


            Square sq = new Square();
            Console.WriteLine("\n\n\nThe area is calculated in a private method and called in a public method");
            sq.Sq_Area();







            //********************************** Operator Overloading *****************************//
            Console.WriteLine("\nOperator overloadig implementation : \n");
            Operator object1 = new Operator(20);
            Operator object2 = new Operator(30);
            Operator object3 = new Operator();
            object3 = object1 + object2;

            object3.Display();


            //******************************** End Main Function **********************//


        }
    }
}
