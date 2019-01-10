using Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globomantic.Services
{
    public class ConferenceMemoryService: IConferenceService
    {
        private readonly List<ConferenceModel> conferences = new List<ConferenceModel>();

        public ConferenceMemoryService()
        {
            conferences.Add(new ConferenceModel { Id = 1, Name = "NDC", Location = "Oslo", Start = new DateTime(2011, 6, 10), AttendeeTotal = 1 });
            conferences.Add(new ConferenceModel { Id = 2, Name = "NDCCC", Location = "OsloOO", Start = new DateTime(2011, 6, 10), AttendeeTotal = 3 });
        }

        public Task Add(ConferenceModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ConferenceModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ConferenceModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StatisticsModel> GetStatistics()
        {
            return Task.Run(() =>
            {
                return new StatisticsModel
                {
                    NumberOfAttendees = conferences.Sum(c => c.AttendeeTotal),
                    AverageConferenceAttendees = (int)conferences.Average(c => c.AttendeeTotal)
                };
            });
        }
    }
}
