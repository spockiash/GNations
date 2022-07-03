using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace GNations.Web.Services
{
    public class BrowserService
    {
        private readonly IJSRuntime _js;

        public BrowserService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<BrowserDimension> GetDimensions()
        {
            return await _js.InvokeAsync<BrowserDimension>("getDimensions");
        }

        public async Task<BrowserDimension> ResizeMap()
        {
            return await _js.InvokeAsync<BrowserDimension>("ResizeMap");
        }

        public async Task<MapPosition> GetMapPosition()
        {
            return await _js.InvokeAsync<MapPosition>("GetMapPosition");
        }

    }

    public class BrowserDimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class MapPosition
    {
        public int Top { get; set; }
        public int Left { get; set; }
    }
}
