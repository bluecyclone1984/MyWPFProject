using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MyWPFProject.UI
{
    public enum SelectType
    {
        [Description("是")]
        Yes = 1,
        [Description("否")]
        No = 2
    }

    public enum DataType
    {
        [Description("布尔型")]
        BOOL = 0,
        [Description("字节型")]
        BYTE = 1,
        [Description("短整型")]
        SINT = 2,
        [Description("整型")]
        INT = 3,
        [Description("双整型")]
        DINT = 4,
        [Description("实型")]
        REAL = 5
    }

}
