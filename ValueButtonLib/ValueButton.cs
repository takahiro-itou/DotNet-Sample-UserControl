namespace ValueButtonLib
{
    public partial class ValueButton : Button
    {
        private int varValue;
        public int ButtonValue
        {
            get { return varValue; }
            set { varValue = value; }
        }

        public ValueButton()
        {
            InitializeComponent();
        }
    }
}