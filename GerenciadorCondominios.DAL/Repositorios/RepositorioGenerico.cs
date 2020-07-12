using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GerenciadorCondominios.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorCondominios.DAL.Repositorios
{
    public class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {
        private readonly Contexto _Contexto;

        public RepositorioGenerico(Contexto contexto)
        {
            _Contexto = contexto;
        }

        public async Task Atualizar(TEntity entity)
        {
            try
            {
                _Contexto.Set<TEntity>().Update(entity);
                await _Contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                
                throw ex; 
            }
        }

        public async Task Excluir(TEntity entity)
        {
            try
            {
                _Contexto.Set<TEntity>().Remove(entity);
                await _Contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                
                throw ex; 
            }
        }

        public async Task Excluir(int id)
        {
            try
            {
                var entity = await PegarPeloId(id);
                _Contexto.Set<TEntity>().Remove(entity);
                await _Contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                
                throw ex; 
            }
        }

        public async Task Excluir(string id)
        {
            try
            {
                var entity = await PegarPeloId(id);
                _Contexto.Set<TEntity>().Remove(entity);
                await _Contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                
                throw ex; 
            }
        }

        public async Task Inserir(TEntity entity)
        {
            try
            {
                await _Contexto.AddAsync(entity);
                await _Contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                
                throw ex; 
            }
        }

        public async Task<TEntity> PegarPeloId(int id)
        {
            try
            {
                return await _Contexto.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                
                throw ex; 
            }
        }

        public async Task<TEntity> PegarPeloId(string id)
        {
            try
            {
                return await _Contexto.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                
                throw ex; 
            }
        }

        public async Task<IEnumerable<TEntity>> PegarTodos()
        {
            try
            {
                return await _Contexto.Set<TEntity>().ToListAsync();
            }
            catch (Exception ex)
            {
                
                throw ex; 
            }
        }
    }
}