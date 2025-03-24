using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using mvc_estudiantes.Data;
using mvc_estudiantes.Models;
using mvc_estudiantes.Services;

namespace mvc_estudiantes.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApiService _apiService;
        public StudentsController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _apiService.GetAllStudentsAsync();
            return View(students);
        }

        public async Task<IActionResult> Details(int id)
        {
            var student = await _apiService.GetStudentAsync(id);
            if(student == null)
                return NotFound();

            return View(student);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var student = await _apiService.GetStudentAsync(id);
            if(student == null)
                return NotFound();

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Dni,BirthDate,FirstName,LastName,Email")] Student student)
        {
            if (id != student.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                var updatedStudent = await _apiService.UpdateStudent(id, student);

                if(!updatedStudent)
                    return NotFound();
                
                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }


    }
}
