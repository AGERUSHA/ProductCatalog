# ProductCatalog

2-апта, Тапсырма 2: Каталог веб-қосымшасын Razor және Partial Views арқылы әзірлеу.

Орындаған: Агадинова Ақерке Қайратқызы, ИСК 241, Абай атындағы Қазақ Ұлттық Педагогикалық Университеті.

- Технология: ASP.NET Core MVC, .NET 8.0, Bootstrap 5
- Модель: `Models/Product.cs` — Id, Name, Price, Category, IsAvailable
- Контроллер: `Controllers/ProductController.cs`
  - `/Product/Index` — тауарлар каталогы (санат бойынша сүзгі: `?category=...`)
  - `/Product/Details/{id}` — тауар туралы толық мәлімет
- Strongly typed view: `Views/Product/Index.cshtml` (`@model List<Product>`), `Views/Product/Details.cshtml` (`@model Product`)
- ViewData / ViewBag: бет атауы, санаттар тізімі, таңдалған санат, қоймадағы тауарлар саны
- Layout: `Views/Shared/_Layout.cshtml` — Bootstrap негізіндегі ортақ header, навигация, footer
- Partial View: `Views/Shared/_ProductCard.cshtml` — әр тауардың карточкасы (`<partial name="_ProductCard" model="product" />`)

## Іске қосу

```bash
dotnet run
```
