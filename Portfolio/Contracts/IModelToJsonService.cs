using Portfolio.Models;

namespace Portfolio.Contracts
{
    public interface IModelToJsonService
    {
        Task<PersonalInfo> GetPersonalInfoAsync();
        Task<List<SkillCategory>> GetSkillCategoriesAsync();
        Task<List<Skill>> GetSkillsAsync();
        Task<List<Project>> GetProjectsAsync();
        Task<List<Experience>> GetExperiencesAsync();
        Task<List<Education>> GetEducationsAsync();
        Task<List<Certificate>> GetCertificatesAsync();
    }
}
