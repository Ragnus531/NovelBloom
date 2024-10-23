using MudBlazor;

namespace NovelBloom.Styles;

public class MainTheme : MudTheme
{
    public MainTheme()
    {
        PaletteLight = new PaletteLight
        {
            White = "#FFFFFF",
            Primary = "#a9a9a9",
            Secondary = "#e97b06",
            Tertiary = "#FFFFFF",
        };
    }
}
