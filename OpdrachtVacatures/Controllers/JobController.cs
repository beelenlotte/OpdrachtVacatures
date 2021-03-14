using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpdrachtVacatures.DTO;
using OpdrachtVacatures.Interfaces;
using OpdrachtVacatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpdrachtVacatures.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IJobService _jobService;
        public JobController(IJobService jobService, IMapper mapper)
        {
            _jobService = jobService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<Jobs> GetJob(int jobId)
        {
            var job = _jobService.GetJob(jobId);
            return job;
        }
        [HttpPost]
        public ActionResult CreateJob(JobDTO newJob)
        {
            Jobs job = _mapper.Map<Jobs>(newJob);
            //var JobToInsertInDb = new Jobs();
            //JobToInsertInDb.CompanyId = newJob.CompanyId;
            //JobToInsertInDb.JobTitle = newJob.JobTitle;
            //JobToInsertInDb.Description = newJob.Description;
            //JobToInsertInDb.Salary = newJob.Salary;
            //JobToInsertInDb.DateCreated = newJob.DateCreated;


            _jobService.CreateJob(job);
            return Ok();
        }
        [HttpPut]
        public ActionResult<Jobs> UpdateJob(int jobIdToEdit, JobDTO updateJobValues)
        {
            Jobs editedJob = _mapper.Map<Jobs>(updateJobValues);
            //var JobToEdit = new Jobs();
            //JobToEdit.CompanyId = updateJobValues.CompanyId;
            //JobToEdit.JobTitle = updateJobValues.JobTitle;
            //JobToEdit.Description = updateJobValues.Description;
            //JobToEdit.Salary = updateJobValues.Salary;
            //JobToEdit.DateCreated = updateJobValues.DateCreated;
            //_jobService.UpdateJob(jobIdToEdit, JobToEdit);
            return editedJob;
        }

        [HttpDelete]
        public ActionResult DeleteJob(int jobId)
        {
            _jobService.DeleteJobById(jobId);
            return Ok();
        }

        [HttpGet("GetAllJobsBypostal")]
        public ActionResult<List<Jobs>> GetAllJobsBPostal(string postalCode)
        {
            List<Jobs> allJobsByPostal = _jobService.GetAllJobsBPostal(postalCode);
            return allJobsByPostal;
        }

        [HttpGet("3Latestjobs")]
        public ActionResult<List<Jobs>> Get3LatestJobs()
        {
            List<Jobs> latest3jobs = _jobService.Get3LatestJobs();
            return latest3jobs;
        }
            

    }
}
