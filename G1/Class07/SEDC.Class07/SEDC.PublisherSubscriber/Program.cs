
using SEDC.PublisherSubscriber.Models;

Market tineks = new Market
{
    Name = "Tinex",
    CurrentProductType = ProductType.Food
};

Market vero = new Market
{
    Name = "Vero",
    CurrentProductType = ProductType.Cosmetics
};

Market neptun = new Market
{
    Name = "Neptun",
    CurrentProductType = ProductType.Electronic
};


User martin = new User("Martin", "Panovski", 29, "martin@gamil.com");
User antonio = new User("Antonio", "Novoselski", 19, "antonio@gamil.com");
User stojadin = new User("Stojadin", "Stojkov", 35, "stojadin@gamil.com");
User monika = new User("Monika", "Krstova", 22, "monika@gamil.com");


tineks.SubscribeToPromotion(martin.ReadPromotion, martin.Email);
tineks.SubscribeToPromotion(antonio.ReadPromotion, antonio.Email);
tineks.SubscribeToPromotion(stojadin.ReadPromotion, stojadin.Email);
tineks.Emails.ForEach(Console.WriteLine);


tineks.Send();

Thread.Sleep(5000);

tineks.Unsubscribe(antonio.ReadPromotion, antonio.Email);
tineks.Emails.ForEach(Console.WriteLine);


neptun.SubscribeToPromotion(monika.ReadPromotion, monika.Email);
neptun.Send();



vero.SubscribeToPromotion(martin.ReadPromotion, martin.Email);
vero.Send();



