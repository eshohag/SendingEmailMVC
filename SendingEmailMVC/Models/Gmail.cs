namespace SendingEmailMVC.Models
{
    public class Gmail
    {
        public int Id { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Subjects { get; set; }
        public string Body { get; set; }

    }
}