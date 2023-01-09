using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using System.Windows;

namespace DXGridDataPager {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class ViewModel : ViewModelBase {
        public ViewModel() {
            Source = TestDataList.CreateData();
        }
        public ObservableCollection<TestDataItem> Source { get; set; }
    }
    public class TestDataList {
        public static ObservableCollection<TestDataItem> CreateData() {
            var testData = new ObservableCollection<TestDataItem>();
            for(int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    TestDataItem item = new TestDataItem {
                        ID = i * 10 + j,
                        Value = ((char)((int)'A' + i)).ToString()
                    };
                    testData.Add(item);
                }
            }
            return testData;
        }
    }
    public class TestDataItem {
        public int ID { get; set; }
        public string Value { get; set; }
    }
}
