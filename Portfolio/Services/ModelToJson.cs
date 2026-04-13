using Portfolio.Contracts;
using Portfolio.Models;
using System.Net.Http.Json;

namespace Portfolio.Services
{
    public class ModelToJson : IModelToJsonService
    {
        private readonly HttpClient _http;

        public ModelToJson(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Certificate>> GetCertificatesAsync()
        {
            try
            {
                var data = await _http.GetFromJsonAsync<List<Certificate>>("data/Certificates.json");
                return data ?? [];
            }
            catch
            {
                return [];
            }
        }

        public async Task<PersonalInfo> GetPersonalInfoAsync()
        {
            try
            {
                var data = await _http.GetFromJsonAsync<PersonalInfo>("data/Person.json");
                return data ?? new PersonalInfo();
            }
            catch
            {
                return new PersonalInfo();
            }
        }

        public async Task<List<Education>> GetEducationsAsync()
        {
            try
            {
                var data = await _http.GetFromJsonAsync<List<Education>>("data/Educations.json");
                return data ?? [];
            }
            catch
            {
                return [];
            }
        }

        public async Task<List<Experience>> GetExperiencesAsync()
        {
            try
            {
                var data = await _http.GetFromJsonAsync<List<Experience>>("data/Experiences.json");
                return data ?? [];
            }
            catch
            {
                return [];
            }
        }

        public async Task<List<Project>> GetProjectsAsync()
        {
            try
            {
                var data = await _http.GetFromJsonAsync<List<Project>>("data/Projects.json");
                return data ?? [];
            }
            catch
            {
                return [];
            }
        }

        public async Task<List<SkillCategory>> GetSkillCategoriesAsync()
        {
            try
            {
                var data = await _http.GetFromJsonAsync<List<SkillCategory>>("data/SkillCategories.json");
                return data ?? [];
            }
            catch
            {
                return [];
            }
        }

        public async Task<List<Skill>> GetSkillsAsync()
        {
            try
            {
                var data = await _http.GetFromJsonAsync<List<Skill>>("data/Skills.json");
                return data ?? [];
            }
            catch
            {
                return [];
            }
        }
    }
}
