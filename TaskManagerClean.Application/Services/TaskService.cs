using TaskManagerClean.Application.DTOs.Tasks;
using TaskManagerClean.Application.Mappers;
using TaskManagerClean.Domain.Entities;
using TaskManagerClean.Domain.Interfaces;

namespace TaskManagerClean.Application.Services
{
    public class TaskService
    {
        //DIP: el AppService depende de interfaces (abstracciones) de dominio y no de implementaciones de infraestructura    
        //nomenclatura de nombramiento pascal: taskReader, taskWriter, etc.
        private readonly ITaskReader _taskReader;
        private readonly ITaskWriter _taskWriter;

        public TaskService(ITaskReader reader, ITaskWriter writer)
        {
            _taskReader = reader;
            _taskWriter = writer;
        }

        public async Task<TaskDto> CreateAsync (CreateTaskRequest request)
        {
            var entity = new TaskItem(Guid.NewGuid(), request.Title, IsCompleted:false);
            await _taskWriter.Add(entity);
            return TaskMapper.ToDto(entity);

        }

        public async Task<IReadOnlyList<TaskDto>> GetAllAsync()
        {
            var list = await _taskReader.GetAll();
            return list.Select(TaskMapper.ToDto).ToList();
        }

        public async Task<TaskDto> UpdateAsync(UpdateTaskRequest request)
        {
            var entity = await _taskReader.GetById(request.Id) ?? throw new KeyNotFoundException("No se encontro la tarea");
            entity.Rename(request.Title);
            await _taskWriter.Update(entity);  
            return TaskMapper.ToDto(entity);
        }
    }
}
