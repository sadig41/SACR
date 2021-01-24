namespace Registration.Model
{
    public class PName
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string TName { get; set; }
        public string LName { get; set; }
        public string FullName => $"{FName} {SName} {TName} {LName}";
    }
}