namespace OnionVb02Library.Application.Mediatrs.Results.BookTagResults
{
    public class GetBookTagQueryResult
    {
        public int BookId { get; set; }
        public int TagId { get; set; }
        public string BookTitle { get; set; }
        public string TagName { get; set; }
    }
}