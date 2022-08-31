using ConsoleUIUtilities2;

namespace COSGenerator; 

public class MainMenu_Container : PageContainer<MainMenu>
{
    public MainMenu_Container(MainMenu page) : base(page) { }

    public override void ShowPage()
    {
        Page.ShowAndLoadMenu(0, 6, 45, "Main Menu");
    }
}