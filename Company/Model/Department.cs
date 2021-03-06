using System.ComponentModel;

namespace Company.Model
{
    class Department : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int Id { get; private set; }
        private string _departName;

        public string DepartName
        {
            get
            {
                return _departName;
            }
            set
            {
                _departName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DepartName"));
            }
        }
        public Department(int id, string name)
        {
            Id = id;
            _departName = name;
        }
        public Department()
        {

        }
    }
}
