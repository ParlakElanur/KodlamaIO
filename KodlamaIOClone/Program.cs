using KodlamaIOClone.Business.Concretes;
using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Requests.CourseRequest;
using KodlamaIOClone.Business.Dtos.Requests.TutorRequest;
using KodlamaIOClone.Business.Dtos.Response;
using KodlamaIOClone.Business.Dtos.Responses.CourseResponse;
using KodlamaIOClone.Business.Dtos.Responses.TutorResponse;
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

GetByIdCategoryResponse categoryGetBy = categoryManager.GetById(4);
Console.WriteLine($"Eklenen kategori : Id {categoryGetBy.Id} - Name {categoryGetBy.Name}");


Console.WriteLine();

UpdateCategoryRequest updateCategoryRequest = new UpdateCategoryRequest() { Id = categoryGetBy.Id, Name = "Programlama Güncel" };
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

Console.WriteLine();
Console.WriteLine("KURS Işlemleri");

CourseManager courseManager = new CourseManager(new InMemoryCourse());

Console.WriteLine("Kurs Listeleme :");
foreach (var c in courseManager.GetAll())
{
    Console.WriteLine(c.Title);
}

AddCourseRequest course = new AddCourseRequest() { Id = 4, Title = ".Net", Description = ".Net Bootcamp",ImageUrl="",Price=0 };

Console.WriteLine();
Console.WriteLine("Kurs ekleme");

courseManager.Add(course);

GetByIdCourseResponse courseGetBy = courseManager.GetById(4);
Console.WriteLine($"Eklenen kurs : Id {courseGetBy.Id} - Name {courseGetBy.Title}");

Console.WriteLine();


UpdateCourseRequest updateCourseRequest = new UpdateCourseRequest() { Id = courseGetBy.Id, Title=".Net Core"};
courseManager.Update(updateCourseRequest);
Console.WriteLine("Kurs Güncellendi");

Console.WriteLine("Güncel liste");

foreach (var item in courseManager.GetAll())
{
    Console.WriteLine(item.Title);
}
Console.WriteLine();
DeleteCourseRequest deleteCourseRequest = new DeleteCourseRequest() { Id = 4 };
courseManager.Delete(deleteCourseRequest);
Console.WriteLine("Kurs Silindi");

Console.WriteLine("Güncel liste");

foreach (var item in courseManager.GetAll())
{
    Console.WriteLine(item.Title);
}

Console.WriteLine();
Console.WriteLine("EĞITMEN Işlemleri");

TutorManager tutorManager = new TutorManager(new InMemoryTutor());

Console.WriteLine("Eğitmen Listeleme :");
foreach (var c in tutorManager.GetAll())
{
    Console.WriteLine(c.FullName);
}
Console.WriteLine();
Console.WriteLine("Eğitmen ekleme");

AddTutorRequest tutor = new AddTutorRequest() { Id = 3, FullName = "Akın Kara" };

Console.WriteLine();
Console.WriteLine("Eğitmen ekleme");

tutorManager.Add(tutor);

GetByIdTutorResponse tutorGetBy = tutorManager.GetById(3);
Console.WriteLine($"Eklenen eğitmen : Id {tutorGetBy.Id} - FullName {tutorGetBy.FullName}");


Console.WriteLine();

UpdateTutorRequest updateTutorRequest = new UpdateTutorRequest() { Id = tutorGetBy.Id, FullName = "Akın Karabulut" };
tutorManager.Update(updateTutorRequest);
Console.WriteLine("Eğitmen Güncellendi");

Console.WriteLine("Güncel liste");

foreach (var item in tutorManager.GetAll())
{
    Console.WriteLine(item.FullName);
}

Console.WriteLine();
DeleteTutorRequest deleteTutorRequest = new DeleteTutorRequest() { Id = 2 };
tutorManager.Delete(deleteTutorRequest);
Console.WriteLine("Eğitmen Silindi");

Console.WriteLine("Güncel liste");

foreach (var item in tutorManager.GetAll())
{
    Console.WriteLine(item.FullName);
}