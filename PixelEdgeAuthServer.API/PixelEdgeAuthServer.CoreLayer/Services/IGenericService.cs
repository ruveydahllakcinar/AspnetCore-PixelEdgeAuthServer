using PixelEdgeSharedLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.CoreLayer.Services
{
    public interface IGenericService<TEntity,TDto> where TEntity : class where TDto : class
    {
        Task<Response<TDto>> GetByIdAsync(int id);
        Task<Response<IEnumerable<TEntity>>> GetAllAsync();

        Task<Response<IEnumerable<TEntity>>> Where(Expression<Func<TEntity, bool>> predicate);
        Task<Response<TDto>>AddAsync(TEntity entity);

        Task<Response<NoDataDto>> Remove(TEntity entity);
        Task<Response<NoDataDto>> Update(TEntity entity);
    }
}
