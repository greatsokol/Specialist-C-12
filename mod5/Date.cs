namespace Geometry
{
    internal class Date
    {   
        static bool IsLeapYear(int year)
        {
            if ((year % 4) != 0) return false;
            if ((year % 100) == 0) {
                if ((year % 400) == 0) return true;
                else return false;
            }
            return true;
        }

        private bool leapYear;
        private int year;
        public int Year
        {
            get => year;
            set
            {
                if (value >= 1899 && value <= 3000) year = value;
                else throw new ArgumentOutOfRangeException($"wrong year {value}");
                leapYear = IsLeapYear(value);
            }
        }

        private int month;
        public int Month
        {
            get => month;
            set
            {
                if (value >= 1 && value <= 12) month = value;
                else throw new ArgumentOutOfRangeException($"wrong month {value}");
            }
        }

        private int day;
        public int Day
        {
            get => day;
            set
            {
                if (month == 0) throw new ArgumentOutOfRangeException("set month before setting day");
                if (value < 1) throw new ArgumentOutOfRangeException($"day is too small {value}");
                switch(month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (value > 31) throw new ArgumentOutOfRangeException($"day is too big {value}");
                        break;
                    case 2:
                        if (year == 0) throw new ArgumentOutOfRangeException("set year before setting day");
                        if (leapYear && value > 28) throw new ArgumentOutOfRangeException($"day is too big {value}");
                        if (!leapYear && value > 29) throw new ArgumentOutOfRangeException($"day is too big {value}");
                        break;
                    default:
                        if (value > 30) throw new ArgumentOutOfRangeException($"day is too big {value}");
                        break;
                }
                day = value;
            }
        }

        public Date() : this(1, 1, 1899) { }

        public Date(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;
        } 

        override public string ToString()
        {
            return $"{day}.{month}.{year}";
        }
    }
}
