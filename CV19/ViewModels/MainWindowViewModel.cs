﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CV19.Infrastructure.Commands;
using CV19.Models;
using CV19.ViewModels.Base;



namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {

        private readonly CountriesStatisticViewModel _CountriesStatisticViewModel;


        #region Заголовок окна

        private string _Title = "MVVM WPF Lessons";

        /// <summary> Заголовок окна </summary>
        public string Title
        {
            get => _Title;
            //set 
            //{
            //    //if (Equals(_Title, value)) return;
            //    //_Title = value;
            //    //OnProrertyChanged();

            //    Set(ref _Title, value);
            //}
            set => Set(ref _Title, value);
        }
        #endregion

        public MainWindowViewModel()
        {
            _CountriesStatisticViewModel = new CountriesStatisticViewModel(this);
        }
    }
}
