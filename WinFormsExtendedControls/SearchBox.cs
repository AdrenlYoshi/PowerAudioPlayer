using System;
using System.ComponentModel;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsExtendedControls
{
    [DefaultEvent("SearchStart")]
    public partial class SearchBox : UserControl
    {
        public Timer tmr = new Timer() { Interval = 800 };

        public int MaxLength
        {
            get => tbSearch.MaxLength; set => tbSearch.MaxLength = value;
        }

        public string PlaceHolderText
        {
            get => tbSearch.PlaceholderText; set => tbSearch.PlaceholderText = value;
        }

        public new string Text
        {
            get => tbSearch.Text; set => tbSearch.Text = value;
        }

        public HorizontalAlignment TextAlign
        {
            get => tbSearch.TextAlign; set => tbSearch.TextAlign = value;
        }

        [DefaultValue(800)]
        public int Delay
        {
            get
            {
                return tmr.Interval;
            }
            set
            {
                tmr.Stop();
                tmr.Interval = value;
            }
        }

        public event EventHandler? SearchTextChanged;

        public event EventHandler? SearchStart;

        public SearchBox()
        {
            InitializeComponent();
            tmr.Interval = Delay;
            tmr.Tick += Tmr_Tick;
        }

        private void Tmr_Tick(object? sender, EventArgs e)
        {
            SearchStart?.Invoke(this, e);
            tmr.Stop();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, e);
            if (tbSearch.Text == string.Empty)
            {
                btnClear.Visible = false;
                btnSearch_Click(this, e);
                return;
            }
            else
            {
                btnClear.Visible = true;
            }
            if (tmr.Enabled)
            {
                tmr.Stop();
                tmr.Interval = Delay;
            }
            tmr.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSearch.Text = string.Empty;
            SearchTextChanged?.Invoke(this, e);
            SearchStart?.Invoke(this, e);
            tmr.Stop();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStart?.Invoke(this, e);
            tmr.Stop();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnSearch_Click(this, e);
        }
    }
}