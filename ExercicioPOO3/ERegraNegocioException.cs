using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO3
{
    class ERegraNegocioException : Exception
    {
        public ERegraNegocioException(string message) : base(message)
        {
        }
    }
}
