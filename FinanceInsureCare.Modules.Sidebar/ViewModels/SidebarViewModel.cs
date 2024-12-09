﻿using FinanceInsureCare.Core.Constants;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace FinanceInsureCare.Modules.Sidebar.ViewModels
{
    internal class SidebarViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        
        private DelegateCommand<string> _navigateCommand;

        public DelegateCommand<string> NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(ExecuteNavigateCommand));

        public SidebarViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _regionManager.RequestNavigate(RegionNames.ContentRegion, ViewNames.DashboardView);
        }

        private void ExecuteNavigateCommand(string path)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, path);
        }
    }
}