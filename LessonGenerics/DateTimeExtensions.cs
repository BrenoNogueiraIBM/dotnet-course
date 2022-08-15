﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
            else
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
        }
    }
}
