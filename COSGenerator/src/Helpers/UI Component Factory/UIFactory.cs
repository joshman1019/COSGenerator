using ConsoleUIUtilities2;

public static class UIFactory
{
    /// <summary>
    /// Returns a standard <see cref="Header"/>
    /// </summary>
    /// <returns></returns>
    public static Header GenerateStandardHeader()
    {
        Header hdr = new Header();
        hdr.AddHeaderLine("Certificate of Service Generator");
        hdr.AddHeaderLine("2022 - Molecule Software Systems");
        hdr.AddHeaderLine("Joshua H. Santiago : Developer");
        hdr.SetTopLineChar('-');
        hdr.SetBottomLineChar('=');
        return hdr; 
    }
}