using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace job_insights_backend.Controllers
{
    [ApiController] /*it indicates class is an api controller*/
    [Route("[controller]")] /*specifies the base route for this controller*/
    public class JobController : Controller
    {
        private readonly IJobRepository _jobRepository; /*private field _jobRepository of type IJobRepository*/
      
        public JobController(IJobRepository jobRepository)   /*for dependency injection.*/
           /* receives an instance of IJobRepository as a parameter and assigns it to the _jobRepository field*/.
        {
            _jobRepository = jobRepository;
        }

    [HttpGet(Name = "GetAllJobs")] /*HTTP GET endpoint for your API., retrieve a list of jobs*/
    //should be invoked for HTTP GET requests.
    //Name = "GetAllJobs": This gives a name to this route, which can be used for 
    //    generating URLs. In this case, it's named "GetAllJobs."
    public async Task<IActionResult> GetAllJobs()  /*This is the method signature*/
        //it is async because it involves database queries
    {
        var results = await _jobRepository.GetAllJobs(); //await the GetAllJobs method of the _jobRepository
 //_jobRepository is likely an interface or class responsible for fetching job data.
        return Ok(results);
        //Once you have the results, you return them as an OkObjectResult
        //    with an HTTP status code 200.
        //    This indicates a successful response, and the results are sent back to the client.
    }

}
}
 //this code defines a controller class JobController with a single GET endpoint (GetAllJobs)
 //that retrieves job data from a repository and returns it to the client as a JSON response. 
 //The IJobRepository dependency is injected into the controller's constructor,
 //allowing it to fetch data from a data source. 