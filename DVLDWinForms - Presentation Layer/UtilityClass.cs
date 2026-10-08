using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLDWinForms___Presentation_Layer
{
    static public class UtilityClass
    {
        static public DataRow[] FilterPeopleDataTableByCondition(DataTable dt, string itemname, string condition)
        {
            
            switch(itemname)
            {
                case "Person ID":
                   if ( int.TryParse(condition,out int PersonID))
                   {
                        return dt.Select($"PersonID={PersonID}");
                    }
                   else
                    {
                        return new DataRow[0];
                    }
                   
                case "National NO":
                    return dt.Select($"NationalNO='{condition}'");
                case "First Name":
                    return dt.Select($"FirstName='{condition}'");
                case "Second Name":
                    return dt.Select($"SecondName='{condition}'");
                case "Third Name":
                    return dt.Select($"ThirdName='{condition}'");
                case "Last Name":
                    return dt.Select($"LastName='{condition}'");
                case "Gender":
                    return dt.Select($"Gender='{condition}'");
                case "Nationality":
                    if (int.TryParse(condition,out int Nationality))
                    {
                        return dt.Select($"NationalityCountryID={Nationality}");
                    }
                    else
                    {
                        return new DataRow[0];
                    }
                   
                case "Email":
                    return dt.Select($"Email='{condition}'");
                case "Phone":
                    return dt.Select($"Phone='{condition}'");
                default:
                    return null;
            }
        }

        static public DataRow[] FilterUsersDataTableByCondition(DataTable dt, string itemname, string condition)
        {

            switch (itemname)
            {
                case "User ID":
                    if (int.TryParse(condition, out int UserID))
                    {
                        return dt.Select($"UserID={UserID}");
                    }
                    else
                    {
                        return new DataRow[0];
                    }
                case "Person ID":
                    if (int.TryParse(condition, out int PersonID))
                    {
                        return dt.Select($"PersonID={PersonID}");
                    }
                    else
                    {
                        return new DataRow[0];
                    }

                case "Full Name":
                    return dt.Select($"FullName='{condition}'");
                case "Username":
                    return dt.Select($"Username='{condition}'");
                case "Is Active":
                    return dt.Select($"IsActive='{condition}'");
                default:
                    return null;
            }
        }
        static public DataRow[] FilterLocalLicensesDataTableByCondition(DataTable dt, string itemname, string condition)
        {

            switch (itemname)
            {
                case "Local License ID":
                    if (int.TryParse(condition, out int LocalLicenseID))
                    {
                        return dt.Select($"LocalDrivingLicenseApplicationID={LocalLicenseID}");
                    }
                    else
                    {
                        return new DataRow[0];
                    }

                case "Full Name":
                    return dt.Select($"FullName='{condition}'");
                case "Class Name":
                    return dt.Select($"ClassName='{condition}'");
                case "National NO":
                    return dt.Select($"NationalNO='{condition}'");
                case "Status":
                    return dt.Select($"Status='{condition}'");
                default:
                    return null;
            }
        }
        }
}
