using System;
using FormsMauiMigration.Data;
using FormsMauiMigration.Models;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using FreshMvvm.Maui;

namespace FormsMauiMigration.PageModels
{
	public class DetailPageModel : FreshBasePageModel
	{
        #region Fields
        private string _name;
        private string _location;
        private string _details;
        private string _imageUrl;
        private UriImageSource _imageUrlSource;
        #endregion Fields

        #region Constructor
        public DetailPageModel()
		{

		}
        #endregion Constructor

        #region FreshMvvm
        public override void Init(object initData)
        {
            base.Init(initData);

            if(initData != null && initData is Monkey)
            {
                Monkey monkey = (Monkey)initData;

                Name = monkey.Name;
                Location = monkey.Location;
                Details = monkey.Details;
                ImageUrl = monkey.ImageUrl;
                //ImageUrlSource = monkey.ImageUrlSource;
                //System.Diagnostics.Debug.WriteLine($"ImageUrl: { monkey.ImageUrl }");
            }
        }
        #endregion FreshMvvm

        #region Methods

        #endregion Methods

        #region Properties
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(nameof(DetailPageModel.Name));
            }
        }

        public UriImageSource ImageUrlSource
        {
            get
            {
                return _imageUrlSource;
            }
            set
            {
                _imageUrlSource = value;
                RaisePropertyChanged(nameof(DetailPageModel.ImageUrlSource));
            }
        }

        public string Location
        {
            get { return _location; }
            set
            {
                _location = value;
                RaisePropertyChanged(nameof(DetailPageModel.Location));
            }
        }

        public string Details
        {
            get { return _details; }
            set
            {
                _details = value;
                RaisePropertyChanged(nameof(DetailPageModel.Details));
            }
        }

        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value;
                RaisePropertyChanged(nameof(DetailPageModel.ImageUrl));
            }
        }
        #endregion Properties

        #region Commands

        #endregion Commands
    }
}