using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Globomantic.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace Globomantic.Controllers
{
    public class ProposalController : Controller
    {
        private IConferenceService conferenceService;
        private IProposalService proposalService;

        public ProposalController(IConferenceService conferenceService, IProposalService proposalService)
        {
            this.conferenceService = conferenceService;
            this.proposalService = proposalService;
        }
        public async Task<IActionResult> Index(int conferenceId)
        {
            var conference = await conferenceService.GetById(conferenceId);
            ViewBag.Title = $"Proposals for Conference {conference.Name} {conference.Location}";
            return View(await proposalService.GetAll(conferenceId));
        }

        public IActionResult Add(int conferenceId)
        {
            ViewBag.Title = "Add Proposal";
            return View(new ProposalModel { ConferenceId = conferenceId });
        }
    }
}