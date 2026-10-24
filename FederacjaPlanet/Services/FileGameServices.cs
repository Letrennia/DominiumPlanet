using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using DominiumPlanet.Models;
using Spectre.Console;
using DominiumPlanet.Views;

namespace DominiumPlanet.Services
{
    internal class FileGameServices
    {
        public void SaveGameToJSON(SaveDataModel saveDataModel)
        {
            try
            {
                string filename = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../Data/save_username.json"));

                string raport = JsonConvert.SerializeObject(saveDataModel, Formatting.Indented);
                File.WriteAllText(filename, raport);
                ReactionView.PositiveSave();

            }
            catch (Exception ex)
            {
                ReactionView.NegativeSave(ex);
            }
        }

        public SaveDataModel ReadGameFromJSON()
        {
            try
            {
                string filename = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../Data/save_username.json"));
                string data = File.ReadAllText(filename);
                SaveDataModel? saveDataModel = JsonConvert.DeserializeObject<SaveDataModel>(data);
                ReactionView.PositiveRead();
                return saveDataModel;
            }
            catch (Exception ex)
            {
                ReactionView.NegativeRead(ex);
                return null;
            }
            
        }
    }
}
