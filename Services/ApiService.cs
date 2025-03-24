using mvc_estudiantes.Models;
using Newtonsoft.Json;

namespace mvc_estudiantes.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Student> GetStudentAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/studentsapi/{id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Student>(content);
            }

            return null;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            var response = await _httpClient.GetAsync("api/studentsapi");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Student>>(content);
            }

            return null;
        }

        public async Task<bool> UpdateStudent(int id, Student student)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/studentsapi/{id}", student);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> CreateStudent(Student student)
        {
            var response = await _httpClient.PostAsJsonAsync("api/studentsapi", student);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteStudent(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/studentsapi/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
