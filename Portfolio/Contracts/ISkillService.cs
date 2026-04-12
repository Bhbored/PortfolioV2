using Portfolio.Models;

namespace Portfolio.Contracts
{
    public interface ISkillService
    {
        Task<List<SkillCategory>> GetALLSkillCategoriesAsync();
        Task<List<Skill>> GetAllSkillsAsync();
        Task<List<Skill>> GetSkillsByCategoryId(int CategorieId);
        Task<List<Skill>> GetTop3SkillsByCertificateId(int CertificateId);

    }
}
