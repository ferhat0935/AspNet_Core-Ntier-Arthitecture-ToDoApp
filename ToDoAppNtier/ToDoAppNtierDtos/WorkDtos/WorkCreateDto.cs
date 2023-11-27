using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppNtierDtos.WorkDtos.Interfaces;

namespace ToDoAppNtierDtos.WorkDtos
{
    public class WorkCreateDto:IDto
    {
       // [Required(ErrorMessage ="Boş Alanları Doldurunuz!")] bir clas birden fazla iş yapamaz.bu yzedn fluent validation kullandık
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
