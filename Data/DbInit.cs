using Demolice.Data.Enums;

namespace Demolice.Data;

public class DbInit(IServiceProvider sp) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await using var scope = sp.CreateAsyncScope();
        var db = scope.ServiceProvider.GetService<AppDbContext>();

        if (await db.Database.EnsureCreatedAsync(stoppingToken))
        {
            db.Products.Add(new Product { Name = "iPhone 14", Category = "Smartphones", Price = 999.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Samsung Galaxy S22", Category = "Smartphones", Price = 899.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "LG OLED TV", Category = "Televisions", Price = 1499.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Sony WH-1000XM4", Category = "Headphones", Price = 349.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Dell XPS 13", Category = "Laptops", Price = 1299.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Apple MacBook Pro", Category = "Laptops", Price = 1999.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Google Pixel 6", Category = "Smartphones", Price = 599.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Samsung Galaxy Tab S8", Category = "Tablets", Price = 699.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Apple iPad Pro", Category = "Tablets", Price = 1099.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Microsoft Surface Pro 8", Category = "Tablets", Price = 1199.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Bose QuietComfort 35 II", Category = "Headphones", Price = 299.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Apple Watch Series 7", Category = "Smartwatches", Price = 399.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Samsung Galaxy Watch 4", Category = "Smartwatches", Price = 249.99m, Description = "...", Added = DateTime.UtcNow });
            db.Products.Add(new Product { Name = "Fitbit Charge 5", Category = "Fitness Trackers", Price = 179.99m, Description = "...", Added = DateTime.UtcNow });

            db.Subscriptions.Add(new Subscription(){Id = Guid.Parse("00000000-0000-4000-0000-999999990003"), UserId = 1, StartDate = DateTime.UtcNow.AddDays(-100), EndDate = DateTime.UtcNow.AddDays(100), Plan = "basic"});
            db.Subscriptions.Add(new Subscription(){Id = Guid.Parse("00000000-0000-4000-0000-888888880001"), UserId = 2, StartDate = DateTime.UtcNow.AddYears(-3), EndDate = DateTime.UtcNow.AddYears(-2), Plan = "basic"});
            db.Subscriptions.Add(new Subscription(){Id = Guid.Parse("00000000-0000-4000-0000-888888880002"), UserId = 2, StartDate = DateTime.UtcNow.AddMonths(-20), EndDate = DateTime.UtcNow.AddMonths(-10), Plan = "premium"});
            db.Subscriptions.Add(new Subscription(){Id = Guid.Parse("00000000-0000-4000-0000-888888880003"), UserId = 2, StartDate = DateTime.UtcNow.AddDays(-50), EndDate = DateTime.UtcNow.AddDays(150), Plan = "premium"});
            db.Subscriptions.Add(new Subscription(){Id = Guid.Parse("00000000-0000-4000-0000-555555550002"), UserId = 3, StartDate = DateTime.UtcNow.AddMonths(-18), EndDate = DateTime.UtcNow.AddMonths(-6), Plan = "basic"});
            db.Subscriptions.Add(new Subscription(){Id = Guid.Parse("00000000-0000-4000-0000-555555550003"), UserId = 3, StartDate = DateTime.UtcNow.AddDays(-30), EndDate = DateTime.UtcNow.AddDays(110), Plan = "basic"});
            db.Subscriptions.Add(new Subscription(){Id = Guid.Parse("00000000-0000-4000-0000-111111110001"), UserId = 4, StartDate = DateTime.UtcNow.AddYears(-2), EndDate = DateTime.UtcNow.AddYears(-1), Plan = "premium"});
            db.Subscriptions.Add(new Subscription(){Id = Guid.Parse("00000000-0000-4000-0000-222222220001"), UserId = 5, StartDate = DateTime.UtcNow.AddYears(-5), EndDate = DateTime.UtcNow.AddYears(-4), Plan = "basic"});
            db.Subscriptions.Add(new Subscription(){Id = Guid.Parse("00000000-0000-4000-0000-222222220002"), UserId = 5, StartDate = DateTime.UtcNow.AddMonths(-22), EndDate = DateTime.UtcNow.AddMonths(-8), Plan = "premium"});
            db.Subscriptions.Add(new Subscription(){Id = Guid.Parse("00000000-0000-4000-0000-222222220003"), UserId = 5, StartDate = DateTime.UtcNow.AddDays(-10), EndDate = DateTime.UtcNow.AddDays(90), Plan = "basic"});

            db.Users.Add(new User {Name = "Jan Novák", Email = "jannovak@email.cz", Language = "cs", FavoriteCategory = "Smartphones"});
            db.Users.Add(new User {Name = "Petr Svoboda", Email = "petrs@email.cz", Language = "cs", FavoriteCategory = "Laptops"});
            db.Users.Add(new User {Name = "Jana Novotná", Email = "jnovot@gmail.com", Language = "sk", FavoriteCategory = "Tablets"});
            db.Users.Add(new User {Name = "Martin Horák", Email = "hor@ak.cz", Language = "sk", FavoriteCategory = "Headphones"});
            db.Users.Add(new User {Name = "Anna Kováčová", Email = "kovyna@mail.cz", Language = "cz", FavoriteCategory = "Smartwatches"});

            db.Emails.Add(new Email {Subject = "Připomenutí schůzky", Text = "Jen připomínám zítřejší schůzku v 10 hodin v zasedací místnosti. Nezapomeňte si přinést reporty.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Oběd dnes?", Text = "Nechceš dnes zajít na oběd? Můžeme vyzkoušet tu novou restauraci vedle kanceláře kolem půl jedné.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Faktura dorazila", Text = "Obdrželi jsme vaši fakturu za poslední služby. Úhrada proběhne do deseti pracovních dnů.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Nová pravidla", Text = "Přikládám aktualizovaná pravidla společnosti. Začínají platit od příštího pondělí, prosím přečtěte si je.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Chyba v přihlášení", Text = "Přihlašovací formulář selhává při zadání speciálních znaků. Můžete to někdo prosím ověřit?", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Všechno nejlepší", Text = "Přejeme krásné narozeniny a hodně štěstí do dalšího roku! Užívej si svůj den naplno.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Výpadek serveru", Text = "Dnes v noci došlo k nečekanému výpadku mezi 1:00 a 2:15. Detailní zprávu pošleme brzy.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Týdenní shrnutí", Text = "Zde je krátké shrnutí výsledků týmu za tento týden a plánovaných úkolů na příští týden.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Krátký dotaz", Text = "Víte, jestli měsíční report zahrnuje také data z externích kampaní, nebo pouze interní?", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Zpětná vazba", Text = "Klient je s poslední dodávkou velmi spokojený. Oceňuje hlavně naši rychlost a přehlednost.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Plán svátků", Text = "Přikládám oficiální kalendář svátků na příští rok. Naplánujte si prosím dovolené včas.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Důležité upozornění", Text = "Kvůli nové bezpečnostní politice je nutné si do pátku změnit heslo, jinak dojde k blokaci účtu.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Připomínka", Text = "Nezapomeňte dnes odevzdat výkazy práce, abychom mohli uzavřít týdenní účetnictví.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Prezentace", Text = "Nahrál jsem návrh prezentace do sdílené složky. Prosím okomentujte do čtvrtka.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Nový kontakt", Text = "Obraťte se prosím na Marka Jensena kvůli integraci. Už je seznámen s aktuálním problémem.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Cesta do Prahy", Text = "Žádám o schválení cesty do pražské kanceláře příští měsíc kvůli zahájení nového projektu.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Chybí soubor", Text = "Nemohu najít soubor z března. Mohl být omylem smazán? Prosím zkontrolujte složku.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Děkuji moc", Text = "Děkuji za pomoc během nasazení nové verze. Vaše práce byla opravdu přínosná!", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Teambuilding", Text = "Plánujeme malý teambuilding na příští pátek. Dejte vědět, jestli máte nějaké nápady.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});
            db.Emails.Add(new Email {Subject = "Aktualizace systému", Text = "IT provede v sobotu večer aktualizaci systému. Nezapomeňte uložit práci a vypnout počítač.", Date = DateTime.Now, Mood = Mood.Unknown, Priority = Priority.Unknown});

            await db.SaveChangesAsync(stoppingToken);
        }
    }
}