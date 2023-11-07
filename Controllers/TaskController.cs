using ex2;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ex2
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService taskService;
        
        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }
       
        // POST api/<TaskController>
        [HttpPost]

        public string CreateTask(Taskk t)
        {
            return taskService.CreateTask(t);
           
        }
       

        // PUT api/<TaskController>/5
        [HttpPut]
        public string Put(Taskk t)
        {
            return taskService.UpdateTask(t);
        }

        // DELETE api/<TaskController>/5
        [HttpDelete]
        public string Delete(Taskk t)
        {
            return taskService.DeleteTask(t);
        }
    }
}
