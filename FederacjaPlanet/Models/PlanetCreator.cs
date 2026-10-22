using System;
using System.Collections.Generic;
using System.Text;



namespace FederacjaPlanet.Models
{
    public static class PlanetCreator
    {
        public static List<Planet> CreatePlanetList()
        {
            Planet mercury = new Planet
            {
                Name = "Merkury",
                Description = "Po nieudanej terraformacji Merkury stał się symbolem próżności ludzkości - przez niedopatrzenia i zaniedbania " +
                "do ciągle tworzącej się atmosfery dostał się duszący, toksyczny dym, który po opadnięciu doprowadził do kompletnej erozji gruntu. " +
                "Dzisiaj, Merkury został owiany mgiełką tajemnicy - znane są legendy rozpalające umysł, o tym że pod jałową i zrogowaciałą powierznią znajdują się liczne i cenne surowce.\n" +
                "Ile jest prawdy w pogloskach? \n Ostatnia załoga została wysłana w celach badawczych ponad 150 lat temu. Kontakt stracono 20 minut po wkroczeniu do zrujnowanej atmosfery " +
                "a ostatni komunikat ze statku 'New Dephi' brzmiał 'temperatura wewnątrz kokpitu w normie...'.",
                Budget = 0,
                Food = 0,
                Energy = 0,
                PublicSatisfaction = 0,
                Authority = 0,

                FoodProduction = 0,
                EnergyProduction = 0,
                FoodUsage = 0,
                EnergyUsage = 0,
                IsIndependent = true,
            };

            Planet venus = new Planet
            {
                Name = "Wenus",
                Description = "Dzięki rozwiniętej kultruze agralnej, przystępnej temperaturze i szybkiemu obiegowi wokół Słońca Wenus " +
                "z czasem stało się spichlerzem Federacji Planet. Podczas wojny, chociaż oficjalnie poparli władzę centralną [], to tajemnicą " +
                "Poliszynela jest fakt że handlowali z każdym kto miał czym zapłacić. Dzisiaj, Wenus zamiast szmaragdem w koronie, pozostaje raczej " +
                "cierniem w boku rządzących, gdzie zamist szukać wspólnego dobra każdy liczy na szybkie napełnienie swoich własnych kieszeni. ",
                Budget = 300,
                Food = 200,
                Energy = 120,
                PublicSatisfaction = 85,
                Authority = 45,

                FoodProduction = 100,
                EnergyProduction = 15,
                FoodUsage = 20,
                EnergyUsage = 10,
                IsIndependent = false,
            };

            Planet mars = new Planet
            {
                Name = "Mars",
                Description = "Miejsce skrajnosci, gdzie monumentalne wieżowce mogą sąsiadować z osiedlami robotniczymi. Ze względu na bogate i rozległe złoża surowców, większość powierzchni " +
                "Marsa pokrywają szyby i fabryki - to właśnie tutaj przybywają ludzie w poszukiwaniu szczęścia i szybkiego zarobku. " +
                "Co faktycznie znajdują? Jeśli jest się inwestorem to najczęściej hermetyczne środowisko, niechętne do przyjmowania konkurencji. " +
                "Natomiast jeśli interesuje ich praca to i owszem, kazda para rąk się przyda. Inna sprawa gdy chodzi o wynagrodzenie. Stawki są marne a od kiedy" +
                "gospodarka przestawiła się na wspieranie marynarki, Mars dalej nie może dojść do siebie. Nierówności społeczne są większe niż kiedykolwiek, a ludzie przepracowani i nieodżywieni.\n" +
                "Właściciele fabryk nie przejmuje to wcale - w końcu nowych pracowników ciągle przybywa, a wyniki nigdy nie były lepsze!\n\n" +
                "Ile czasu minie nim głodujący wyjdą na ulice?",
                Budget = 50,
                Food = 40,
                Energy = 200,
                PublicSatisfaction = 40,
                Authority = 56,

                FoodProduction = 10,
                EnergyProduction = 70,
                FoodUsage = 20,
                EnergyUsage = 20,
                IsIndependent = false,
            };

            Planet earth = new Planet
            {
                Name = "Ziemia",
                Description = "To właśnie od tej planety wszystko się zaczęło. Z niej wyruszyły ekspedycje na inne planety, które wraz z czasem zostały dołączone do Federacji. Pomimo upływu lat " +
                "i wyczerpania surowców Ziemia nie jest jedynie reliktem przeszłości. To właśnie tutaj znajdują się liczne miejsca kluczowe dla wspólnej histori oraz siedziby banków. " +
                "Jest to również siedziba władcy, który w każdej chwili może zwrócić się o zaopatrzenie skarbca..",
                Budget = 100,
                Food = 90,
                Energy = 80,
                PublicSatisfaction = 60,
                Authority = 50,

                FoodProduction = 10,
                EnergyProduction = 10,
                FoodUsage = 20,
                EnergyUsage = 25,
                IsIndependent = false,
            };

            Planet jupiter = new Planet
            {
                Name = "Jowisz",
                Description = "Kiedys miejsce z wieloma osrodkami kluturalnymi i centrami danych, dzis ruina. To właśnie na ksiezycach Jowisza miały miejsce najbardziej zazarce walki podczas " +
                "Wielkiej Walki Planetarnej. Teraz gdy Wojna się skonczyla a 80% infrastruktury zostało zniszczone mieszkancy moga jedynie liczyc na pomoc innych planet i federalny plan odbudowy. " +
                "Wiele osób twierdzi że Księżyce Jowisza już nigdy nie odzyskają dawnej świetności, i lepiej byłoby zainwestować w terraformacje innego miejsca zamiast wydawać fundusze na takie gruzowisko. " +
                "Czy Ksiezyce Jowisza mają jeszcze szanse na lepszą przyszłość?",
                Budget = 30,
                Food = 20,
                Energy = 30,
                PublicSatisfaction = 30,
                Authority = 35,

                FoodProduction = 5,
                EnergyProduction = 5,
                FoodUsage = 10,
                EnergyUsage = 5,
                IsIndependent = false,
            };

            Planet moonAliance = new Planet
            {
                Name = "SK",
                Description = "Sojusz Ksiezycowy czyli zrzeszenie powstałe jako wynik dążeń do uzyskania niezaleznosci przez ksiezyce Saturna, Uranu i Neptuna. Niewiele wiadomo o sytuacji wewnętrznej" +
                "sojuszu, ale jak donoszą szpiedzy Federacji - wydaje się, że powoli ale skutecznie gospodarka się podności" +
                "",
                Budget = 900,
                Food = 200,
                Energy = 90,
                PublicSatisfaction = 50,
                Authority = 0,

                FoodProduction = 72,
                EnergyProduction = 115,
                FoodUsage = 70,
                EnergyUsage = 80,
                IsIndependent = true,
            };


            List<Planet> planetList = new List<Planet>
            {
                mercury, venus, mars, earth, jupiter, moonAliance,
            };
            return planetList;
        }



        
    }
}
