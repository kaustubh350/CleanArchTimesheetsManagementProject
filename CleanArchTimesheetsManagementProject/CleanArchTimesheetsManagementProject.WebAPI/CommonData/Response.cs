using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchTimesheetsManagementProject.WebAPI.CommonData
{
    public abstract class Response : IResponse
    {
        public List<string> Errors { get; set; } = new();

        public bool IsSuccessful { get; set; }

    }
}



