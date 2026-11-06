namespace WinFormsApp2.SmartHomeSecurity;

// Implement this against the shared database and pass it to SecurityService.
public interface ISecurityRepository
{
    IReadOnlyList<SecurityEvent> LoadAll();
    void Save(SecurityEvent e);
    void Clear();
}

// Default: nothing is stored (events live in memory only).
public sealed class NullSecurityRepository : ISecurityRepository
{
    public IReadOnlyList<SecurityEvent> LoadAll() => Array.Empty<SecurityEvent>();
    public void Save(SecurityEvent e) { }
    public void Clear() { }
}
