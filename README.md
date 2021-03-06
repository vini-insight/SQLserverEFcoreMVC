# SQLserverEFcoreMVC
SQLserverEFcoreMVC

SQL server Entity Framework core Migrations MVC

projeto criado com o comando

    dotnet new mvc

Usando o modelo Code First do Enntity Framework

    [X] code first
    [ ] model first
    [ ] database first


Dependencias:

    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 3.1.1

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.1

    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 3.1.1


EFcore --version 3.1.3 INSTALADO GLOBALMENTE:

    dotnet ef migrations add CreateDatabase

    dotnet ef database update



tentar instalar globalmente

    dotnet tool install --global dotnet-aspnet-codegenerator --version 3.1.1

pra ver se não precisa isntalar o pacote abaixo?

    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 3.1.1



https://github.com/gavilanch/example-scaffolding-with-dotnet-cli

Baseado nos seguintes Tutoriais:

    https://www.youtube.com/watch?v=knCH5cEo-Vo
    https://gavilan.blog/2018/04/28/asp-net-core-2-doing-scaffolding-with-dotnet-cli-aspnet-codegenerator/
    https://github.com/gavilanch/example-scaffolding-with-dotnet-cli

