using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Domain;
using MediatR;
using Persistence;

namespace Application.Works
{
    public class Create
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Work Work { get; set; }
        }
        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                await _context.Works.AddAsync(request.Work);
                
                var result = await _context.SaveChangesAsync() > 0;

                if(result) {
                    return Result<Unit>.Success(Unit.Value);
                }
                return Result<Unit>.Failure("Fail to create work");
            }
        }
    }
}