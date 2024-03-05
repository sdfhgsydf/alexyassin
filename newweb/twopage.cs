using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;

public class EditModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public class InputModel
    {
        [Required(ErrorMessage = "الاسم الكامل مطلوب")]
        public string NameFull { get; set; }

        [Required(ErrorMessage = "العنوان مطلوب")]
        public string Address { get; set; }

        [Required(ErrorMessage = "الشهادة مطلوبة")]
        public string Shada { get; set; }

        public string[] MaritalStatus { get; set; }

        [Required(ErrorMessage = "سنة التخرج مطلوبة")]
        public DateTime GraduationYear { get; set; }

        [Required(ErrorMessage = "التاريخ مطلوب")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "الرقم التعيين مطلوب")]
        public int Number { get; set; }
    }

    public void OnGet(string namefull, string address, string shada, string[] marital_status, DateTime graduation_year, DateTime date, int number)
    {
        Input = new InputModel
        {
            NameFull = namefull,
            Address = address,
            Shada = shada,
            MaritalStatus = marital_status,
            GraduationYear = graduation_year,
            Date = date,
            Number = number
        };
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

       

        return RedirectToPage("/Index");
    }
}
