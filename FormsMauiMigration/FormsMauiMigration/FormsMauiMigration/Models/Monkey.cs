using System;


namespace FormsMauiMigration.Models
{
    public class Monkey
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }

        //public Xamarin.Forms.ImageSource Image
        //{
        //    get { return Xamarin.Forms.ImageSource.FromUri(new Uri(ImageUrl)); }
        //}

        //public Xamarin.Forms.UriImageSource ImageSource
        //{
        //    get
        //    {
        //        return new Xamarin.Forms.UriImageSource
        //        {
        //            Uri = new Uri(ImageUrl),
        //            CachingEnabled = true,
        //            CacheValidity = new TimeSpan(0,0,10)
        //        };
        //    }
        //}

        //private string _imageUrl;
        //public string ImageUrl
        //{
        //    get { return _imageUrl; }
        //    set
        //    {
        //        _imageUrl = value;
        //    }
        //}

        //private string _imageUrl;
        //public string ImageUrl
        //{
        //    get { return _imageUrl + $"?cachebust={DateTime.UtcNow.Ticks.ToString()}"; }
        //    set { _imageUrl = value; }
        //}
    }
}