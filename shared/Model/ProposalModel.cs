﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Model
{
    public class ProposalModel
    {
        public int Id { get; set; }
        public int ConferenceId { get; set; }
        public string Speaker { get; set; }
        public string Title { get; set; }
        public int Approved { get; set; }
    }
}
