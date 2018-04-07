using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using LiveCharts;
using LiveCharts.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace PlantsDashboard
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        Random rand;
        SerialPort serialPort;
        float currentTemp;
        float currentAHumidity;
        double currentEHumidity;
        double currentIllu;
        double currentPressure;
        System.IO.StreamWriter fileLog;
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (serialPort != null)
                {
                    string[] package = serialPort.ReadExisting().Split('\n');
                    for (int i = 0; i < package.Length; i++)
                    {
                        string[] tokens = package[i].Split(':');
                        if (tokens.Length == 2)
                        {
                            try
                            {
                                switch (tokens[0])
                                {
                                    case "T":
                                        lbTemp.Text = "Temperature: " + tokens[1] + " (Celsius)";

                                        currentTemp = float.Parse(tokens[1]);
                                        break;
                                    case "H":
                                        lbAirHumid.Text = "Air Humidity: " + tokens[1] + " %";
                                        currentAHumidity = float.Parse(tokens[1]);
                                        break;
                                    case "L":
                                        currentIllu = Math.Round(float.Parse(tokens[1])/1024*100,2);
                                        lbIllumination.Text = "Illumination: " +currentIllu + " (%)";
                                       
                                        break;
                                    case "E":
                                        currentEHumidity = Math.Round(float.Parse(tokens[1]) / 1024 * 100, 2);
                                        lbEarthHumid.Text = "Earth Humidity: " + currentEHumidity + " %";
                                        break;
                                    case "P":
                                        currentPressure = Math.Round(float.Parse(tokens[1]) / 100, 2);
                                        lbAtm.Text = "Atmosphere Pressure: " + currentPressure + " (hPa)";
                                        break;
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    if (currentEHumidity < trackThreshold.Value)
                    {
                        serialPort.Write("1");
                    }

                }
            }
            catch
            {
                currentTemp = 0;
                currentEHumidity = 0;
                currentAHumidity = 0;
                currentIllu = 0;
                currentPressure = 0;
            }

            chartHumidity.Series[0].Values.Add(new ObservableValue(currentTemp));
            chartHumidity.Series[1].Values.Add(new ObservableValue(currentAHumidity));
            chartHumidity.Series[2].Values.Add(new ObservableValue(currentEHumidity));
            chartHumidity.Series[0].Values.RemoveAt(0);
            chartHumidity.Series[1].Values.RemoveAt(0);
            chartHumidity.Series[2].Values.RemoveAt(0);

            gaugeIllu.Value = currentIllu;
            gaugeAtm.Value = currentPressure;

            if (fileLog != null)
            {
                fileLog.WriteLine(String.Format("{0};{1};{2};{3};{4};{5}",DateTime.Now, currentTemp, currentAHumidity, currentEHumidity, currentPressure, currentIllu));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            rand = new Random();
            
            gaugeAtm.From = 300;
            gaugeAtm.To = 1100;
            gaugeIllu.From = 0;
            gaugeIllu.To = 100;
            gaugeIllu.FromColor = System.Windows.Media.Color.FromRgb(246,229,141);
            gaugeIllu.ToColor = System.Windows.Media.Color.FromRgb(241, 196, 15);
            chartHumidity.Series.Add(new LineSeries
            {
                StrokeThickness = 2,
               // StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(192, 57, 43)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 0,
                PointGeometrySize = 7,
                Title="Temperature"
                
            });

            chartHumidity.Series.Add(new LineSeries
            {
                StrokeThickness = 2,
                // StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(41, 128, 185)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 0,
                PointGeometrySize = 7,
                PointGeometry = DefaultGeometries.Triangle,
                Title="Air Humidity"

            });

            chartHumidity.Series.Add(new LineSeries
            {
                StrokeThickness = 2,
                // StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(241, 196, 15)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 0,
                PointGeometrySize = 7,
                PointGeometry = DefaultGeometries.Cross,
                Title="Earth Humidity"

            });

            ChartValues<ObservableValue> defaultValue = new ChartValues<ObservableValue>();
            ChartValues<ObservableValue> defaultValue2 = new ChartValues<ObservableValue>();
            ChartValues<ObservableValue> defaultValue3 = new ChartValues<ObservableValue>();
            for (int i = 0; i < 30; i++)
            {
                defaultValue.Add(new ObservableValue(0));
                defaultValue2.Add(new ObservableValue(0));
                defaultValue3.Add(new ObservableValue(0));
            }
       

            chartHumidity.Series[0].Values = defaultValue;
            chartHumidity.Series[1].Values = defaultValue2;
            chartHumidity.Series[2].Values = defaultValue3;

            chartHumidity.AxisY.Add(new Axis
            {
                IsMerged = false,
                MaxValue=100,
                MinValue=0,
               
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(4),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(44, 62, 80))
                },
                Title="Temperature (Celsius) - Humidity (%)",
                
            });
            chartHumidity.AxisX.Add(new Axis
            {
                
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(10),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(44, 62, 80))
                },

            });

            chartHumidity.LegendLocation = LegendLocation.Right;

            

            timer1.Enabled = true;
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort(tbCOM.Text);
                serialPort.Open();

            }
            catch { }
        }

        private void btWatering_Click(object sender, EventArgs e)
        {
            serialPort.Write("1");
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            serialPort.Write("0");
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            lbWThreshold.Text = "Watering Threshold: " + trackThreshold.Value;
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            if (fileLog != null)
            {
                fileLog.Flush();
                fileLog.Close();
                fileLog = null;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save log to...";
            saveFileDialog.Filter = "(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileLog = new System.IO.StreamWriter(saveFileDialog.FileName);
                fileLog.WriteLine("Date;Temperature;Humidity;Ehumidity;Atmosphere Pressure;Illuminance");
            }
        }
    }
}
