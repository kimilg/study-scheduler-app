using System;
using System.Threading.Tasks;
using Application.Works;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class WorksController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetWorks()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWork(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query{Id = id}));
        }

        [HttpPost]
        public async Task<IActionResult> CreateWork(Work work)
        {
            return HandleResult(await Mediator.Send(new Create.Command{Work = work}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditWork(Guid id, Work work)
        {
            work.Id = id;
            return HandleResult(await Mediator.Send(new Edit.Command{Id=id, Work=work}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWork(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command{Id = id}));
        }
    }
}