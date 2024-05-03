namespace PharmacyApi.Infrastructure;

public abstract class EntityControllerBase<TEntity, TAddEditViewModel, TViewModel, TController> 
           : CrudControllerBase<TViewModel, TEntity, TController> where TEntity 
           : BaseEntity where TController 
           : class where TViewModel 
           : ViewModelBase where TAddEditViewModel
           : AddEditViewModelBase
{
    private readonly IMapper _mapper;
    public EntityControllerBase(ILogger<TController> logger, IMapper mapper) : base(logger, mapper)
    {
         _mapper = mapper;
    }

    [HttpPost]
    public async Task<dynamic> Create(TAddEditViewModel viewModel)
    {
        var entity = _mapper.Map<TAddEditViewModel, TEntity>(viewModel);

        await Validation(entity);

        return await base.Create(entity);
    }

    [Route("{id}")]
    [HttpPut]
    public async Task<dynamic> Update(Guid id, TAddEditViewModel viewModel)
    {
        var entity = _mapper.Map<TAddEditViewModel, TEntity>(viewModel);

        await Validation(entity);

        return await base.Update(id, entity);
    }

    [Route("delete/soft/{id}")]
    [HttpDelete]
    public virtual async Task SoftDelete(Guid id)
    {
        var entity = await MyDatabaseContext.Set<TEntity>().SingleAsync(x => x.Id == id);
        entity.IsDeleted = true;

        await MyDatabaseContext.SaveChangesAsync();
    }

    protected abstract Task Validation(TEntity entity);
}
