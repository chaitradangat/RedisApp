using System;
using ServiceStack.Redis;

namespace RedisApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (IRedisNativeClient client = new RedisClient())
            {
                // todo: #this connects to local instance of redis find how to connect to remote instance
            }












        }
    }
}
