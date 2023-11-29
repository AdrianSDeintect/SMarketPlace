using Serenity.ComponentModel;

namespace SMarketPlace.Log.Forms;

[FormScript("Log.Promocionesuber")]
[BasedOnRow(typeof(PromocionesuberRow), CheckNames = true)]
public class PromocionesuberForm
{
    public string LocalSap { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string FormatDescription { get; set; }
    public string FormatDescriptionShort { get; set; }
    public string Name { get; set; }
    public int ProductId { get; set; }
}