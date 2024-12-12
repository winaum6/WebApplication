using System.ComponentModel.DataAnnotations;
using TodoList.Domain.Entities;

namespace WebApplication4.Models.Home
{
    public class HomeViewModel
    {
        [Required(ErrorMessage = "Данное поле обязательное")]
        public string TaskName { get; set; }
        [Required(ErrorMessage = "Данное поле обязательное")]
        public DateTime? DateTime { get; set; }

        public IEnumerable<TaskApp>? Tasks {  get; set; }
    }
}
