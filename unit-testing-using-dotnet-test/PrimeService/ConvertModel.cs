public class ConvertItemModel{
    private int id;
    private string name;
    private string remark;

    public ConvertItemModel(int id, string name, string remark)
    {
        this.Id = id;
        this.Name = name;
        this.Remark = remark;
    }

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string Remark { get => remark; set => remark = value; }
}