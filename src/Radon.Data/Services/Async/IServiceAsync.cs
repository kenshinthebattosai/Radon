﻿using System;
using Radon.Data.Contracts;

namespace Radon.Data.Services.Async
{
    /// <summary>
    /// An async repository for items, which allows for finding and deletion of entities by keyValues, 
    /// in addition to querying and basic CRUD functionality.
    /// </summary>
    /// <typeparam name="T">The type of items this repository is for.</typeparam>
    public interface IServiceAsync<T>
        : IService<T>, ICreatableServiceAsync<T>, IRetrievableServiceAsync<T>, IUpdatableServiceAsync<T>,
        ICreatableUpdatableServiceAsync<T>, IDeletableServiceAsync<T>
        where T : ICreatable, IRetrievable, IUpdatable, IDeletable
    {
    }

    /// <summary>
    /// An async repository for items, which allows for finding and deletion of entities by Id, 
    /// in addition to querying and basic CRUD functionality.
    /// </summary>
    /// <typeparam name="T">The type of items for which this repository is for.</typeparam>
    /// <typeparam name="TKey">The type of Id that is used for indexing.</typeparam>
    public interface IServiceAsync<T, in TKey>
        : IService<T, TKey>, ICreatableServiceAsync<T>, IRetrievableServiceAsync<T, TKey>, IUpdatableServiceAsync<T, TKey>,
        ICreatableUpdatableServiceAsync<T, TKey>, IDeletableServiceAsync<T, TKey>
        where T : ICreatable<TKey>, IRetrievable<TKey>, IUpdatable<TKey>, IDeletable<TKey>
        where TKey : IComparable
    {
    }
}