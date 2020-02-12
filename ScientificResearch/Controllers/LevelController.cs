using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScientificResearch.Core.Business.Filters;
using ScientificResearch.Core.Business.Models;
using ScientificResearch.Core.Business.Models.Base;
using ScientificResearch.Core.Business.Models.Levels;
using ScientificResearch.Core.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/menus")]
    [ValidateModel]
    public class LevelController : ControllerBase
    {
        private readonly ILevelService _levelService;

        public LevelController(ILevelService levelService)
        {
            _levelService = levelService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] RequestListViewModel requestListViewModel)
        {
            var menu = await _levelService.ListLevelAsync(requestListViewModel);
            return Ok(menu);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenuById(Guid id)
        {
            var menu = await _levelService.GetLevelByIdAsync(id);
            return Ok(menu);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] LevelManageModel levelManagerModel)
        {
            var response = await _levelService.CreateLevelAsync(levelManagerModel);
            return new CustomActionResult(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] LevelManageModel levelManageModel)
        {
            var response = await _levelService.UpdateLevelAsync(id, levelManageModel);
            return new CustomActionResult(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _levelService.DeleteLevelAsync(id);
            return new CustomActionResult(response);
        }
    }
}
