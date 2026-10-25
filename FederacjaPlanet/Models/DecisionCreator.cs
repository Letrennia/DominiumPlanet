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
                GainBudgetFrom = 400,
                GainAuthority = -20,
                IsActive = true,
                PlanetName = "Ziemia",
                option1 = "Zadlóż sie (+400).",
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
                Cost = 240,
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
                Cost = 130,
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
                Cost = 130,
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
                Cost = 200,
                IsActive=false,
                PlanetName = "Mars",
                GainAuthority = 10,
                GainPublicSatisfaction = -25,
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
                GainAuthority = -10,
                GainPublicSatisfaction = 5,
                option1 = "Ogranicz wydatki na wojsko (+250).",
                option2 = "Nie rób inspekcji - masz ważniejsze rzeczy na głowie."
            };
            Decision decision15 = new Decision //to tez zeby bylo permanentne
            {
                Name = "Przekaż żywność z Wenus na Jowisz",
                Description = "Sytuacja na Księżycach dalej pozostaje dramatyczna. Większość farm i centr agralnych zostało zniszczonych podczas Wojny. Mieszkańcy borykają się z głodem.",
                Cost = 250,
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
                Cost = 340,
                IsActive = false,
                GainAuthority = 5,
                GainPublicSatisfaction = 10,
                PlanetName = "Ziemia",
                EnergyDistribution = (30, "Mars", "Ziemia"),
                option1 = "Zamów dostawę (30j).",
                option2 = "Cena jest zbyt wysoka."
            };
            Decision decision17 = new Decision
            {
                Name = "Mieszkania socjalne na Marsie",
                Description = "Pomimo twoich zaleceń, fabrykanci dalej nie egzekwują nowych zasad. Aby wspomóc wykorzystywanych pracowników postanawiasz zacząć budować mieszkania " +
                "socjalne... bez zgody ich pracodawców.",
                Cost = 290,
                IsActive = false,
                GainAuthority = -20,
                GainPublicSatisfaction = 10,
                PlanetName = "Mars",
                option1 = "Działaj na własną rękę.",
                option2 = "Utrzymaj względnie dobre stosunki z elitami Marsa."
            };
            Decision decision18 = new Decision
            {
                Name = "Dofinansuj ośrodki kultury na Jowiszu",
                Description = "Kiedyś księżyce Jowisza były ostoją kultury, a na każdej ulicy znajdował się Teatr, Opera lub Muzeum. Tęsknisz za czasami, gdy Europa biła światłami " +
                "kamer i ogromnych telebimów. Choć nikt nie posądziłby Cię o poetycką duszę to jednak jakaś cząstka Ciebie ciepło wraca myślami do nudnych wernisaży, które organizowała " +
                "twoja Ciotka. \n\n A może jeszcze nie jest za późno?",
                Cost = 170,
                IsActive = false,
                GainAuthority = -15,
                GainPublicSatisfaction = -15,
                PlanetName = "Jowisz",
                option1 = "Wspomóż artystyczną działalność na Jowiszu.",
                option2 = "Czas na sztukę jeszcze nie nadszedł."
            };
            Decision decision19 = new Decision
            {
                Name = "Zakup żywności na Ziemię",
                Description = "Wenus grozi podniesieniem cen eksportu żywności, a ludzie w stolicy są niespokojni. Dodatkowa żywność zawsze się przyda, ale przesadą byłoby powiedzenie " +
                "że cena nie gra roli.",
                Cost = 370,
                IsActive = false,
                FoodDistribution = (30, "Wenus", "Ziemia"),
                GainPublicSatisfaction = -10,
                PlanetName = "Ziemia",
                option1 = "Zakup żywność (30j).",
                option2 = "Poczekaj."
            };
            Decision decision20 = new Decision
            {
                Name = "Pośrednicz w wymianie",
                Description = "Sytuacja pomiędzy Wenus a Marsem zawsze była napięte - ludzie stojący za sterami tych planet zawsze byli zbyt ambitni i zbyt egocentryczni dla własnego " +
                "dobra. Dziś zwracają się do ciebie z prośbą aby uczestniczyć w wymianie towarów Żywność za Energie. Oczywiście za swój udział obie strony hojnie Cię wynagrodzą.",
                Cost = 0,
                GainBudgetFrom = 200,
                IsActive = false,
                FoodDistribution = (35, "Wenus", "Mars"),
                EnergyDistribution = (35, "Mars", "Wenus"),
                option1 = "Zostań mediatorem (+200).",
                option2 = "Niech radzą sobie sami."
            };
            Decision decision21 = new Decision
            {
                Name = "Gala",
                Description = "Ekstrawaganckie przyjęcia to idealne miejsce do pokazania sie z lepszej strony jak i świetny moment na zawarcie bliższych znajomości z lokalną elitą.",
                Cost = 0,
                GainAuthority = 5,
                GainPublicSatisfaction = -5,
                IsActive = false,
                option1 = "Uczestnicz w gali.",
                option2 = "To nie jest dobry moment."
            };
            Decision decision22 = new Decision
            {
                Name = "Modernizacja ziemskiej floty",
                Description = "Podczas ostatniego spotkania z doradcami padł temat zagrożenia ze strony Sojuszu Księżycowego. Temat ten, podobnie jak wiele innych, zazwyczaj znajdzie " +
                "swoje miejsce podczas każdej mniejszej lub większej debaty. Zazwyczaj zbywasz zagrożenie machnięciem ręki, ale nie można zaprzeczyć, że ostatnio SK radzi sobie naprawdę dobrze.\n\n" +
                "Podejrzanie dobrze. ",
                Cost = 420,
                GainAuthority = 5,
                GainPublicSatisfaction = 10,
                IsActive = false,
                option1 = "Przeznacz fundusze na modernizacje.",
                option2 = "To tylko plotki..."
            };
            Decision decision23 = new Decision
            {
                Name = "Akt posłuszeństwa",
                Description = "Najważniejsza do utrzymania jest stolica. W obliczu narastających problemów oraz rosnącej desperacji zwracasz się z żądaniem udowodnienia poparcia " +
                "ze strony Wenus i Mara. Planety mają Ci dostarczyć Żywności i Energii bo inaczej... właściwie to nie masz możliwości im zagrozić, ale czy podporu Dominium o tym wiedzą?",
                Cost = 0,
                GainAuthority = 5,
                GainPublicSatisfaction = 10,
                PlanetName = "Ziemia",
                EnergyDistribution = (30, "Mars", "Ziemia"),
                FoodDistribution = (30, "Wenus", "Ziemia"),
                IsActive = false,
                option1 = "Zażądaj trybutu.",
                option2 = "To zbyt ryzykowne..."
            };
            




        List<Decision> decisionList = new List<Decision>
            {
                decision0, decision11, decision1, decision2, decision3, decision4, decision5, decision6, decision7, decision8, decision9, decision10, decision12, decision13,
                decision14, decision15, decision16, decision17, decision18, decision19, decision20, decision21, decision22, decision23
            
            };
            
            return decisionList;
        }
    }
}
