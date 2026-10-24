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
                Description = "Choć nie jest to obowiązek, to jednak wielu Władców decyduje się w ciągu najbliższych dni od przejęcia władzy na wygloszenie mowy zapowiadającej dalsze rządy.",
                Cost = 0,
                GainAuthority = 10,
                IsActive = true,
                option1 = "Wygłoś przemowę.",
                option2 = "Nie wygłaszaj przemowy - liczą się czyny nie słowa."
               
            };
            Decision decision1 = new Decision
            {
                Name = "Podatek od eksportu żywnosci",
                Description = "Sytuacja Skarbu Państwa nie jest najlepsza. Wręcz przeciwnie sprawy się mają na Wenus, gdzie moneta obraca się szybko i zdaje się wcale nie tracić na wartości. " +
                "Podniesienie podatku od eksportu żywności wydaje się wręcz idealnym rozwiązaniem, aby uzupełnić pustki w Skarbcu - podniesienie opłat nie zaszkodzi tak zamożnej planecie jak Wenus.\n\n" +
                "Coś jednak nie daje ci spokoju w tym pozornie idealnym rozwiązaniu...",
                Cost = 0,
                GainBudgetFrom = (80, "Wenus", ""), //od kazdej tury najlepiej | gainbudget zawsze do skarbca
                GainAuthority = 5,
                GainPublicSatisfaction = -5,
                IsActive = true,
                option1 = "Podnieś podatki od eksportu żywnosci (1 tura)",
                option2 = "Zostaw Wenus w spokoju"
               
            };
            Decision decision2 = new Decision
            {
                Name = "Ekspedycja na Mars",
                Description = "Pomimo pochodzenia, w głębi duszy zawsze było ci bliżej do Podróżnika niż Wielkiego Władcy. Teraz, gdy zostałeś zmuszony do przybrania tej drugiej pozy, coraz bardziej " +
                "tęsknisz za prostszymi czasami a myśli mimowolnie zwracają się w kierunku Merkurego - tajemniczej planety, która uległa zniszczeniu 340 lat temu po nieudanej terraformacji. " +
                "Pomimo upływu lat legendy o rozległych złożach i dawnej zaginionej technologi wciąż pozostają żywe. Ile jest w nich prawdy?\n\n" +
                "Twój wewnętrzny Racjonalista wie że te historie można włożyć między bajki ale Podróżnik-Odkrywca wierzy w powodzenie ekspedycji\n\n. " +
                "Władca zdaje sobie sprawę że skarbiec sam się nie zapełni.",
                Cost = 1500,
                IsActive = false,
                option1 = "Sfinansuj ekspedycje na Mars (1500).",
                option2 = "Poczekaj z finansowaniem."
            };
            Decision decision3 = new Decision
            {
                Name = "Kredyt",
                Description = "Ziemscy bankierzy są zawsze skłonni pożyczyć pieniądze tak szanownej osobie jak Władca Federacji. Na jaki procent? Proszę nie zaprzątać " +
                "tym sobie głowy Ekscelencjo! Na jaki okres? Z pewnością uda nam się dogadać...\n\n" +
                "Zaciągnięty dług jednak nie maleje, a w dodatku dalej nie udało ci się całkowicie spłacić kredytu, który został przeznaczony na modernizacje floty która nalezy do twojej rodziny. " +
                "Czy możesz sobie pozwolić na oplatanie się kolejnymi węzami założonymi przez tych chciwych ludzi?",
                Cost = 0,
                GainBudgetFrom = (500, "", ""),
                GainAuthority = -15,
                IsActive = true,
                option1 = "Zadlóż sie (500).",
                option2 = "Nie bierz kolejnego kredytu."
            };

            Decision decision4 = new Decision
            {
                Name = "Spłać część kredytu",
                Description = "Ziemscy bankierzy są zawsze skłonni pożyczyć pieniądze tak szanownej osobie jak Władca Federacji. Na jaki procent? Proszę nie zaprzątać " +
                "tym sobie głowy Ekscelencjo! Jaki okres? Na pewno uda nam się dogadać...\n\n" +
                "Zaciągnięty dług jednak nie maleje, a w dodatku dalej nie udało ci się całkowicie spłacić kredytu, który został przeznaczony na modernizacje floty która nalezy do twojej rodziny. " +
                "Czy możesz sobie pozwolić na oplatanie się kolejnymi węzami założonymi przez tych chciwych ludzi?",
                Cost = 100,
                GainAuthority = 2,
                IsActive = true,
                option1 = "Spłać część kredytu (100).",
                option2 = "Jeszcze nie teraz."
            };

            Decision decision5 = new Decision
            {
                Name = "Przekaz srodki na odbudowę Jowisza",
                Description = "Podczas twojej przemowy padły kluczowe słowa 'Dołożę wszelkich starań aby naprawić krzywdy wyrządzone niudolnymi rządami mojego poprzednika [...]. " +
                "Nie pozwolę by Jowisz podzielił los Merkurego!\n\n" +
                "To wszystko piękne słowa, ale czy coś za nimi stoi?",
                Cost = 200,
                GainAuthority = 6,
                GainPublicSatisfaction = 10,
                IsActive = true,
                option1 = "Przekaż fundusze na odbudowę (200).",
                option2 = "Poczekaj z odbudową."
            };
            Decision decision6 = new Decision
            {
                Name = "Reformy na Marsie - los robotników",
                Description = "Wszyscy, nawet twój poprzednik, zdawali sobie sprawę z tego jak traktowani są robotnicy na Marsie. Wszyscy, nawet twój poprzednik zdawali sobie sprawę że interwencja " +
                "na niewiele by się zdała, a mogłaby sprawić że elity Marsa obróciłyby się przeciwko Władzy Centralnej. W dniu slubowania wiele myśli kłębiło się w twojej głowie, ale najgłośniejszą była " +
                "'muszę pokazać wszystkim że nie jestem jak []. Muszę przywrócić światu równowagę'.\n\n" +
                "To twoja szansa by pokazać się jako miłosierny Władca.",
                Cost = 50,
                GainPublicSatisfaction = 2,
                GainAuthority = 5,
                IsActive = true,
                option1 = "Wprowadz reformy na Marsie.",
                option2 = "Nie ryzykuj."
            };
            Decision decision7 = new Decision
            {
                Name = "Pertraktacje z Sojuszem Księżycowem o żywność i energię",
                Description = "Twoi zaufani słudzy donoszą, że sytuacja w Sojuszu Księżycowym jest nie tylko stabilna, ale że intensywnie rozwija się tam przemysł i sektor usług. " +
                "Twój poprzednik częściej wojował z władcami księżyców niż się z nimi dogadywał. Choć wspomnienia strzałów działek plazmowych wciąż nie dają ci spać w niektóre noce, " +
                "może nadszedł już czas by zakopać wojenny topór i zacząć myśleć o współpracy?",
                Cost = 100,
                IsActive = true,
                option1 = "Wyślij posłów na Tytan (księżyc Saturna).",
                option2 = "Rany wciąż są zbyt świeże..."
            };
            Decision decision8 = new Decision
            {
                Name = "Przyslij czesc zywnosci na Mars",
                Description = "Sytuacja na Marsie jak zwykle jest daleka od idealnych. Przyslij czesc wlasnych zapasow na Mars",
                Cost = 20,
                FoodDistribution = (25, "Ziemia", "Mars"),
                IsActive = true,
                option1 = "Prześlij żywność na Mars.",
                option2 = "Zachowaj żywność dla siebie."
            };

            Decision decision9 = new Decision
            {
                Name = "Sfinansuj baze badawczą na [] (Jowisz)",
                Description = "Jednym z głównych problemów księżycy Jowisza jest wysokie bezrobocie. W trakcie wojny wiele instytucji " +
                "zostało zniszczony. Budowa bazy dałaby coś do roboty rzemieślnikom, a kiedy placówka zostałąby ukończona zatrudniłaby kolejne " +
                "setki a może i tyesiące. Oczywiście jest to jedynie kropa w morzu potrzeb ludności tych odległych księżycy a mimo to...\n\n" +
                "Może warto spróbować?",
                Cost = 600,
                
                IsActive = false,
                GainAuthority = 20,
                GainPublicSatisfaction = 20,
                option1 = "Sfinansuj budowę",
                option2 = "To i tak nie ma sensu"
            };

            Decision decision10 = new Decision
            {
                Name = "Przekieruj energię z Marsa na Jowisz",
                Description = "Mars ma jej pod dostatkiem. Księżyce Jowisza potrzebują pomocy. Wydaje się to uczciwa umowa.",
                
      
            };




        List<Decision> decisionList = new List<Decision>
            {
                decision0, decision1, decision2, decision3, decision4, decision5, decision6, decision7, decision8, 
            decision9
            };
            
            return decisionList;
        }
    }
}
