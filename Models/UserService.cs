using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace wpf_mvvm_first_look.Models;

public class UserService
{
    private static List<User>? ObjUserList { get; set; } = new();

    public static void GetUser()
    {
        ObjUserList = new List<User>()
        {
                new User() {
                    UserId= 1,
                    Username = "Sinthon",
                    Email = "sinthon@example.com",
                    Password = "P@ssw0rd",
                    Address = "Siemreap",
                    Phone = "081968806"
                },
                new User() {
                    UserId= 2,
                    Username = "Makara",
                    Email = "makara@example.com",
                    Password = "P@ssw0rd",
                    Address = "Siemreap",
                    Phone = "081968806"
                },
                new User() {
                    UserId= 3,
                    Username = "Vanthong",
                    Email = "vanthong@example.com",
                    Password = "P@ssw0rd",
                    Address = "Siemreap",
                    Phone = "081968806"
                },
        };
    }


    public static List<User>? GetObjUserList() => ObjUserList;

    public static bool AddUser(User user)
    {
        if(user.Username == null)
        {
            throw new ArgumentException("User requred");
        }

        ObjUserList?.Add(user);
        return true;
    }

    public static bool UpdateUser(User user)
    {
        var hasUser = ObjUserList?.Where(u=> u.Equals(user)).First();

        if (hasUser == null)
        {
            return false;
        }

        hasUser = user;
        return true;
    }

    public static bool DeleteUser(User user)
    {
        if(ObjUserList != null && !ObjUserList.Any(u => u.Equals(user)))
        {
            return false;
        }

        ObjUserList?.Remove(user);

        return true;
    }

    public static List<User> Search(User user)
    {
        return ObjUserList?.Where(u => u.Like(user)).ToList() ?? new();
    }

    public static User GetSigleUser(int userId)
    {
        return ObjUserList?.Find(u => u.UserId == userId) ?? new();
    }
}



