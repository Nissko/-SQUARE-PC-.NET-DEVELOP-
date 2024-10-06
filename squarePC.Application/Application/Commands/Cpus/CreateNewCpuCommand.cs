using MediatR;
using squarePC.Application.Application.Templates.CpusRequest;

namespace squarePC.Application.Application.Commands.Cpus
{
    public class CreateNewCpuCommand : IRequest<Unit>
    {
        public CreateNewCpuCommand(CreateCpuRequest createCpuRequest)
        {
            CreateCpu = createCpuRequest;
        }

        /// <summary>
        /// Запрос на создание процессора
        /// </summary>
        public CreateCpuRequest CreateCpu { get; private set; }
    }
}