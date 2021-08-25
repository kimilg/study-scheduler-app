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

        // [HttpPost]
        // public async Task<IActionResult> CreateWork(Work work)
        // {
            
        // }
       
    }
}