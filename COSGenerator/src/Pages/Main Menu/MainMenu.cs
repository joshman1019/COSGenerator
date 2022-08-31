using ConsoleUIUtilities2;

namespace COSGenerator; 

public class MainMenu : Page
{
    protected override void BuildComponent()
    {
        // Set standard header
        SetHeader(UIFactory.GenerateStandardHeader());

        // Create Menu
        Menu mn = new Menu();
        mn.AddMenuItem(new MenuItem("1) Prepare a certificate header", new ConsoleKey[] { ConsoleKey.D1, ConsoleKey.NumPad1 }, PrepareCertificateHeader_COMMAND));
        mn.AddMenuItem(new MenuItem("2) Add/Remove Recipient", new ConsoleKey[] { ConsoleKey.D2, ConsoleKey.NumPad2 }, AddRemoveRecipient_COMMAND));
        mn.AddMenuItem(new MenuItem("ESC) Exit the application", new ConsoleKey[] { ConsoleKey.Escape }, () =>
        {
            // Breaks the menu
            mn.CallMenuBreakExternal();
        }));

        // Add the menu to the page
        SetMenu(mn);
    }

    private void PrepareCertificateHeader_COMMAND()
    {
        // At this time do nothing
    }

    private void AddRemoveRecipient_COMMAND()
    {
        // At this time do nothing
    }
}
