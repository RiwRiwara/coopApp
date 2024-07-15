using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CoopWeb.Data
{
    public class StudentSeed
    {
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;

        public StudentSeed(IPasswordHasher<ApplicationUser> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        public List<ApplicationUser> GetStudents()
        {
            var students = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    StudentID = "6304101389",
                    UserName = "user1@example.com",
                    NormalizedUserName = "USER1@EXAMPLE.COM",
                    Email = "user1@example.com",
                    NormalizedEmail = "USER1@EXAMPLE.COM",
                    FirstName = "ฐิติกร",
                    LastName = "เรือนมนต์",
                    Nickname = "ไนท์",
                    RoleId = "1",
                    ProjectId = 1
                },
                new ApplicationUser
                {
                    StudentID = "6404101303",
                    UserName = "user2@example.com",
                    NormalizedUserName = "USER2@EXAMPLE.COM",
                    Email = "user2@example.com",
                    NormalizedEmail = "USER2@EXAMPLE.COM",
                    FirstName = "กัญญาพัชร",
                    LastName = "ยศสนิท",
                    Nickname = "ไอซ์",
                    RoleId = "1",
                    ProjectId = 2
                },
                new ApplicationUser
                {
                    StudentID = "6404101324",
                    UserName = "user3@example.com",
                    NormalizedUserName = "USER3@EXAMPLE.COM",
                    Email = "user3@example.com",
                    NormalizedEmail = "USER3@EXAMPLE.COM",
                    FirstName = "นิมมิตา",
                    LastName = "สมริน",
                    Nickname = "มิ้น",
                    RoleId = "1",
                    ProjectId = 2
                },
                new ApplicationUser
                {
                    StudentID = "6404101378",
                    UserName = "user4@example.com",
                    NormalizedUserName = "USER4@EXAMPLE.COM",
                    Email = "user4@example.com",
                    NormalizedEmail = "USER4@EXAMPLE.COM",
                    FirstName = "อัจฉริยะณัฐ",
                    LastName = "ปะฏิเต",
                    Nickname = "ต้อง",
                    RoleId = "1",
                    ProjectId = 2
                },
                new ApplicationUser
                {
                    StudentID = "6404101306",
                    UserName = "user5@example.com",
                    NormalizedUserName = "USER5@EXAMPLE.COM",
                    Email = "user5@example.com",
                    NormalizedEmail = "USER5@EXAMPLE.COM",
                    FirstName = "ขวัญชนก",
                    LastName = "เสนีย์วงศ์ ณ อยุธยา",
                    Nickname = "แพรวา",
                    RoleId = "1",
                    ProjectId = 3
                },
                new ApplicationUser
                {
                    StudentID = "6404101332",
                    UserName = "user6@example.com",
                    NormalizedUserName = "USER6@EXAMPLE.COM",
                    Email = "user6@example.com",
                    NormalizedEmail = "USER6@EXAMPLE.COM",
                    FirstName = "เมธาวัฒน์",
                    LastName = "มหาวัน",
                    Nickname = "ตะวัน",
                    RoleId = "1",
                    ProjectId = 3
                },
                new ApplicationUser
                {
                    StudentID = "6404101311",
                    UserName = "user7@example.com",
                    NormalizedUserName = "USER7@EXAMPLE.COM",
                    Email = "user7@example.com",
                    NormalizedEmail = "USER7@EXAMPLE.COM",
                    FirstName = "ฐิติพงษ์",
                    LastName = "เรือนสุภา",
                    Nickname = "",
                    RoleId = "1",
                    ProjectId = 4
                },
                new ApplicationUser
                {
                    StudentID = "6404101312",
                    UserName = "user8@example.com",
                    NormalizedUserName = "USER8@EXAMPLE.COM",
                    Email = "user8@example.com",
                    NormalizedEmail = "USER8@EXAMPLE.COM",
                    FirstName = "ณรงค์เกียรติ",
                    LastName = "นามห้วยทอง",
                    Nickname = "ก๊อต",
                    RoleId = "1",
                    ProjectId = 5
                },
                new ApplicationUser
                {
                    StudentID = "6404101316",
                    UserName = "user9@example.com",
                    NormalizedUserName = "USER9@EXAMPLE.COM",
                    Email = "user9@example.com",
                    NormalizedEmail = "USER9@EXAMPLE.COM",
                    FirstName = "ตะวัน",
                    LastName = "สุรินา",
                    Nickname = "เจแปน",
                    RoleId = "1",
                    ProjectId = 5
                },
                new ApplicationUser
                {
                    StudentID = "6404101318",
                    UserName = "user10@example.com",
                    NormalizedUserName = "USER10@EXAMPLE.COM",
                    Email = "user10@example.com",
                    NormalizedEmail = "USER10@EXAMPLE.COM",
                    FirstName = "ไตรภาค",
                    LastName = "สิทธิแก้ว",
                    Nickname = "ภาค",
                    RoleId = "1",
                    ProjectId = 5
                },
                new ApplicationUser
                {
                    StudentID = "6404101359",
                    UserName = "user11@example.com",
                    NormalizedUserName = "USER11@EXAMPLE.COM",
                    Email = "user11@example.com",
                    NormalizedEmail = "USER11@EXAMPLE.COM",
                    FirstName = "ณภัทร",
                    LastName = "บัวบาน",
                    Nickname = "หนึ่ง",
                    RoleId = "1",
                    ProjectId = 5
                },
                new ApplicationUser
                {
                    StudentID = "6404101369",
                    UserName = "user12@example.com",
                    NormalizedUserName = "USER12@EXAMPLE.COM",
                    Email = "user12@example.com",
                    NormalizedEmail = "USER12@EXAMPLE.COM",
                    FirstName = "มณฑารบ",
                    LastName = "ชาวโพงพาง",
                    Nickname = "มัดหมี่",
                    RoleId = "1",
                    ProjectId = 6
                },
                new ApplicationUser
                {
                    StudentID = "6404101379",
                    UserName = "user13@example.com",
                    NormalizedUserName = "USER13@EXAMPLE.COM",
                    Email = "user13@example.com",
                    NormalizedEmail = "USER13@EXAMPLE.COM",
                    FirstName = "ไอลดา",
                    LastName = "แสงภิรมย์",
                    Nickname = "เฟริ์น",
                    RoleId = "1",
                    ProjectId = 6
                },
                new ApplicationUser
                {
                    StudentID = "6404101325",
                    UserName = "user14@example.com",
                    NormalizedUserName = "USER14@EXAMPLE.COM",
                    Email = "user14@example.com",
                    NormalizedEmail = "USER14@EXAMPLE.COM",
                    FirstName = "ผดุงเกียรติ",
                    LastName = "สุตาโย",
                    Nickname = "บอย",
                    RoleId = "1",
                    ProjectId = 7
                },
                new ApplicationUser
                {
                    StudentID = "6404101327",
                    UserName = "user15@example.com",
                    NormalizedUserName = "USER15@EXAMPLE.COM",
                    Email = "user15@example.com",
                    NormalizedEmail = "USER15@EXAMPLE.COM",
                    FirstName = "พิมลพรรณ",
                    LastName = "เงินทอง",
                    Nickname = "โฟร์ท",
                    RoleId = "1",
                    ProjectId = 8
                },
                new ApplicationUser
                {
                    StudentID = "6404101330",
                    UserName = "user16@example.com",
                    NormalizedUserName = "USER16@EXAMPLE.COM",
                    Email = "user16@example.com",
                    NormalizedEmail = "USER16@EXAMPLE.COM",
                    FirstName = "ภราดร",
                    LastName = "ศรีทา",
                    Nickname = "บอล",
                    RoleId = "1",
                    ProjectId = 8
                },
                new ApplicationUser
                {
                    StudentID = "6404101350",
                    UserName = "user17@example.com",
                    NormalizedUserName = "USER17@EXAMPLE.COM",
                    Email = "user17@example.com",
                    NormalizedEmail = "USER17@EXAMPLE.COM",
                    FirstName = "อดิศร",
                    LastName = "วงศ์คำ",
                    Nickname = "แนท",
                    RoleId = "1",
                    ProjectId = 9
                },
                new ApplicationUser
                {
                    StudentID = "6404101377",
                    UserName = "user18@example.com",
                    NormalizedUserName = "USER18@EXAMPLE.COM",
                    Email = "user18@example.com",
                    NormalizedEmail = "USER18@EXAMPLE.COM",
                    FirstName = "อภิวัฒน์",
                    LastName = "ไชยา",
                    Nickname = "ฟิว",
                    RoleId = "1",
                    ProjectId = 9
                },
                new ApplicationUser
                {
                    StudentID = "6404101337",
                    UserName = "user19@example.com",
                    NormalizedUserName = "USER19@EXAMPLE.COM",
                    Email = "user19@example.com",
                    NormalizedEmail = "USER19@EXAMPLE.COM",
                    FirstName = "ลลิษา",
                    LastName = "ยอดมณี",
                    Nickname = "แบม",
                    RoleId = "1",
                    ProjectId = 10
                },
                new ApplicationUser
                {
                    StudentID = "6404101338",
                    UserName = "user20@example.com",
                    NormalizedUserName = "USER20@EXAMPLE.COM",
                    Email = "user20@example.com",
                    NormalizedEmail = "USER20@EXAMPLE.COM",
                    FirstName = "วชรพล",
                    LastName = "ไชยวรรณ",
                    Nickname = "เติ้ง",
                    RoleId = "1",
                    ProjectId = 11
                },
                new ApplicationUser
                {
                    StudentID = "6404101341",
                    UserName = "user21@example.com",
                    NormalizedUserName = "USER21@EXAMPLE.COM",
                    Email = "user21@example.com",
                    NormalizedEmail = "USER21@EXAMPLE.COM",
                    FirstName = "ศรายุทธ",
                    LastName = "เสนอาสา",
                    Nickname = "คิม",
                    RoleId = "1",
                    ProjectId = 12
                },
                new ApplicationUser
                {
                    StudentID = "6404101344",
                    UserName = "user22@example.com",
                    NormalizedUserName = "USER22@EXAMPLE.COM",
                    Email = "user22@example.com",
                    NormalizedEmail = "USER22@EXAMPLE.COM",
                    FirstName = "ศุภณัฐ",
                    LastName = "วิบูลย์พานิช",
                    Nickname = "ออม",
                    RoleId = "1",
                    ProjectId = 12
                },
                new ApplicationUser
                {
                    StudentID = "6404101345",
                    UserName = "user23@example.com",
                    NormalizedUserName = "USER23@EXAMPLE.COM",
                    Email = "user23@example.com",
                    NormalizedEmail = "USER23@EXAMPLE.COM",
                    FirstName = "เศรษฐพงศ์",
                    LastName = "อินทร์แสง",
                    Nickname = "แบงค์",
                    RoleId = "1",
                    ProjectId = 13
                },
                new ApplicationUser
                {
                    StudentID = "6404101334",
                    UserName = "user24@example.com",
                    NormalizedUserName = "USER24@EXAMPLE.COM",
                    Email = "user24@example.com",
                    NormalizedEmail = "USER24@EXAMPLE.COM",
                    FirstName = "รัฐติกรณ์",
                    LastName = "จินะกาศ",
                    Nickname = "โอม",
                    RoleId = "1",
                    ProjectId = 13
                },
                new ApplicationUser
                {
                    StudentID = "6404101347",
                    UserName = "user25@example.com",
                    NormalizedUserName = "USER25@EXAMPLE.COM",
                    Email = "user25@example.com",
                    NormalizedEmail = "USER25@EXAMPLE.COM",
                    FirstName = "สุจิตรา",
                    LastName = "ปานการะเกตุ",
                    Nickname = "โม",
                    RoleId = "1",
                    ProjectId = 14
                },
                new ApplicationUser
                {
                    StudentID = "6404101348",
                    UserName = "user26@example.com",
                    NormalizedUserName = "USER26@EXAMPLE.COM",
                    Email = "user26@example.com",
                    NormalizedEmail = "USER26@EXAMPLE.COM",
                    FirstName = "สุธิชานนท์",
                    LastName = "พูลการขาย",
                    Nickname = "เม่น",
                    RoleId = "1",
                    ProjectId = 14
                },
                new ApplicationUser
                {
                    StudentID = "6404101342",
                    UserName = "user27@example.com",
                    NormalizedUserName = "USER27@EXAMPLE.COM",
                    Email = "user27@example.com",
                    NormalizedEmail = "USER27@EXAMPLE.COM",
                    FirstName = "ศิระณัฐ",
                    LastName = "จันทะกี",
                    Nickname = "มาร์ค",
                    RoleId = "1",
                    ProjectId = 15
                },
                new ApplicationUser
                {
                    StudentID = "6404101349",
                    UserName = "user28@example.com",
                    NormalizedUserName = "USER28@EXAMPLE.COM",
                    Email = "user28@example.com",
                    NormalizedEmail = "USER28@EXAMPLE.COM",
                    FirstName = "สุนิสา",
                    LastName = "ผาด่าน",
                    Nickname = "ชิ",
                    RoleId = "1",
                    ProjectId = 15
                },
                new ApplicationUser
                {
                    StudentID = "6404101354",
                    UserName = "user29@example.com",
                    NormalizedUserName = "USER29@EXAMPLE.COM",
                    Email = "user29@example.com",
                    NormalizedEmail = "USER29@EXAMPLE.COM",
                    FirstName = "กณิศนันท์",
                    LastName = "ทองสกุล",
                    Nickname = "แยม",
                    RoleId = "1",
                    ProjectId = 16
                },
                new ApplicationUser
                {
                    StudentID = "6404101357",
                    UserName = "user30@example.com",
                    NormalizedUserName = "USER30@EXAMPLE.COM",
                    Email = "user30@example.com",
                    NormalizedEmail = "USER30@EXAMPLE.COM",
                    FirstName = "ชนันฌ์ณภัสฐ์",
                    LastName = "สิงห์คาล",
                    Nickname = "สาหร่าย",
                    RoleId = "1",
                    ProjectId = 17
                },
                new ApplicationUser
                {
                    StudentID = "6404101335",
                    UserName = "user31@example.com",
                    NormalizedUserName = "USER31@EXAMPLE.COM",
                    Email = "user31@example.com",
                    NormalizedEmail = "USER31@EXAMPLE.COM",
                    FirstName = "รุ่งเจริญ",
                    LastName = "โพธิ์ศรี",
                    Nickname = "เพชร",
                    RoleId = "1",
                    ProjectId = 18
                },
                new ApplicationUser
                {
                    StudentID = "6404101365",
                    UserName = "user32@example.com",
                    NormalizedUserName = "USER32@EXAMPLE.COM",
                    Email = "user32@example.com",
                    NormalizedEmail = "USER32@EXAMPLE.COM",
                    FirstName = "พงศกร",
                    LastName = "คูณเสนา",
                    Nickname = "เพชร",
                    RoleId = "1",
                    ProjectId = 18
                },
                new ApplicationUser
                {
                    StudentID = "6404101372",
                    UserName = "user33@example.com",
                    NormalizedUserName = "USER33@EXAMPLE.COM",
                    Email = "user33@example.com",
                    NormalizedEmail = "USER33@EXAMPLE.COM",
                    FirstName = "ศิริชัย",
                    LastName = "เกษมสุข",
                    Nickname = "โอม",
                    RoleId = "1",
                    ProjectId = 19
                },
                new ApplicationUser
                {
                    StudentID = "6404101356",
                    UserName = "user34@example.com",
                    NormalizedUserName = "USER34@EXAMPLE.COM",
                    Email = "user34@example.com",
                    NormalizedEmail = "USER34@EXAMPLE.COM",
                    FirstName = "กุณช์ศุภณัฐ",
                    LastName = "ศรีตาบุตรวรัตถ์",
                    Nickname = "ยู",
                    RoleId = "1",
                    ProjectId = 20
                }
            };

            foreach (var student in students)
            {
                student.PasswordHash = _passwordHasher.HashPassword(student, ".Password123!");
            }

            return students;
        }
    }
}
