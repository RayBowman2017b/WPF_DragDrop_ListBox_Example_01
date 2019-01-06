using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using GongSolutions.Wpf.DragDrop;

/******************************************************

    CODE is from:
    https://www.codeproject.com/Tips/805035/%2FTips%2F805035%2FReorder-DataGrid-ListBox-Items-with-Drag-and-Drop

******************************************************/

namespace Reorder_item_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        private void ListBox_Drop(object sender,DragEventArgs e)
        {
            int x=0;
        }
    }

    public class DragDropHandler : IDropTarget
    {

        void IDropTarget.DragOver(DropInfo dropInfo)
        {
            if (dropInfo.Data is MSP)
            {
                dropInfo.DropTargetAdorner = DropTargetAdorners.Highlight;
                dropInfo.Effects = DragDropEffects.Move;
            }
        }

        void IDropTarget.Drop(DropInfo dropInfo)
        {
            int x=0;
        }

        //public MyDropHandler(MainWindowViewModel mainWindowViewModel)
        //{
        //    _mainWindowViewModel = mainWindowViewModel;
        //}

        //public void DragOver(IDropInfo dropInfo)
        //{
        //    dropInfo.Effects = DragDropEffects.Copy;
        //}

        //public void Drop(IDropInfo dropInfo)
        //{
        //    _mainWindowViewModel.Name = (string) dropInfo.Data;
        //}
    }    



}
