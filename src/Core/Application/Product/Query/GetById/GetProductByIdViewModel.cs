namespace Application.Product.Query.GetById
{
    public record GetProductByIdViewModel
    {
        public GetProductByIdViewModel(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
