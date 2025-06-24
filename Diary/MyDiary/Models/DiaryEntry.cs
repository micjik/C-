﻿using System.ComponentModel.DataAnnotations;

namespace MyDiary.Models
{
    public class DiaryEntry
    {
        

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public DateTime Created { get; set; } = new DateTime();
    }
}
