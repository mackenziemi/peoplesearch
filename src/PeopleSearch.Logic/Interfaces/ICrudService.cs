namespace PeopleSearch.Logic.Interfaces
{
    public interface ICrudService<T>: IInsertModel<T>
        , IGetModelById<T>
        , IUpdateModel<T>
        , IDeleteModel<T>
        , IGetAllModels<T>
    {
        
    }
}