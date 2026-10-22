using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Models
{
    public class SaveDataModel
    {
        public GameState? GameState { get; set; }
        public List<(int, Decision)>? Raport {  get; set; }
    }
}
