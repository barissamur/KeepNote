using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace KeepNoteAPI.Data
{
    public class Note
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Title { get; set; } = null!;

        public string? Content { get; set; }
    }
}
