using OpdrachtVacatures.Db;
using OpdrachtVacatures.Interfaces;
using OpdrachtVacatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpdrachtVacatures.Services
{
    public class JobService : IJobService
    {
        public Jobs GetJob(int jobId)
        {
            using var db = new JobsContext();
            var job = db.Jobs.FirstOrDefault(x => x.Id == jobId);
            return job;
        }
        public void CreateJob(Jobs newJob)
        {
            using var db = new JobsContext();
            db.Add(newJob);
            db.SaveChanges();
        }

        //automapper? 
        public Jobs UpdateJob(int jobIdToEdit, Jobs updateJobValues)
        {
            using var db = new JobsContext();
            var JobToEdit = db.Jobs.First(Jobs => Jobs.Id == jobIdToEdit);
            JobToEdit.Company = updateJobValues.Company;
            JobToEdit.JobTitle = updateJobValues.JobTitle;
            JobToEdit.Description = updateJobValues.Description;
            JobToEdit.Salary = updateJobValues.Salary;
            JobToEdit.DateCreated = updateJobValues.DateCreated;
            db.SaveChanges();
            return JobToEdit;
        }
        public void DeleteJobById(int jobId)
        {
            using var db = new JobsContext();
            var jobToDelete = db.Jobs.Find(jobId);
            db.Jobs.Remove(jobToDelete);
            db.SaveChanges();
        }

        public List<Jobs> GetAllJobsBPostal(string postalCode)
        {
            using var db = new JobsContext();
            List<Jobs> jobs = db.Jobs.Where(x => x.Company.Postalcode == postalCode).ToList();
            return jobs;
        }
        public List<Jobs> Get3LatestJobs()
        {
            using var db = new JobsContext();
            var jobs = db.Jobs.OrderByDescending(x => x.DateCreated).Take(3).ToList();
            return jobs;
        }

    }
}
