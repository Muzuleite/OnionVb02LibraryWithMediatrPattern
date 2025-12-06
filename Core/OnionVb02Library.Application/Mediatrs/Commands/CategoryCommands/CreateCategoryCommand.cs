using MediatR;
    public class CreateCategoryCommand : IRequest
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
