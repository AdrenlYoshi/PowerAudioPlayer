using System.ComponentModel;

namespace WinFormsExtendedControls
{
    public class ToolStripRadioButton : ToolStripButton
    {
        private int radioButtonGroupId = 0;
        private bool updateButtonGroup = true;

        private Color checkedColor1 = Color.Transparent;
        private Color checkedColor2 = Color.Transparent;


        public ToolStripRadioButton()
        {
            CheckOnClick = true;
        }


        [Category("Behavior")]
        public int RadioButtonGroupId
        {
            get
            {
                return radioButtonGroupId;
            }
            set
            {
                radioButtonGroupId = value;

                // Make sure no two radio buttons are checked at the same time
                UpdateGroup();
            }
        }


        // Set check value without updating (disabling) other radio buttons in the group
        private void SetCheckValue(bool checkValue)
        {
            updateButtonGroup = false;
            Checked = checkValue;
            updateButtonGroup = true;
        }

        // To make sure no two radio buttons are checked at the same time
        private void UpdateGroup()
        {
            if (Parent != null)
            {
                // Get number of checked radio buttons in group
                int checkedCount = Parent.Items.OfType<ToolStripRadioButton>().Count(x => x.RadioButtonGroupId == RadioButtonGroupId && x.Checked);

                if (checkedCount > 1)
                {
                    Checked = false;
                }
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Checked = true;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            if (Parent != null && updateButtonGroup)
            {
                foreach (ToolStripRadioButton radioButton in Parent.Items.OfType<ToolStripRadioButton>())
                {
                    if (radioButton != this && radioButton.RadioButtonGroupId == RadioButtonGroupId)
                    {
                        radioButton.SetCheckValue(false);
                    }
                }
            }
        }
    }
}