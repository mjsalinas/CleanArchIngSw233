
using TaskManagerClean.Application.DTOs.Tasks;
using TaskManagerClean.Domain.Entities;

namespace TaskManagerClean.Application.Mappers
{
    //clean code:separamos mapeo para mantener AppServices limpios de logica de transformacion de datos
    public static class TaskMapper
    {
        public static TaskDto ToDto(TaskItem i) => new (i.Id, i.Title, i.IsCompleted);
    }
}
