public class SAI {
    private static int NextId = 1;
    public int Id { get; set; }
    public string SearchCriteria { get; set; }
    public List<string> Input { get; set; }
    public List<string> Answer { get; set; }
    public bool Result { get; set; } = false;

    public SAI() {
        Id = NextId++;
    }
}