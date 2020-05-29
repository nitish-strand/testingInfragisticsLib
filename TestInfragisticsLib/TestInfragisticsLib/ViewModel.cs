using Infragistics.Common;
using Infragistics.Common.Util;
using Infragistics.Controls.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;

namespace TestInfragisticsLib
{
    public class ViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; } = "Heatmap Trail";
        public class DataPoint
        {
            public string IndianSates { get; set; }
            public DateTime Date { get; set; }
            public double PropertyTwo { get; set; }
        }

        #region Data Property
        public DataPoint[,] Data
        {
            get { return data; }
            set
            {
                if (data != value)
                {
                    data = value;
                    OnPropertyChanged("Data");
                }
            }
        }
        private DataPoint[,] data;
        #endregion

        #region Rows Property
        public IList<string> Rows
        {
            get { return rows; }
            set
            {
                if (rows != value)
                {
                    rows = value;
                    OnPropertyChanged("Rows");
                }
            }
        }
        private IList<string> rows = null;
        #endregion

        #region Cols Property
        public List<DateTime> Cols
        {
            get { return cols; }
            set
            {
                if (cols != value)
                {
                    cols = value;
                    OnPropertyChanged("Cols");
                }
            }
        }
        private List<DateTime> cols;
        #endregion

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        public void refresh()
        {
            Random random = new Random();
            DataPoint[,] data = new DataPoint[rowcnt, colcnt];

            for (int row = 0; row < data.GetLength(0); ++row)
            {
                for (int col = 0; col < data.GetLength(1); ++col)
                {
                    data[row, col] = new DataPoint() { IndianSates = Rows[row], Date = Cols[col], PropertyTwo = random.Next(1, 1000) };
                }
            }
            Data = data;
        }

        private int rowcnt = 12;
        private int colcnt = 10;
        public ViewModel() 
        {
            List<string> rows = new List<string>();

            for (int i = 0; i < rowcnt; ++i)
            {
                rows.Add(bogus[i]);
            }

            List<DateTime> cols = new List<DateTime>();

            for (int i = 0; i < colcnt; ++i)
            {
                cols.Add(DateTime.Today.AddDays(i - colcnt));
            }

            Rows = rows;
            Cols = cols;
            refresh();
            
            colorHandle(); //without it also its breaking, earlier it was not.
        }

        #region SetColors Property
        public IScale SetColors
        {
            get { return setColors; }
            set
            {
                if (setColors != value)
                {
                    setColors = value;
                    OnPropertyChanged("SetColors");
                }
            }
        }
        private IScale setColors;
        #endregion

        private void colorHandle()
        {
            LinearScale linearScale = new LinearScale();

            //Heatmap heatmap = new Heatmap();

            linearScale.MinimumValue = 0;
            linearScale.MaximumValue = 100;

            ColorCollection colors = new ColorCollection();
            colors.Add(System.Windows.Media.Colors.Blue);
            colors.Add(System.Windows.Media.Colors.Pink);
            colors.Add(System.Windows.Media.Colors.Red);

            //linearScale.Colors =new[] { System.Windows.Media.Colors.Blue, System.Windows.Media.Colors.Pink, System.Windows.Media.Colors.Red };

            linearScale.Colors = colors;

            //heatmap.ValueScale = linearScale;
            SetColors = linearScale;
        }

        private string[] bogus =
        {
            #region statenames
                "Andhra Pradesh",
                "Arunachal Pradesh",
                "Assam",
                "Bihar",
                "Chhattisgarh",
                "Goa",
                "Gujarat",
                "Haryana",
                "Himachal Pradesh",
                "Jammu and Kashmir",
                "Jharkhand",
                "Karnataka",
                "Kerala",
                "Madhya Pradesh",
                "Maharashtra",
                "Manipur",
                "Meghalaya",
                "Mizoram",
                "Nagaland",
                "Odisha",
                "Punjab",
                "Rajasthan",
                "Sikkim",
                "Tamil Nadu",
                "Telangana",
                "Tripura",
                "Uttarakhand",
                "Uttar Pradesh",
                "West Bengal",
                "Andaman and Nicobar Islands",
                "Chandigarh",
                "Dadra and Nagar Haveli",
                "Daman and Diu",
                "Delhi",
                "Lakshadweep",
                "Puducherry"
        #endregion
    };


    }
}
