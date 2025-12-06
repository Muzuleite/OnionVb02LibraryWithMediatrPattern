namespace OnionVb02Library.Application.DtoClasses
{
    public class BookTagDto : BaseDto
    {
        public int BookId { get; set; }
        public int TagId { get; set; }

        public string BookTitle { get; set; }
        public string TagName { get; set; }
    }

}
