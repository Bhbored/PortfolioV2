using Portfolio.Contracts;
using Portfolio.Mockdata;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class SkillService : ISkillService
    {
        private List<SkillCategory> _skillCategories;
        private List<Skill> _skills;

        public SkillService()
        {
            _skillCategories = SkillData.Categories;
            _skills = SkillData.Skills;
        }
        public async Task<List<SkillCategory>> GetALLSkillCategoriesAsync()
        {
            return _skillCategories;
        }

        public async Task<List<Skill>> GetAllSkillsAsync()
        {
            return _skills;
        }

        public async Task<List<Skill>> GetSkillsByCategoryId(int CategorieId)
        {
            var skills = await GetAllSkillsAsync();
            return skills.Where(x => x.SkillCategoryID == CategorieId).ToList();
        }

        public async Task<List<Skill>> GetTop3SkillsByCertificateId(int CertificateId)
        {
            var skills = await GetAllSkillsAsync();
            return skills.Where(x => x.CertificateID == CertificateId)
                .OrderByDescending(x => x.MasteryLevel)
                .Take(3)
                .ToList();
        }
    }
}
