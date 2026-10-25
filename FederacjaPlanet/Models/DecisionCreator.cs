using System;
using System.Collections.Generic;
using System.Text;

using DominiumPlanet.Models;
namespace DominiumPlanet.Models
{
    public class DecisionCreator
    {
        public static List<Decision> CreateDecisionList()
        {
            Decision decision0 = new Decision
            {
                Name = "Wygłoś mowę",
                Description = "Choć nie jest to obowiązek, to jednak wielu Władców decyduje się w ciągu najbliższych dni od przejęcia władzy na wygłoszenie mowy zapowiadającej dalsze rządy.",
                Cost = 0,
                GainAuthority = 10,
                IsActive = true,
                option1 = "Wygłoś przemowę.",
                option2 = "Nie wygłaszaj przemowy - liczą się czyny nie słowa."
               

            };
            Decision decision1 = new Decision
            {
                Name = "Podatek od eksportu żywności",
                Description = "Sytuacja Skarbu Państwa nie jest najlepsza. Wręcz przeciwnie sprawy się mają na Wenus, gdzie moneta obraca się szybko i zdaje się wcale nie tracić na wartości. " +
                "Podniesienie podatku od eksportu żywności wydaje się wręcz idealnym rozwiązaniem, aby uzupełnić pustki w Skarbcu - podniesienie opłat nie zaszkodzi tak zamożnej planecie jak Wenus.\n\n" +
                "Coś jednak nie daje ci spokoju w tym pozornie idealnym rozwiązaniu...",
                Cost = 0,
                GainBudgetFrom = 25, //od kazdej tury najlepiej | gainbudget zawsze do skarbca
                GainAuthority = 5,
                GainPublicSatisfaction = -15,
                IsActive = false,
                PlanetName = "Wenus",
                option1 = "Podnieś podatki od eksportu żywnosci (+25 do każdej tury)",
                option2 = "Zostaw Wenus w spokoju"
               
            };
            Decision decision2 = new Decision
            {
                Name = "Ekspedycja na Merkurego",
                Description = "Pomimo pochodzenia, w głębi duszy zawsze było ci bliżej do Podróżnika niż Wielkiego Władcy. Teraz, gdy zostałeś zmuszony do przybrania tej drugiej pozy, coraz bardziej " +
                "tęsknisz za prostszymi czasami a myśli mimowolnie zwracają się w kierunku Merkurego - tajemniczej planety, która uległa zniszczeniu 340 lat temu po nieudanej terraformacji. " +
                "Pomimo upływu lat legendy o rozległych złożach i dawnej zaginionej technologi wciąż pozostają żywe. Ile jest w nich prawdy?\n\n" +
                "Twój wewnętrzny Racjonalista wie że te historie można włożyć między bajki, ale Podróżnik-Odkrywca wierzy w powodzenie ekspedycji\n\n. " +
                "Władca zdaje sobie sprawę że skarbiec sam się nie zapełni.",
                Cost = 1500,
                IsActive = false,
                option1 = "Sfinansuj ekspedycje na Mars.",
                option2 = "Poczekaj z finansowaniem."
            };
            Decision decision3 = new Decision
            {
                Name = "Kredyt",
                Description = "Ziemscy bankierzy są zawsze skłonni pożyczyć pieniądze tak szanownej osobie jak Władca Federacji. Na jaki procent? Proszę nie zaprzątać " +
                "tym sobie głowy Ekscelencjo! Na jaki okres? Z pewnością uda nam się dogadać...\n\n" +
                "Zaciągnięty dług jednak nie maleje, a w dodatku dalej nie udało ci się całkowicie spłacić kredytu, który został przeznaczony na modernizacje floty, należącej do twojej rodziny. " +
                "Czy możesz sobie pozwolić na oplatanie się kolejnymi węzami założonymi przez bankierów?",
                Cost = 0,
                GainBudgetFrom = 500,
                GainAuthority = -15,
                IsActive = true,
                PlanetName = "Ziemia",
                option1 = "Zadlóż sie (+500).",
                option2 = "Nie bierz kolejnego kredytu."
            };

            Decision decision4 = new Decision
            {
                Name = "Spłać część kredytu",
                Description = "Nadszedł czas by uwolnić się od części zobowiązań.",
                Cost = 100,
                GainAuthority = 2,
                IsActive = true,
                PlanetName = "Ziemia",
                option1 = "Spłać część kredytu.",
                option2 = "Jeszcze nie teraz."
            };

            Decision decision5 = new Decision
            {
                Name = "Przekaż środki na odbudowę Jowisza",
                Description = "Podczas twojej przemowy padły kluczowe słowa 'Dołożę wszelkich starań, aby naprawić krzywdy wyrządzone rządami mojego poprzednika. [...] " +
                "Nie pozwolę by Jowisz podzielił los Merkurego!\n\n" +
                "To wszystko piękne słowa, ale czy coś za nimi stoi?",
                Cost = 200,
                GainAuthority = 11,
                GainPublicSatisfaction = 11,
                IsActive = true,
                PlanetName = "Jowisz",
                option1 = "Przekaż fundusze na odbudowę.",
                option2 = "Poczekaj z odbudową."
            };
            Decision decision6 = new Decision
            {
                Name = "Reformy na Marsie - los robotników",
                Description = "Wszyscy, nawet Twój poprzednik, zdawali sobie sprawę z tego jak traktowani są robotnicy na Marsie. Wszyscy, nawet Twój poprzednik zdawali sobie sprawę, że interwencja " +
                "na niewiele by się zdała, a mogłaby sprawić że elity Marsa obróciłyby się przeciwko Władzy Centralnej. W dniu ślubowania wiele myśli kłębiło się w Twojej głowie, ale najgłośniejszą " +
                "była 'muszę pokazać wszystkim że nie jestem jak Hadrian. Muszę przywrócić światu równowagę'.\n\n" +
                "To twoja szansa by pokazać się jako miłosierny Władca.",
                Cost = 100,
                GainPublicSatisfaction = 2,
                GainAuthority = 5,
                IsActive = false,
                PlanetName = "Mars",
                option1 = "Wprowadz reformy na Marsie.",
                option2 = "Nie ryzykuj."
            };
            Decision decision7 = new Decision
            {
                Name = "Pertraktacje z Sojuszem Księżycowym o żywność i energię",
                Description = "Twoi zaufani słudzy donoszą, że sytuacja w Sojuszu Księżycowym jest nie tylko stabilna, ale że intensywnie rozwija się tam przemysł i sektor usług. " +
                "Twój poprzednik częściej wojował z Władcami księżyców niż się z nimi dogadywał. Choć wspomnienia strzałów działek plazmowych wciąż nie dają ci spać w niektóre noce, " +
                "może nadszedł już czas by zakopać wojenny topór i zacząć myśleć o współpracy?",
                Cost = 100,
                IsActive = false,
                option1 = "Wyślij posłów na Tytan (księżyc Saturna).",
                option2 = "Rany wciąż są zbyt świeże..."
            };
            Decision decision8 = new Decision
            {
                Name = "Przyślij część żywności na Mars",
                Description = "Sytuacja na Marsie jak zwykle jest daleka od idealnych, a po podwyżkach Wenus jest jeszcze gorzej. Przyślij część własnych zapasów na Mars",
                Cost = 100,
                FoodDistribution = (25, "Ziemia", "Mars"),
                IsActive = false,
                PlanetName = "Mars",
                option1 = "Prześlij żywność na Mars.",
                option2 = "Zachowaj żywność sobie."
            };

            Decision decision9 = new Decision
            {
                Name = "Sfinansuj bazę badawczą na Kallisto (Jowisz)",
                Description = "Jednym z głównych problemów księżycy Jowisza jest wysokie bezrobocie. W trakcie wojny wiele instytucji zostało zniszczony. " +
                "Budowa bazy dałaby coś do roboty rzemieślnikom, a kiedy placówka zostałąby ukończona zatrudniłaby kolejne setki a może i tyesiące. " +
                "Oczywiście jest to jedynie kropa w morzu potrzeb ludności tych odległych księżycy a mimo to...\n\n" +
                "Może warto spróbować?",
                Cost = 600,
                
                IsActive = true,
                PlanetName = "Jowisz",
                GainAuthority = 20,
                GainPublicSatisfaction = 20,
                option1 = "Sfinansuj budowę.",
                option2 = "To i tak nie ma sensu..."
            };

            Decision decision10 = new Decision
            {
                Name = "Przekieruj energię z Marsa na Jowisz",
                Description = "Wysłannicy z Księżycy Jowisz zwrócili się do Ciebie z uprzejmą prośbą o dostarczenie energii. Generatory na Ganimedesie zostały uszkodzone podczas " +
                "ostatniej burzy, a rezerwy energii na Io są na wyczerpaniu. Mars ma energii w nadmiarze, inna sprawa że będzie cię to troche kosztować aby przekonać fabrykantów " +
                "do pomocy.",
                Cost = 300,
                IsActive = false,
                PlanetName = "Jowisz",
                GainAuthority = 5,
                GainPublicSatisfaction = 15,
                EnergyDistribution = (25, "Mars", "Jowisz"),
                option1 = "Pomóż księżycom Jowisza (25j)",
                option2 = "Jeszcze nie teraz."

            };
            Decision decision11 = new Decision
            {
                Name = "Amnestia dla zdrajców",
                Description = "Twój kuzyn nie był najlepszym Władcą, a w dodatku osoby, które go obaliły są jednocześniem powodem dlaczego to Ty zajmujesz teraz miejsce na tronie. ",
                Cost = 0,
                IsActive=true,
                GainAuthority = -15,
                option1 = "Okaż miłosierdzie.",
                option2 = "Pozbądź się zdrajców."
            };
            Decision decision12 = new Decision
            {
                Name = "Inspekcja fabryk na Marsie",
                Description = "Nie jest wielką tajemnicą jak się mają sprawy na Marsie. Ostatnio jednak coraz głośnie mówi się o możliwości zamieszek. ",
                Cost = 120,
                IsActive=false,
                PlanetName = "Mars",
                GainAuthority = 10,
                GainPublicSatisfaction = 5,
                option1 = "Wyślij inspekcje do 5 głównych zakładów.",
                option2 = "Nie rób inspekcji - masz ważniejsze rzeczy na głowie."
            };
            Decision decision13 = new Decision
            {
                Name = "Zamknij fabrykę MarsTech",
                Description = "Twoi inspektorzy złożyli raport o warunkach panujących w 5 głównych zakładach Marsa. Tak jak się można było spodziewać większość norm została " +
                "przekroczona. To co przykuwa twoją uwagę to natomiast fabryka MarsTech, która jest pod tym względem liderem. W twojej głowie układa się plan zamknięcia zakładu - " +
                "zrobienie z niej przykładu.",
                Cost = 120,
                IsActive=false,
                PlanetName = "Mars",
                GainAuthority = -25,
                GainPublicSatisfaction = 10,
                option1 = "Wyślij inspekcje do 5 głównych zakładów.",
                option2 = "Nie rób inspekcji - masz ważniejsze rzeczy na głowie."
            };
            Decision decision14 = new Decision
            {
                Name = "Ogranicz wydatki na wojsko",
                Description = "Wojna skończyła się rok temu, a mimo to na wojsko dalej przeznaczane są wysokie kwoty. 'Być może ludzie zasługują na pokój' mówisz.\n\n" +
                "Twoi doradcy się z tobą nie zgadzają. Przypominają ci o zagrożeniu ze strony Sojuszu Księżycowego, o tym co się stało z księżycami Jowisza. A jednak jeśli nic nie " +
                "zrobisz to niedługo skarbiec będzie całkowicie pusty.",
                Cost = 0,
                GainBudgetFrom = 250,
                IsActive=false,
                GainAuthority = -8,
                GainPublicSatisfaction = 5,
                option1 = "Ogranicz wydatki na wojsko (+250).",
                option2 = "Nie rób inspekcji - masz ważniejsze rzeczy na głowie."
            };
            Decision decision15 = new Decision //to tez zeby bylo permanentne
            {
                Name = "Przekaż żywność z Wenus na Jowisz",
                Description = "Sytuacja na Księżycach dalej pozostaje dramatyczna. Większość farm i centr agralnych zostało zniszczonych podczas Wojny. Mieszkańcy borykają się z głodem.",
                Cost = 190,
                IsActive = true,
                GainAuthority = 10,
                GainPublicSatisfaction = 10,
                PlanetName = "Jowisz",
                FoodDistribution = (25, "Wenus", "Jowisz"),
                option1 = "Zorganizuj dostawę (25j).",
                option2 = "Zostaw Jowisz sam sobie."
            };
            Decision decision16 = new Decision
            {
                Name = "Zakup zapas energii dla Ziemi",
                Description = "Ziemia może i być siedzibą Władcy, ale nie zmienia to faktu, że jeśli chodzi o surowce to nie ma tu czego szukać.",
                Cost = 300,
                IsActive = false,
                GainAuthority = 5,
                GainPublicSatisfaction = 10,
                PlanetName = "Ziemia",
                EnergyDistribution = (30, "Mars", "Ziemia"),
                option1 = "Zamów dostawę (30j).",
                option2 = "Cena jest zbyt wysoka."
            };




        List<Decision> decisionList = new List<Decision>
            {
                decision0, decision11, decision1, decision2, decision3, decision4, decision5, decision6, decision7, decision8, decision9, decision10, decision12, decision13,
                decision14, decision15, decision16
            
            };
            
            return decisionList;
        }
    }
}
