using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Helpers
{
    public class Response<T>
    {
        public Response() { }

        public Response(T data, string message = null) 
        { 
            Succeded = true;
            Message = message;
            Result = data;
        
        }

        public Response(string message)
        {
            Message = message;
            Succeded = false;
        }

        public bool Succeded { get; set; }

        public string Message { get; set; }

        public T Result { get; set; }


    }
}
