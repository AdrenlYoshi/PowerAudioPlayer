using System.Windows.Forms;

namespace WinFormsExtendedControls
{
    public class SelRangeTrackBar : TrackBar
    {
        private const int TBS_ENABLESELRANGE = 0x0020;
        private const int TBM_SETSELSTART = 0x0400 + 11;
        private const int TBM_SETSELEND = 0x0400 + 12;
        private const int TBM_CLEARSEL = 0x0400 + 19;
        private const int TBM_GETSELSTART = 0x0400 + 17;
        private const int TBM_GETSELEND = 0x0400 + 18;

        private bool _enableSelRange = false;
        public bool EnableSelRange
        {
            get
            {
                return _enableSelRange;
            }
            set
            {
                if (value)
                {
                    NativeAPI.SetWindowLong(Handle, NativeAPI.GWL_STYLE, NativeAPI.GetWindowLong(Handle, NativeAPI.GWL_STYLE) | TBS_ENABLESELRANGE);
                }
                else
                {
                    ClearSelRange();
                    NativeAPI.SetWindowLong(Handle, NativeAPI.GWL_STYLE, NativeAPI.GetWindowLong(Handle, NativeAPI.GWL_STYLE) & ~TBS_ENABLESELRANGE);
                }
                base.Refresh();
                _enableSelRange = value;
            }
        }

        public int SelStart 
        { 
            get 
            {
                return NativeAPI.SendMessage(Handle, TBM_GETSELSTART, 0, 0);
            }
            set
            {
                NativeAPI.SendMessage(Handle, TBM_SETSELSTART, 0, value);
                base.Refresh();
            }
        }

        public int SelEnd
        {
            get 
            {
                return NativeAPI.SendMessage(Handle, TBM_GETSELEND, 0, 0);
            }
            set
            {
                NativeAPI.SendMessage(Handle, TBM_SETSELEND, 0, value);
                base.Refresh();
            }
        }

        public SelRangeTrackBar()
        {
        }

        public void SetSelRange(int Start, int End)
        {
            SelStart = Start;
            SelEnd = End;
        }

        public void ClearSelRange()
        {
            NativeAPI.SendMessage(Handle, TBM_CLEARSEL, 0, 0);
        }
    }
}