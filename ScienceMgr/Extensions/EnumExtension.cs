using ScienceMgr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceMgr.Extensions
{
    public static class EnumExtension
    {
        public static string ToFriendlyString(this RoleType type)
        {
            switch (type)
            {
                case RoleType.Lecturer:
                    return "Giảng viên";
                case RoleType.Postgraduate:
                    return "Nghiên cứu sinh";
                case RoleType.Student:
                    return "Sinh viên";
                default:
                    return "Không xác định";
            }
        }
        public static string ToFriendlyString(this GenderType type)
        {
            switch (type)
            {
                case GenderType.Male:
                    return "Nam";
                case GenderType.Female:
                    return "Nữ";
                default:
                    return "Không xác định";
            }
        }
    }
}
