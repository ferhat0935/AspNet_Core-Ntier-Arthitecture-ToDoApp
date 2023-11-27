using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppNtierDtos.WorkDtos.Interfaces;

namespace ToDoAppNtierDtos.WorkDtos
{
    public class WorkUpdateDto:IDto
    {
        //güncelleme yaparken örneğin definition boş geçilmesn gibi kurallarımız olabilir.O yzden worklistdto kullanmadk
      //  [Range(1,int.MaxValue,ErrorMessage ="Id giriniz")]
        public int Id { get; set; }
       // [Required(ErrorMessage ="Boş alanları doldurunuz!")]
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
