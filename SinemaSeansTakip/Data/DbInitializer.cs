using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using SinemaSeansTakip.Models;

namespace SinemaSeansTakip
{
    public static class DbInitializer
    {
        private static string connectionString = "Data Source=..\\..\\files\\SinemaSeansTakip.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists("..\\..\\files\\SinemaSeansTakip.db")) 
            {
                SQLiteConnection.CreateFile("..\\..\\files\\SinemaSeansTakip.db");
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                  
                    string createFilmTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Film(
                            id INTEGER PRIMARY KEY NOT NULL,
                            filmAdi TEXT NOT NULL
                            
                      );";
                    string insertFilmQuery = @"
                    INSERT INTO Film (FilmAdi) VALUES ('İhtiyar Delikanlı');
                    INSERT INTO Film (FilmAdi) VALUES ('Köylüler');
                    INSERT INTO Film (FilmAdi) VALUES ('Demir Pençe');
                    INSERT INTO Film (FilmAdi) VALUES ('Çocuk ve Balıkçıl');";

                    string createSalonTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Salon(
                            id INTEGER PRIMARY KEY NOT NULL,
                            SalonKapasite INTEGER NOT NULL
                        );";

                    string insertSalonQuery = @"
                    INSERT INTO Salon (SalonKapasite) VALUES (96)";
                   
                    string createSeansTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Seans(
                            id INTEGER PRIMARY KEY NOT NULL,
                            tarih TEXT NOT NULL,
                            saat INTEGER NOT NULL,
                            filmId INTEGER NOT NULL,
                            salonId INTEGER NOT NULL,
                            FOREIGN KEY (filmId) REFERENCES Film(id),
                            FOREIGN KEY (salonId) REFERENCES Salon(id)

                        );";

                    string insertSeansQuery = @"
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('20.04.2024', '14:00', 1, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('20.04.2024', '16:15', 2, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('20.04.2024', '18:30', 3, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('21.04.2024', '14:00', 2, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('21.04.2024', '16:30', 1, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('21.04.2024', '18:45', 3, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('22.04.2024', '14:00', 1, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('22.04.2024', '16:15', 3, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('22.04.2024', '18:30', 2, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('23.04.2024', '14:00', 4, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('23.04.2024', '16:30', 4, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('24.04.2024', '14:00', 4, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('25.04.2024', '14:00', 1, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('25.04.2024', '16:15', 3, 1);
                    INSERT INTO Seans (tarih, saat, filmId, salonId ) VALUES ('25.04.2024', '18:30', 3, 1);";


                    string createRezervasyonTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Seans(
                            id INTEGER PRIMARY KEY NOT NULL,
                            koltukNo TEXT NOT NULL,
                          
                            seansId INTEGER NOT NULL,
                            FOREIGN KEY (seansId) REFERENCES Seans(id)
                           
                        );";

                    string insertRezervasyonQuery = @"
                   ;";


                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createFilmTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertFilmQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createSalonTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertSalonQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createSeansTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertSeansQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createRezervasyonTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertRezervasyonQuery;
                        command.ExecuteNonQuery();


                    }

                }
            }
        }
    }
}