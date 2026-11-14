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
    public class FileGameServices
    {
        public static Action? PositiveRead;
        public void SaveGameToJSON(SaveDataModel saveDataModel)
        {
            try
            {
                //string filename = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../Data/save_username.json"));
                string filename = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../DataWpf/save_username.json"));

                string raport = JsonConvert.SerializeObject(saveDataModel, Formatting.Indented);
                File.WriteAllText(filename, raport);
                //ReactionView.PositiveSave(); // do konsoli
                PositiveRead.Invoke();

            }
            catch (Exception ex)
            {
                throw new Exception("Błąd podczas odczytu zapisu gry.", ex);
                //ReactionView.NegativeSave(ex); //do konsoli
            }
        }

        public SaveDataModel ReadGameFromJSON()
        {
            try
            {

                string filename = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../DataWpf/save_username.json"));
                //string filename = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../Data/save_username.json"));

                
                string data = File.ReadAllText(filename);
                SaveDataModel? saveDataModel = JsonConvert.DeserializeObject<SaveDataModel>(
                    data, new JsonSerializerSettings
                    {
                        ObjectCreationHandling = ObjectCreationHandling.Replace
                    });
                //ReactionView.PositiveRead(); //do konsoli

                return saveDataModel;
            }
            catch (Exception ex)
            {
                throw new Exception("Błąd podczas odczytu zapisu gry.", ex);
                //ReactionView.NegativeRead(ex); //do konsoli
                return null;
            }
            
        }
    }
}
