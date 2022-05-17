using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ysk.Todo.Business.Abstract;

namespace Ysk.Todo.Web.TagHelpers
{
    [HtmlTargetElement("getTaskAppUserId")]
    public class TaskAppUserIdTagHelper : TagHelper
    {
        private readonly ITaskService _taskService;
        public TaskAppUserIdTagHelper(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public int AppUserId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            List<Entities.Concrete.Task> tasks = _taskService.GetAllByAppUserId(AppUserId);
            int completedTaskCount = tasks.Where(I => I.Status).Count();
            int workedOnTaskCount = tasks.Where(I => !I.Status).Count();

            string htmlString = $"<strong> Tamamladığı görev sayısı :</strong>{completedTaskCount} <br> <strong> Üstünde çalıştığı görev sayısı : </strong>{workedOnTaskCount}";

            output.Content.SetHtmlContent(htmlString);
        }
    }
}
