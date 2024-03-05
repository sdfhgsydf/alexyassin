using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyProjectName.Data; // تغيير MyProjectName إلى اسم مشروعك

namespace MyProjectName.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

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

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var formData = new FormData
            {
                NameFull = Input.NameFull,
                Address = Input.Address,
                Shada = Input.Shada,
                MaritalStatus = string.Join(",", Input.MaritalStatus),
                GraduationYear = Input.GraduationYear,
                Date = Input.Date,
                Number = Input.Number
            };

            _context.FormDatas.Add(formData);
            _context.SaveChanges();

            return RedirectToPage("/SuccessPage");
        }
    }
}
