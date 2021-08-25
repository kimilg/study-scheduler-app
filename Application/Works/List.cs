using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Works
{
    public class List
    {
        public class Query : IRequest<Result<List<WorkDto>>>
        {
        }
        public class Handler : IRequestHandler<Query, Result<List<WorkDto>>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Result<List<WorkDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var works = await _context.Works
                    .ProjectTo<WorkDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                return Result<List<WorkDto>>.Success(works);
            }
        }
    }
}