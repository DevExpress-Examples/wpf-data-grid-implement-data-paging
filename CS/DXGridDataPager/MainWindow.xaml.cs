using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DXGridDataPager {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            DataContext = new VM();
            InitializeComponent();
        }
    }
    public class VM : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        int pageIndex = 1;
        public int PageIndex {
            get { return pageIndex; }
            set {
                if(value == pageIndex) return;
                pageIndex = value;
                OnPropertyChanged("PageIndex");
            }
        }
        protected void OnPropertyChanged(string propertyName) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public List<TestDataList> PagedCollection { get; private set; }
        public VM() {
            PagedCollection = new List<TestDataList>();
            PagedCollection.Add(TestDataList.Create(0));
            PagedCollection.Add(TestDataList.Create(3));
            PagedCollection.Add(TestDataList.Create(5));
            PagedCollection.Add(TestDataList.Create(7));
            PageIndex = 2;
        }
    }
    public class TestDataList : ObservableCollection<TestDataItem> {
        public static TestDataList Create(int cc) {
            TestDataList res = new TestDataList();
            for(int i = 0; i < 10; i++) {
                TestDataItem item = new TestDataItem();
                item.ID = i;
                item.Value = ((char)((int)'A' + cc)).ToString();
                res.Add(item);
            }
            for(int i = 0; i < 10; i++) {
                TestDataItem item = new TestDataItem();
                item.ID = i;
                item.Value = ((char)((int)'B' + cc)).ToString();
                res.Add(item);
            }
            return res;
        }
    }
    public class TestDataItem {
        public int ID { get; set; }
        public string Value { get; set; }
    }
}
