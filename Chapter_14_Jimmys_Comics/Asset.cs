namespace Chapter_14_Jimmys_Comics
{
    public class Asset
    {
        private Asset(string fileName)
        {
            FileName = fileName;
        }

        public string FileName { get; set; }

        public static Asset BlueGray => new Asset("bluegray_250x250.jpg");
        public static Asset Issue19 => new Asset("Captain Amazing Issue 19 cover.png");
        public static Asset Issue36 => new Asset("Captain Amazing Issue 36 cover.png");
        public static Asset Issue57 => new Asset("Captain Amazing Issue 57 cover.png");
        public static Asset Issue6 => new Asset("Captain Amazing Issue 6 cover.png");
        public static Asset Issue68 => new Asset("Captain Amazing Issue 68 cover.png");
        public static Asset Issue74 => new Asset("Captain Amazing Issue 74 cover.png");
        public static Asset Issue84 => new Asset("Captain Amazing Issue 84 cover.png");
        public static Asset Issue97 => new Asset("Captain Amazing Issue 97 cover.png");
        public static Asset CaptainAmazing => new Asset("captain_amazing_250x250.jpg");
        public static Asset CaptainAmazingZoom => new Asset("captain_amazing_zoom_250x250.jpg");
        public static Asset Purple => new Asset("purple_250x250.jpg");
    }
}