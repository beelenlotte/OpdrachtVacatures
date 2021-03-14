using OpdrachtVacatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpdrachtVacatures.Interfaces
{
    public interface IJobService
    {
        Jobs GetJob(int jobId);
        void CreateJob(Jobs newJob);
        Jobs UpdateJob(int jobIdToEdit, Jobs updateJobValues);
        void DeleteJobById(int jobId);
        List<Jobs> GetAllJobsBPostal(string postalCode);
        List<Jobs> Get3LatestJobs();
    }
}
