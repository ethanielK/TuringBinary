namespace WPF__数据校验与转换
{
    public class EmployeeSatisfaction
    {
        public string Name { get; set; }
        public SatisfactionType Satisfaction { get; set; }
    }

    public enum SatisfactionType
    {
        Anxious,
        Cold,
        Nerd,
        Smiling,
        Sos
    };
}
