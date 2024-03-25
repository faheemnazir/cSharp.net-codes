using System.Collections;

namespace stacksAndQueues;

public class mainClas
{
   public  Stack<stack> st = new Stack<stack>();
   public Queue<queues> que = new Queue<queues>();
    private void addStack()
    {
        stack s = new stack();
        Console.WriteLine("enter the details here for stack");
        Console.WriteLine("enter the id");
        s.id = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the age");
        s.age = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the name ");
        s.name = Console.ReadLine();
        Console.WriteLine("enter the address here");
        s.address = Console.ReadLine();
        st.Push(s);
    }
    private void addQueue()
    {
        queues s = new queues();
        Console.WriteLine("enter the details here for stack");
        Console.WriteLine("enter the id");
        s.id = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the age");
        s.age = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the name ");
        s.name = Console.ReadLine();
        Console.WriteLine("enter the address here");
        s.address = Console.ReadLine();
        que.Enqueue(s);
    }

    private void displayStcak()
    {
        Console.WriteLine("printing all studnets in lifo order here");
        foreach (var ele in st)
        {
            Console.WriteLine($"{ele.id} {ele.age} {ele.name} {ele.address}");
            
        }
        
    }
    private void displayQueue()
    {
        Console.WriteLine("printing all studnets in fifo order here");
        foreach (var ele in que)
        {
            Console.WriteLine($"{ele.id} {ele.age} {ele.name} {ele.address}");
            
            
        }
        Console.WriteLine("name of the peek elemengt is ");
        Console.WriteLine(que.Peek().name);
        
    }
    public static void Main(string[] args)
    {
        // Stack<int> st = new Stack<int>();
        // for (int i = 0; i < 4; i++)
        // {
        //     Console.WriteLine("enter the element in stack");
        //     st.Push(int.Parse(Console.ReadLine()));
        // }
        // Console.WriteLine("the elements in filo order is ");
        // // for (int i = 0; i < st.Count; i++)
        // // {
        // //     Console.WriteLine(st.Pop());
        // // }
        // foreach (var ele in st)
        // {
        //     Console.WriteLine(ele);
        //     
        // }
        //
        // // while (st.Count>0)
        // // {
        // //     Console.WriteLine(st.Pop());
        // //     
        // // }
        // Console.WriteLine(st.Peek());
        // Console.WriteLine(st.First());
        // Console.WriteLine(st.Last());
        // Console.WriteLine(st.Order());
        // Console.WriteLine(st.ElementAt(3));
        // // Console.WriteLine(st.Join());
        //
        // Func<int, int> printstac = x => x * 2;
        // Console.WriteLine("prinitng doubeles as");
        // foreach (var el in st)
        // {
        //     Console.WriteLine(printstac(el));
        //     
        // }
        //
        // var add = (int a, int b, int c) => a + b + c;
        // Console.WriteLine(add(1,2,5));

       
        mainClas mc = new mainClas();
        // Console.WriteLine("creating stack of custom class");
        // mc.addStack();
        // mc.addStack();mc.addStack();
        // mc.displayStcak();
        mc.addQueue();
        mc.addQueue();
        mc.addQueue();
        mc.displayQueue();
        
        



    }
}