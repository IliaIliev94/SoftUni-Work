namespace ViewEngineDemo.MyViewEngine
{
    public interface IViewEngine
    {
        string GetHtml<T>(string viewContent, T model);
    }
}
