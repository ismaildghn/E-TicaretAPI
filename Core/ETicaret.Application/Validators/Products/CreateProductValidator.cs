using ETicaret.Application.ViewModels.Products;
using FluentValidation;


namespace ETicaret.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {

        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen ürün adını boş bırakmayınız.")
                .MinimumLength(5)
                .MaximumLength(150)
                .WithMessage("Lütfen ürün adını 5 ile 150 karakter arasında giriniz.");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen stok bilgisi giriniz.")
                .Must(s => s >= 0)
                .WithMessage("Stok bilgisi negatif olamaz");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen fiyat bilgisi giriniz")
                .Must(s => s >= 0)
                .WithMessage("Fiyat bilgisi negatif olamaz");
        }
    }
}
