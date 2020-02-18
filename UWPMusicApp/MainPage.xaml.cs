using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using UWPMusicApp.Model;
using static UWPMusicApp.Model.Music;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPMusicApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Music> musics;
        //Load Pane
        private List<MenuItem> menuItems;
        public MainPage()
        {
            this.InitializeComponent();
            //Create a point to store obervable collection musics
            musics = new ObservableCollection<Music>();
            // call static class
            MusicManager.GetAllMusics(musics);
            //INstantiate Menu List
            menuItems = new List<MenuItem>();
            //Load Pane
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/Classical.png",
                Category = MusicCategory.Classical
            });
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/Country.png",
                Category = MusicCategory.Country
            });
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/International.png",
                Category = MusicCategory.International
            });
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/Rock.png",
                Category = MusicCategory.Rock
            });


        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MysplitView.IsPaneOpen = !MysplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MusicManager.GetAllMusics(musics);
            CategoryTextBlock.Text = "KSS Music Library";
            //Menu Item no longer selected, greyed out
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem= (MenuItem)e.ClickedItem;
            CategoryTextBlock.Text = menuItem.Category.ToString();
            //UseLayoutRounding same musics collecton memory
            MusicManager.GetMusicByCategory(musics, menuItem.Category);
            BackButton.Visibility = Visibility.Visible;
        }

        private void MusicGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var music= (Music)e.ClickedItem;
            MyMediaElement.Source = new Uri(this.BaseUri, music.AudioFile);
        }
    }
}
