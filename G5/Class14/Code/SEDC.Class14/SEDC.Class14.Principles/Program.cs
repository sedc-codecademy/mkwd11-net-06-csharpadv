using SEDC.Class14.Principles.Solid;

// SOLID Principles
// SOLID is an acronym for five principles: 

// Single Responsibility Principle
// Open-Closed Principle
// Liskov Substitution Principle
// Interface Segregation Principle
// Dependency Inversion Principle

// These principles aim to promote modularity, flexibility, and maintainability in object - oriented design.



// DRY (Don't Repeat Yourself)

// The DRY principle is a rule that we need to avoid and try not to repeat implementation in our code.
// Every piece of logic must have a single and unique representation in our code.



// KISS (Keep It Simple, Stupid)

// The KISS principle advocates for simplicity in design and implementation.
// It suggests that code should be kept as simple as possible, avoiding unnecessary complexity and over - engineering.
// Simpler code tends to be easier to understand, debug, and maintain.



// YAGNI (You Ain't Gonna Need It)

// YAGNI encourages developers to avoid adding functionality or features until they are actually needed.
// It advises against speculation and premature optimization, focusing instead on the current requirements and avoiding unnecessary complexity or bloat.


LiskovSubstitutionAppBad liskovSubstitutionAppBad = new LiskovSubstitutionAppBad();
//liskovSubstitutionAppBad.Run();


LiskovSubstitutionAppGood liskovSubstitutionAppGood = new LiskovSubstitutionAppGood();
//liskovSubstitutionAppGood.Run();

IConvenientMarket basicMarket = new BasicMarket();

IGreenMarket basicMarket1 = new BasicMarket();
IGreenMarket basicMarket2 = new GreenMarketGood();
IGreenMarket greenMarket3 = new SuperMarketGood();

NotificationService notificationService = new NotificationService();
notificationService.Send();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

//IMessageSender emailService = new EmailSenderService();
//IMessageSender smsSenderService = new SmsSenderService();
//IMessageSender facebookSenderService = new FacebookMessageSenderService();

NotificationSenderService emailSender = new NotificationSenderService(new EmailSenderService());
NotificationSenderService facebookSender = new NotificationSenderService(new FacebookMessageSenderService());
NotificationSenderService smsSender = new NotificationSenderService(new SmsSenderService());
emailSender.Send();
facebookSender.Send();
smsSender.Send();


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Sending services from outside
List<IMessageSender> msgSenders = new List<IMessageSender>() {
    new EmailSenderService(),
    new SmsSenderService(),
    new FacebookMessageSenderService()
};

NotificationSenderMultipleService notificationSenderMultipleGood = new NotificationSenderMultipleService(msgSenders);
notificationSenderMultipleGood.Send();