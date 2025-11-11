using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerClean.Domain.Entities;

namespace TaskManagerClean.Domain.Interfaces
{
    //implementacion de ISP (principio de segregacion de interfaces)
    //uno de los pasos para la implementacion de DIP (princ. de inversion de dependencias) 
    public interface ITaskReader
    {
        Task<TaskItem> GetById(Guid id);
        Task<IReadOnlyList<TaskItem>> GetAll();

    }
}
