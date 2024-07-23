using System;
using System.Diagnostics;
using Humanizer;

namespace app
{
    //abstract egs
    abstract class AB{
        public int x=5;
        public abstract void Dis();
    }
    class Fetch : AB{
        public override void Dis()
        {
            Console.WriteLine("Hello guys");
        }
    }

    //interface egs
    interface MyInterface{
        void Show();
    }
    class GetFace:MyInterface{
        public void Show(){
            System.Console.WriteLine("Inteface msg");
        }
    }
    class Program
    {
        public static void Main(String[] r)
        {
            // Fetch f1=new Fetch();
            // f1.Dis();
            // AB x=new Fetch();
            // x.Dis();
            // f1.x=20;
            // Console.WriteLine(f1.x);

            // Interface egs
            // MyInterface mif=new GetFace();
            // mif.Show();

            // Using external packages egs
            // Console.WriteLine("Case".ToQuantity(0)); 
            // Console.WriteLine(DateTime.UtcNow.AddHours(-48).Humanize());
            // Console.WriteLine(TimeSpan.FromDays(21).Humanize());

            // Console.WriteLine(Fibo(4));

            // Diagnostics
            // Debug.Assert(0!=0,"That is false");
            // Debug.WriteLine("hello");

            // to get and find files & folders
            // new NewOne().ShowFilesDirectories();
            // System.Console.WriteLine(Directory.GetCurrentDirectory());
        }

        static int Fibo(int n){
            int n1=0,n2=1,sum=0;

            for(int i=2;i<=n;i++){
                sum=n1+n2;
                n1=n2;
                n2=sum;
            }
            Debug.WriteLineIf(n2==3,"Valid"); //It'll print at debugging
            return n==0?n1:n2;
        }

    }
}