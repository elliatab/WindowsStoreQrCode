using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using ZXing;

namespace WindowsStoreQrCode
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            var barcodeWriter = new BarcodeWriter
            {
                Renderer = new ZXing.Rendering.PixelDataRenderer(),
                Format = BarcodeFormat.QR_CODE,
                Options = { Height = 250, Width = 250, Margin = 1 }
            };

            var qrPixelData = barcodeWriter.Write("http://zxingnet.codeplex.com/");

            // ToBitmap() returns an object...
            var qrCodeBitmap = qrPixelData.ToBitmap();
            // but it's actually a WriteableBitmap 
            MyQRCode.Source = qrCodeBitmap as WriteableBitmap;
        }       
    }
}
