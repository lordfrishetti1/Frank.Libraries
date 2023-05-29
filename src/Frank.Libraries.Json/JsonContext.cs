﻿using System.IO.Abstractions;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.Json;

public class JsonContext<TEntity> : IJsonContext<TEntity> where TEntity : JsonEntity
{
    private readonly string _filePath;
    private readonly IFileSystem _fileSystem;
    private readonly JsonConfiguration _options;
    private readonly List<TEntity> _tempCollection;
    private readonly IJsonSerializer _jsonSerializer = new JsonSerializer();

    private List<TEntity> _collection;
    private bool _unsavedChanges;

    public JsonContext(IOptions<JsonConfiguration> options, IFileSystem fileSystem)
    {
        _fileSystem = fileSystem;
        _options = options!.Value;
        _collection = new List<TEntity>();
        _tempCollection = new List<TEntity>();

        if (string.IsNullOrWhiteSpace(_options.Folder))
        {
            _options.Folder = _fileSystem.Path.Combine(_fileSystem.Directory.GetCurrentDirectory(), "Data");
        }

        _filePath = _fileSystem.Path.Combine(_options.Folder, typeof(TEntity).Name + ".json");
        Setup();
    }

    public List<TEntity> GetList() =>
        //if (!_collection.Any())
        //    _collection = _fileSystem.File.ReadAllText(_filePath).FromJson<List<TEntity>>();
        //return _collection;
        _jsonSerializer.Deserialize<List<TEntity>>(_fileSystem.File.ReadAllText(_filePath));

    public IEnumerable<TEntity> GetCollection() =>
        //if (!_collection.Any())
        //    _collection = _fileSystem.File.ReadAllText(_filePath).FromJson<List<TEntity>>();
        //return _collection;
        _jsonSerializer.Deserialize<List<TEntity>>(_fileSystem.File.ReadAllText(_filePath)).AsQueryable();

    public IQueryable<TEntity> GetQueryable() =>
        //if (!_collection.Any())
        //    _collection = _fileSystem.File.ReadAllText(_filePath).FromJson<List<TEntity>>();
        //return _collection.AsQueryable();
        _jsonSerializer.Deserialize<List<TEntity>>(_fileSystem.File.ReadAllText(_filePath)).AsQueryable();

    public TEntity GetById(Guid id) => _collection.FirstOrDefault(x => x.Id == id)!;

    public void Delete(Guid id)
    {
        var entity = _collection.FirstOrDefault(x => x.Id == id)!;
        _collection.Remove(entity);
        _unsavedChanges = true;
    }

    public void Add(TEntity item)
    {
        _tempCollection.Add(item);
        _unsavedChanges = true;
    }

    public void Add(List<TEntity> items)
    {
        _tempCollection.AddRange(items);
        _unsavedChanges = true;
    }

    public bool SaveChanges()
    {
        if (!_unsavedChanges)
        {
            return true;
        }

        GetCollection();
        _collection.AddRange(_tempCollection);
        _fileSystem.File.WriteAllText(_filePath, _jsonSerializer.Serialize(_collection));
        _tempCollection.Clear();

        GetCollection();

        _unsavedChanges = false;
        return true;
    }

    public void DiscardChanges()
    {
        _tempCollection.Clear();
        _unsavedChanges = false;
    }

    private void Setup()
    {
        if (!_fileSystem.Directory.Exists(_options.Folder))
        {
            _fileSystem.Directory.CreateDirectory(_options.Folder!);
        }

        if (!_fileSystem.File.Exists(_filePath))
        {
            _fileSystem.File.WriteAllText(_filePath, _jsonSerializer.Serialize(new List<TEntity>()));
        }

        _collection = _jsonSerializer.Deserialize<List<TEntity>>(_fileSystem.File.ReadAllText(_filePath));
    }
}