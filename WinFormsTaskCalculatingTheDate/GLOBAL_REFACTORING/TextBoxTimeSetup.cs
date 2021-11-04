using System;
using System.Windows.Forms;

namespace WinFormsTaskCalculatingTheDate
{
    public class TextBoxTimeSetup
    {
        public enum TimeType
        {
            Default,
            Seconds,
            Minutes,
            Hours,
            Days,
            Month,
            Years
        }

        [Serializable] public class TextBoxValue
        {
            public TimeType timeType;
            public string timeRusName;
            public string timeSpan;

            public TextBoxValue(TimeType enteredTimeType, string enteredTimeRusName, string enteredTimeSpan)
            {
                timeType = enteredTimeType;
                timeRusName = enteredTimeRusName;
                timeSpan = enteredTimeSpan;
            }

        }

        public class TimeTextBoxItem
        {
            public TimeTextBoxItem(DateTime date, DateTime dateTimeNow, TextBox textBoxResult, TextBoxValue[] textBoxValue)
            {
                SetTimeInTextBox(textBoxResult, textBoxValue);
            }

            private void SetTimeInTextBox(TextBox textBoxResult, TextBoxValue[] textBoxValue)
            {
                int linesInTextBoxTime = 3;
                for (int i = 0; i < linesInTextBoxTime; i++)
                {
                    textBoxResult.Text += textBoxValue[i].timeRusName + textBoxValue[i].timeSpan;
                    SkipLine(textBoxResult);
                }
            }
            private void SkipLine(TextBox textBoxForSkip)
            {
                textBoxForSkip.Text += "\r\n";
            }
        }

        private TextBoxValue[] InitializeBigTime(TimeSpan enteredTimeSpan)
        {
            TextBoxValue[] textBoxValues = new TextBoxValue[3];
            textBoxValues[0] = new TextBoxValue(TimeType.Days, "Дней: ", ((int)enteredTimeSpan.TotalDays + 1).ToString());
            textBoxValues[1] = new TextBoxValue(TimeType.Month, "Месяцев: ", ((int)enteredTimeSpan.TotalDays / 30).ToString());
            textBoxValues[2] = new TextBoxValue(TimeType.Years, "Годов: ", ((int)enteredTimeSpan.TotalDays / 365).ToString());
            return textBoxValues;
        }

        private TextBoxValue[] InitializeSmallTime(TimeSpan enteredTimeSpan)
        {
            TextBoxValue[] textBoxValues = new TextBoxValue[3];
            textBoxValues[0] = new TextBoxValue(TimeType.Hours, "Секунд: ", ((int)enteredTimeSpan.TotalSeconds).ToString());
            textBoxValues[1] = new TextBoxValue(TimeType.Minutes, "Минут: ", ((int)enteredTimeSpan.TotalMinutes).ToString());
            textBoxValues[2] = new TextBoxValue(TimeType.Seconds, "Часов: ", ((int)enteredTimeSpan.TotalHours).ToString());
            return textBoxValues;
        }

        public TextBoxValue[] SelectSuitableTime(bool isTimeSizeBig, TimeSpan timeSpan)
        {
            return isTimeSizeBig ? InitializeBigTime(timeSpan) : InitializeSmallTime(timeSpan);
        }
    }
}