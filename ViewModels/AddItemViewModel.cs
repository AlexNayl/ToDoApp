using System;

namespace ToDoApp.ViewModels
{
    public class AddItemViewModel : ViewModelBase
    {
        public string Description { get; set; } = String.Empty;
    }
}