using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Reflection;

namespace FormsMauiMigration.Data
{
	public class BaseModel : INotifyPropertyChanged
	{
        public object GetPropValue(string propertyName)
        {
            var propInfo = this.GetType().GetTypeInfo().GetDeclaredProperty(propertyName);
            return propInfo.GetValue(this);
        }

        public event PropertyChangedEventHandler PropertyChanged; // Required by INotifyPropertyChanged

        /// <summary>
        ///   This is a helper method that will raise the PropertyChanged event when a property is changed.
        /// </summary>
        /// <param name="propertyName">Property name. If null, then this property will hold the name of the member that invoked it.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

