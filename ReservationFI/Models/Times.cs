using System.ComponentModel;
using System.Reflection;

namespace ReservationFI.Models
{
    /// <summary>
    /// Class representing the times of the day that a room can be reserved
    /// </summary>
    public static class Times
    {
        public enum TimesEnum
        {
            [Description("8:00")]
            Eight = 8,
            [Description("10:00")]
            Ten = 10,
            [Description("12:00")]
            Twelve = 12,
            [Description("14:00")]
            Fourteen = 14,
            [Description("16:00")]
            Sixteen = 16,
            [Description("18:00")]
            Eighteen = 18,
            [Description("20:00")]
            Twenty = 20
        }

        /// <summary>
        /// Method needed to get the description of the enum 
        /// </summary>
        /// <param name="GenericEnum">enum</param>
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes != null && attributes.Count() > 0)
                {
                    return ((DescriptionAttribute)attributes.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }
    }
}
