using System.Windows.Interactivity;
using DevExpress.Xpf.Editors.DataPager;
using System.Windows;
using System.Collections;
using System.Collections.Specialized;
namespace DXGridDataPager {
    public class SourcesBehavior : Behavior<DataPager> {
        public static readonly DependencyProperty ActualSourceProperty =
            DependencyProperty.Register("ActualSource", typeof(object), typeof(SourcesBehavior), null);
        public static readonly DependencyProperty SourcesProperty =
            DependencyProperty.Register("Sources", typeof(IList), typeof(SourcesBehavior),
            new PropertyMetadata(null, (d, e) => ((SourcesBehavior)d).OnSourcesChanged((IList)e.NewValue)));
        public object ActualSource {
            get { return (object)GetValue(ActualSourceProperty); }
            set { SetValue(ActualSourceProperty, value); }
        }
        public IList Sources {
            get { return (IList)GetValue(SourcesProperty); }
            set { SetValue(SourcesProperty, value); }
        }
        public DataPager DataPager { get { return AssociatedObject; } }
        protected override void OnAttached() {
            base.OnAttached();
            //DataPager.PageSize = Sources.Count;
            DataPager.ItemCount = Sources.Count;
            //DataPager.PageSize = Sou
            UpdateActualSource(DataPager.PageIndex);
            SubsribeSourcesColletion(Sources);
            SubscribeDataPager();
        }
        protected override void OnDetaching() {
            UnsubsribeDataPager();
            UnsubsribeSourcesColletion(Sources);
            base.OnDetaching();
        }
        void OnSourcesChanged(IList oldSources) {
            if(DataPager == null) return;
            UpdateActualSource(DataPager.PageIndex);
            if(Sources != null) DataPager.ItemCount = Sources.Count;
            UnsubsribeSourcesColletion(oldSources);
            SubsribeSourcesColletion(Sources);
            if(ActualSource != null) DataPager.PageIndex = Sources.IndexOf(ActualSource);
            SubscribeDataPager();
        }
        void UnsubsribeSourcesColletion(IList sources) {
            if(sources is INotifyCollectionChanged)
                ((INotifyCollectionChanged)sources).CollectionChanged -= Sources_CollectionChanged;
        }
        void SubsribeSourcesColletion(IList sources) {
            UnsubsribeSourcesColletion(sources);
            if(sources is INotifyCollectionChanged)
                ((INotifyCollectionChanged)sources).CollectionChanged += Sources_CollectionChanged;
        }
        void UnsubsribeDataPager() {
            if(DataPager == null) return;
            DataPager.PageIndexChanged -= DataPager_PageIndexChanged;
        }
        void SubscribeDataPager() {
            if(DataPager == null) return;
            UnsubsribeDataPager();
            DataPager.PageIndexChanged += DataPager_PageIndexChanged;
        }

        void Sources_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) {
            if(Sources != null) DataPager.ItemCount = Sources.Count;
            if(ActualSource == null) UpdateActualSource(DataPager.PageIndex);
        }
        void UpdateActualSource(int index) {
            if(Sources != null && Sources.Count > 0) {
                if(index < Sources.Count) ActualSource = Sources[index];
                else ActualSource = Sources[0];
            }

        }
        void DataPager_PageIndexChanged(object sender, DataPagerPageIndexChangedEventArgs e) {
            UpdateActualSource(e.NewValue);
        }
    }
}