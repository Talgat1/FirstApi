﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApi.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoListPage : ContentPage
    {
        public TodoListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            TodoLV.ItemsSource = await App.TodoManager.GetTodoItemModels();
        }

        private void TodoLV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new CreateOrEditTodoPage()
            {
                BindingContext = e.SelectedItem as TodoItemModel
            });
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateOrEditTodoPage(true)
            {
                BindingContext = new TodoItemModel()
                {
                    Id = Guid.NewGuid().ToString(),
                }
            });
        }
    }
}