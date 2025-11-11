using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerClean.Application.DTOs.Tasks
{
    //SRP: un contrato de datos de entrada/salida para la capa de Aplicacion. Su responsabilidad es transformar datos
   
    public record TaskDto (Guid Id, string Title, bool IsCompleted); 
 
}
