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

UpdateCategoryRequest updateCategoryRequest = new UpdateCategoryRequest() { Id = 5, Name = "Programlama 5" };
categoryManager.Update(updateCategoryRequest, 4);
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

CourseManager courseManager = new CourseManager(new InMemoryCourse());

Console.WriteLine("Kurs Listeleme :");
foreach (var c in courseManager.GetAll())
{
    Console.WriteLine(c.Title);
}

//AddCategoryRequest category = new AddCategoryRequest() { Id = 4, Name = "Programlama 4" };

//Console.WriteLine();
//Console.WriteLine("Kategori ekleme");

//categoryManager.Add(category);

//GetByIdCategoryResponse categoryGet = categoryManager.GetById(4);
//Console.WriteLine($"Eklenen kategori : Id {categoryGet.Id} - Name {categoryGet.Name}");


//Console.WriteLine();

//UpdateCategoryRequest updateCategoryRequest = new UpdateCategoryRequest() { Id = 5, Name = "Programlama 5" };
//categoryManager.Update(updateCategoryRequest, 4);
//Console.WriteLine("Kategori Güncellendi");

//Console.WriteLine("Güncel liste");

//foreach (var item in categoryManager.GetAll())
//{
//    Console.WriteLine(item.Name);
//}

//Console.WriteLine();
//DeleteCategoryRequest deleteCategoryRequest = new DeleteCategoryRequest() { Id = 4 };
//categoryManager.Delete(deleteCategoryRequest);
//Console.WriteLine("Kategori Silindi");

//Console.WriteLine("Güncel liste");

//foreach (var item in categoryManager.GetAll())
//{
//    Console.WriteLine(item.Name);
//}
