using System;
using System.Collections.Generic;
using System.Text;

namespace DominiumPlanet.Models
{
    public class GameModel
    {
        public string Title { get; set; } = "SOL DOMINIUM";
        public string Story { get; set; } = "Jest 44 rok III ery solarnej. Dotychczasowy Władca Sol Dominium, Hadrian Młodszy, Twój kuzyn, po 3 latach nieudolnych rządów został obalony. " +
            "Niedługo późnieju twoich drzwi stanęła Gwardia Przyboczna. Nie przyszli jednak po to by Cię aresztować, ale wyznaczyć na nowego Władcę. Odmowa nie wchodziła w grę." +
            "Chaos potęgował się z każdą chwilą, a pochopne działania mogły jedynie dolać oliwy do ognia." +
            "Tron nigdy nie był przeznaczony dla ciebie, a jednak już godzinę później siedzisz w Wielkiej Sali, miejscu gdzie twój kuzyn, Hadrian, jeszcze wczoraj decydował o losie Układu Słonecznego.\n\n" +
            "Hadrian nie był dobrym Władcą. Pozostawił po sobie zniszczenie, głód i samowolkę. Podpisał upokażający rozejm i pozwolił księżycom Saturna, Urana i Neptuna na odłączenie od Dominium. " +
            "Władza centralna nigdy była słabsza a skarbiec bardziej pusty. Nie będzie łatwo naprawić wyrządzone szkody, ale jeśli nawet nie spróbujesz to najpewniej podzielisz los Hadriana.\n\n" +
            "Stąpasz po niepwenym gruncie, ale wiesz jedno - jeśli przetrwasz pierwsze 10 cykli panowania, Twoje szanse na utrzymanie się na tronie znacznie wzrosną.";
        public string Rules { get; set; } = "Twoim celem jest przetrwać pierwsze 9 cykli (tur) i niedopuścić do obalenia przez wrogie stronnictwo. Aby utrzymać się na tronie musisz:\n" +
            "[yellow]-[/] wzmocnić autorytet - słaba pozycja Władcy prowadzi do samowolki\n" +
            "[yellow]-[/] utrzymać poparcie społeczne - niskie poparcie może doprowadzić do buntu planety\n" +
            "[yellow]-[/] zadbać o stan planet - jako Władca Dominium twoim zadaniem jest zapewnieniem poddanym odpowiedniej ilości żywności, energii oraz godziwych warunków życia\n\n"+
            "Wybierając opcję 'Zakończ turę' mija jeden cykl - w jego trakcie do Twojego skarbca zostaną dodane fundusze z podatków (150). Każda planeta rozlicza w tym czasie swój własny bilans " +
            "zużycia żywności i energii. [red]NIE możesz pozwolić na to by skarbiec był pusty podczas tego czasu.[/]"
            ;


    }
}
