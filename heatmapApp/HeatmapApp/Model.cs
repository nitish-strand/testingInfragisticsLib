using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections;
using Infragistics.Common.Util;
using Infragistics.Common;

namespace HeatmapApp
{
    public class Model : INotifyPropertyChanged
    {
        public class Ticker
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
        }

        public class DataPoint
        {
            public Ticker Ticker { get; set; }
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
        public IList<Ticker> Rows
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
        private IList<Ticker> rows = null;
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



        private int rowcnt = 32;
        private int colcnt = 64;
        public Model()
        {
            List<Ticker> rows = new List<Ticker>();

            for (int i = 0; i < rowcnt; ++i)
            {
                rows.Add(new Ticker() { Symbol = bogus[i, 0], Name = bogus[i, 1] });
            }

            List<DateTime> cols = new List<DateTime>();

            for (int i = 0; i < colcnt; ++i)
            {
                cols.Add(DateTime.Today.AddDays(i-colcnt));
            }

            Rows = rows;
            Cols = cols;
            refresh();

            colorHandle();
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

            linearScale.MinimumValue = 0;
            linearScale.MaximumValue = 100;

            ColorCollection colors = new ColorCollection();
            colors.Add(System.Windows.Media.Colors.Blue);
            colors.Add(System.Windows.Media.Colors.Pink);
            colors.Add(System.Windows.Media.Colors.Red);


            linearScale.Colors = colors;

            SetColors = linearScale;
        }


        public void refresh()
        {
            DataPoint[,] data = new DataPoint[rowcnt, colcnt];

            for (int row = 0; row < data.GetLength(0); ++row)
            {
                for (int col = 0; col < data.GetLength(1); ++col)
                {
                    double x = 5.0 * col / data.GetLength(1);
                    double y = 30.0 * row / data.GetLength(0);

                    data[row, col] = new DataPoint() { Ticker = Rows[row], Date = Cols[col], PropertyTwo = 100*MathUtil.Noise(x, y, seed)};
                }
            }

            seed += 0.1;

            Data = data;
        }
        private double seed = 0.0;

        private string[,] bogus =
        {
            #region symbol/name pairs
            { "ATVI", "Activision Blizzard, Inc" },
            { "ADBE", "Adobe Systems Incorporated" },
            { "AKAM", "Akamai Technologies, Inc." },
            { "ALXN", "Alexion Pharmaceuticals, Inc." },
            { "ALTR", "Altera Corporation" },
            { "AMZN", "Amazon.com, Inc." },
            { "AMGN", "Amgen Inc." },
            { "APOL", "Apollo Group, Inc." },
            { "AAPL", "Apple Inc." },
            { "AMAT", "Applied Materials, Inc." },
            { "ADSK", "Autodesk, Inc." },
            { "ADP", "Automatic Data Processing, Inc." },
            { "BIDU", "Baidu, Inc." },
            { "BBBY", "Bed Bath & Beyond Inc." },
            { "BIIB", "Biogen Idec Inc" },
            { "BMC", " BMC Software, Inc." },
            { "BRCM", "Broadcom Corporation" },
            { "CHRW", "C.H. Robinson Worldwide, Inc." },
            { "CA", "CA Inc." },
            { "CELG", "Celgene Corporation" },
            { "CERN", "Cerner Corporation" },
            { "CHKP", "Check Point Software Technologies Ltd." },
            { "CSCO", "Cisco Systems, Inc." },
            { "CTXS", "Citrix Systems, Inc." },
            { "CTSH", "Cognizant Technology Solutions Corporation" },
            { "CMCSA", "Comcast Corporation" },
            { "COST", "Costco Wholesale Corporation" },
            { "CTRP", "Ctrip.com International, Ltd." },
            { "DELL", "Dell Inc." },
            { "XRAY", "DENTSPLY International Inc." },
            { "DTV", "DIRECTV" },
            { "DLTR", "Dollar Tree, Inc." },
            { "EBAY", "eBay Inc." },
            { "ERTS", "Electronic Arts Inc." },
            { "EXPE", "Expedia, Inc." },
            { "EXPD", "Expeditors International of Washington, Inc." },
            { "ESRX", "Express Scripts, Inc." },
            { "FFIV", "F5 Networks, Inc." },
            { "FAST", "Fastenal Company" },
            { "FSLR", "First Solar, Inc." },
            { "FISV", "Fiserv, Inc." },
            { "FLEX", "Flextronics International Ltd." },
            { "FLIR", "FLIR Systems, Inc." },
            { "GRMN", "Garmin Ltd." },
            { "GILD", "Gilead Sciences, Inc." },
            { "GOOG", "Google Inc." },
            { "GMCR", "Green Mountain Coffee Roasters, Inc." },
            { "HSIC", "Henry Schein, Inc." },
            { "ILMN", "Illumina, Inc." },
            { "INFY", "Infosys Limited" },
            { "INTC", "Intel Corporation" },
            { "INTU", "Intuit Inc." },
            { "ISRG", "Intuitive Surgical, Inc." },
            { "JOYG", "Joy Global Inc." },
            { "KLAC", "KLA-Tencor Corporation" },
            { "LRCX", "Lam Research Corporation" },
            { "LINTA", "Liberty Media Corporation" },
            { "LIFE", "Life Technologies Corporation" },
            { "LLTC", "Linear Technology Corporation" },
            { "MRVL", "Marvell Technology Group Ltd." },
            { "MAT", "Mattel, Inc." },
            { "MXIM", "Maxim Integrated Products, Inc." },
            { "MCHP", "Microchip Technology Incorporated" },
            { "MU", "Micron Technology, Inc." },
            { "MSFT", "Microsoft Corporation" },
            { "MYL", "Mylan Inc." },
            { "NTAP", "NetApp, Inc." },
            { "NFLX", "Netflix, Inc." },
            { "NWSA", "News Corporation" },
            { "NIHD", "NII Holdings, Inc." },
            { "NVDA", "NVIDIA Corporation" },
            { "ORLY", "O'Reilly Automotive, Inc." },
            { "ORCL", "Oracle Corporation" },
            { "PCAR", "PACCAR Inc." },
            { "PAYX", "Paychex, Inc." },
            { "PCLN", "priceline.com Incorporated" },
            { "QGEN", "Qiagen N.V." },
            { "QCOM", "QUALCOMM Incorporated" },
            { "RIMM", "Research in Motion Limited" },
            { "ROST", "Ross Stores, Inc." },
            { "SNDK", "SanDisk Corporation" },
            { "STX", "Seagate Technology." },
            { "SHLD", "Sears Holdings Corporation" },
            { "SIAL", "Sigma-Aldrich Corporation" },
            { "SIRI", "Sirius XM Radio Inc." },
            { "SPLS", "Staples, Inc." },
            { "SBUX", "Starbucks Corporation" },
            { "SRCL", "Stericycle, Inc." },
            { "SYMC", "Symantec Corporation" },
            { "TEVA", "Teva Pharmaceutical Industries Limited" },
            { "URBN", "Urban Outfitters, Inc." },
            { "VRSN", "VeriSign, Inc." },
            { "VRTX", "Vertex Pharmaceuticals Incorporated" },
            { "VMED", "Virgin Media Inc." },
            { "VOD", "Vodafone Group Plc" },
            { "WCRX", "Warner Chilcott plc" },
            { "WFM", "Whole Foods Market, Inc." },
            { "WYNN", "Wynn Resorts, Limited" },
            { "XLNX", "Xilinx, Inc." },
            { "YHOO", "Yahoo! Inc." }
            #endregion
        };
    }
}
