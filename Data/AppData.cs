using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;

namespace WinFormsApp2.Data
{
    // Simple class that stores the lighting information of one room
    public class RoomData
    {
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public int Brightness { get; set; }
        public bool IsOn { get; set; }
        public bool IsFavorite { get; set; }
        public Color LightColor { get; set; } = AppColors.PrimaryPurple;
        public bool AutoOffEnabled { get; set; }
        public int AutoOffMinutes { get; set; } = 30;

        public RoomData(string name, string subtitle, int brightness, bool isOn, bool isFavorite)
        {
            Name = name;
            Subtitle = subtitle;
            Brightness = brightness;
            IsOn = isOn;
            IsFavorite = isFavorite;
        }

        public void TurnOn()
        {
            IsOn = true;
            if (Brightness <= 0)
            {
                Brightness = AppData.Settings.DefaultBrightness;
            }
        }

        public void TurnOff()
        {
            IsOn = false;
            Brightness = 0;
        }

        public void SetBrightness(int value)
        {
            if (value < 0) value = 0;
            if (value > 100) value = 100;

            Brightness = value;
            IsOn = Brightness > 0;
        }

        // Simple energy formula: every room has a 60 W lamp
        public double GetWatts()
        {
            if (!IsOn) return 0;
            return 60.0 * Brightness / 100.0;
        }
    }

    // Settings that are saved to settings.json
    public class AppSettings
    {
        public int DefaultBrightness { get; set; } = 75;
        public bool NotificationsEnabled { get; set; } = true;
        public bool AutoOffEnabled { get; set; } = false;
        public string Theme { get; set; } = "Dark Purple";
    }

    // All the data of the application in one simple static class
    public static class AppData
    {
        // Raised every time something changes, so the pages can refresh
        public static event Action DataChanged;

        public static List<RoomData> Rooms { get; } = new List<RoomData>
        {
            new RoomData("Living Room", "Relax & Enjoy", 75, true, true),
            new RoomData("Bedroom", "Sleep in Comfort", 60, true, true),
            new RoomData("Kitchen", "Cook with Clarity", 80, true, true),
            new RoomData("Bathroom", "Fresh & Bright", 0, false, false)
        };

        public static AppSettings Settings { get; set; } = new AppSettings();

        public static bool SecurityArmed { get; set; } = true;
        public static bool EnergySavingMode { get; set; } = false;

        public static void NotifyDataChanged()
        {
            DataChanged?.Invoke();
        }

        // ----- Quick actions -----

        public static void AllLightsOn()
        {
            foreach (RoomData room in Rooms)
            {
                room.TurnOn();
            }
            NotifyDataChanged();
        }

        public static void AllLightsOff()
        {
            foreach (RoomData room in Rooms)
            {
                room.TurnOff();
            }
            NotifyDataChanged();
        }

        public static void NightMode()
        {
            foreach (RoomData room in Rooms)
            {
                room.IsOn = true;
                room.Brightness = 20;
            }
            NotifyDataChanged();
        }

        public static void RelaxMode()
        {
            int[] values = { 40, 30, 40, 20 };
            for (int i = 0; i < Rooms.Count; i++)
            {
                Rooms[i].IsOn = true;
                Rooms[i].Brightness = values[i];
            }
            NotifyDataChanged();
        }

        public static void SetColorForAllRooms(Color color)
        {
            foreach (RoomData room in Rooms)
            {
                room.LightColor = color;
            }
            NotifyDataChanged();
        }

        // Energy saving mode limits every room that is on to 30 %
        public static void ApplyEnergySaving()
        {
            foreach (RoomData room in Rooms)
            {
                if (room.IsOn && room.Brightness > 30)
                {
                    room.Brightness = 30;
                }
            }
            NotifyDataChanged();
        }

        // ----- Calculations -----

        public static int GetAverageBrightness()
        {
            int sum = 0;
            foreach (RoomData room in Rooms)
            {
                sum += room.Brightness;
            }
            return (int)Math.Round((double)sum / Rooms.Count);
        }

        public static int GetOnRoomsCount()
        {
            int count = 0;
            foreach (RoomData room in Rooms)
            {
                if (room.IsOn) count++;
            }
            return count;
        }

        public static int GetOffRoomsCount()
        {
            return Rooms.Count - GetOnRoomsCount();
        }

        public static double GetTotalWatts()
        {
            double total = 0;
            foreach (RoomData room in Rooms)
            {
                total += room.GetWatts();
            }
            return total;
        }

        // ----- Save / load settings (JSON file next to the .exe) -----

        private static string SettingsFilePath
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json"); }
        }

        public static void SaveSettings()
        {
            try
            {
                string json = JsonSerializer.Serialize(Settings, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(SettingsFilePath, json);
            }
            catch (Exception)
            {
                // Saving settings is not critical for this project
            }
        }

        public static void LoadSettings()
        {
            try
            {
                if (File.Exists(SettingsFilePath))
                {
                    AppSettings loaded = JsonSerializer.Deserialize<AppSettings>(File.ReadAllText(SettingsFilePath));
                    if (loaded != null)
                    {
                        Settings = loaded;
                    }
                }
            }
            catch (Exception)
            {
                Settings = new AppSettings();
            }
        }
    }
}
