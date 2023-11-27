using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppNtierCommon.ResponseObjects
{
    public class CustomValidationError
    {
        public string ErroMessage { get; set; }
        public string PropertyName { get; set; }
    }
}
