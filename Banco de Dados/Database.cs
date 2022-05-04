using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using sistema_academia.Classes;

namespace sistema_academia.Banco_de_Dados
{
    public static class Database
    {

        public static async Task CriarAlunoAsync()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "sistema-academia.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            FirestoreDb db = FirestoreDb.Create("sistema-academia-aee3a");

            DocumentReference docRef = db.Collection("teste").Document("alovelace");
            Dictionary<string, object> user = new Dictionary<string, object>
            {
                { "First", "Ada" },
                { "Last", "Lovelace" },
                { "Born", 1815 }
            };
            _ = await docRef.SetAsync(user);

            MessageBox.Show("a");
        }
    }
}
