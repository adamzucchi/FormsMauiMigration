using System;

namespace FormsMauiMigration.Data
{
    public class Monkey : BaseModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }

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

        private string _imageUrl;
        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value;
                OnPropertyChanged(nameof(Monkey.ImageUrl));
                //OnPropertyChanged(nameof(Monkey.ImageSource));
            }
        }
        //private string _imageUrl;
        //public string ImageUrl
        //{
        //    get { return _imageUrl + $"?cachebust={DateTime.UtcNow.Ticks.ToString()}"; }
        //    set { _imageUrl = value; }
        //}
    }
}