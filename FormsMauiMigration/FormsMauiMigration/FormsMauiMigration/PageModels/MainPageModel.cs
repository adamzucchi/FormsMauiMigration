using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using FormsMauiMigration.Data;
using FormsMauiMigration.Interfaces;
using FormsMauiMigration.Models;
using FreshMvvm;
using Xamarin.Forms;

namespace FormsMauiMigration.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        private ICloudService _cloudService;
        private IDataService _dataService;
        private Monkey _selectedMonkey;
        private ObservableCollection<Monkey> _monkeys;

        #region Constructor
        public MainPageModel(ICloudService cloudService, IDataService dataService)
        {
            _cloudService = cloudService;
            _dataService = dataService;

            SelectedMonkeyChangedCommand = new Command(async () => await SelectedMonkeyChanged());
        }
        #endregion Constructor

        #region FreshMvvmLifecycleMethods
        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            Task.Run(async () =>
            {
                IList<Monkey> monkeys = await _cloudService.GetMonkeys();

                foreach(Monkey cloudMonkey in monkeys)
                {
                    Data.Models.Monkey dbMonkey = new Data.Models.Monkey
                    {
                        Id = cloudMonkey.Id,
                        Name = cloudMonkey.Name,
                        Details = cloudMonkey.Details,
                        Location = cloudMonkey.Location,
                        ImageUrl = cloudMonkey.ImageUrl
                    };

                    await _dataService.MonkeyRepository.Save(dbMonkey);
                }

                Device.BeginInvokeOnMainThread(() =>
                {
                    Monkeys = new ObservableCollection<Monkey>(monkeys);
                });
            });
        }
        #endregion FreshMvvmLifecycleMethods

        #region Methods
        private async Task SelectedMonkeyChanged()
        {
            if(_selectedMonkey != null)
            {
                await CoreMethods.PushPageModel<DetailPageModel>(_selectedMonkey);

                SelectedMonkey = null;
            }
        }
        #endregion Methods

        #region Properties
        public Monkey SelectedMonkey
        {
            get { return _selectedMonkey; }
            set
            {
                _selectedMonkey = value;
                RaisePropertyChanged(nameof(MainPageModel.SelectedMonkey));
            }
        }

        public ObservableCollection<Monkey> Monkeys
        {
            get { return _monkeys; }
            set
            {
                _monkeys = value;
                RaisePropertyChanged(nameof(MainPageModel.Monkeys));
            }
        }
        #endregion Properties

        #region Commands
        public ICommand SelectedMonkeyChangedCommand
        {
            get;
            private set;
        }
        #endregion Commands
    }
}

