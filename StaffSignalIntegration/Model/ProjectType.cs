using System.ComponentModel;

namespace StaffSignalsIntegration.Model
{
    public enum ProjectType : int
    {
        [Description("Internal")]
        Internal = 1,
        [Description("External")]
        External = 2
    }
}
