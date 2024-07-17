using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoopWeb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProjectName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Chairman = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Director1 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Director2 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Advisor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkPlace = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Stages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    StageNumber = table.Column<int>(type: "int", nullable: false),
                    StageName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FileName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Deadline = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FilePath = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FileData = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StudentID = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nickname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Student", "STUDENT" },
                    { "2", null, "Staff", "STAFF" },
                    { "3", null, "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Advisor", "Chairman", "Director1", "Director2", "ProjectName", "WorkPlace" },
                values: new object[,]
                {
                    { 1, null, "อ.อลงกต กองมณี", "ผศ.ก่องกาญจน์ ดุลยไชย", "ผศ.ก่องกาญจน์ ดุลยไชย", "การพัฒนาฟอเร็กซ์เอ็กซ์เพิร์ทแอดไวเซอร์ และเว็บไชต์เพื่อการจัดจำหน่าย", "บริษัท โกลเด้น อาวเออร์ สตูดิโอ จำกัด" },
                    { 2, null, "อ.ดร.พยุงศักดิ์ เกษมสำราญ", "ผศ.ภานุวัฒน์ เมฆะ", "ผศ.ภานุวัฒน์ เมฆะ", "หุ่นยนต์ตรวจโรคพืชอัตโนมัติ", "บริษัท ควอนต้า ซินเนอร์จี้ จำกัด" },
                    { 3, null, "ผศ.ภานุวัฒน์ เมฆะ", "อ.ดร.พยุงศักดิ์ เกษมสำรา", "อ.ดร.พยุงศักดิ์ เกษมสำราญ", "ระบบจองห้องประชุมงานเพื่อเชื่อมต่อกับระบบบริหารทรัพยากรบุคคล", "บริษัทดูดี อินดีด คอร์ปอเรชัน จํากัด" },
                    { 4, null, "อ.ดร.สมนึก สินธุปวน", "ผศ.ดร.พาสน์ ปราโมกข์ช", "ผศ.ดร.พาสน์ ปราโมกข์ชน", "การพัฒนาระบบ AI สำหรับใช้ใน NPC ในเมตาเวิร์ส", "บริษัท เอ็นดีเอฟ เดฟ จำกัด" },
                    { 5, null, "ผศ.ก่องกาญจน์ ดุลยไชย", "อ.อรรถวิท ชังคมานนท์", "อ.อรรถวิท ชังคมานนท์", "เพย์โซลูชั่นเช็คสลิป", "บริษัทเพย์โซลูชั่น จำกัด (เชียงใหม่)" },
                    { 6, null, "อ.อรรถวิท ชังคมานนท์", "ผศ.ก่องกาญจน์ ดุลยไชย", "ผศ.ก่องกาญจน์ ดุลยไชย", "ระบบการแจ้งเตือนการชำระเงินผ่านแอปพลิเคชั่นไลน์", "บริษัทเพย์โซลูชั่น จำกัด (กรุงเทพ)" },
                    { 7, null, "ผศ.ดร.ปวีณ เขื่อนแก้ว", "อ.อรรถวิท ชังคมานนท์", "อ.อรรถวิท ชังคมานนท์", "SecureManage : ระบบสำหรับบริหารจัดการ Pentest และ PoC ตามมาตรฐาน OWASP", "บริษัท ไอเน็ต แมเนจ์ เซอร์วิสเซส จำกัด" },
                    { 8, null, "ผศ.ดร.สนิท สิทธิ", "อ.อลงกต กองมณี", "ผศ.ภานุวัฒน์ เมฆะ", "ระบบจัดการลำดับคิว", "บริษัท ไอโซแคร์ ซิสเตมส์ จำกัด" },
                    { 9, null, "อ.ดร.สมนึก สินธุปวน", "อ.อลงกต กองมณี", "อ.อลงกต กองมณี", "ระบบจัดการบริการดูแลและบำรุงรักษา", "บริษัท ลูคัส สแทรททิจี จำกัด" },
                    { 10, null, "ผศ.ภานุวัฒน์ เมฆะ", "อ.ดร.พยุงศักดิ์ เกษมสำรา", "อ.ดร.พยุงศักดิ์ เกษมสำราญ", "ระบบสนับสนุนและรายงานผลธนาคารเวชกรรม", "บริษัท ไอบิท แบงก์ จำกัด" },
                    { 11, null, "ผศ.ภานุวัฒน์ เมฆะ", "ผศ.ภานุวัฒน์ เมฆะ", "ผศ.ภานุวัฒน์ เมฆะ", "บริษัท ควอนต้า ซินเนอร์จี้ จำกัด", "อ.ดร.พยุงศักดิ์ เกษมสำราญ" },
                    { 12, null, "อ.ดร.พยุงศักดิ์ เกษมสำราญ", "อ.ดร.พยุงศักดิ์ เกษมสำรา", "อ.ดร.พยุงศักดิ์ เกษมสำราญ", "ระบบจองห้องประชุมงานเพื่อเชื่อมต่อกับระบบบริหารทรัพยากรบุคคล", "บริษัทดูดี อินดีด คอร์ปอเรชัน จำกัด" },
                    { 13, null, "ผศ.ดร.ปวีณ เขื่อนแก้ว", "อ.อรรถวิท ชังคมานนท์", "อ.อรรถวิท ชังคมานนท์", "SecureManage : ระบบสำหรับบริหารจัดการ Pentest และ PoC ตามมาตรฐาน OWASP", "บริษัท ไอเน็ต แมเนจ์ เซอร์วิสเซส จำกัด" },
                    { 14, null, "อ.อรรถวิท ชังคมานนท์", "ผศ.ก่องกาญจน์ ดุลยไชย", "ผศ.ก่องกาญจน์ ดุลยไชย", "ระบบการแจ้งเตือนการชำระเงินผ่านแอปพลิเคชั่นไลน์", "บริษัทเพย์โซลูชั่น จำกัด (กรุงเทพ)" },
                    { 15, null, "ผศ.ภานุวัฒน์ เมฆะ", "อ.ดร.พยุงศักดิ์ เกษมสำรา", "อ.ดร.พยุงศักดิ์ เกษมสำราญ", "ระบบสนับสนุนและรายงานผลธนาคารเวชกรรม", "บริษัท ไอบิท แบงก์ จำกัด" },
                    { 16, null, "ผศ.ดร.สนิท สิทธิ", "อ.อลงกต กองมณี", null, "ระบบจัดการลำดับคิว", "บริษัท ไอโซแคร์ ซิสเตมส์ จำกัด" },
                    { 17, null, "อ.ดร.สมนึก สินธุปวน", "อ.อลงกต กองมณี", "อ.อลงกต กองมณี", "ระบบจัดการบริการดูแลและบำรุงรักษา", "บริษัท ลูคัส สแทรททิจี จำกัด" },
                    { 18, null, "อ.ดร.พยุงศักดิ์ เกษมสำราญ", "อ.ดร.พยุงศักดิ์ เกษมสำรา", "อ.ดร.พยุงศักดิ์ เกษมสำราญ", "ระบบจองห้องประชุมงานเพื่อเชื่อมต่อกับระบบบริหารทรัพยากรบุคคล", "บริษัทดูดี อินดีด คอร์ปอเรชัน จำกัด" },
                    { 19, null, "ผศ.ดร.ปวีณ เขื่อนแก้ว", "อ.อรรถวิท ชังคมานนท์", "อ.อรรถวิท ชังคมานนท์", "SecureManage : ระบบสำหรับบริหารจัดการ Pentest และ PoC ตามมาตรฐาน OWASP", "บริษัท ไอเน็ต แมเนจ์ เซอร์วิสเซส จำกัด" },
                    { 20, null, "อ.อรรถวิท ชังคมานนท์", "ผศ.ก่องกาญจน์ ดุลยไชย", "ผศ.ก่องกาญจน์ ดุลยไชย", "ระบบการแจ้งเตือนการชำระเงินผ่านแอปพลิเคชั่นไลน์", "บริษัทเพย์โซลูชั่น จำกัด (กรุงเทพ)" }
                });

            migrationBuilder.InsertData(
                table: "Stages",
                columns: new[] { "Id", "Deadline", "Description", "FileData", "FileName", "FilePath", "ProjectId", "StageId", "StageName", "StageNumber", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7734), null, null, null, null, 1, 4, null, 4, null },
                    { 2, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7837), null, null, null, "File2.pdf", 1, 5, "Project 1", 5, "Not Started" },
                    { 3, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7849), null, null, null, "File3.pdf", 1, 6, "Project 1", 6, "Not Started" },
                    { 4, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7853), null, null, null, null, 1, 7, null, 7, null },
                    { 5, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7858), null, null, null, "File5.pdf", 1, 8, "Project 1", 8, "Not Started" },
                    { 6, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7866), null, null, null, "File6.pdf", 1, 9, "Project 1", 9, "Not Started" },
                    { 7, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7871), null, null, null, null, 1, 10, null, 10, null },
                    { 8, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7873), null, null, null, null, 1, 11, null, 11, null },
                    { 9, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7875), null, null, null, null, 1, 12, null, 12, null },
                    { 10, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7879), null, null, null, null, 1, 13, null, 13, null },
                    { 11, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7881), null, null, null, null, 2, 4, null, 4, null },
                    { 12, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7886), null, null, null, "File2.pdf", 2, 5, "Project 2", 5, "Not Started" },
                    { 13, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7892), null, null, null, "File3.pdf", 2, 6, "Project 2", 6, "Not Started" },
                    { 14, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7896), null, null, null, null, 2, 7, null, 7, null },
                    { 15, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7900), null, null, null, "File5.pdf", 2, 8, "Project 2", 8, "Not Started" },
                    { 16, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7907), null, null, null, "File6.pdf", 2, 9, "Project 2", 9, "Not Started" },
                    { 17, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7911), null, null, null, null, 2, 10, null, 10, null },
                    { 18, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7914), null, null, null, null, 2, 11, null, 11, null },
                    { 19, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7917), null, null, null, null, 2, 12, null, 12, null },
                    { 20, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7919), null, null, null, null, 2, 13, null, 13, null },
                    { 21, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7921), null, null, null, null, 3, 4, null, 4, null },
                    { 22, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7925), null, null, null, "File2.pdf", 3, 5, "Project 3", 5, "Not Started" },
                    { 23, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7932), null, null, null, "File3.pdf", 3, 6, "Project 3", 6, "Not Started" },
                    { 24, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7944), null, null, null, null, 3, 7, null, 7, null },
                    { 25, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7949), null, null, null, "File5.pdf", 3, 8, "Project 3", 8, "Not Started" },
                    { 26, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7955), null, null, null, "File6.pdf", 3, 9, "Project 3", 9, "Not Started" },
                    { 27, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7959), null, null, null, null, 3, 10, null, 10, null },
                    { 28, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7962), null, null, null, null, 3, 11, null, 11, null },
                    { 29, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7964), null, null, null, null, 3, 12, null, 12, null },
                    { 30, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(7976), null, null, null, null, 3, 13, null, 13, null },
                    { 31, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(8875), null, null, null, null, 4, 4, null, 4, null },
                    { 32, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(8937), null, null, null, "File2.pdf", 4, 5, "Project 4", 5, "Not Started" },
                    { 33, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(8949), null, null, null, "File3.pdf", 4, 6, "Project 4", 6, "Not Started" },
                    { 34, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(8965), null, null, null, null, 4, 7, null, 7, null },
                    { 35, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(8971), null, null, null, "File5.pdf", 4, 8, "Project 4", 8, "Not Started" },
                    { 36, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9059), null, null, null, "File6.pdf", 4, 9, "Project 4", 9, "Not Started" },
                    { 37, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9066), null, null, null, null, 4, 10, null, 10, null },
                    { 38, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9069), null, null, null, null, 4, 11, null, 11, null },
                    { 39, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9071), null, null, null, null, 4, 12, null, 12, null },
                    { 40, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9074), null, null, null, null, 4, 13, null, 13, null },
                    { 41, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9077), null, null, null, null, 5, 4, null, 4, null },
                    { 42, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9083), null, null, null, "File2.pdf", 5, 5, "Project 5", 5, "Not Started" },
                    { 43, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9094), null, null, null, "File3.pdf", 5, 6, "Project 5", 6, "Not Started" },
                    { 44, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9100), null, null, null, null, 5, 7, null, 7, null },
                    { 45, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9106), null, null, null, "File5.pdf", 5, 8, "Project 5", 8, "Not Started" },
                    { 46, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9325), null, null, null, "File6.pdf", 5, 9, "Project 5", 9, "Not Started" },
                    { 47, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9332), null, null, null, null, 5, 10, null, 10, null },
                    { 48, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9335), null, null, null, null, 5, 11, null, 11, null },
                    { 49, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9338), null, null, null, null, 5, 12, null, 12, null },
                    { 50, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9340), null, null, null, null, 5, 13, null, 13, null },
                    { 51, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9343), null, null, null, null, 6, 4, null, 4, null },
                    { 52, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9350), null, null, null, "File2.pdf", 6, 5, "Project 6", 5, "Not Started" },
                    { 53, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9359), null, null, null, "File3.pdf", 6, 6, "Project 6", 6, "Not Started" },
                    { 54, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9365), null, null, null, null, 6, 7, null, 7, null },
                    { 55, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9371), null, null, null, "File5.pdf", 6, 8, "Project 6", 8, "Not Started" },
                    { 56, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9380), null, null, null, "File6.pdf", 6, 9, "Project 6", 9, "Not Started" },
                    { 57, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9387), null, null, null, null, 6, 10, null, 10, null },
                    { 58, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9390), null, null, null, null, 6, 11, null, 11, null },
                    { 59, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9393), null, null, null, null, 6, 12, null, 12, null },
                    { 60, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9395), null, null, null, null, 6, 13, null, 13, null },
                    { 61, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9398), null, null, null, null, 7, 4, null, 4, null },
                    { 62, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9404), null, null, null, "File2.pdf", 7, 5, "Project 7", 5, "Not Started" },
                    { 63, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9413), null, null, null, "File3.pdf", 7, 6, "Project 7", 6, "Not Started" },
                    { 64, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9419), null, null, null, null, 7, 7, null, 7, null },
                    { 65, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9425), null, null, null, "File5.pdf", 7, 8, "Project 7", 8, "Not Started" },
                    { 66, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9439), null, null, null, "File6.pdf", 7, 9, "Project 7", 9, "Not Started" },
                    { 67, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9445), null, null, null, null, 7, 10, null, 10, null },
                    { 68, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9448), null, null, null, null, 7, 11, null, 11, null },
                    { 69, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9450), null, null, null, null, 7, 12, null, 12, null },
                    { 70, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9453), null, null, null, null, 7, 13, null, 13, null },
                    { 71, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9456), null, null, null, null, 8, 4, null, 4, null },
                    { 72, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9461), null, null, null, "File2.pdf", 8, 5, "Project 8", 5, "Not Started" },
                    { 73, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9471), null, null, null, "File3.pdf", 8, 6, "Project 8", 6, "Not Started" },
                    { 74, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9477), null, null, null, null, 8, 7, null, 7, null },
                    { 75, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9483), null, null, null, "File5.pdf", 8, 8, "Project 8", 8, "Not Started" },
                    { 76, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9492), null, null, null, "File6.pdf", 8, 9, "Project 8", 9, "Not Started" },
                    { 77, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9498), null, null, null, null, 8, 10, null, 10, null },
                    { 78, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9501), null, null, null, null, 8, 11, null, 11, null },
                    { 79, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9503), null, null, null, null, 8, 12, null, 12, null },
                    { 80, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9506), null, null, null, null, 8, 13, null, 13, null },
                    { 81, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9509), null, null, null, null, 9, 4, null, 4, null },
                    { 82, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9514), null, null, null, "File2.pdf", 9, 5, "Project 9", 5, "Not Started" },
                    { 83, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9523), null, null, null, "File3.pdf", 9, 6, "Project 9", 6, "Not Started" },
                    { 84, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9530), null, null, null, null, 9, 7, null, 7, null },
                    { 85, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9536), null, null, null, "File5.pdf", 9, 8, "Project 9", 8, "Not Started" },
                    { 86, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9545), null, null, null, "File6.pdf", 9, 9, "Project 9", 9, "Not Started" },
                    { 87, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9552), null, null, null, null, 9, 10, null, 10, null },
                    { 88, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9554), null, null, null, null, 9, 11, null, 11, null },
                    { 89, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9557), null, null, null, null, 9, 12, null, 12, null },
                    { 90, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9559), null, null, null, null, 9, 13, null, 13, null },
                    { 91, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9562), null, null, null, null, 10, 4, null, 4, null },
                    { 92, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9572), null, null, null, "File2.pdf", 10, 5, "Project 10", 5, "Not Started" },
                    { 93, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9581), null, null, null, "File3.pdf", 10, 6, "Project 10", 6, "Not Started" },
                    { 94, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9707), null, null, null, null, 10, 7, null, 7, null },
                    { 95, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9715), null, null, null, "File5.pdf", 10, 8, "Project 10", 8, "Not Started" },
                    { 96, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9725), null, null, null, "File6.pdf", 10, 9, "Project 10", 9, "Not Started" },
                    { 97, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9732), null, null, null, null, 10, 10, null, 10, null },
                    { 98, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9734), null, null, null, null, 10, 11, null, 11, null },
                    { 99, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9737), null, null, null, null, 10, 12, null, 12, null },
                    { 100, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9739), null, null, null, null, 10, 13, null, 13, null },
                    { 101, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9742), null, null, null, null, 11, 4, null, 4, null },
                    { 102, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9748), null, null, null, "File2.pdf", 11, 5, "Project 11", 5, "Not Started" },
                    { 103, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9758), null, null, null, "File3.pdf", 11, 6, "Project 11", 6, "Not Started" },
                    { 104, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9764), null, null, null, null, 11, 7, null, 7, null },
                    { 105, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9770), null, null, null, "File5.pdf", 11, 8, "Project 11", 8, "Not Started" },
                    { 106, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9780), null, null, null, "File6.pdf", 11, 9, "Project 11", 9, "Not Started" },
                    { 107, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9786), null, null, null, null, 11, 10, null, 10, null },
                    { 108, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9789), null, null, null, null, 11, 11, null, 11, null },
                    { 109, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9791), null, null, null, null, 11, 12, null, 12, null },
                    { 110, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9794), null, null, null, null, 11, 13, null, 13, null },
                    { 111, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9797), null, null, null, null, 12, 4, null, 4, null },
                    { 112, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9803), null, null, null, "File2.pdf", 12, 5, "Project 12", 5, "Not Started" },
                    { 113, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9812), null, null, null, "File3.pdf", 12, 6, "Project 12", 6, "Not Started" },
                    { 114, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9817), null, null, null, null, 12, 7, null, 7, null },
                    { 115, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9823), null, null, null, "File5.pdf", 12, 8, "Project 12", 8, "Not Started" },
                    { 116, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9833), null, null, null, "File6.pdf", 12, 9, "Project 12", 9, "Not Started" },
                    { 117, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9840), null, null, null, null, 12, 10, null, 10, null },
                    { 118, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9842), null, null, null, null, 12, 11, null, 11, null },
                    { 119, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9845), null, null, null, null, 12, 12, null, 12, null },
                    { 120, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9847), null, null, null, null, 12, 13, null, 13, null },
                    { 121, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9850), null, null, null, null, 13, 4, null, 4, null },
                    { 122, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9856), null, null, null, "File2.pdf", 13, 5, "Project 13", 5, "Not Started" },
                    { 123, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9865), null, null, null, "File3.pdf", 13, 6, "Project 13", 6, "Not Started" },
                    { 124, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9871), null, null, null, null, 13, 7, null, 7, null },
                    { 125, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9877), null, null, null, "File5.pdf", 13, 8, "Project 13", 8, "Not Started" },
                    { 126, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9886), null, null, null, "File6.pdf", 13, 9, "Project 13", 9, "Not Started" },
                    { 127, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9893), null, null, null, null, 13, 10, null, 10, null },
                    { 128, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9896), null, null, null, null, 13, 11, null, 11, null },
                    { 129, new DateTime(2025, 4, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9898), null, null, null, null, 13, 12, null, 12, null },
                    { 130, new DateTime(2025, 5, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9904), null, null, null, null, 13, 13, null, 13, null },
                    { 131, new DateTime(2024, 8, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9907), null, null, null, null, 14, 4, null, 4, null },
                    { 132, new DateTime(2024, 9, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9913), null, null, null, "File2.pdf", 14, 5, "Project 14", 5, "Not Started" },
                    { 133, new DateTime(2024, 10, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9922), null, null, null, "File3.pdf", 14, 6, "Project 14", 6, "Not Started" },
                    { 134, new DateTime(2024, 11, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9929), null, null, null, null, 14, 7, null, 7, null },
                    { 135, new DateTime(2024, 12, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9979), null, null, null, "File5.pdf", 14, 8, "Project 14", 8, "Not Started" },
                    { 136, new DateTime(2025, 1, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9989), null, null, null, "File6.pdf", 14, 9, "Project 14", 9, "Not Started" },
                    { 137, new DateTime(2025, 2, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9995), null, null, null, null, 14, 10, null, 10, null },
                    { 138, new DateTime(2025, 3, 17, 21, 39, 58, 420, DateTimeKind.Local).AddTicks(9998), null, null, null, null, 14, 11, null, 11, null },
                    { 139, new DateTime(2025, 4, 17, 21, 39, 58, 421, DateTimeKind.Local), null, null, null, null, 14, 12, null, 12, null },
                    { 140, new DateTime(2025, 5, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(3), null, null, null, null, 14, 13, null, 13, null },
                    { 141, new DateTime(2024, 8, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(5), null, null, null, null, 15, 4, null, 4, null },
                    { 142, new DateTime(2024, 9, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(11), null, null, null, "File2.pdf", 15, 5, "Project 15", 5, "Not Started" },
                    { 143, new DateTime(2024, 10, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(20), null, null, null, "File3.pdf", 15, 6, "Project 15", 6, "Not Started" },
                    { 144, new DateTime(2024, 11, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(26), null, null, null, null, 15, 7, null, 7, null },
                    { 145, new DateTime(2024, 12, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(32), null, null, null, "File5.pdf", 15, 8, "Project 15", 8, "Not Started" },
                    { 146, new DateTime(2025, 1, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(42), null, null, null, "File6.pdf", 15, 9, "Project 15", 9, "Not Started" },
                    { 147, new DateTime(2025, 2, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(48), null, null, null, null, 15, 10, null, 10, null },
                    { 148, new DateTime(2025, 3, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(50), null, null, null, null, 15, 11, null, 11, null },
                    { 149, new DateTime(2025, 4, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(53), null, null, null, null, 15, 12, null, 12, null },
                    { 150, new DateTime(2025, 5, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(55), null, null, null, null, 15, 13, null, 13, null },
                    { 151, new DateTime(2024, 8, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(58), null, null, null, null, 16, 4, null, 4, null },
                    { 152, new DateTime(2024, 9, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(64), null, null, null, "File2.pdf", 16, 5, "Project 16", 5, "Not Started" },
                    { 153, new DateTime(2024, 10, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(73), null, null, null, "File3.pdf", 16, 6, "Project 16", 6, "Not Started" },
                    { 154, new DateTime(2024, 11, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(79), null, null, null, null, 16, 7, null, 7, null },
                    { 155, new DateTime(2024, 12, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(85), null, null, null, "File5.pdf", 16, 8, "Project 16", 8, "Not Started" },
                    { 156, new DateTime(2025, 1, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(94), null, null, null, "File6.pdf", 16, 9, "Project 16", 9, "Not Started" },
                    { 157, new DateTime(2025, 2, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(100), null, null, null, null, 16, 10, null, 10, null },
                    { 158, new DateTime(2025, 3, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(103), null, null, null, null, 16, 11, null, 11, null },
                    { 159, new DateTime(2025, 4, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(105), null, null, null, null, 16, 12, null, 12, null },
                    { 160, new DateTime(2025, 5, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(108), null, null, null, null, 16, 13, null, 13, null },
                    { 161, new DateTime(2024, 8, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(110), null, null, null, null, 17, 4, null, 4, null },
                    { 162, new DateTime(2024, 9, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(117), null, null, null, "File2.pdf", 17, 5, "Project 17", 5, "Not Started" },
                    { 163, new DateTime(2024, 10, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(126), null, null, null, "File3.pdf", 17, 6, "Project 17", 6, "Not Started" },
                    { 164, new DateTime(2024, 11, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(131), null, null, null, null, 17, 7, null, 7, null },
                    { 165, new DateTime(2024, 12, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(138), null, null, null, "File5.pdf", 17, 8, "Project 17", 8, "Not Started" },
                    { 166, new DateTime(2025, 1, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(146), null, null, null, "File6.pdf", 17, 9, "Project 17", 9, "Not Started" },
                    { 167, new DateTime(2025, 2, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(153), null, null, null, null, 17, 10, null, 10, null },
                    { 168, new DateTime(2025, 3, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(156), null, null, null, null, 17, 11, null, 11, null },
                    { 169, new DateTime(2025, 4, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(158), null, null, null, null, 17, 12, null, 12, null },
                    { 170, new DateTime(2025, 5, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(161), null, null, null, null, 17, 13, null, 13, null },
                    { 171, new DateTime(2024, 8, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(163), null, null, null, null, 18, 4, null, 4, null },
                    { 172, new DateTime(2024, 9, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(169), null, null, null, "File2.pdf", 18, 5, "Project 18", 5, "Not Started" },
                    { 173, new DateTime(2024, 10, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(178), null, null, null, "File3.pdf", 18, 6, "Project 18", 6, "Not Started" },
                    { 174, new DateTime(2024, 11, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(184), null, null, null, null, 18, 7, null, 7, null },
                    { 175, new DateTime(2024, 12, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(191), null, null, null, "File5.pdf", 18, 8, "Project 18", 8, "Not Started" },
                    { 176, new DateTime(2025, 1, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(200), null, null, null, "File6.pdf", 18, 9, "Project 18", 9, "Not Started" },
                    { 177, new DateTime(2025, 2, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(207), null, null, null, null, 18, 10, null, 10, null },
                    { 178, new DateTime(2025, 3, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(209), null, null, null, null, 18, 11, null, 11, null },
                    { 179, new DateTime(2025, 4, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(212), null, null, null, null, 18, 12, null, 12, null },
                    { 180, new DateTime(2025, 5, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(214), null, null, null, null, 18, 13, null, 13, null },
                    { 181, new DateTime(2024, 8, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(217), null, null, null, null, 19, 4, null, 4, null },
                    { 182, new DateTime(2024, 9, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(223), null, null, null, "File2.pdf", 19, 5, "Project 19", 5, "Not Started" },
                    { 183, new DateTime(2024, 10, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(232), null, null, null, "File3.pdf", 19, 6, "Project 19", 6, "Not Started" },
                    { 184, new DateTime(2024, 11, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(239), null, null, null, null, 19, 7, null, 7, null },
                    { 185, new DateTime(2024, 12, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(245), null, null, null, "File5.pdf", 19, 8, "Project 19", 8, "Not Started" },
                    { 186, new DateTime(2025, 1, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(255), null, null, null, "File6.pdf", 19, 9, "Project 19", 9, "Not Started" },
                    { 187, new DateTime(2025, 2, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(416), null, null, null, null, 19, 10, null, 10, null },
                    { 188, new DateTime(2025, 3, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(419), null, null, null, null, 19, 11, null, 11, null },
                    { 189, new DateTime(2025, 4, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(422), null, null, null, null, 19, 12, null, 12, null },
                    { 190, new DateTime(2025, 5, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(424), null, null, null, null, 19, 13, null, 13, null },
                    { 191, new DateTime(2024, 8, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(427), null, null, null, null, 20, 4, null, 4, null },
                    { 192, new DateTime(2024, 9, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(435), null, null, null, "File2.pdf", 20, 5, "Project 20", 5, "Not Started" },
                    { 193, new DateTime(2024, 10, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(445), null, null, null, "File3.pdf", 20, 6, "Project 20", 6, "Not Started" },
                    { 194, new DateTime(2024, 11, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(451), null, null, null, null, 20, 7, null, 7, null },
                    { 195, new DateTime(2024, 12, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(457), null, null, null, "File5.pdf", 20, 8, "Project 20", 8, "Not Started" },
                    { 196, new DateTime(2025, 1, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(467), null, null, null, "File6.pdf", 20, 9, "Project 20", 9, "Not Started" },
                    { 197, new DateTime(2025, 2, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(473), null, null, null, null, 20, 10, null, 10, null },
                    { 198, new DateTime(2025, 3, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(475), null, null, null, null, 20, 11, null, 11, null },
                    { 199, new DateTime(2025, 4, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(478), null, null, null, null, 20, 12, null, 12, null },
                    { 200, new DateTime(2025, 5, 17, 21, 39, 58, 421, DateTimeKind.Local).AddTicks(480), null, null, null, null, 20, 13, null, 13, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProjectId", "RoleId", "SecurityStamp", "StudentID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16922ff8-2d7c-4cde-b3a9-0910a9a94d89", 0, "39b6de84-2867-4737-93ad-910d88ca5eaf", "user29@example.com", false, "กณิศนันท์", "ทองสกุล", false, null, "แยม", "USER29@EXAMPLE.COM", "USER29@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI7GAx6R2pC9p22IUVKt06LgUiOaTzgSFK+jdkLqKLfTZp0MrcT95dk2KBtMJWovuQ==", null, false, 16, "1", "c0f5a728-2411-4f4f-95d0-0a63f86ddb8a", "6404101354", false, "user29@example.com" },
                    { "1aa5ee2c-dd32-42b1-9a15-9d19f34b74fe", 0, "ac7fdf74-706b-45a3-9f48-c07b73d8e4e0", "user13@example.com", false, "ไอลดา", "แสงภิรมย์", false, null, "เฟริ์น", "USER13@EXAMPLE.COM", "USER13@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOxC7Z4tM/ehNXo3LInRtGFRcFlOJf71DoP1NRGKaXg/D88SEOAxe5JQEIUFs0pQVg==", null, false, 6, "1", "179b97e7-175d-4c47-9d4d-b10bb8f5cc5b", "6404101379", false, "user13@example.com" },
                    { "20c92bdd-29dc-4a94-8418-448ed01a0c3a", 0, "c237a8e3-13aa-48e0-aea4-63a0684284ac", "teacher@example.com", false, "Jim", "Beam", false, null, "Jimmy", "TEACHER@EXAMPLE.COM", "TEACHER@EXAMPLE.COM", "AQAAAAIAAYagAAAAENkPohh8ZK3udLM/HQgb9mvz1OfJlNZy2i5edIK9OpnlK082TteZGc3lfnSrU4hG9g==", null, false, 0, "3", "6e56177e-3a19-494c-81c2-9c47d56ef3d6", null, false, "teacher@example.com" },
                    { "21d36960-6d3c-4c5a-9c4e-4f45ecba7177", 0, "ab226054-e9a2-46bc-a372-9cf0eea6cb81", "user27@example.com", false, "ศิระณัฐ", "จันทะกี", false, null, "มาร์ค", "USER27@EXAMPLE.COM", "USER27@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM5PyhvlEV6810UQr+0Jh5lsNs0cYZukBZq+ONOmGwYbQvwFp/qI6VjtcUzIlGDC+Q==", null, false, 15, "1", "22c67bab-49cb-42d9-bfb2-024f5217f8d3", "6404101342", false, "user27@example.com" },
                    { "25504a42-23bf-491f-821a-9d4c3e0ff648", 0, "5a1f0115-5a60-45d5-8999-e78ef90f62bc", "user21@example.com", false, "ศรายุทธ", "เสนอาสา", false, null, "คิม", "USER21@EXAMPLE.COM", "USER21@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPbiiQdAR4gyUUtjWS3i4pvz1hbu/3b5zbp7mIpkmMLrYgyAJDQDbcChye62NzBbDw==", null, false, 12, "1", "038ec9fe-0b39-4f74-b7a0-8a8026958797", "6404101341", false, "user21@example.com" },
                    { "376a4a34-3a86-4c73-b0c7-4505aa6b146f", 0, "2a4704aa-56e6-48ab-af04-4ab1129fd28c", "user15@example.com", false, "พิมลพรรณ", "เงินทอง", false, null, "โฟร์ท", "USER15@EXAMPLE.COM", "USER15@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBUmqA7PocVLU3TOMwtTMvLbiKKQvGc0Qn+wMAsy+hx9KjaTTp5NRxqH83F02x3LoQ==", null, false, 8, "1", "157f9d9a-7f70-4166-a664-dfcbd5eca9ad", "6404101327", false, "user15@example.com" },
                    { "3a1d907b-7b62-4028-856b-dd78ed4a297a", 0, "576c974a-009a-4fba-8353-a22c687316cf", "user31@example.com", false, "รุ่งเจริญ", "โพธิ์ศรี", false, null, "เพชร", "USER31@EXAMPLE.COM", "USER31@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKgNn2EupmGVnSpBtIcUJkfrtnRfBgIXVek9lpNBCqc6a2KMgHGdkOjYXANTS5hkmA==", null, false, 18, "1", "c192f8d7-53cf-465c-af7d-c4dc77dbc27e", "6404101335", false, "user31@example.com" },
                    { "3fe376fb-ccc5-4a6c-8d9c-e48d63b999a4", 0, "f2ca4f35-4734-4a27-bf0a-731a479101a3", "user22@example.com", false, "ศุภณัฐ", "วิบูลย์พานิช", false, null, "ออม", "USER22@EXAMPLE.COM", "USER22@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHCnI6SkujLi0ripuhTMw78u1ifzR5qJnXeQuv0l3nKPd7uKpZov/RJvSChmKizm7A==", null, false, 12, "1", "668d1d9f-14c0-4b58-8b39-4349f1a19a08", "6404101344", false, "user22@example.com" },
                    { "477e85fe-72ec-4718-81b6-a18cec89bce3", 0, "e618a5f8-2e30-475b-a823-0f4393ad860c", "user32@example.com", false, "พงศกร", "คูณเสนา", false, null, "เพชร", "USER32@EXAMPLE.COM", "USER32@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAkQwuykK5nKI20xu7hrT/1JmPjNe9Oi8eYQd1gvE0lfbqVd2Q1akc1XiDhe5yG1lQ==", null, false, 18, "1", "b6973f97-bbbf-4f3e-b249-67d496df1c4f", "6404101365", false, "user32@example.com" },
                    { "504f1591-5933-424d-a85f-53745f051c1b", 0, "9033246f-c7c6-46e1-903d-a6c43b595434", "user19@example.com", false, "ลลิษา", "ยอดมณี", false, null, "แบม", "USER19@EXAMPLE.COM", "USER19@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO+pSGsI6ko7c+7MlkE6oFQxTHwzwWn4MbTgozukDdIOHrYhmooGoaYLXhX8nKTWiA==", null, false, 10, "1", "589ee9a9-8a5b-4d56-b5dd-a9812e1bb9e9", "6404101337", false, "user19@example.com" },
                    { "5ed72c2c-2479-47db-b831-24a1ff898078", 0, "28e5bab0-af1b-4240-8ea7-da7c78b8d17c", "user24@example.com", false, "รัฐติกรณ์", "จินะกาศ", false, null, "โอม", "USER24@EXAMPLE.COM", "USER24@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO5OcQhLOVP1Lve1/AVgYhlZrPm2YHF8EG9oggIfKk4tc3GZdHiQ3wQQRfx4bMk/+A==", null, false, 13, "1", "fd2ad24a-2e3c-4ed3-be78-a92a4f4f196a", "6404101334", false, "user24@example.com" },
                    { "65c9bedc-6e79-4c52-bf36-6f781101968e", 0, "83426c26-63c4-4f31-9d5f-868f4c09c228", "user7@example.com", false, "ฐิติพงษ์", "เรือนสุภา", false, null, "", "USER7@EXAMPLE.COM", "USER7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGluev9RVI0C7mTpi3nLmgjzCvBsDs9RZfv/LNq87RE0yEd0QYAa2GKA2T2Bz066Tw==", null, false, 4, "1", "78414040-7896-407a-af2e-d14df608649b", "6404101311", false, "user7@example.com" },
                    { "65e69316-91c5-4f23-a382-6d85b03ad188", 0, "3fdb4c51-b493-4bac-b965-8540734fa56a", "user25@example.com", false, "สุจิตรา", "ปานการะเกตุ", false, null, "โม", "USER25@EXAMPLE.COM", "USER25@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH21DsncZaj27sKJ7+UjYa5C4xmCzTy/UV7UBs5E/M4OMLrpX8fEvSup7sCd5XCzyg==", null, false, 14, "1", "12b49956-d3b8-452d-939a-1195a4cba0e4", "6404101347", false, "user25@example.com" },
                    { "6694a287-dfe1-4496-baa1-f07da4ec20af", 0, "c622932a-50d5-4023-9d16-b331a7943b77", "staff@example.com", false, "Jane", "Doe", false, null, "Janie", "STAFF@EXAMPLE.COM", "STAFF@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFIGOSK0zrgerKcBDIAjczNNDN/l7TuDHO96lY4WuWeyd3j1UUfCjcWg9ZgXZdlmPw==", null, false, 0, "2", "ffae6135-2d1d-494b-8128-1b09bc2d89dd", null, false, "staff@example.com" },
                    { "6788538d-43a2-4e55-8204-2602b6a14cf4", 0, "1f27d177-79bf-46e4-96ba-3a823925c125", "user9@example.com", false, "ตะวัน", "สุรินา", false, null, "เจแปน", "USER9@EXAMPLE.COM", "USER9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ56uJMPxjGhwQMS+2gK+8vGUC/4kxAibObfO1dBf4VgDN2hHzid7u8d2uHV7GXVNA==", null, false, 5, "1", "eb67a6b2-9640-4a27-ab47-e648c8bc303d", "6404101316", false, "user9@example.com" },
                    { "69de53da-e19a-4549-8388-6f635555927c", 0, "a88bcf54-09e9-404f-8d41-9b08210ad8f7", "user33@example.com", false, "ศิริชัย", "เกษมสุข", false, null, "โอม", "USER33@EXAMPLE.COM", "USER33@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDCkBJff8SYoAduH5Mdu5scbXz4IjDZypCGt26ZJyn+1rckAaHA9chYpIyQNtL43QA==", null, false, 19, "1", "c6223a47-b878-4a9f-b861-21f8d3fdd20a", "6404101372", false, "user33@example.com" },
                    { "6f91fa39-f2fa-42b8-99a2-0771fe4fd9b7", 0, "fa20e96c-2179-4653-b7b7-58cf060280ba", "user20@example.com", false, "วชรพล", "ไชยวรรณ", false, null, "เติ้ง", "USER20@EXAMPLE.COM", "USER20@EXAMPLE.COM", "AQAAAAIAAYagAAAAECqLFaC9pAyMpY4sH5yup2MPBYGKTRtMqh14cfcBds5WA0eYkdN7D29fmEA/21qblQ==", null, false, 11, "1", "f691725f-cc1f-4162-bd9d-adfe8d04ec0d", "6404101338", false, "user20@example.com" },
                    { "790e71d9-4256-43df-8bf0-27624b9faa47", 0, "4ef271f4-2dfb-4cd1-bde7-8ef5fd9c51da", "user4@example.com", false, "อัจฉริยะณัฐ", "ปะฏิเต", false, null, "ต้อง", "USER4@EXAMPLE.COM", "USER4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ/ed0ngaJ5iBqzCy298zRhdIk28t5WbvSVU2hw90FRwzBCwxUpdTifAqctlMPO4rQ==", null, false, 2, "1", "7519ac57-fc09-4944-859e-c2029a9cdfdd", "6404101378", false, "user4@example.com" },
                    { "80a5a9fe-72cf-4dd5-96bf-362e4421cdfe", 0, "ba301c88-e664-4ef0-a374-1f981d12e67d", "user17@example.com", false, "อดิศร", "วงศ์คำ", false, null, "แนท", "USER17@EXAMPLE.COM", "USER17@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFrpYYE2GsVFBA2hPSwzX8cQAWEH7fK/ktnGlTPCWsCHsMY8HeqkbMJI3ToslFkn+g==", null, false, 9, "1", "3c34fb2e-cbbd-40de-ac3c-a2644f74e315", "6404101350", false, "user17@example.com" },
                    { "81e28eaf-18a2-4631-b7fb-7a879a705bd5", 0, "58eac500-03a7-42e3-9073-8282515343ef", "user12@example.com", false, "มณฑารบ", "ชาวโพงพาง", false, null, "มัดหมี่", "USER12@EXAMPLE.COM", "USER12@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF044HjxEBc8wK2EoT23gdn8h/68/2+7qaCnNMZsDjJIx2/P2DAMDYreW0Xs9rF03Q==", null, false, 6, "1", "a6b5558c-bfb4-4e3d-b3c4-27ee4c2be9ca", "6404101369", false, "user12@example.com" },
                    { "89032091-8b68-4410-acb2-0b66df42fc00", 0, "95b3e364-786e-46d6-9d45-8477e7f2a1d5", "user23@example.com", false, "เศรษฐพงศ์", "อินทร์แสง", false, null, "แบงค์", "USER23@EXAMPLE.COM", "USER23@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGX+3LGjCtJEIgOKEhY1lYYz/UPRaGoM1AvwSa/faR6BwRhXJw++gQFwzWuNsaEwpQ==", null, false, 13, "1", "25d5d56d-9fd4-4f03-9649-ffda08a0f3df", "6404101345", false, "user23@example.com" },
                    { "915e6cbd-ac05-4607-819a-b9c4a09fd414", 0, "5fe064f6-ebf5-4aea-ac61-fecaae0551d8", "user34@example.com", false, "กุณช์ศุภณัฐ", "ศรีตาบุตรวรัตถ์", false, null, "ยู", "USER34@EXAMPLE.COM", "USER34@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKUwjY/vlniEGaY793B+aJvRplLXKx+y+WjjZqEUhy4PaJEMm5HvHgpqMI+9qCFYaA==", null, false, 20, "1", "c4ad99d1-27d5-47f6-a98d-cdd6d8b4e561", "6404101356", false, "user34@example.com" },
                    { "91e6a596-333c-4d5d-9ca3-2ecfa3c50eb1", 0, "a6a8ef6f-3ab0-4688-91d6-9c9ee2a2c2c8", "user16@example.com", false, "ภราดร", "ศรีทา", false, null, "บอล", "USER16@EXAMPLE.COM", "USER16@EXAMPLE.COM", "AQAAAAIAAYagAAAAECEN2/hUY5CSW7Nj6/LnOW0bpBj1YgXNKMofM7Kdyhv+rsnLkC2namocvsFWrJ1htA==", null, false, 8, "1", "7a13d57d-0c5d-4c7e-8562-080356df43af", "6404101330", false, "user16@example.com" },
                    { "a9f38814-ce48-4177-a4eb-90222c662f34", 0, "51d689be-27f8-40d1-9579-36606295ae44", "user30@example.com", false, "ชนันฌ์ณภัสฐ์", "สิงห์คาล", false, null, "สาหร่าย", "USER30@EXAMPLE.COM", "USER30@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGq2oH/0sFVxkpO8kK41XrWtCqMQhcjFtKSWado3Aay8CNiwuerd/42FgAtP9sp+ow==", null, false, 17, "1", "944cee30-5dc1-4d17-a590-edaa7debedc9", "6404101357", false, "user30@example.com" },
                    { "b9d88cfd-a1d7-4e20-908d-eed41ed082a6", 0, "1b583214-0b67-425c-a01d-43e7fee141ee", "user8@example.com", false, "ณรงค์เกียรติ", "นามห้วยทอง", false, null, "ก๊อต", "USER8@EXAMPLE.COM", "USER8@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDYL3g8Tyowu03qIVWq/faepQEXtz8gN+aRCIb7Ryo61pVCuUub9sK/PbyR5UdQwfg==", null, false, 5, "1", "5b6d5e96-c7a2-400a-a9a1-a5189cf60f8f", "6404101312", false, "user8@example.com" },
                    { "c86ab657-ecfc-42e5-9901-c2cc5c17ab88", 0, "f7b089a0-4204-474d-a4c2-a5e8b9d50b9e", "user28@example.com", false, "สุนิสา", "ผาด่าน", false, null, "ชิ", "USER28@EXAMPLE.COM", "USER28@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN9UNk3rhsU9twH4E51m/yIqloztvy4yzRFYxv0bKHehlqAbRzitkyFSIHmwwSHX3Q==", null, false, 15, "1", "e9387137-f119-4062-80fe-f012130fd331", "6404101349", false, "user28@example.com" },
                    { "cb0fcc2d-6983-4a0f-a2ce-47466bc7e848", 0, "33917bfc-312e-4c42-b2cd-63ed0abc6abd", "user1@example.com", false, "ฐิติกร", "เรือนมนต์", false, null, "ไนท์", "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAYPoM22yI9TN38ZCUTkjb0UdbsKCUhGGNA7j/17HuGUGPbgsJfoJO/k16sKmmz7FA==", null, false, 1, "1", "239d6dd2-c7d4-4baf-b036-a29a0a546397", "6304101389", false, "user1@example.com" },
                    { "d7e34f77-4daa-4419-b845-8e43bb663536", 0, "06efa6a7-ccdf-4815-b8ac-fb20e945f1e7", "user6@example.com", false, "เมธาวัฒน์", "มหาวัน", false, null, "ตะวัน", "USER6@EXAMPLE.COM", "USER6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE4wu1iqQQsj2fM1Fmjdx9ZOjZ44bCJ+jYg0JAkRSNK6L1dcF0SZMNFNq0AlmE60DQ==", null, false, 3, "1", "04e906a3-72f8-4088-ae1d-940c48a4afa8", "6404101332", false, "user6@example.com" },
                    { "e87acb77-7336-40ba-b471-f73570393dba", 0, "9abb5b05-d100-46f4-8ad2-9c9235507779", "user10@example.com", false, "ไตรภาค", "สิทธิแก้ว", false, null, "ภาค", "USER10@EXAMPLE.COM", "USER10@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBiJctk2qlTzkuyTscip9SBWGQ+DzFAciqfOjHUa4a2DN5SQarwTFOqE1tRtitH/rA==", null, false, 5, "1", "fb069070-5e48-4e09-8893-c1f6adbe1351", "6404101318", false, "user10@example.com" },
                    { "eacbf0cd-322c-462d-b579-c3f678d40766", 0, "a9b9da22-c55b-4c54-a77d-38fb6d83aa7b", "user5@example.com", false, "ขวัญชนก", "เสนีย์วงศ์ ณ อยุธยา", false, null, "แพรวา", "USER5@EXAMPLE.COM", "USER5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBvN2UB95d2ghnuS6flXxCPb1bCCfa7LxCilr/fmf1zNvAF/PE/RQ30M2o4JG2FHug==", null, false, 3, "1", "c04877a4-ceb7-4768-be9b-53723225b61d", "6404101306", false, "user5@example.com" },
                    { "ef077a63-e399-471a-a4d5-78cd481e45a9", 0, "c0aa8266-7662-4146-befa-791ae686cf7d", "user26@example.com", false, "สุธิชานนท์", "พูลการขาย", false, null, "เม่น", "USER26@EXAMPLE.COM", "USER26@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAkO1yHvcqjXK4eJu0HgbNOb2xY3eYzuv+uOOmBE8/our7rUNT3QXwM5JqKpR3Wcjw==", null, false, 14, "1", "93c67093-837f-4068-8e27-a0bade57afc4", "6404101348", false, "user26@example.com" },
                    { "ef6eeae0-a23e-4a3d-8952-b64db4a3c7be", 0, "4eb8eea0-31ed-47f6-9a17-f7f6f0015ab3", "user11@example.com", false, "ณภัทร", "บัวบาน", false, null, "หนึ่ง", "USER11@EXAMPLE.COM", "USER11@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPf6sofWwxvM0uFW1gxskjuzIIflURpSxu+0mrZ8pd6oe8mGCINXOktjMM3ibfA+cQ==", null, false, 5, "1", "e09f242c-4383-4c66-8976-06df5a2a466b", "6404101359", false, "user11@example.com" },
                    { "f26ce9ca-f84c-47f6-ab1a-436df06e0968", 0, "7496d228-60a7-4102-acab-b3dc236e5826", "user2@example.com", false, "กัญญาพัชร", "ยศสนิท", false, null, "ไอซ์", "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKgS0/cKi03wLZDQ5EH08D5vx6I+NJwJehTrxTNWDgvGYpbeHpD7lFXhUHiEEV84Fg==", null, false, 2, "1", "b9587737-7a7d-48d4-a7f3-232b3b16f55b", "6404101303", false, "user2@example.com" },
                    { "f5681b6d-d21d-4e33-94c9-f5754314abf0", 0, "83b19e54-2f8c-4af2-9793-50cfaa17f5ff", "user18@example.com", false, "อภิวัฒน์", "ไชยา", false, null, "ฟิว", "USER18@EXAMPLE.COM", "USER18@EXAMPLE.COM", "AQAAAAIAAYagAAAAEESGTxLoPWsCm7v8A6k9AtsvJoWyhPQ2aoB9kJN7dPGyk3li67EcjUPsm0XN0rVlOw==", null, false, 9, "1", "bd4cdc5b-0bce-48a2-a1f1-6eeb01331527", "6404101377", false, "user18@example.com" },
                    { "f58ac283-b4d5-43e1-899a-6dda0ef28430", 0, "0ce86054-b501-48ed-9f30-ca148cde4fbc", "user14@example.com", false, "ผดุงเกียรติ", "สุตาโย", false, null, "บอย", "USER14@EXAMPLE.COM", "USER14@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDSaNEFn1eMYtroX6kzWWQSplvbsiYbWtISjOeqLtsUIbsoP03QMuoIWT1CQHdiGbA==", null, false, 7, "1", "90dc2e00-439e-4455-9601-422ee50e231d", "6404101325", false, "user14@example.com" },
                    { "f7b5fd19-b494-485d-89ca-4331403ab1f7", 0, "3668ecbd-3d3d-46b4-a879-9af1edcaff39", "user3@example.com", false, "นิมมิตา", "สมริน", false, null, "มิ้น", "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIRnoMEh+gOjnvJlrf5aBybsqZLLD9qkheydj3pMKVLMaiTmK1CdYRqf35yi4qNEsQ==", null, false, 2, "1", "fedd1d7c-0f11-461c-9ed4-3fa53325369f", "6404101324", false, "user3@example.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Stages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
