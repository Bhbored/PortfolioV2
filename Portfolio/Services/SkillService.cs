using Portfolio.Contracts;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class SkillService : ISkillService
    {
        private readonly IModelToJsonService _modelToJsonService;

        public SkillService(IModelToJsonService modelToJsonService)
        {
            _modelToJsonService = modelToJsonService;
        }
        public async Task<List<SkillCategory>> GetALLSkillCategoriesAsync()
        {

            return await _modelToJsonService.GetSkillCategoriesAsync();
        }

        public async Task<List<Skill>> GetAllSkillsAsync()
        {
            return await _modelToJsonService.GetSkillsAsync();
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
