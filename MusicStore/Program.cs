using MusicStore.Instruments;

namespace MusicStore;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    public static InstrumentsData? InstrumentsData;
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}