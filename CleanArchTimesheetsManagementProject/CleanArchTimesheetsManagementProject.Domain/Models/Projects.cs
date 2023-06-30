using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetsManagementProject.Domain.Models
{
    public class Projects
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ClientId { get; set; }
        public int ProjectCost { get; set; }
        public int ProjectHeadId { get; set; }
        public int ProjectManagerId { get; set; }
        //public int ProjectUserId { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

        // public List<ProjectUsers> ProjectUsers { get; set; }
        //public Users Users { get; set; }
        //public Client Client { get; set; }
    }
}
