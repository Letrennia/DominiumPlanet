using System;
using System.Collections.Generic;
using System.Text;



namespace DominiumPlanet.Models
{
    public static class PlanetCreator
    {
        public static List<Planet> CreatePlanetList()
        {
            Planet mercury = new Planet
            {
                Name = "Merkury",
                Description = "Po nieudanej terraformacji Merkury stał się symbolem próżności ludzkości. Niedopatrzenie i zaniedbania sprawiły, że do ciągle formującej się " +
                "atmosfery przedostał się duszący, toksyczny dym, który po opadnięciu doprowadził do kompletnej erozji gruntu. " +
                "Dziś Merkury spowija mgiełka tajemnicy. Wszyscy znają legendy, o tym że pod jałową i zrogowaciałą powierznią znajdują się bezcenne surowce.\n\n" +
                "Ile prawdy kryje się w pogłoskach? \n\nOstatnia ekspedycja badawcza wyruszyła na Merkurego ponad 150 lat temu, a kontakt z załogą stracono zaledwie 20 minut po wejściu w zrujnowaną " +
                "atmosfere planety. Ostatni odebrany komunikat brzmiał 'temperatura wewnątrz kokpitu 23 stopnie...'.",
                Food = 0,
                Energy = 0,
                PublicSatisfaction = 0,
                Authority = 0,

                FoodProduction = 0,
                EnergyProduction = 0,
                FoodUsage = 0,
                EnergyUsage = 0,
                IsIndependent = true,
                Riot = false
            };

            Planet venus = new Planet
            {
                Name = "Wenus",
                Description = "Dzięki rozwiniętej kulturze agralnej, sprzyjającej temperaturze i krótkiemu okresowi obiegu wokół Słońca, Wenus z czasem stało się spichlerzem Sol Dominium. " +
                "Pola uprawne to jednak nie wszystko co ma do zaoferowania ta piękna planeta - jej wybrzeża zapełnione sa ośrodków wypoczynkowych i sportowych."+
                "Podczas wojny, chociaż Wenus oficjalnie poparła władzę centralną, to tajemnicą poliszynela pozostaje fakt, że lokalne elity handlowały ze wszystkimi, którzy byli w stanie zapłacić.\n\n " +
                "Dziś, Wenus zamiast szmaragdem w koronie, pozostaje raczej cierniem w boku rządzących, gdzie zamiast szukać wspólnego dobra każdy liczy na szybkie napełnienie własnych kieszeni, a " +
                "może i uzyskanie czegoś więcej?",
                Food = 120,
                Energy = 70,
                PublicSatisfaction = 65,
                Authority = 30,

                FoodProduction = 80,
                EnergyProduction = 9,
                FoodUsage = 50,
                EnergyUsage = 15,
                IsIndependent = false,
                Riot = false
            };

            Planet mars = new Planet
            {
                Name = "Mars",
                Description = "Miejsce skrajnosci, gdzie monumentalne wieżowce sąsiadują z robotniczymi osiedlami. Ze względu na bogate i rozległe złoża surowców, większość powierzchni " +
                "Marsa pokrywają szyby i fabryki - to właśnie tutaj przybywają ludzie w poszukiwaniu szczęścia i szybkiego zarobku. " +
                "Co faktycznie znajdują? Jeśli są inwestorami to najczęściej hermetyczne środowisko, niechętne do przyjmowania konkurencji. " +
                "Natomiast jeśli interesuje ich praca, nie musza się martwić - każda para rąk do pracy się przyda! Inna sprawa gdy chodzi o wynagrodzenie - stawki są marne, a od kiedy gospodarka " +
                "przestawiła się na wspieranie marynarki, Mars dalej nie może dojść do siebie.\n\n" +
                "Nierówności społeczne są większe niż kiedykolwiek, a ludzie przepracowani i nieodżywieni.\n" +
                "Właścicieli fabryk to nie przejmuje - w końcu nowych pracowników ciągle przybywa, a wyniki nigdy nie były lepsze!\n\n" +
                "Ile czasu minie nim głodujący wyjdą na ulice?",
                Food = 40,
                Energy = 200,
                PublicSatisfaction = 35,
                Authority = 50,

                FoodProduction = 10,
                EnergyProduction = 70,
                FoodUsage = 20,
                EnergyUsage = 35,
                IsIndependent = false,
                Riot = false
            };

            Planet earth = new Planet
            {
                Name = "Ziemia",
                Description = "To właśnie od tej planety wszystko się zaczęło. Z niej wyruszyły pierwsze ekspedycje badawcze, a później statki pasażerskie i towarowe. " +
                "Nic więc dziwnego, że to Ziemia została stolicą Dominium i to właśnie tutaj znajduje się główna siedziba Władcy.\n\n" +
                "Pomimo upływu lat i wyczerpania surowców, Ziemia nie jest jednak jedynie reliktem przeszłości - dzięki swojej długiej historii i prestiżowi, wiele firm i instytucji " +
                "ma tutaj swój oddział - w tym wszystkie najważniejsze banki. " +
                "Natomiast błędem byłoby zakładać, że jest to arkadia - w każdym kącie może czyhać niebezpieczeństwo, a każdy uśmiech skrywać drwinę lub potencjalny spisek.\n\n" +
                "O bezpieczeństwo Władcy Dominium troszczy się Gwardia Przyboczna. Może podniosłoby Cię to na duchu, gdyby nie świadomość, że połowa Twoich poprzedników została przez nią obalona.",
                Food = 80,
                Energy = 70,
                PublicSatisfaction = 60,
                Authority = 45,

                FoodProduction = 10,
                EnergyProduction = 10,
                FoodUsage = 20,
                EnergyUsage = 25,
                IsIndependent = false,
                Riot = false
            };

            Planet jupiter = new Planet
            {
                Name = "Jowisz",
                Description = "A właściwie to jego księzyce. Kiedyś miejsca słynące z wielu ośrodków kluturalnych oraz ogromnych farm centr danych. Dziś ruina. To właśnie na ksiezycach Jowisza " +
                "miały miejsce najbardziej zażarce walki podczas Wojny." +
                "Teraz gdy podpisano rozejm, a 80% infrastruktury zostało zniszczone, mieszkańcy mogą jedynie liczyć na pomoc innych planet i Plan Odbudowy zapowiedziany jeszcze za panowania Hadriana.\n\n" +
                "Wielu uważa, że Księżyce Jowisza już nigdy nie odzyskają dawnej świetności i lepiej byłoby zainwestować w terraformacje innego miejsca zamiast marnować fundusze na to gruzowisko.\n\n" +
                "Czy Ksiezyce Jowisza mają jeszcze szanse na lepszą przyszłość?",
                Food = 20,
                Energy = 30,
                PublicSatisfaction = 30,
                Authority = 35,

                FoodProduction = 5,
                EnergyProduction = 5,
                FoodUsage = 10,
                EnergyUsage = 10,
                IsIndependent = false,
                Riot = false
            };

            Planet moonAliance = new Planet
            {
                Name = "SK",
                Description = "Sojusz Ksieżycowy, czyli zrzeszenie powstałe w wyniku dążeń do uzyskania niepodległości przez ksieżyce Saturna, Uranu i Neptuna. Niewiele wiadomo o sytuacji wewnętrznej" +
                "Sojuszu, ale jak donoszą szpiedzy Dominium - gospodarka powoli, lecz skutecznie się odbudowuje.",
                Food = 200,
                Energy = 90,
                PublicSatisfaction = 50,
                Authority = 0,

                FoodProduction = 72,
                EnergyProduction = 115,
                FoodUsage = 70,
                EnergyUsage = 80,
                IsIndependent = true,
                Riot = false
            };



            List<Planet> planetList = new List<Planet>
            {
                mercury, venus, mars, earth, jupiter, moonAliance,
            };
            return planetList;
        }



        
    }
}
