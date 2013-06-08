using System.Linq;

namespace RepositoryPatternDotNet
{
    /// <summary>Represents a repository of entities.</summary>
    /// <typeparam name="TEntity">The type of entity in the repository.</typeparam>
    public interface IRepository<TEntity> : IQueryable<TEntity>
    {
        /// <summary>Delete an entity from the repository.</summary>
        /// <param name="entity">The entity to delete.</param>
        /// <remarks>If the entity does not exist in the repository then the behaviour is implementation defined.</remarks>
        void Delete(TEntity entity);

        /// <summary>Find an entity in the repository.</summary>
        /// <param name="primaryKeyValues">Values representing the primary key of the entity to find.</param>
        /// <remarks>If the entity does not exist in the repository then the behaviour is implementation defined.</remarks>
        /// <returns>The entity.</returns>
        TEntity Find(params object[] primaryKeyValues);

        /// <summary>Insert an entity into the repository.</summary>
        /// <param name="entity">The entity to insert.</param>
        /// <remarks>If the entity already exists in the repository then the behaviour is implementation defined.</remarks>
        void Insert(TEntity entity);

        /// <summary>Update an entity in the repository.</summary>
        /// <param name="entity">The entity to update.</param>
        /// <remarks>If the entity does not exist in the repository then the behaviour is implementation defined.</remarks>
        void Update(TEntity entity);
    }
}