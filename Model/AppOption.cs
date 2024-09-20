namespace Model
{
    public class AppOption
    {
        public OptionId optionId { get; set; }
        public string value { get; set; }
        public string defaultValue { get; set; }
    }

    public enum OptionId
    {
        Language,
        Font
    }
}
