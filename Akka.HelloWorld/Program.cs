using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Akka.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 生成一个actor system
            var actorSystem = ActorSystem.Create("HelloSystem");


            Props props = Props.Create<HelloActor>();
            IActorRef helloActor = actorSystem.ActorOf(props, "helloActor");

            helloActor.Tell("World");

            
            Console.ReadLine();
        }
    }

    public class HelloActor : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            Console.WriteLine("Hello " + message);
        }
    }

   
}
