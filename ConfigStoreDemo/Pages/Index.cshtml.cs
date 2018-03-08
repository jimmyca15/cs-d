namespace ConfigStoreDemo.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class IndexModel : PageModel
    {
        private Settings _settings = new Settings();

        public void OnGet()
        {
            ViewData["AppName"] = _settings.AppName;
            ViewData["RefreshRate"] = _settings.RefreshRate;
            ViewData["Language"] = _settings.Language;
            ViewData["Messages"] = _settings.Messages;
            ViewData["FontSize"] = _settings.FontSize;
            ViewData["BackgroundColor"] = _settings.BackgroundColor;
        }
    }
}
