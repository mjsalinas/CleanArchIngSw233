using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerClean.Domain.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }  = string.Empty;
        public bool IsCompleted { get; set; }

        public TaskItem(Guid guid, string title, bool IsCompleted)
        {
            if (title == null || string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Titulo es requerido");

            Id = guid;
            Title = title;
            IsCompleted = IsCompleted;
        }

        public void Rename(string title)
        {
            if (title == null || string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Titulo es requerido");

            Title = title;
        }
    }
}
