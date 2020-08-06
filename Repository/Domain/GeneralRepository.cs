using System.Collections.Generic;
using System.Threading.Tasks;
namespace Domain.Repository
{
    interface GeneralRepository<t>
    {
        //Create
        t Create(t obj);
        Task<t> CreateAsync(t obj);
        //Read
        IEnumerable<t> Read(t obj);
        Task<IEnumerable<t>> ReadAsync(t obj);
        //Update
        t Update(t obj);
        Task<t> UpdateAsync(t obj);
        //Delete
        t Delete(t obj);
        Task<t> DeleteAsync(t obj);
    }
}