using CourseApp.DAL;
using CourseApp.Migrations;
using CourseApp.Models;

Console.WriteLine("");




void AddGroup()
{
    AppDbContext context = new AppDbContext();

    var newGroup = new Group
    {
        No = "PB302",
        Limit = 10,
        StartDate = new DateTime(11, 12, 2023)
    };

    context.Groups.Add(newGroup);
    context.SaveChanges();
}

List<Group> GetGroups()
{
    AppDbContext context = new AppDbContext();

    return context.Groups.ToList();
}

Group GetFirstGroup()
{
    AppDbContext context = new AppDbContext();

    return context.Groups.First();
}

void DeleteGourp()
{
    AppDbContext context = new AppDbContext();

    var group = context.Groups.First();

    context.Groups.Remove(group);
    context.SaveChanges();
}

void UpdateGroupLimit()
{
    AppDbContext context = new AppDbContext();

    var group = context.Groups.First();

    group.Limit = 12;

    context.SaveChanges();
}