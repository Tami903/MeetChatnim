using Meetchatnim.Core.Entities;
using Meetchatnim.Core.Repositories;
using Meetchatnim.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetchatnim.Service
{
    public interface ICandidateService
    {
     //   private readonly ICandidateRepository _ICandidateRepository;

        public ICandidateService(ICandidateRepository CandidateRepository)
        {
            CandidateRepository = CandidateRepository;
        }

        public List<Candidate> GetList()
        {
            return _ICandidateRepository.GetAll();
        }
    }
