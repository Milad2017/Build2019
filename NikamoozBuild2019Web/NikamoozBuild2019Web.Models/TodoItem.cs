using System;

namespace NikamoozBuild2019Web.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime? DoneDate { get; set; }
    }
}
