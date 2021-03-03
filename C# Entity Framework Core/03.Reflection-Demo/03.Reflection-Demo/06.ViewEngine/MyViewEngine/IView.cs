namespace ViewEngineDemo.MyViewEngine
{
    public interface IView
    {
        string GetHtml(object model);
    }
}
