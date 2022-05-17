using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Dto.DTOs.ReportDto
{
    public class ReportAddDto
    {
        public string Description { get; set; }
        public string Detail { get; set; }
        public Task Task { get; set; }
        public int TaskId { get; set; }
    }
}
