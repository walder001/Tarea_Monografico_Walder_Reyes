using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Tarea_Monografico_Walder_Reyes.Controllers.Base
{
    public abstract class RepoBase <TEntity> : IRepoBase<TEntity> where TEntity: class
    {
        private readonly DbContext _repoContext;
        public RepoBase(DbContext repoContext)
        {
            _repoContext = repoContext;
        }
        public IQueryable<TEntity> BuscarPorCondicion(Expression<Func<TEntity, bool>> expression)
        {
            return _repoContext.Set<TEntity>().Where(expression).AsNoTracking();
        }

        public async Task<TEntity> BuscarPorId(int? id)
        {
            var obj = await _repoContext.Set<TEntity>().FindAsync(id);
            // _repoContext.Entry(obj).State = EntityState.Detached;
            return obj;
        }

        public IQueryable<TEntity> BuscarTodo()
        {
            return _repoContext.Set<TEntity>().AsNoTracking();
        }

        public async Task Crear(TEntity entity)
        {
            try
            {
                //entity.Creado = DateTime.Now;
                //entity.CreadoPorId = 0;
               // entity.Modificado = DateTime.Now;
                //entity.ModificadoPorId = _user.GetUserID().ToInt();
               // entity.Inactivo = false;
                await _repoContext.Set<TEntity>().AddAsync(entity);
                await _repoContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
                //_logger.LogDebug(ex, "No se puedo crear registro.");
            }
        }

        public async Task Eliminar(TEntity entity)
        {
            try
            {
                //elimina definitivamente el registro
                //_repoContext.Set<TEntity>().Remove(entity);
                //await _repoContext.SaveChangesAsync();

                _repoContext.Set<TEntity>().Update(entity);
               // entity.Modificado = DateTime.Now;
                // entity.ModificadoPorId = _user.GetUserID().ToInt();
               // _repoContext.Entry(entity).Property(c => c.Creado).IsModified = false;
                //_repoContext.Entry(entity).Property(c => c.CreadoPorId).IsModified = false;
               // _repoContext.Entry(entity).Property(c => c.Inactivo).IsModified = false;
               // entity.Inactivo = true;
                await _repoContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
                //_logger.LogDebug(ex, "No se pudo elminar el registro.");
            }
        }

        /// <summary>
        /// Actualiza cualquier objeto 
        /// </summary>
        /// <param name="entity">Un objeto de clase.</param>
        /// <returns></returns>
        public async Task Modificar(TEntity entity)
        {
            try
            {
                _repoContext.Set<TEntity>().Update(entity);
             //   entity.Modificado = DateTime.Now;
                // entity.ModificadoPorId = _user.GetUserID().ToInt();
              //  _repoContext.Entry(entity).Property(c => c.Creado).IsModified = false;
                //_repoContext.Entry(entity).Property(c => c.CreadoPorId).IsModified = false;
              //  _repoContext.Entry(entity).Property(c => c.Inactivo).IsModified = false;
                await _repoContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
                //_logger.LogDebug(ex, "No se pudo actualizar el registro.");
            }
        }

    }
}
