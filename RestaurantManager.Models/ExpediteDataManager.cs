using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        private List<Order> _orderItems;

        protected override void OnDataLoaded()
        {
            this.OrderItems = base.Repository.Orders;
        }

        public List<Order> OrderItems
        {
            //get { return base.Repository.Orders; }
            //set { OnPropertyChanged(); }
            
            get { return _orderItems; }
            set { _orderItems = value; OnPropertyChanged(); }
        }
    }
}
