using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Model;

namespace Globomantic.Services
{
    public class ProposalMemoryService : IProposalService
    {
        private readonly List<ProposalModel> proposals = new List<ProposalModel>();

        public ProposalMemoryService()
        {
            proposals.Add(new ProposalModel { Id = 1, ConferenceId = 1, Speaker = "Roland Guijt", Title = "Understanding ASP.NET Core Security" });
            proposals.Add(new ProposalModel { Id = 2, ConferenceId = 2, Speaker = "Guijt Roland Guijt", Title = "Guijt Guijt Understanding ASP.NET Core Security" });
        }

        public Task Add(ProposalModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ProposalModel> Approve(int proposalId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProposalModel>> GetAll(int conferenceId)
        {
            throw new NotImplementedException();
        }
    }
}
