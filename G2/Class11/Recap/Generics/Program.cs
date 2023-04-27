using Generics.Entities;
using Generics.Services;

PersonService<Male> maleService = new PersonService<Male>();
PersonService<Female> femaleService = new PersonService<Female>();

Male male = new Male()
{
    Id = 1,
    Age = 31,
    FullName = "Bob Bobsky"
};

Female female = new Female()
{
    Id = 2,
    FullName = "Mary Popinson",
    IsMarried = true
};

maleService.Print(male);
femaleService.Print(female);