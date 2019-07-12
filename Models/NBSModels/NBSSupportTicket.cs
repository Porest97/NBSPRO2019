using NBSPRO2019.Models.MutualModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NBSPRO2019.Models.NBSModels
{
    public class NBSSupportTicket
    {
        public int Id { get; set; }


        public DateTime? TimeStampCreated { get; set; } = DateTime.Now;


        public DateTime? TimeStampResolved { get; set; }


        public DateTime? TimeStampClosed { get; set; }

        [Display(Name = "DWK Ticket")]
        public string DWorkinTicketNumber { get; set; }

        [ForeignKey("BusinessCentreId")]
        public int? BusinessCentreId { get; set; }
        public BusinessCentre BusinessCentre { get; set; }

        [Display(Name = "Ordered BY")]
        public int? PersonId { get; set; }
        [Display(Name = "Ordered BY")]
        [ForeignKey("PersonId")]
        public Person OrderedBy { get; set; }

        [Display(Name = "Assigned FE BY")]
        public int? PersonId1 { get; set; }
        [Display(Name = "Assigned FE")]
        [ForeignKey("PersonId1")]
        public Person AssignedFE { get; set; }

        [Display(Name = "Fault Descripition")]
        public string FaultDescription { get; set; }

        [Display(Name = "Fault Report")]
        public string FaultReport { get; set; }

        [Display(Name = "Ticket Log")]
        public string TicketLog { get; set; }
    }
}
