using System.ComponentModel.DataAnnotations;

namespace BlazorServerSignalRApp.Models
{
    public class DisplayMessageModel
    {
        [Required]
        [StringLength(255, ErrorMessage = "The message is too long!")]
        public string MessageText { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The Username is too long!")]
        [MinLength(4, ErrorMessage = "The Username is too short!")]
        public string UserName { get; set; }
        public string SendTime { get; set; }
    }
}
