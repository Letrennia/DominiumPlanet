using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominiumPlanet.Views
{
    internal class AnimationView
    {
        public static void AnimationPlanets()
        {
            string frame1 = "                    ░░░░░░░░░░▒▒▒                     \r\n                  ░░░░░░░░░░░░░░▒▒▒       ████        \r\n                ░░░░░░░░░░░░░░░░░▒▒▒▒    █████▓▓▓▓▓▓  \r\n              ░░░░░░░░░░░░░░░░░░░░░▒▒▒▒   ███     ▓▓▓▓\r\n             ░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒         ▓▓▓▓▓\r\n       ▓▓▓▓  ░░░░░░░░░░░░░░░░░░░░░▒░▒▒▒▒      ▓▓▓▓▓   \r\n   ▓▓▓▓▓     ░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒  ▓▓▓▓▓▓      \r\n▓▓▓▓         ░░░░░░░░░░░░░░░░░░▒░░▒▒▓▓▓▓▓▓▓           \r\n▓▓▓    █████  ░░░░░░░░░░░░░░▒░▒▒▒▒▒▒▒▒▒               \r\n  ▓▓▓▓▓██████   ░░░░░░░░▒░░░▒░░▒▒▒▒▒▒                 \r\n        ████      ░░░░▒░░░▒░▒▒▒▒▒▒▒                   \r\n                    ░░░░░▒▒▒▒▒▒▒▒                     \r\n                                                      \r\n                                                      \r\n                    SOL  DOMINIUM                     ";
            string frame2 = "                    ░░░░░░░░░░▒▒▒                     \r\n                  ░░░░░░░░░░░░░░▒▒▒ ████▓▓▓▓          \r\n                ░░░░░░░░░░░░░░░░░▒▒▒▒███  ▓▓▓▓▓▓▓▓▓▓  \r\n              ░░░░░░░░░░░░░░░░░░░░░▒▒▒▒           ▓▓▓▓\r\n             ░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒         ▓▓▓▓▓\r\n             ░░░░░░░░░░░░░░░░░░░░░▒░▒▒▒▒      ▓▓▓▓▓   \r\n   ▓▓▓▓▓     ░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒    ▓▓▓▓      \r\n▓▓▓▓         █████░░░░░░░░░░░░░▒░░▒▒▒▒▒▒              \r\n▓▓▓         ▓██████░░░░░░░░░▒░▒▒▒▒▒▒▒▒▒               \r\n  ▓▓▓▓▓  ▓▓▓▓▓████░░░░░░▒░░░▒░░▒▒▒▒▒▒                 \r\n      ▓▓▓▓        ░░░░▒░░░▒░▒▒▒▒▒▒▒                   \r\n                    ░░░░░▒▒▒▒▒▒▒▒                     \r\n                                                      \r\n                                                      \r\n                    SOL  DOMINIUM                     ";
            string frame3 = "                    ░░░░░░░░░░▒▒▒                     \r\n                  ░░░░░░░░░░░░░░▒▒▒  ▓▓▓▓▓▓▓          \r\n                ░░░░░░░░░░░░░░░░░▒▒▒▒     ▓▓▓▓▓▓▓▓▓▓  \r\n              ░░░░░░░░░░░░░░░░░░░░░▒▒▒▒           ▓▓▓▓\r\n             ░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒           ▓▓▓\r\n             ░░░░░░░░░░░░░░░░░░░░░▒░▒▒▒▒         ▓▓   \r\n             ░░░░░░░░░█████░░░░░░░░▒▒▒▒▒              \r\n             ░░░░░░░░▓██████░░░▒░░▒▒▒▒▒▒              \r\n▓▓▓           ░░▓▓▓▓▓▓▓████░▒░▒▒▒▒▒▒▒▒▒               \r\n  ▓▓▓▓▓  ▓▓▓▓▓▓▓▓░░░░░░░▒░░░▒░░▒▒▒▒▒▒                 \r\n      ▓▓▓▓▓▓      ░░░░▒░░░▒░▒▒▒▒▒▒▒                   \r\n                    ░░░░░▒▒▒▒▒▒▒▒                     \r\n                                                      \r\n                                                      \r\n                    SOL  DOMINIUM                     ";
            //string frame4 = "           ░░░░░░░░░░▒▒▒                   \r\n         ░░░░░░░░░░░░░░▒▒▒  ▓▓▓▓▓▓▓        \r\n       ░░░░░░░░░░░░░░░░░▒▒▒▒     ▓▓▓▓▓▓▓▓▓▓\r\n     ░░░░░░░░░░░░░░░░░░░░░▒▒▒▒             \r\n    ░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒            \r\n    ░░░░░░░░░░░░░░░░░░█████░▒▒▒            \r\n    ░░░░░░░░░░░░░░░░▓▓██████▒▒▒            \r\n    ░░░░░░░░░░░▓▓▓▓▓▓▓▓████░▒▒▒            \r\n     ░░▓▓▓▓▓▓▓▓▓░░░▒░▒▒▒▒▒▒▒▒▒             \r\n  ▓▓▓▓▓▓░░░░░░░▒░░░▒░░▒▒▒▒▒▒               \r\n▓▓▓      ░░░░▒░░░▒░▒▒▒▒▒▒▒                 \r\n           ░░░░░▒▒▒▒▒▒▒▒                   \r\n                                           \r\n                                           \r\n           SOL  DOMINIUM                   ";
            //string frame4 = "                    ░░░░░░░░░░▒▒▒                     \r\n                  ░░░░░░░░░░░░░░▒▒▒  ▓▓▓▓▓▓▓          \r\n                ░░░░░░░░░░░░░░░░░▒▒▒▒     ▓▓▓▓▓▓▓▓▓▓  \r\n              ░░░░░░░░░░░░░░░░░░░░░▒▒▒▒           ▓▓▓▓\r\n             ░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒           ▓▓▓\r\n             ░░░░░░░░░░░░░░░░░░░░░▒░▒▒▒▒         ▓▓   \r\n             ░░░░░░░░░█████░░░░░░░░▒▒▒▒▒              \r\n             ░░░░░░░░▓██████░░░▒░░▒▒▒▒▒▒              \r\n▓▓▓           ░░▓▓▓▓▓▓▓████░▒░▒▒▒▒▒▒▒▒▒               \r\n  ▓▓▓▓▓  ▓▓▓▓▓▓▓▓░░░░░░░▒░░░▒░░▒▒▒▒▒▒                 \r\n      ▓▓▓▓▓▓      ░░░░▒░░░▒░▒▒▒▒▒▒▒                   \r\n                    ░░░░░▒▒▒▒▒▒▒▒                     \r\n                                                      \r\n                                                      \r\n                    SOL  DOMINIUM                     ";
            string frame5 = "                ░░░░░░░░░░▒▒▒               \r\n              ░░░░░░░░░░░░░░▒▒▒             \r\n         ▓▓▓░░░░░░░░░░░░░░░░░▒▒▒▒           \r\n ████  ▓▓▓░░░░░░░░░░░░░░░░░░░░░▒▒▒▒         \r\n█████▓▓  ░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒        \r\n ███▓    ░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒  █████ \r\n         ░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▒▒▒ ▓██████\r\n         ░░░░░░░░░░░▓▓▓▓▓▓▓░░░▒▒▓▓▓▓▓▓▓████ \r\n          ░░░░░░▓▓▓▓▓░░░▒░▒▒▒▒▒▒▒▒▒         \r\n            ░░░░░░░░▒░░░▒░░▒▒▒▒▒▒           \r\n              ░░░░▒░░░▒░▒▒▒▒▒▒▒             \r\n                ░░░░░▒▒▒▒▒▒▒▒               \r\n                                            \r\n                                            \r\n                SOL  DOMINIUM               ";
            string frame6 = "                      ░░░░░░░░░░▒▒▒                     \r\n                    ░░░░░░░░░░░░░░▒▒▒                   \r\n               ▓▓ ░░░░░░░░░░░░░░░░░▒▒▒▒                 \r\n          ▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░▒▒▒▒         █████ \r\n         ▓▓▓▓  ░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒       ▓██████\r\n ████ ▓▓▓▓     ░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒      ▓▓▓████ \r\n█████▓▓▓       ░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▒▒▒ ▓▓▓▓▓▓       \r\n ███▓▓         ░░░░░░░░░░░░░░▓▓▓▓░░░▒▒▓▓▓▓▓             \r\n                ░░░░░░░░░░░░░░▒░▒▒▒▒▒▒▒▒▒               \r\n                  ░░░░░░░░▒░░░▒░░▒▒▒▒▒▒                 \r\n                    ░░░░▒░░░▒░▒▒▒▒▒▒▒                   \r\n                      ░░░░░▒▒▒▒▒▒▒▒                     \r\n                                                        \r\n                                                        \r\n                      SOL  DOMINIUM                     ";
            string frame7 = "                        ░░░░░░░░░░▒▒▒                       \r\n                      ░░░░░░░░░░░░░░▒▒▒                     \r\n                    ░░░░░░░░░░░░░░░░░▒▒▒▒             █████ \r\n                  ░░░░░░░░░░░░░░░░░░░░░▒▒▒▒         ▓▓██████\r\n           ▓▓    ░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒       ▓▓▓▓████ \r\n         ▓▓▓     ░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒      ▓▓▓       \r\n       ▓▓▓       ░░░░░░░░░░░░░░░░░░░░░▓▓▓▒▒▒ ▓▓▓▓▓▓         \r\n      ▓▓         ░░░░░░░░░░░░░░░░▒▒░░░▒▒▓▓▓▓▓               \r\n     ▓▓▓          ░░░░░░░░░░░░░░▒░▒▒▒▒▒▒▒▒▒                 \r\n ████▓▓             ░░░░░░░░▒░░░▒░░▒▒▒▒▒▒                   \r\n█████▓                ░░░░▒░░░▒░▒▒▒▒▒▒▒                     \r\n ███                    ░░░░░▒▒▒▒▒▒▒▒                       \r\n                                                            \r\n                                                            \r\n                        SOL  DOMINIUM                       ";

            string[] frames = { frame1, frame2, frame3, frame5, frame6, frame7 };

            AnsiConsole.Live(new Panel(frames[0])).Start(ctx =>
            {
                int i = 0;
                int times = 0;
                while (times != 18)
                {
                    ctx.UpdateTarget(
                        new Panel(
                            new Align(
                                new Text(frames[i]),
                                HorizontalAlignment.Center,
                                VerticalAlignment.Middle
                            ))
                        {
                            Border = BoxBorder.None,
                            Expand = true
                        });
                    i = (i + 1) % frames.Length;
                    Thread.Sleep(100);
                    times++;

                }
            });

        }
    
        public static void AnimationTurn(int turn)
        {
            string turn1 = "        X    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     X        \r\n       XXX    X                               X     XXX       \r\n      XXXXX    XX                           XX     XXXXX      \r\n     XXXXXXX     X                         X      XXXXXXX     \r\n    XXXXXXXXX     X                       X      XXXXXXXXX    \r\n   XXXXXXXXXXX     XX       TURA 1      XX      XXXXXXXXXXX   \r\n  XXXXXXXXXXXXX      X                 X       XXXXXXXXXXXXX  \r\n XXXXXXXXXXXXXXX      X               X       XXXXXXXXXXXXXXX \r\nXXXXXXXXXXXXXXXXX      XX           XX       XXXXXXXXXXXXXXXXX\r\n                         X         X                          \r\n                          X       X                           \r\n                           XX   XX                            \r\n                             X X                              \r\n                              X                               ";
            string turn2 = "        X    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     X        \r\n       XXX    X                               X     XXX       \r\n      XXXXX    XX                           XX     XXXXX      \r\n     XXXXXXX     X                         X      XXXXXXX     \r\n    XXXXXXXXX     X                       X      XXXXXXXXX    \r\n   XXXXXXXXXXX     XX       TURA 2      XX      XXXXXXXXXXX   \r\n  XXXXXXXXXXXXX      X                 X       XXXXXXXXXXXXX  \r\n XXXXXXXXXXXXXXX      X               X       XXXXXXXXXXXXXXX \r\nXXXXXXXXXXXXXXXXX      XX           XX       XXXXXXXXXXXXXXXXX\r\n                         X         X                          \r\n                          X       X                           \r\n                           XX   XX                            \r\n                             X X                              \r\n                              X                               ";
            string turn3 = "        X    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     X        \r\n       XXX    X                               X     XXX       \r\n      XXXXX    XX                           XX     XXXXX      \r\n     XXXXXXX     X                         X      XXXXXXX     \r\n    XXXXXXXXX     X                       X      XXXXXXXXX    \r\n   XXXXXXXXXXX     XX       TURA 3      XX      XXXXXXXXXXX   \r\n  XXXXXXXXXXXXX      X                 X       XXXXXXXXXXXXX  \r\n XXXXXXXXXXXXXXX      X               X       XXXXXXXXXXXXXXX \r\nXXXXXXXXXXXXXXXXX      XX           XX       XXXXXXXXXXXXXXXXX\r\n                         X         X                          \r\n                          X       X                           \r\n                           XX   XX                            \r\n                             X X                              \r\n                              X                               ";
            string turn4 = "        X    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     X        \r\n       XXX    X                               X     XXX       \r\n      XXXXX    XX                           XX     XXXXX      \r\n     XXXXXXX     X                         X      XXXXXXX     \r\n    XXXXXXXXX     X                       X      XXXXXXXXX    \r\n   XXXXXXXXXXX     XX       TURA 4      XX      XXXXXXXXXXX   \r\n  XXXXXXXXXXXXX      X                 X       XXXXXXXXXXXXX  \r\n XXXXXXXXXXXXXXX      X               X       XXXXXXXXXXXXXXX \r\nXXXXXXXXXXXXXXXXX      XX           XX       XXXXXXXXXXXXXXXXX\r\n                         X         X                          \r\n                          X       X                           \r\n                           XX   XX                            \r\n                             X X                              \r\n                              X                               ";
            string turn5 = "        X    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     X        \r\n       XXX    X                               X     XXX       \r\n      XXXXX    XX                           XX     XXXXX      \r\n     XXXXXXX     X                         X      XXXXXXX     \r\n    XXXXXXXXX     X                       X      XXXXXXXXX    \r\n   XXXXXXXXXXX     XX       TURA 5      XX      XXXXXXXXXXX   \r\n  XXXXXXXXXXXXX      X                 X       XXXXXXXXXXXXX  \r\n XXXXXXXXXXXXXXX      X               X       XXXXXXXXXXXXXXX \r\nXXXXXXXXXXXXXXXXX      XX           XX       XXXXXXXXXXXXXXXXX\r\n                         X         X                          \r\n                          X       X                           \r\n                           XX   XX                            \r\n                             X X                              \r\n                              X                               ";
            string turn6 = "        X    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     X        \r\n       XXX    X                               X     XXX       \r\n      XXXXX    XX                           XX     XXXXX      \r\n     XXXXXXX     X                         X      XXXXXXX     \r\n    XXXXXXXXX     X                       X      XXXXXXXXX    \r\n   XXXXXXXXXXX     XX       TURA 6      XX      XXXXXXXXXXX   \r\n  XXXXXXXXXXXXX      X                 X       XXXXXXXXXXXXX  \r\n XXXXXXXXXXXXXXX      X               X       XXXXXXXXXXXXXXX \r\nXXXXXXXXXXXXXXXXX      XX           XX       XXXXXXXXXXXXXXXXX\r\n                         X         X                          \r\n                          X       X                           \r\n                           XX   XX                            \r\n                             X X                              \r\n                              X                               ";
            string turn7 = "        X    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     X        \r\n       XXX    X                               X     XXX       \r\n      XXXXX    XX                           XX     XXXXX      \r\n     XXXXXXX     X                         X      XXXXXXX     \r\n    XXXXXXXXX     X                       X      XXXXXXXXX    \r\n   XXXXXXXXXXX     XX       TURA 7      XX      XXXXXXXXXXX   \r\n  XXXXXXXXXXXXX      X                 X       XXXXXXXXXXXXX  \r\n XXXXXXXXXXXXXXX      X               X       XXXXXXXXXXXXXXX \r\nXXXXXXXXXXXXXXXXX      XX           XX       XXXXXXXXXXXXXXXXX\r\n                         X         X                          \r\n                          X       X                           \r\n                           XX   XX                            \r\n                             X X                              \r\n                              X                               ";
            string turn8 = "        X    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     X        \r\n       XXX    X                               X     XXX       \r\n      XXXXX    XX                           XX     XXXXX      \r\n     XXXXXXX     X                         X      XXXXXXX     \r\n    XXXXXXXXX     X                       X      XXXXXXXXX    \r\n   XXXXXXXXXXX     XX       TURA 8      XX      XXXXXXXXXXX   \r\n  XXXXXXXXXXXXX      X                 X       XXXXXXXXXXXXX  \r\n XXXXXXXXXXXXXXX      X               X       XXXXXXXXXXXXXXX \r\nXXXXXXXXXXXXXXXXX      XX           XX       XXXXXXXXXXXXXXXXX\r\n                         X         X                          \r\n                          X       X                           \r\n                           XX   XX                            \r\n                             X X                              \r\n                              X                               ";
            string turn9 = "        X    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     X        \r\n       XXX    X                               X     XXX       \r\n      XXXXX    XX                           XX     XXXXX      \r\n     XXXXXXX     X                         X      XXXXXXX     \r\n    XXXXXXXXX     X                       X      XXXXXXXXX    \r\n   XXXXXXXXXXX     XX       TURA 9      XX      XXXXXXXXXXX   \r\n  XXXXXXXXXXXXX      X                 X       XXXXXXXXXXXXX  \r\n XXXXXXXXXXXXXXX      X               X       XXXXXXXXXXXXXXX \r\nXXXXXXXXXXXXXXXXX      XX           XX       XXXXXXXXXXXXXXXXX\r\n                         X         X                          \r\n                          X       X                           \r\n                           XX   XX                            \r\n                             X X                              \r\n                              X                               ";
            string turn10 = "        X    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     X        \r\n       XXX    X                               X     XXX       \r\n      XXXXX    XX                           XX     XXXXX      \r\n     XXXXXXX     X                         X      XXXXXXX     \r\n    XXXXXXXXX     X                       X      XXXXXXXXX    \r\n   XXXXXXXXXXX     XX       TURA 10      XX      XXXXXXXXXXX   \r\n  XXXXXXXXXXXXX      X                 X       XXXXXXXXXXXXX  \r\n XXXXXXXXXXXXXXX      X               X       XXXXXXXXXXXXXXX \r\nXXXXXXXXXXXXXXXXX      XX           XX       XXXXXXXXXXXXXXXXX\r\n                         X         X                          \r\n                          X       X                           \r\n                           XX   XX                            \r\n                             X X                              \r\n                              X                               ";
            //string turn11 = "        X    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     X        \r\n       XXX    X                               X     XXX       \r\n      XXXXX    XX                           XX     XXXXX      \r\n     XXXXXXX     X                         X      XXXXXXX     \r\n    XXXXXXXXX     X                       X      XXXXXXXXX    \r\n   XXXXXXXXXXX     XX       TURA 2      XX      XXXXXXXXXXX   \r\n  XXXXXXXXXXXXX      X                 X       XXXXXXXXXXXXX  \r\n XXXXXXXXXXXXXXX      X               X       XXXXXXXXXXXXXXX \r\nXXXXXXXXXXXXXXXXX      XX           XX       XXXXXXXXXXXXXXXXX\r\n                         X         X                          \r\n                          X       X                           \r\n                           XX   XX                            \r\n                             X X                              \r\n                              X                               ";

            switch (turn)
            {
                case 1:
                    WriteTurn(turn1);
                    break;
                case 2:
                    WriteTurn(turn2);
                    break;
                case 3:
                    WriteTurn(turn3);
                    break;
                case 4:
                    WriteTurn(turn4);
                    break;
                case 5:
                    WriteTurn(turn5);
                    break;
                case 6:
                    WriteTurn(turn6);
                    break;
                case 7:
                    WriteTurn(turn7);
                    break;
                case 8:
                    WriteTurn(turn8);
                    break;
                case 9:
                    WriteTurn(turn9);
                    break;
                case 10:
                    WriteTurn(turn10);
                    break;
            }
        }

        private static void WriteTurn(string mess) 
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new Align(new Text($"{mess}"), HorizontalAlignment.Center));
            Thread.Sleep(1000);
            AnsiConsole.Clear();
        }

    }
}
