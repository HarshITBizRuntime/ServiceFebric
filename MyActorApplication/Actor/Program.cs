using HelloWorld.Interfaces;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;
using System;
using System.Threading.Tasks;

namespace Actor
{
    class Program
    {
        static void Main(string[] args)
        {
            IHelloWorld actor = ActorProxy.Create<IHelloWorld>(ActorId.CreateRandom(), new Uri("fabric:/MyActorApplication/HelloWorldActorService"));
            Task<string> retval = actor.GetHelloWorldAsync();
            Console.Write(retval.Result);
            Console.ReadLine();
        }
    }
}
