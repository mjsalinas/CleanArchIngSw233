using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerClean.Domain.Entities;

namespace TaskManagerClean.Domain.Interfaces
{
    public interface ITaskWriter
    {
        Task Add(TaskItem item);
        Task Update(TaskItem item);
        Task Delete(Guid id);
    }
}
