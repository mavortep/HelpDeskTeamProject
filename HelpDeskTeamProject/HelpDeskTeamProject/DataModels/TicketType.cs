﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelpDeskTeamProject.DataModels
{
    public class TicketType
    {
        public int Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }
    }
}