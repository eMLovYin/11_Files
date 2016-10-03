namespace _11_Files
{
    public interface IFileRepository : IStockRepository, IFileOperation
    {
        string StockFileName(int v);
        object StockFileName(Stock hp);
    }
}