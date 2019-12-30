using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEditor
{
    public partial class DataEditorForm : Form
    {
        private SynchronizationContext _syncContext;

        public DataEditorForm(DataEditorFormConfiguration config)
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._syncContext = SynchronizationContext.Current;
            await LoadLayout();
        }

        private async Task LoadLayout()
        {
            await Task.Run(new Action(async () =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (i % 100 == 0)
                    {
                        await Task.Delay(1000);
                        _syncContext.Post(new SendOrPostCallback(x => this.Text = $"i = {x}"), i);
                    }
                }
            }));
        }
    }
}
