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
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Id"));
                }
            }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set
            {
                level = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this,new PropertyChangedEventArgs("Level"));
                }
            }
        }

    }
}
