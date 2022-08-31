namespace COSGenerator; 

public class Application
{
    /// <summary>
    /// Standard constructor
    /// </summary>
    public Application(MainMenu? menu = null)
    {
        // Calls the main menu to open and creates an application loop 
        MainMenu_Container container = new MainMenu_Container(menu ?? new MainMenu());
        container.ShowPage();
    }
}