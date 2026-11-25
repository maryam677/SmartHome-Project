using System.Text.Json;
using System.Text.Json.Serialization;

namespace WinFormsApp2.Data;

public enum RoomDeviceGlyph
{
    Bulb,
    Screen,
    Thermo,
    Camera,
    Snowflake,
    Fridge,
    Faucet,
    Drop,
    Fan,
    Printer
}

public enum RoomPhotoKind
{
    Living,
    Bedroom,
    Kitchen,
    Bathroom,
    Office,
    Kids
}

public sealed class RoomDevice
{
    public RoomDeviceGlyph Glyph { get; set; }
    public int Count { get; set; }
    public bool IsOn { get; set; } = true;

    public RoomDevice()
    {
    }

    public RoomDevice(RoomDeviceGlyph glyph, int count, bool isOn = true)
    {
        Glyph = glyph;
        Count = count;
        IsOn = isOn;
    }
}

public sealed class RoomRecord
{
    public string Name { get; set; } = "";
    public RoomPhotoKind Photo { get; set; }
    public double BaseKwh { get; set; }
    public List<RoomDevice> Devices { get; set; } = new();

    public int DeviceCount => Devices.Sum(device => Math.Max(0, device.Count));

    public int DevicesOn => Devices.Where(device => device.IsOn).Sum(device => Math.Max(0, device.Count));

    public int ActivePercent => DeviceCount == 0 ? 0 : (int)Math.Round(100.0 * DevicesOn / DeviceCount);

    public bool IsOn => DevicesOn > 0;

    public double LiveKwh => DeviceCount == 0 || !IsOn ? 0 : BaseKwh * DevicesOn / DeviceCount;
}

public static class RoomCatalog
{
    private static readonly List<RoomRecord> rooms = new();
    private static readonly JsonSerializerOptions jsonOptions = new()
    {
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter() }
    };

    static RoomCatalog()
    {
        Load();
    }

    public static IReadOnlyList<RoomRecord> Rooms => rooms;

    public static int DeviceCount => rooms.Sum(room => room.DeviceCount);

    public static int DevicesOn => rooms.Sum(room => room.DevicesOn);

    public static int DevicesOff => Math.Max(0, DeviceCount - DevicesOn);

    public static double LiveKwh => rooms.Sum(room => room.LiveKwh);

    public static int CountOn(RoomDeviceGlyph glyph)
    {
        return rooms.SelectMany(room => room.Devices)
            .Where(device => device.Glyph == glyph && device.IsOn)
            .Sum(device => Math.Max(0, device.Count));
    }

    public static void Add(RoomRecord room)
    {
        rooms.Add(room);
        Save();
    }

    public static void Remove(RoomRecord room)
    {
        rooms.Remove(room);
        Save();
    }

    public static void Save()
    {
        try
        {
            File.WriteAllText(FilePath, JsonSerializer.Serialize(rooms, jsonOptions));
        }
        catch (IOException)
        {
        }
        catch (UnauthorizedAccessException)
        {
        }
    }

    public static RoomRecord Create(string name, string type)
    {
        RoomPhotoKind photo = type switch
        {
            "Living Room" => RoomPhotoKind.Living,
            "Bedroom" => RoomPhotoKind.Bedroom,
            "Kitchen" => RoomPhotoKind.Kitchen,
            "Bathroom" => RoomPhotoKind.Bathroom,
            "Office" => RoomPhotoKind.Office,
            "Kids Room" => RoomPhotoKind.Kids,
            _ => RoomPhotoKind.Living
        };

        return new RoomRecord
        {
            Name = name,
            Photo = photo,
            BaseKwh = 3.2,
            Devices = new List<RoomDevice>
            {
                new(RoomDeviceGlyph.Bulb, 1, true),
                new(RoomDeviceGlyph.Thermo, 1, true)
            }
        };
    }

    private static bool StripBathroomCameras()
    {
        bool changed = false;
        foreach (RoomRecord room in rooms)
        {
            bool bathroom = room.Photo == RoomPhotoKind.Bathroom
                || room.Name.Contains("Bath", StringComparison.OrdinalIgnoreCase);
            if (!bathroom || room.Devices == null)
                continue;
            int removed = room.Devices.RemoveAll(device => device.Glyph == RoomDeviceGlyph.Camera);
            if (removed > 0)
                changed = true;
        }
        return changed;
    }

    private static string FilePath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rooms.json");

    private static void Load()
    {
        try
        {
            if (File.Exists(FilePath))
            {
                List<RoomRecord>? loaded = JsonSerializer.Deserialize<List<RoomRecord>>(File.ReadAllText(FilePath), jsonOptions);
                if (loaded != null)
                {
                    rooms.AddRange(loaded.Where(room => room.Devices != null));
                    if (StripBathroomCameras())
                        Save();
                    return;
                }
            }
        }
        catch (JsonException)
        {
        }
        catch (IOException)
        {
        }

        rooms.AddRange(Seed());
        Save();
    }

    private static IEnumerable<RoomRecord> Seed()
    {
        yield return Room("Living Room", RoomPhotoKind.Living, 12.6,
            new RoomDevice(RoomDeviceGlyph.Bulb, 3, true),
            new RoomDevice(RoomDeviceGlyph.Screen, 1, true),
            new RoomDevice(RoomDeviceGlyph.Thermo, 1, true),
            new RoomDevice(RoomDeviceGlyph.Camera, 1, false));
        yield return Room("Bedroom", RoomPhotoKind.Bedroom, 8.4,
            new RoomDevice(RoomDeviceGlyph.Bulb, 2, true),
            new RoomDevice(RoomDeviceGlyph.Snowflake, 1, true),
            new RoomDevice(RoomDeviceGlyph.Thermo, 1, false));
        yield return Room("Kitchen", RoomPhotoKind.Kitchen, 10.2,
            new RoomDevice(RoomDeviceGlyph.Bulb, 2, true),
            new RoomDevice(RoomDeviceGlyph.Fridge, 1, true),
            new RoomDevice(RoomDeviceGlyph.Faucet, 1, false),
            new RoomDevice(RoomDeviceGlyph.Thermo, 1, true));
        yield return Room("Bathroom", RoomPhotoKind.Bathroom, 4.1,
            new RoomDevice(RoomDeviceGlyph.Bulb, 1, true),
            new RoomDevice(RoomDeviceGlyph.Drop, 1, true),
            new RoomDevice(RoomDeviceGlyph.Fan, 1, false));
        yield return Room("Office", RoomPhotoKind.Office, 6.5,
            new RoomDevice(RoomDeviceGlyph.Bulb, 2, true),
            new RoomDevice(RoomDeviceGlyph.Screen, 1, false),
            new RoomDevice(RoomDeviceGlyph.Printer, 1, false));
        yield return Room("Kids Room", RoomPhotoKind.Kids, 5.3,
            new RoomDevice(RoomDeviceGlyph.Bulb, 2, true),
            new RoomDevice(RoomDeviceGlyph.Screen, 1, true),
            new RoomDevice(RoomDeviceGlyph.Thermo, 1, false));
    }

    private static RoomRecord Room(string name, RoomPhotoKind photo, double kwh, params RoomDevice[] devices)
    {
        return new RoomRecord
        {
            Name = name,
            Photo = photo,
            BaseKwh = kwh,
            Devices = devices.ToList()
        };
    }
}
