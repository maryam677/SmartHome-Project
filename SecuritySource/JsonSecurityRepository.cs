using System.Text.Json;
using System.Text.Json.Serialization;

namespace WinFormsApp2.SmartHomeSecurity;

// Simple file-based repository so the log survives restarts.
// Replace it with a database-backed ISecurityRepository when the shared DB is ready.
public sealed class JsonSecurityRepository : ISecurityRepository
{
    private static readonly JsonSerializerOptions Options = new()
    {
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter() }
    };

    private readonly object _lock = new();
    private readonly string _path;
    private List<SecurityEvent>? _cache;

    public JsonSecurityRepository(string? path = null)
    {
        _path = path ?? Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "SmartHome", "security-log.json");
    }

    public IReadOnlyList<SecurityEvent> LoadAll()
    {
        lock (_lock) return Load().ToList();
    }

    public void Save(SecurityEvent e)
    {
        lock (_lock)
        {
            Load().Add(e);
            Write();
        }
    }

    public void Clear()
    {
        lock (_lock)
        {
            Load().Clear();
            Write();
        }
    }

    private List<SecurityEvent> Load()
    {
        if (_cache != null) return _cache;
        try
        {
            _cache = File.Exists(_path)
                ? JsonSerializer.Deserialize<List<SecurityEvent>>(File.ReadAllText(_path), Options) ?? new()
                : new();
        }
        catch (JsonException)
        {
            _cache = new(); // corrupted file: start fresh
        }
        return _cache;
    }

    private void Write()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(_path)!);
        string tmp = _path + ".tmp";
        File.WriteAllText(tmp, JsonSerializer.Serialize(_cache, Options));
        File.Move(tmp, _path, overwrite: true);
    }
}
