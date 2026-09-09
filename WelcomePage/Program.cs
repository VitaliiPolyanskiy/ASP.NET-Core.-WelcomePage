var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Welcome Page Middleware – компонент middleware-конвеєра,
// який надсилає клієнту деяку стандартну веб-сторінку
app.UseWelcomePage();

app.Run();
