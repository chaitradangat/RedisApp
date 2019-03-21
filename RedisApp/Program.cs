using System;
using StackExchange.Redis;

//using ServiceStack.Redis; #this library is very neat however with limited usage on a free licence,hence not used.

namespace RedisApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region -Old Code-
            //using (IRedisNativeClient client = new RedisClient())
            //{
            //    // todo: #this connects to local instance of redis find how to connect to remote instance
            //}
            #endregion

            //connecting to my Linux Machine. Dont try doing anything naughty here ;)
            IConnectionMultiplexer redis = ConnectionMultiplexer.Connect("198.12.118.83");

            //getting database for RedisDB
            IDatabase redisDB = redis.GetDatabase();

            //setting a key with value "Redis Rocks!"

            var _value = "Redis Rocks!";

            redisDB.StringSet("uid:1", _value);

            //reading the value back
            var _savedValue = redisDB.StringGet("uid:1");

            Console.WriteLine(_savedValue);

            //#todo: try different operations on redis data types

            Console.ReadLine();
        }
    }
}
