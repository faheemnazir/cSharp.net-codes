using System.Collections;
// using System.Runtime.InteropServices.JavaScript;
// using Microsoft.VisualBasic;
//
// namespace customClassList;
//
// public class mainClass
// {
//     private List<person> persons = new List<person>();
//     private string ispresent(string givenname)
//     {
//         var persontofind = persons.Find(person => person.name.Equals(givenname, StringComparison.OrdinalIgnoreCase));
//         if (persontofind != null)
//         {
//             persons.Remove(persontofind);
//             Console.WriteLine("removed sucesesfully\n");
//             return "person is present";
//         }
//
//         var find = persons.Find(person => person.name.Equals(givenname, StringComparison.OrdinalIgnoreCase));
//         ArrayList arr = new ArrayList();
//         arr.Add(1);
//         arr.Add(2);
//         arr.Add(3);
//         Console.WriteLine("printing array lisy as");
//         foreach (var ele in arr)
//         {
//             Console.WriteLine(ele);
//             
//         }
//
//         return "person not present";
//     }
//     
//     private void add()
//     {
//         person per = new person();
//         Console.WriteLine("enter the name of the person");
//         per.name=Console.ReadLine();
//         Console.WriteLine("enter the city ");
//         per.city = Console.ReadLine();
//         Console.WriteLine("enter the age");
//         per.age = int.Parse(Console.ReadLine());
//         Console.WriteLine("entre the college name");
//         per.college = Console.ReadLine();
//         Console.WriteLine("enter the height");
//         per.height = float.Parse(Console.ReadLine());
//         persons.Add(per);
//         Console.WriteLine("added sucessesfully");
//     }
//
//     private void display()
//     {
//         Console.WriteLine("details of the persons are");
//         foreach (var item in persons)
//         {
//             Console.WriteLine("name is "+item.name+"\n city is "+item.city+"\n age is "+item.age+"\n college is "+item.city+"\n height is "+item.height );
//         }
//     }
    
    public static void Main(string[] args)
    {
        mainClass mc = new mainClass();
        while (true)
        {
            Console.WriteLine("1. add person to list");
            Console.WriteLine("2. search person in the list ");
            Console.WriteLine("3. display the current person in the list");
            Console.WriteLine("enter your choice: ");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1: mc.add();
                    break;
                case 2:Console.WriteLine("enter the name of the person to search");
                    string nametosearch = Console.ReadLine();
                    string persent=mc.ispresent(nametosearch);
                    Console.WriteLine(persent);
                    break;
                case 3:mc.display();
                    break;
                default: break;
                
            }

        }

    }
}