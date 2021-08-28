using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitrineLuxury.Entities.Concrete;
using VitrineLuxury.Entities.DTO;
using VitrineLuxury.Service.Abstract;

namespace VitrineLuxuryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;
        public ProjectsController(IProjectService projectService,IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var projects = await _projectService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProjectDto>>(projects));
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await _projectService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProjectDto>(project));
        }

        [HttpGet("imageurls/")]
        public async Task<IActionResult> GetProjectsWithImageUrlByIdAsync()
        {
            var projects = await _projectService.GetProjectsWithImageUrlsAsync();
            return Ok(projects);
        }

        [HttpGet("imageurl/{id}")]
        public async Task<IActionResult> GetProjectWithImageUrlByIdAsync(int id)
        {
            var project = await _projectService.GetProjectWithImageUrlByIdAsync(id);
            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProjectDto projectDto)
        {
            await _projectService.AddAsync(_mapper.Map<Project>(projectDto));
            return Ok();
        }

        [HttpPut]
        public IActionResult Update (ProjectDto projectDto)
        {
            var project = _projectService.Update(_mapper.Map<Project>(projectDto));
            return Ok(_mapper.Map<ProjectDto>(project));
        }

        [HttpDelete]
        public void Remove(ProjectDto projectDto)
        {
            _projectService.Remove(_mapper.Map<Project>(projectDto));

        } 

    }
}
