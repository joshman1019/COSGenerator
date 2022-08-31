namespace COSGenerator; 

public class COSHeader
{
    public string? CaseNumber { get; set; }
    public List<string> Plaintiffs { get; set; } = new List<string>();
    public List<string> Defendants { get; set; } = new List<string>();
    public string? InTheMatterOf { get; set; } = string.Empty; 
    public string ServedDocumentDescription { get; set; }

}