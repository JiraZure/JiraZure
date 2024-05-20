using System;
namespace JiraZure.Models
{

namespace CustomExceptions
{
    public class EnviromentException : Exception
    {
    //    public ConfifurationException()
    //    {
    //    }
    //        public ConfifurationException(string message, Exception inner)
    //: base(message, inner)
    //        {
    //        }

            public EnviromentException(string message)
            : base(message)
        {
                Console.WriteLine("some ENV is not set: " + message);
            }


    }
}
}
