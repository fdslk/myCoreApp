using System;

namespace DITest
{
    public class MessageWriter : IMessageWriter{

        public void Write(string message)
        {
            Console.WriteLine($"MessageWriter.Write(message: \"{message}\")");
        }
    }
}