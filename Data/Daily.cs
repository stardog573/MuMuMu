namespace SHI_Daily_Archive.Data;
public interface IDbAccess
{
    Task<List<T>> LoadData<T, U>(string sql, U parameters, string? connectionString);
}
public class Daily
{
    public int id { get; set; }        
    public string? name { get; set; }
    public string? path { get; set; }
    public string? thumbnail { get; set; }
    public string? category1 { get; set; }
    public string? category2 { get; set; }
    public string? compatibility { get; set; }
    public string? version { get; set; }
    public string? developer { get; set; }
    public int runCount { get; set; }
    public int favCount { get; set; }
    public DateTime createdDate { get; set; }
    public string? tag { get; set; }
    public string? fileName { get; set; }
    public string? fileSize { get; set; }
}