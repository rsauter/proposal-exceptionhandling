﻿
using ExceptionhandlingDemo.ViewModels.DataViewModels;

namespace ExceptionhandlingDemo.ViewModels
{
    public class HomeDetailsViewModel : BaseViewModel
    {
        public CustomerDataViewModel Customer { get; set; }

        public HomeDetailsViewModel()
        {
            PageTitle = "Customer Details";
            PageSubTitle = "Your Customer Details";
        }
       
    }
}
