using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace enrollment_form.Models
{

    public class UserDetailModel
    {

        public string StudentName { get; set; }


        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }

        [RegularExpression(@"^[0-9]{10}", ErrorMessage = "Invalid Phone Number")]
        public string? PhoneNumber { get; set; }

        [Range(2021, 2025, ErrorMessage = "Graduation Year must be between 2021 - 2025")]
        public string? GraduatedYear { get; set; }

        public string SelectedCourse { get; set; }

        public List<string>? Course { get; set; } = new List<string>
        {
            "Full Stack Web Development",
            "Cloud Computing",
            "Cyber Security"
        };

        public string GetFirstName()
        {
            if(string.IsNullOrWhiteSpace(StudentName))
            {
                return string.Empty;
            }

            var names = StudentName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach(var name in names)
            {
                if (name.Length > 1 && char.IsUpper(name[0]))
                    return name;
            }

            return string.Empty;
        }

        public string DisplayMessage()
        {
            return $"Congrats {GetFirstName()}! You are successfully enrolled into {SelectedCourse} program.";
        }
    }

}
