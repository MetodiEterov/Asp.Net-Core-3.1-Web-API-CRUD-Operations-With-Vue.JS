using System.Collections.Generic;

using Entities.Models;

namespace Entities.Contracts
{
    /// <summary>
    /// IOwnerMemoryCache interface
    /// </summary>
    public interface IOwnerMemoryCache
    {
        /// <summary>
        /// SetOwnerMemoryCache contract
        /// </summary>
        /// <param name="windowsGroups"></param>
        void SetOwnerMemoryCache(IEnumerable<Owner> windowsGroups);

        /// <summary>
        /// GetOwnerMemoryCache contract
        /// </summary>
        /// <returns></returns>
        IEnumerable<Owner> GetOwnerMemoryCache();
    }
}
