using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF__数据绑定
{
    internal class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

		private string name;

		public string Name
		{
			get { return name; }
			set 
			{ 
				name = value; 
				if(PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs("Name"));
				}
			}
		}

	}
}
