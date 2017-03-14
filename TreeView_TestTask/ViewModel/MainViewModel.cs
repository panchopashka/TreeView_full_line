using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Windows;
using System;

namespace TreeView_TestTask.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public const string TitlePropertyName = "Title";
        public string Title { get; set; }
        private IRepository _repository;

        public MainViewModel(IRepository repository)
        {
            _repository = repository;
            Categories = new ObservableCollection<Category>();
            Title = "TreeView";
        }

        private void UpdateCategories()
        {
            Categories.AddRange(_repository.getCategories(Categories.Count + 1));
        }

        private async Task UpdateCategoriesFiltred()
        {
            if (CategoriesFiltred == null)
            {
                CategoriesFiltred = new ObservableCollection<Category>();
            }

            if (string.IsNullOrWhiteSpace(SearchText))
            {
                CategoriesFiltred.ReplaceRange(Categories);
            }
            else
            {
                string lowerSearchText = SearchText.ToLower();
                await SearchTextInCollectionAsync(lowerSearchText, Categories, CategoriesFiltred);
            }
        }

        private  Task SearchTextInCollectionAsync(string text, IEnumerable<Category> collection, ObservableCollection<Category> newCollection)
        {
            return Task.Run(() =>
            {
              
                List<Category> tempCollection = new List<Category>();
                foreach (Category cat in collection)
                {
                    Category tempCategory = new Category();
                    bool isItemReduced = false;
                    tempCategory.Number = cat.Number;
                    tempCategory.Items = new List<Item>();

                    if (cat.Name.ToLower().Contains(text))
                    {
                        tempCategory.Color = "Green";
                        tempCategory.IsExpanded = true;
                    }

                    foreach (Item item in cat.Items)
                    {
                        if (item.Name.ToLower().Contains(text))
                        {
                            tempCategory.IsExpanded = true;
                            isItemReduced = true;
                            tempCategory.Items.Add(new Item() { Number = item.Number, Color = "Green" });
                        }
                    }

                    if (!isItemReduced)
                        foreach (Item item in cat.Items)
                        {
                            tempCategory.Items.Add(new Item() { Number = item.Number });
                        }

                    if (tempCategory.IsExpanded)
                        tempCollection.Add(tempCategory);

                    Debug.WriteLine("Thread #" + Thread.CurrentThread.ManagedThreadId + " : work");
                }
                Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, 
                    new Action( () => newCollection.ReplaceRange(tempCollection)));
            });
        }


        #region Properties

        public const string SearchTextPropertyName = "SearchText";
        private string _searchText = null;

        public string SearchText
        {
            get
            {
                return _searchText;
            }

            set
            {
                if (_searchText == value)
                {
                    return;
                }

                _searchText = value;
                RaisePropertyChanged(SearchTextPropertyName);
            }
        }

        public const string CategoriesPropertyName = "Categories";
        private ObservableCollection<Category> _categories = null;
        public ObservableCollection<Category> Categories
        {
            get
            {
                return _categories;
            }

            set
            {
                if (_categories == value)
                {
                    return;
                }

                _categories = value;
                RaisePropertyChanged(CategoriesPropertyName);
            }
        }

        public const string CategoriesFiltredPropertyName = "CategoriesFiltred";
        private ObservableCollection<Category> _categoriesFiltred = null;
        public ObservableCollection<Category> CategoriesFiltred
        {
            get
            {
                return _categoriesFiltred;
            }

            set
            {
                if (_categoriesFiltred == value)
                {
                    return;
                }

                _categoriesFiltred = value;
                RaisePropertyChanged(CategoriesFiltredPropertyName);
            }
        }

        #endregion

        protected async override void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName == "SearchText")
                await UpdateCategoriesFiltred();
            else
                base.RaisePropertyChanged(propertyName);      
        }

        private RelayCommand _loadCategories;

        public RelayCommand LoadCategories
        {
            get
            {
                return _loadCategories
                    ?? (_loadCategories = new RelayCommand(
                    async () =>
                    {
                        UpdateCategories();
                        await UpdateCategoriesFiltred();
                    }));
            }
        }

    }
}