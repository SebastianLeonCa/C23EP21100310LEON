using Caso2Scaffolding21100310LEON.Data;

namespace Caso2Scaffolding21100310LEON.Interfaces
{
    public interface ICompetencyRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Competency>> GetAll();
        Task<int> Insert(Competency competency);
        Task<bool> Update(Competency competency);
    }
}