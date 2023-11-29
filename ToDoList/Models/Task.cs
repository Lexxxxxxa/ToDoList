using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле 'Назва' є обов'язковим.")]
        [StringLength(100, ErrorMessage = "Назва завдання повинна містити не більше 100 символів.")]
        public string Title { get; set; }

        public bool IsDone { get; set; }

        [Display(Name = "Дата створення")]
        public DateTime CreatedAt { get; set; }
    }
}
