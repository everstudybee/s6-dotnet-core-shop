<div align="center">
    <h1>.NET Core Shop</h1>
    <h3>
        <a href="#">
            Live demo
        </a>
        <span> | </span>
        <a href="https://github.com/everstudybee/s6-dotnet-core-shop">
            GitHub
        </a>
    </h3>
    <p>Web app - Shop</p>
    <p><b>Status:</b> 🛠️ The application is in active development 🛠️</p>
    <br>
    <p>Technologies and tools:</p>
    <p>
        <img src="docs/img/dotnet.svg" width="40" height="40" alt="dotnet"/>
        <img src="docs/img/csharp.svg" width="40" height="40" alt="csharp"/>
        <img src="docs/img/sqlserver.svg" width="40" height="40" alt="sqlserver"/>
        <img src="docs/img/html5.svg" width="40" height="40" alt="html"/>
        <img src="docs/img/css3.svg" width="40" height="40" alt="css"/>
        <img src="docs/img/materialize.svg" width="40" height="40" alt="materialize"/>
        <img src="docs/img/tailwind.svg" width="40" height="40" alt="tailwind"/>
        <img src="docs/img/js.svg" width="40" height="40" alt="javascript"/>
        <img src="docs/img/md.svg" width="40" height="40" alt="markdown"/>
        <img src="docs/img/git.svg" width="40" height="40" alt="git"/>
        <img src="docs/img/github.svg" width="40" height="40" alt="github"/>
        <img src="docs/img/vs.svg" width="40" height="40" alt="visualstudio2022"/>
        <img src="docs/img/reshaper.svg" width="40" height="40" alt="reshaper"/>
    </p>
</div>
<br>

## Documentation

### Git, versioning and tagging

1. [Course Git [PL]](https://youtube.com/playlist?list=PLj-pbEqbjo6AKsJ8oE2pvIqsb15mxdrxs)
2. [Conventional Commits - Nazewnictwo commit w Git](https://www.conventionalcommits.org/en/v1.0.0/)
3. [Semantic Versioning - Numerowanie wersji](https://semver.org/)
4. [Tagging - Git, Releases - GitHub](https://youtu.be/Wq_zrz7jV80)

### Frameworks CSS

1. [ASP.NET Core documentation page](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0)
2. [Material Design - project website](https://material.io/)
   1. [Material Design - Web Develop](https://material.io/develop/web)
   2. [Mateerialize - CSS framework based on Material Design](https://materializecss.com/)
3. [Bootstrap](https://getbootstrap.com/)
4. [Material Design for Bootstrap v5 & v4](https://mdbootstrap.com/)
5. [Pure.CSS - light CSS framework](https://purecss.io/)
6. Frameworks overview
   1. [9 Best CSS Frameworks in 2022](https://athemes.com/collections/best-css-frameworks/)
   2. [20 Best Material Design CSS Frameworks for Websites](https://superdevresources.com/material-design-web-ui-frameworks/)

## OPIS APLIKACJI

Aplikacja jest prostym sklepem internetowym w którym rozdzielona na osobne projekty aplikację dla klienta, część administracyjną oraz klasy bazodanowe.

1. Kod z każdych zajęć oznaczony jest odpowiednimi tagami w Git
2. Wszystkie kroki notowane są w pliku README.md

<h2 class="movie">W1 - 2022-02-20</h2>

## PRZYKŁADOWY PROJEKT BEZ MVC

### Znaczniki HTML w ASP.NET Core
feat: play with razor and html tags

1. Dodaj nowy projekt `ASP.NET Core Web App`, pozostałe opcje domyślne
2. Zmodyfikuj kod widoku `Index.cshtml` - treść strona startowa
   - Dodanie kilku znaczników HTML

### Dodawanie i Modyfikowanie styli CSS
feat: play with _Layout.cshtml, Index.cshtml and site.css

1. Dodaj nowy projekt `ASP.NET Core Web App`, pozostałe opcje domyślne
2. Zmodyfikuj kod widoku `Index.cshtml` - treść strony startowej
3. Style, js i dodatkowe biblioteki takie jak Bootstrap są w folderze `wwwroot`
4. Plik `_Layout.schtml` odpowiada za szablon strony
   - Znacznik `@RenderBody()` w treści pliku oznacza miejsce, gdzie będzie wklejana treść poszczególnych stron
   - Odpowiednikiem `_Layout.cshtml` w aplikacjach desktopowych jest `generic.xaml`
   - W `generic.xaml` odpowiednikiem `@RenderBody()` jest `<ContentPresenter>`
   - Jeśli jest jeden layout to jest domyślny, jeśli jest więcej to można decydować, która strona korzysta z którego layoutu
5. Zmodyfikuj plik `site.css` - który odpowiada za style CSS całego projektu

### Procedura tworzenia projektu zgodnie ze wzorcem MVC
feat: create ASP.NET Core Web App MVC

1. Model MVC to model projektowy `Model > View > Controller`
   - `Model` zawiera klasy do zarządzania bazą danych oraz klasy logiki biznesowej
   - `Widok` zawiera strony napisane w HTML raz z wstrzykiwanym kodem C#'owym i są renderowane za pomocą silnika `Razor`
   - `Kontroler` zawiera klasy pośredniczące między modelem a widokiem
   - We wzorcu projektowym MVVM jednemu View-Model odpowiadał jeden Widok. We wzorcu projektowym MVC jednemu Kontrolerowi odpowiada wiele Widoków
   - Każdy Widok na ogół ma osobną funkcję w Kontrolerze. Jeden Kontroler działa na rzecz wielu widoków.
2. Dodaj nowy projekt `ASP.NET Core Web App (Model-VIew-Controller)`, pozostałe opcje domyślne
3. Główne elementy projektu `ASP.NET Core Web App (Model-VIew-Controller)`
   - `Views > Home > Index.cshtml` - strona otwierająca się jako pierwsza
   - `Views > Shared > _Layout.cshtml` - szablon domyślny dla wszystkich stron
   - `wwwroot > css > site.css` - główny plik styli CSS
   - `Controllers > HomeController.cs > funkcja Index()` - główny kontroler sterujący widokiem `Index.cshtml`

<h2 class="movie">W2 - 2022-02-20</h2>

## SOLUCJA OD POCZĄTKU. ROZWÓJ PRJEKTU Firma.PortalWWW

### feat: przygotuj nowa solucje z projektami
feat: prepare a new solution with projects

1. Dodaj do projektu `Blank Solution` - solucja to zbiór projektów
2. Dodaj nowy projekt `ASP.NET Core Web App (Model-VIew-Controller)` - nazwa `Firma.PortalWWW`
   1. Projekt ten jest aplikacją internetową dedykowaną klientom
3. Dodaj nowy projekt `ASP.NET Core Web App (Model-VIew-Controller)` - nazwa `Firma.Intranet`
   1. Projekt ten jest aplikacją internetową dedykowaną pracownikom
4. `PPM na Firma.Intranet > Set as Startup Project` - ustaw `Firma.Intranet` jako projekt startowy
   1. Nazwa aktywnego projektu będzie pogrubiona w Solution Explorer

### feat: zintegruj materializecss z Firma.PortalWWW
feat: integrate materializecss with Firma.PortalWWW

1. Pobierz framework materializecss (link u góry w Dokumentacji)
2. Ustaw projekt Firma.PortalWWW jako Startup Project
3. Przeciągnij rozpakowany folder `materialize` do `Firma.PortalWWW > wwwroot > lib`

### feat: podepnij materializecss do _Layout.cshtml i uaktualnij biblioteki
feat: connect materializcsse to _Layout.cshtml and update libraries

1. Pobierz wybrany template materialize np. [Starter Template](https://materializecss.com/getting-started.html)
2. Edytuj `Frima.PortalWWW > Shared > _Layout.cshtml` i przekopiuj odpowiednie fragmenty z `template > index.html`
   1. `head` integruj style css potrzebne do działania template. Zweryfikować dodatkowe pliki z dedykowanym CSS
      1. Dodaj dodatkowy kod CSS do `Firma.PortalWWW > wwwroot > lib > css > site.css`
   2. `body` integruj zawartość template strony
   3. `script` integruj odpowiednie skrypty potrzebne do działania template
        1. Dodaj odpowiednią wersję jQuery do `Firma.PortalWWW > wwwroot > lib > jquery > dist`
        2. Dodaj dodatkowy kod JavaScript do `Firma.PortalWWW > wwwroot > lib > js > site.js`
   4. W pliku `_Layout.cshtml` w miejscu w którym ma się wklejać renderowana treść strony dodaj linijkę `@RenderBody()`
3. Edytuj plik `FirmaPortalWWW > Views > Home > Index.cshtml` i dodaj odpowiednią treść strony `Home` z uwzględnieniem nowych klas CSS z materialize
4. Usuń nieużywane przez template skrypty z `Firma.PortalWWW > wwwroot > lib`
    1. Bootstrap

### feat: dodaj linki do menu w _Layout.cshtml
feat: add links to the menu in _Layout.cshtml

1. Tworzenie linku do strony `@Html.ActionLink("Prywatność","Privacy","Home")`
   1. `Prywatność` - anchor text `linkText`
   2. `Privacy` - nazwa funkcji wyświetlającej daną stronę w kontrolerze `actionName`
   3. `Home` - nazwa kontrolera `controllerName`






<style>
    .movie {
        color:red;
        margin: 50px 0 20px 0 !important;
    }
</style>