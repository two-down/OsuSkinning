using OsuSkinning.MODEL;
using System.Collections.ObjectModel;
using System.Windows;

namespace OsuSkinning.UI
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Skin> SkinNames = new ObservableCollection<Skin>();

        public MainWindow()
        {
            InitializeComponent();

            skinBrowserTreeView.ItemsSource = SkinNames;
        }
    }
}
