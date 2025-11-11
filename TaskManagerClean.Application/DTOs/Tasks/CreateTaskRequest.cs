using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerClean.Application.DTOs.Tasks
{
    //Single Responsibility Princip.
    public class CreateTaskRequest
    {
        public string Title { get; set; }
    }
}
