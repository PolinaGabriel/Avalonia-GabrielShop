using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace GabrielShop
{
    public static class ImageHelper
    {
        public static Bitmap LoadFromResource(string resourceUri)
        {
            return new Bitmap(AssetLoader.Open(new Uri(resourceUri)));
        }
    }
}