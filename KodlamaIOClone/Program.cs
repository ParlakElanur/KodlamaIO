using KodlamaIOClone.Business.Concretes;
using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Response;
using KodlamaIOClone.DataAccess.Concretes;

Console.WriteLine("KATEGORI Işlemleri");

CategoryManager categoryManager = new CategoryManager(new InMemoryCategory());

Console.WriteLine("Kategori Listeleme :");
foreach (var c in categoryManager.GetAll())
{
    Console.WriteLine(c.Name);
}

AddCategoryRequest category = new AddCategoryRequest() { Id = 4, Name = "Programlama 4" };

Console.WriteLine();
Console.WriteLine("Kategori ekleme");

categoryManager.Add(category);

GetByIdCategoryResponse categoryGet = categoryManager.GetById(4);
Console.WriteLine($"Eklenen kategori : Id {categoryGet.Id} - Name {categoryGet.Name}");


Console.WriteLine();

GetByIdCategoryResponse categoryId = categoryManager.GetById(4);

UpdateCategoryRequest updateCategoryRequest = new UpdateCategoryRequest() { Id = categoryId.Id, Name = "Programlama Güncel" };
categoryManager.Update(updateCategoryRequest);
Console.WriteLine("Kategori Güncellendi");

Console.WriteLine("Güncel liste");

foreach (var item in categoryManager.GetAll())
{
    Console.WriteLine(item.Name);
}

Console.WriteLine();
DeleteCategoryRequest deleteCategoryRequest = new DeleteCategoryRequest() { Id = 4 };
categoryManager.Delete(deleteCategoryRequest);
Console.WriteLine("Kategori Silindi");

Console.WriteLine("Güncel liste");

foreach (var item in categoryManager.GetAll())
{
    Console.WriteLine(item.Name);
}

Console.WriteLine("KURS Işlemleri");


