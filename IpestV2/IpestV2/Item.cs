using System.Collections.ObjectModel;


namespace IpestV2
{
    public class Item
    {
        public int id { get; set; } 
        public int priority { get; set; }
        public int catches { get; set; }
        public int battery { get; set; }
        public int scheduled { get; set; }

        public Item()
        {

        }
        public Item(int idD , int priorityD ,int catchesD ,  int batteryD, int scheduledD)
        {
            this.id = idD; 
            this.priority = priorityD;
            this.catches = catchesD;
            this.battery = batteryD;
            this.scheduled = scheduledD;
           // CustomerList = new ObservableCollection<items>();
        }
    }
}