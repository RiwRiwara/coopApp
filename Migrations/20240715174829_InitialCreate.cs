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
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                columns: new[] { "Id", "Deadline", "Description", "FileName", "FilePath", "ProjectId", "StageId", "StageName", "StageNumber", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6004), null, null, null, 1, 4, null, 4, null },
                    { 2, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6124), null, null, "File2.pdf", 1, 5, "Stage 2 for Project 1", 5, "Not Started" },
                    { 3, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6139), null, null, "File3.pdf", 1, 6, "Stage 3 for Project 1", 6, "Not Started" },
                    { 4, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6145), null, null, null, 1, 7, null, 7, null },
                    { 5, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6153), null, null, "File5.pdf", 1, 8, "Stage 5 for Project 1", 8, "Not Started" },
                    { 6, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6165), null, null, "File6.pdf", 1, 9, "Stage 6 for Project 1", 9, "Not Started" },
                    { 7, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6174), null, null, null, 1, 10, null, 10, null },
                    { 8, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6176), null, null, null, 1, 11, null, 11, null },
                    { 9, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6178), null, null, null, 1, 12, null, 12, null },
                    { 10, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6182), null, null, null, 1, 13, null, 13, null },
                    { 11, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6185), null, null, null, 2, 4, null, 4, null },
                    { 12, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6192), null, null, "File2.pdf", 2, 5, "Stage 2 for Project 2", 5, "Not Started" },
                    { 13, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6202), null, null, "File3.pdf", 2, 6, "Stage 3 for Project 2", 6, "Not Started" },
                    { 14, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6208), null, null, null, 2, 7, null, 7, null },
                    { 15, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6215), null, null, "File5.pdf", 2, 8, "Stage 5 for Project 2", 8, "Not Started" },
                    { 16, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6238), null, null, "File6.pdf", 2, 9, "Stage 6 for Project 2", 9, "Not Started" },
                    { 17, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6245), null, null, null, 2, 10, null, 10, null },
                    { 18, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6249), null, null, null, 2, 11, null, 11, null },
                    { 19, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6252), null, null, null, 2, 12, null, 12, null },
                    { 20, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6254), null, null, null, 2, 13, null, 13, null },
                    { 21, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6257), null, null, null, 3, 4, null, 4, null },
                    { 22, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6264), null, null, "File2.pdf", 3, 5, "Stage 2 for Project 3", 5, "Not Started" },
                    { 23, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6274), null, null, "File3.pdf", 3, 6, "Stage 3 for Project 3", 6, "Not Started" },
                    { 24, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6308), null, null, null, 3, 7, null, 7, null },
                    { 25, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6317), null, null, "File5.pdf", 3, 8, "Stage 5 for Project 3", 8, "Not Started" },
                    { 26, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6328), null, null, "File6.pdf", 3, 9, "Stage 6 for Project 3", 9, "Not Started" },
                    { 27, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6335), null, null, null, 3, 10, null, 10, null },
                    { 28, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6338), null, null, null, 3, 11, null, 11, null },
                    { 29, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6340), null, null, null, 3, 12, null, 12, null },
                    { 30, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6351), null, null, null, 3, 13, null, 13, null },
                    { 31, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6377), null, null, null, 4, 4, null, 4, null },
                    { 32, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6386), null, null, "File2.pdf", 4, 5, "Stage 2 for Project 4", 5, "Not Started" },
                    { 33, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6397), null, null, "File3.pdf", 4, 6, "Stage 3 for Project 4", 6, "Not Started" },
                    { 34, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6405), null, null, null, 4, 7, null, 7, null },
                    { 35, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6412), null, null, "File5.pdf", 4, 8, "Stage 5 for Project 4", 8, "Not Started" },
                    { 36, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6510), null, null, "File6.pdf", 4, 9, "Stage 6 for Project 4", 9, "Not Started" },
                    { 37, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6517), null, null, null, 4, 10, null, 10, null },
                    { 38, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6519), null, null, null, 4, 11, null, 11, null },
                    { 39, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6521), null, null, null, 4, 12, null, 12, null },
                    { 40, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6524), null, null, null, 4, 13, null, 13, null },
                    { 41, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6526), null, null, null, 5, 4, null, 4, null },
                    { 42, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6534), null, null, "File2.pdf", 5, 5, "Stage 2 for Project 5", 5, "Not Started" },
                    { 43, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6545), null, null, "File3.pdf", 5, 6, "Stage 3 for Project 5", 6, "Not Started" },
                    { 44, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6551), null, null, null, 5, 7, null, 7, null },
                    { 45, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6558), null, null, "File5.pdf", 5, 8, "Stage 5 for Project 5", 8, "Not Started" },
                    { 46, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6569), null, null, "File6.pdf", 5, 9, "Stage 6 for Project 5", 9, "Not Started" },
                    { 47, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6576), null, null, null, 5, 10, null, 10, null },
                    { 48, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6578), null, null, null, 5, 11, null, 11, null },
                    { 49, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6580), null, null, null, 5, 12, null, 12, null },
                    { 50, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6582), null, null, null, 5, 13, null, 13, null },
                    { 51, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6585), null, null, null, 6, 4, null, 4, null },
                    { 52, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6593), null, null, "File2.pdf", 6, 5, "Stage 2 for Project 6", 5, "Not Started" },
                    { 53, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6604), null, null, "File3.pdf", 6, 6, "Stage 3 for Project 6", 6, "Not Started" },
                    { 54, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6610), null, null, null, 6, 7, null, 7, null },
                    { 55, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6617), null, null, "File5.pdf", 6, 8, "Stage 5 for Project 6", 8, "Not Started" },
                    { 56, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6628), null, null, "File6.pdf", 6, 9, "Stage 6 for Project 6", 9, "Not Started" },
                    { 57, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6634), null, null, null, 6, 10, null, 10, null },
                    { 58, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6637), null, null, null, 6, 11, null, 11, null },
                    { 59, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6639), null, null, null, 6, 12, null, 12, null },
                    { 60, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6641), null, null, null, 6, 13, null, 13, null },
                    { 61, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6644), null, null, null, 7, 4, null, 4, null },
                    { 62, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6651), null, null, "File2.pdf", 7, 5, "Stage 2 for Project 7", 5, "Not Started" },
                    { 63, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6662), null, null, "File3.pdf", 7, 6, "Stage 3 for Project 7", 6, "Not Started" },
                    { 64, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6668), null, null, null, 7, 7, null, 7, null },
                    { 65, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6676), null, null, "File5.pdf", 7, 8, "Stage 5 for Project 7", 8, "Not Started" },
                    { 66, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6688), null, null, "File6.pdf", 7, 9, "Stage 6 for Project 7", 9, "Not Started" },
                    { 67, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6695), null, null, null, 7, 10, null, 10, null },
                    { 68, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6697), null, null, null, 7, 11, null, 11, null },
                    { 69, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6699), null, null, null, 7, 12, null, 12, null },
                    { 70, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6701), null, null, null, 7, 13, null, 13, null },
                    { 71, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6704), null, null, null, 8, 4, null, 4, null },
                    { 72, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6711), null, null, "File2.pdf", 8, 5, "Stage 2 for Project 8", 5, "Not Started" },
                    { 73, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6722), null, null, "File3.pdf", 8, 6, "Stage 3 for Project 8", 6, "Not Started" },
                    { 74, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6728), null, null, null, 8, 7, null, 7, null },
                    { 75, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6735), null, null, "File5.pdf", 8, 8, "Stage 5 for Project 8", 8, "Not Started" },
                    { 76, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6746), null, null, "File6.pdf", 8, 9, "Stage 6 for Project 8", 9, "Not Started" },
                    { 77, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6752), null, null, null, 8, 10, null, 10, null },
                    { 78, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6754), null, null, null, 8, 11, null, 11, null },
                    { 79, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6757), null, null, null, 8, 12, null, 12, null },
                    { 80, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6935), null, null, null, 8, 13, null, 13, null },
                    { 81, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6939), null, null, null, 9, 4, null, 4, null },
                    { 82, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6948), null, null, "File2.pdf", 9, 5, "Stage 2 for Project 9", 5, "Not Started" },
                    { 83, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6960), null, null, "File3.pdf", 9, 6, "Stage 3 for Project 9", 6, "Not Started" },
                    { 84, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6966), null, null, null, 9, 7, null, 7, null },
                    { 85, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6974), null, null, "File5.pdf", 9, 8, "Stage 5 for Project 9", 8, "Not Started" },
                    { 86, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6985), null, null, "File6.pdf", 9, 9, "Stage 6 for Project 9", 9, "Not Started" },
                    { 87, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6992), null, null, null, 9, 10, null, 10, null },
                    { 88, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6994), null, null, null, 9, 11, null, 11, null },
                    { 89, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6997), null, null, null, 9, 12, null, 12, null },
                    { 90, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(6999), null, null, null, 9, 13, null, 13, null },
                    { 91, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7002), null, null, null, 10, 4, null, 4, null },
                    { 92, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7012), null, null, "File2.pdf", 10, 5, "Stage 2 for Project 10", 5, "Not Started" },
                    { 93, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7023), null, null, "File3.pdf", 10, 6, "Stage 3 for Project 10", 6, "Not Started" },
                    { 94, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7029), null, null, null, 10, 7, null, 7, null },
                    { 95, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7037), null, null, "File5.pdf", 10, 8, "Stage 5 for Project 10", 8, "Not Started" },
                    { 96, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7047), null, null, "File6.pdf", 10, 9, "Stage 6 for Project 10", 9, "Not Started" },
                    { 97, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7054), null, null, null, 10, 10, null, 10, null },
                    { 98, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7056), null, null, null, 10, 11, null, 11, null },
                    { 99, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7059), null, null, null, 10, 12, null, 12, null },
                    { 100, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7061), null, null, null, 10, 13, null, 13, null },
                    { 101, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7064), null, null, null, 11, 4, null, 4, null },
                    { 102, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7071), null, null, "File2.pdf", 11, 5, "Stage 2 for Project 11", 5, "Not Started" },
                    { 103, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7082), null, null, "File3.pdf", 11, 6, "Stage 3 for Project 11", 6, "Not Started" },
                    { 104, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7088), null, null, null, 11, 7, null, 7, null },
                    { 105, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7096), null, null, "File5.pdf", 11, 8, "Stage 5 for Project 11", 8, "Not Started" },
                    { 106, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7107), null, null, "File6.pdf", 11, 9, "Stage 6 for Project 11", 9, "Not Started" },
                    { 107, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7114), null, null, null, 11, 10, null, 10, null },
                    { 108, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7117), null, null, null, 11, 11, null, 11, null },
                    { 109, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7119), null, null, null, 11, 12, null, 12, null },
                    { 110, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7121), null, null, null, 11, 13, null, 13, null },
                    { 111, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7124), null, null, null, 12, 4, null, 4, null },
                    { 112, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7131), null, null, "File2.pdf", 12, 5, "Stage 2 for Project 12", 5, "Not Started" },
                    { 113, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7142), null, null, "File3.pdf", 12, 6, "Stage 3 for Project 12", 6, "Not Started" },
                    { 114, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7148), null, null, null, 12, 7, null, 7, null },
                    { 115, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7155), null, null, "File5.pdf", 12, 8, "Stage 5 for Project 12", 8, "Not Started" },
                    { 116, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7165), null, null, "File6.pdf", 12, 9, "Stage 6 for Project 12", 9, "Not Started" },
                    { 117, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7171), null, null, null, 12, 10, null, 10, null },
                    { 118, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7174), null, null, null, 12, 11, null, 11, null },
                    { 119, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7176), null, null, null, 12, 12, null, 12, null },
                    { 120, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7178), null, null, null, 12, 13, null, 13, null },
                    { 121, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7180), null, null, null, 13, 4, null, 4, null },
                    { 122, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7187), null, null, "File2.pdf", 13, 5, "Stage 2 for Project 13", 5, "Not Started" },
                    { 123, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7198), null, null, "File3.pdf", 13, 6, "Stage 3 for Project 13", 6, "Not Started" },
                    { 124, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7204), null, null, null, 13, 7, null, 7, null },
                    { 125, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7212), null, null, "File5.pdf", 13, 8, "Stage 5 for Project 13", 8, "Not Started" },
                    { 126, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7223), null, null, "File6.pdf", 13, 9, "Stage 6 for Project 13", 9, "Not Started" },
                    { 127, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7230), null, null, null, 13, 10, null, 10, null },
                    { 128, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7232), null, null, null, 13, 11, null, 11, null },
                    { 129, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7235), null, null, null, 13, 12, null, 12, null },
                    { 130, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7337), null, null, null, 13, 13, null, 13, null },
                    { 131, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7340), null, null, null, 14, 4, null, 4, null },
                    { 132, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7349), null, null, "File2.pdf", 14, 5, "Stage 2 for Project 14", 5, "Not Started" },
                    { 133, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7359), null, null, "File3.pdf", 14, 6, "Stage 3 for Project 14", 6, "Not Started" },
                    { 134, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7365), null, null, null, 14, 7, null, 7, null },
                    { 135, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7372), null, null, "File5.pdf", 14, 8, "Stage 5 for Project 14", 8, "Not Started" },
                    { 136, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7384), null, null, "File6.pdf", 14, 9, "Stage 6 for Project 14", 9, "Not Started" },
                    { 137, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7391), null, null, null, 14, 10, null, 10, null },
                    { 138, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7393), null, null, null, 14, 11, null, 11, null },
                    { 139, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7395), null, null, null, 14, 12, null, 12, null },
                    { 140, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7397), null, null, null, 14, 13, null, 13, null },
                    { 141, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7400), null, null, null, 15, 4, null, 4, null },
                    { 142, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7407), null, null, "File2.pdf", 15, 5, "Stage 2 for Project 15", 5, "Not Started" },
                    { 143, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7418), null, null, "File3.pdf", 15, 6, "Stage 3 for Project 15", 6, "Not Started" },
                    { 144, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7424), null, null, null, 15, 7, null, 7, null },
                    { 145, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7432), null, null, "File5.pdf", 15, 8, "Stage 5 for Project 15", 8, "Not Started" },
                    { 146, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7443), null, null, "File6.pdf", 15, 9, "Stage 6 for Project 15", 9, "Not Started" },
                    { 147, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7451), null, null, null, 15, 10, null, 10, null },
                    { 148, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7454), null, null, null, 15, 11, null, 11, null },
                    { 149, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7456), null, null, null, 15, 12, null, 12, null },
                    { 150, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7458), null, null, null, 15, 13, null, 13, null },
                    { 151, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7461), null, null, null, 16, 4, null, 4, null },
                    { 152, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7469), null, null, "File2.pdf", 16, 5, "Stage 2 for Project 16", 5, "Not Started" },
                    { 153, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7480), null, null, "File3.pdf", 16, 6, "Stage 3 for Project 16", 6, "Not Started" },
                    { 154, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7486), null, null, null, 16, 7, null, 7, null },
                    { 155, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7493), null, null, "File5.pdf", 16, 8, "Stage 5 for Project 16", 8, "Not Started" },
                    { 156, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7504), null, null, "File6.pdf", 16, 9, "Stage 6 for Project 16", 9, "Not Started" },
                    { 157, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7511), null, null, null, 16, 10, null, 10, null },
                    { 158, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7514), null, null, null, 16, 11, null, 11, null },
                    { 159, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7516), null, null, null, 16, 12, null, 12, null },
                    { 160, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7519), null, null, null, 16, 13, null, 13, null },
                    { 161, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7521), null, null, null, 17, 4, null, 4, null },
                    { 162, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7530), null, null, "File2.pdf", 17, 5, "Stage 2 for Project 17", 5, "Not Started" },
                    { 163, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7541), null, null, "File3.pdf", 17, 6, "Stage 3 for Project 17", 6, "Not Started" },
                    { 164, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7547), null, null, null, 17, 7, null, 7, null },
                    { 165, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7555), null, null, "File5.pdf", 17, 8, "Stage 5 for Project 17", 8, "Not Started" },
                    { 166, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7566), null, null, "File6.pdf", 17, 9, "Stage 6 for Project 17", 9, "Not Started" },
                    { 167, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7573), null, null, null, 17, 10, null, 10, null },
                    { 168, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7638), null, null, null, 17, 11, null, 11, null },
                    { 169, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7641), null, null, null, 17, 12, null, 12, null },
                    { 170, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7643), null, null, null, 17, 13, null, 13, null },
                    { 171, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7646), null, null, null, 18, 4, null, 4, null },
                    { 172, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7654), null, null, "File2.pdf", 18, 5, "Stage 2 for Project 18", 5, "Not Started" },
                    { 173, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7666), null, null, "File3.pdf", 18, 6, "Stage 3 for Project 18", 6, "Not Started" },
                    { 174, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7672), null, null, null, 18, 7, null, 7, null },
                    { 175, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7680), null, null, "File5.pdf", 18, 8, "Stage 5 for Project 18", 8, "Not Started" },
                    { 176, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7692), null, null, "File6.pdf", 18, 9, "Stage 6 for Project 18", 9, "Not Started" },
                    { 177, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7699), null, null, null, 18, 10, null, 10, null },
                    { 178, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7701), null, null, null, 18, 11, null, 11, null },
                    { 179, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7703), null, null, null, 18, 12, null, 12, null },
                    { 180, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7706), null, null, null, 18, 13, null, 13, null },
                    { 181, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7708), null, null, null, 19, 4, null, 4, null },
                    { 182, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7716), null, null, "File2.pdf", 19, 5, "Stage 2 for Project 19", 5, "Not Started" },
                    { 183, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7728), null, null, "File3.pdf", 19, 6, "Stage 3 for Project 19", 6, "Not Started" },
                    { 184, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7734), null, null, null, 19, 7, null, 7, null },
                    { 185, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7742), null, null, "File5.pdf", 19, 8, "Stage 5 for Project 19", 8, "Not Started" },
                    { 186, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7753), null, null, "File6.pdf", 19, 9, "Stage 6 for Project 19", 9, "Not Started" },
                    { 187, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7761), null, null, null, 19, 10, null, 10, null },
                    { 188, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7763), null, null, null, 19, 11, null, 11, null },
                    { 189, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7766), null, null, null, 19, 12, null, 12, null },
                    { 190, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7768), null, null, null, 19, 13, null, 13, null },
                    { 191, new DateTime(2024, 8, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7771), null, null, null, 20, 4, null, 4, null },
                    { 192, new DateTime(2024, 9, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7778), null, null, "File2.pdf", 20, 5, "Stage 2 for Project 20", 5, "Not Started" },
                    { 193, new DateTime(2024, 10, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7789), null, null, "File3.pdf", 20, 6, "Stage 3 for Project 20", 6, "Not Started" },
                    { 194, new DateTime(2024, 11, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7795), null, null, null, 20, 7, null, 7, null },
                    { 195, new DateTime(2024, 12, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7802), null, null, "File5.pdf", 20, 8, "Stage 5 for Project 20", 8, "Not Started" },
                    { 196, new DateTime(2025, 1, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7813), null, null, "File6.pdf", 20, 9, "Stage 6 for Project 20", 9, "Not Started" },
                    { 197, new DateTime(2025, 2, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7820), null, null, null, 20, 10, null, 10, null },
                    { 198, new DateTime(2025, 3, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7823), null, null, null, 20, 11, null, 11, null },
                    { 199, new DateTime(2025, 4, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7825), null, null, null, 20, 12, null, 12, null },
                    { 200, new DateTime(2025, 5, 16, 0, 48, 29, 96, DateTimeKind.Local).AddTicks(7828), null, null, null, 20, 13, null, 13, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProjectId", "RoleId", "SecurityStamp", "StudentID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00176a9e-6e8d-4e1d-9522-155de0650066", 0, "dc16fdd7-4c78-4575-85df-4b6bc4ea72b2", "user33@example.com", false, "ศิริชัย", "เกษมสุข", false, null, "โอม", "USER33@EXAMPLE.COM", "USER33@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMXxGa3BJM7M+ESYMmVDhn9YYIPIYNVW+ua4JafVioX5YwtMGi4N1HEYUDQ3UL03Kg==", null, false, 19, "1", "aa2c1ac3-be54-452e-87ae-dec6798a5d8f", "6404101372", false, "user33@example.com" },
                    { "0af619df-5e22-4d9a-bfbf-e8b4a8efb30d", 0, "725be9cf-a905-42e2-8daa-bc45fe8fd4ec", "staff@example.com", false, "Jane", "Doe", false, null, "Janie", "STAFF@EXAMPLE.COM", "STAFF@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEBx8llxRp9NKMhx/60V7aPfwOvijlZ5CRDXKVDSyobXIz7LjS0rDYG81PwSp68RJg==", null, false, 0, "2", "7accae66-75bc-4bc6-8c3b-73aa1a69fd47", null, false, "staff@example.com" },
                    { "0e6ca9e3-78f8-41bf-8a6a-f9ba57abc1e0", 0, "94e8e148-3a59-4b16-b15e-1886335f6d9c", "user31@example.com", false, "รุ่งเจริญ", "โพธิ์ศรี", false, null, "เพชร", "USER31@EXAMPLE.COM", "USER31@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP1GqDTr0yvlkLjEnFCMxF9T/Kljydsis3HLLhzgTxbQgb0ASQLUgBur6z4ibtabPQ==", null, false, 18, "1", "d01e4cb2-9800-4ff6-8e34-f9905340577e", "6404101335", false, "user31@example.com" },
                    { "1994384b-393f-4396-927c-c43ff61d1945", 0, "e8b78ce6-bc60-45b6-8b4c-5bae4a90e9ce", "user7@example.com", false, "ฐิติพงษ์", "เรือนสุภา", false, null, "", "USER7@EXAMPLE.COM", "USER7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO3TI2ijC3nKFf7u6SX9Af5rePpwRLmimTzoQLOoWt+qYpnQUIb/CCJwu0Z20FpxXg==", null, false, 4, "1", "74af15ae-eecb-409a-bc43-6dd72b566c46", "6404101311", false, "user7@example.com" },
                    { "21eb7c39-4498-40e0-94da-3a5242729065", 0, "5dcc8cfd-9d7b-4db5-aad0-2477245ee3ba", "user4@example.com", false, "อัจฉริยะณัฐ", "ปะฏิเต", false, null, "ต้อง", "USER4@EXAMPLE.COM", "USER4@EXAMPLE.COM", "AQAAAAIAAYagAAAAELKK8Gi8rV76nFfwxR2tqIp4PsqVKOXTgbRqHirg9ufGQtJFdRBufheqWHGUFdFiqw==", null, false, 2, "1", "ee2ce5b3-86d6-4c3a-a549-b569408e63b0", "6404101378", false, "user4@example.com" },
                    { "2c26c85d-1d1b-49fc-a34c-aebdbb3f0783", 0, "f7d23270-c87d-4221-bf01-a930cbf1ea48", "user28@example.com", false, "สุนิสา", "ผาด่าน", false, null, "ชิ", "USER28@EXAMPLE.COM", "USER28@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHt9jwzEwfzIIUoQfV6GEUwatLqg472nzl7aXBav6W1VEusdnTln5N1FWTXQIgP2+Q==", null, false, 15, "1", "71492bf9-904a-42cf-a7ce-4825cfcd0a7b", "6404101349", false, "user28@example.com" },
                    { "2c566bdc-a561-40da-93e8-89e92586a907", 0, "2ca07c80-80f9-457a-ae73-3d848d6079c1", "user20@example.com", false, "วชรพล", "ไชยวรรณ", false, null, "เติ้ง", "USER20@EXAMPLE.COM", "USER20@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJNvWcXzbEawx7TCBSoBzx9Z2+TyxpH0zUjDoFQHVmez4YbGWQXowJAlVFcz8txL4Q==", null, false, 11, "1", "381b0253-862d-4054-b3db-ce5a78f9c828", "6404101338", false, "user20@example.com" },
                    { "3362f7c8-3470-44ae-96b5-e3bd8688df92", 0, "277487a8-fc7c-4d7a-afe7-8de82e59cf4e", "user18@example.com", false, "อภิวัฒน์", "ไชยา", false, null, "ฟิว", "USER18@EXAMPLE.COM", "USER18@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPzAcszGrMgdblbGtsOKqukTDiBR8nhNXbMlXjaKfKdc8B9uOW8vh/qeY0gqyrGjEA==", null, false, 9, "1", "dad62183-0049-4e1f-a36a-c807b1b4349b", "6404101377", false, "user18@example.com" },
                    { "34727629-6f9a-467a-a602-6c677f86a575", 0, "9ecc532b-87ba-4283-a386-85076572771b", "user11@example.com", false, "ณภัทร", "บัวบาน", false, null, "หนึ่ง", "USER11@EXAMPLE.COM", "USER11@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJZ4Soxpjuvvb/tnXnQTrfGTdjYNJreAaGcpUVaOQ4U9tYscNG0bFw8VjKjYa4+fBQ==", null, false, 5, "1", "a1264e56-62ca-46ea-a2a5-358d33f5e97b", "6404101359", false, "user11@example.com" },
                    { "3abff280-1865-4759-bab0-957b6b8abc70", 0, "dddf9902-c5a5-46f2-a24b-812996863a6a", "user1@example.com", false, "ฐิติกร", "เรือนมนต์", false, null, "ไนท์", "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFJDJlwK4gvQ1NP7lqfCh9HKg+6d5yPmzS5AyMjFRis4K5PIFHamCTf7aumew+nunQ==", null, false, 1, "1", "35cfb484-d8c5-4f3e-b64a-1c8a0b1f0dcf", "6304101389", false, "user1@example.com" },
                    { "3aebd114-3c5e-4e72-bf41-45eb1e864692", 0, "70478351-8778-40cf-9a35-4f35e426bfbd", "user14@example.com", false, "ผดุงเกียรติ", "สุตาโย", false, null, "บอย", "USER14@EXAMPLE.COM", "USER14@EXAMPLE.COM", "AQAAAAIAAYagAAAAELuMza1ap4PNr/eWhliOHA6XWIHOoQsOl+wo9P5Nb++wO+jY2eIOCCHPH3BYORCDjQ==", null, false, 7, "1", "156f3ce5-294c-467b-830f-0dd75bdf158d", "6404101325", false, "user14@example.com" },
                    { "3bfa4bb3-8df5-4db6-9574-73be8fc9c7e0", 0, "7d933d25-62d5-432b-9efd-0d7c800b2001", "user25@example.com", false, "สุจิตรา", "ปานการะเกตุ", false, null, "โม", "USER25@EXAMPLE.COM", "USER25@EXAMPLE.COM", "AQAAAAIAAYagAAAAECrQ8OVD34+fnVg5W8UTGzmuTo3SI+QKVGgQtdKWMsQ0qYUsFyLgdm2tn8Bb+cyaNw==", null, false, 14, "1", "1821683c-1b0a-481d-9b59-96438dd51a7f", "6404101347", false, "user25@example.com" },
                    { "49a004d9-3d06-4cac-bfb8-74477e3a8cee", 0, "3006bef1-d724-400f-8ff9-c10be3dea2df", "teacher@example.com", false, "Jim", "Beam", false, null, "Jimmy", "TEACHER@EXAMPLE.COM", "TEACHER@EXAMPLE.COM", "AQAAAAIAAYagAAAAECCYaMCCtpqw3XJosurFjl/kp8+gSBULyCeyOw68qeQJrCdWE7J79bfEdMNPDgdE4g==", null, false, 0, "3", "61e9f63b-4980-49b9-b023-328c68fa6ba5", null, false, "teacher@example.com" },
                    { "4a6b7946-00a0-4ce4-874e-877ef6491394", 0, "d4e6aa5d-8cc3-48ff-8de0-d5396eca66b2", "user6@example.com", false, "เมธาวัฒน์", "มหาวัน", false, null, "ตะวัน", "USER6@EXAMPLE.COM", "USER6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBQHThEkSyLn9pTpccnAnxxh0ncauTZAKqK4Ub1revSxLnwjh+t95+pli4m7iFwrVA==", null, false, 3, "1", "d036ec61-f6b7-4ba3-beac-ea09d71289aa", "6404101332", false, "user6@example.com" },
                    { "4f4d4b04-0409-4e54-bb54-bdce539916ba", 0, "ef3dfc42-3204-45e7-9991-d7baddc98a86", "user29@example.com", false, "กณิศนันท์", "ทองสกุล", false, null, "แยม", "USER29@EXAMPLE.COM", "USER29@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDvKxVkwONU4xNcLwxKV6D3StfY+mRUdl9yTQslydR6npbWwLf3hkXpzo0Mi4xANBw==", null, false, 16, "1", "d3b93817-59f9-4295-8c83-a60f3ba1a5d9", "6404101354", false, "user29@example.com" },
                    { "51aac5c6-75f5-4615-9e18-c737d8716810", 0, "68e6ce25-b249-46dc-bb60-1a47e243b4ff", "user34@example.com", false, "กุณช์ศุภณัฐ", "ศรีตาบุตรวรัตถ์", false, null, "ยู", "USER34@EXAMPLE.COM", "USER34@EXAMPLE.COM", "AQAAAAIAAYagAAAAECtlt/hsttIg20bBBBrRIRKXB3WYYJpg71qGBrPowXK++vO+3yKa8QzQLcupZdMysg==", null, false, 20, "1", "3ab5b701-d39d-4332-b7c1-60e803f0c167", "6404101356", false, "user34@example.com" },
                    { "5a1e2d11-2aa1-42e4-ae0c-a683905a862b", 0, "4d85ba5b-dc31-4bd9-a179-7de6ccd3a83f", "user3@example.com", false, "นิมมิตา", "สมริน", false, null, "มิ้น", "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIGwNe27JGSXIKn25xLDELtzN/9UVWkA2NPHdwgnKSqjcmNZ/cJwlsOIjgDlxIvCkA==", null, false, 2, "1", "21f39957-8743-407c-b136-10aeaf2b08b4", "6404101324", false, "user3@example.com" },
                    { "5c1ab99f-69f6-4009-a20b-8c5f82a39b3d", 0, "e56d55ac-3c2f-45e6-809a-363fcd97ffae", "user16@example.com", false, "ภราดร", "ศรีทา", false, null, "บอล", "USER16@EXAMPLE.COM", "USER16@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKYUpOOeQ4m5nB5ysWBrLXznBRtgaW6/xcoJLTbjIvGIyW+x8BecI9vOy+7B3qLoCA==", null, false, 8, "1", "80dc8a70-a855-4986-ba30-8814f8cb92ec", "6404101330", false, "user16@example.com" },
                    { "68d32276-8685-471b-8e97-9dc21f16ea56", 0, "e602cd96-2e80-40ad-bb7f-1a9488263d7a", "user12@example.com", false, "มณฑารบ", "ชาวโพงพาง", false, null, "มัดหมี่", "USER12@EXAMPLE.COM", "USER12@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHPGK6hXKfRBM+cSbkV3FI2jqPelDMk5xOeEV1RAVQF50qgw7DSrWVku4fWUuaZgFQ==", null, false, 6, "1", "27ee59de-60b3-472d-8860-44a22a7a34c2", "6404101369", false, "user12@example.com" },
                    { "8c3cae53-fe64-4013-9d2c-a5e88d33b5cb", 0, "4087936a-60ea-4516-a921-f503aff74ce1", "user10@example.com", false, "ไตรภาค", "สิทธิแก้ว", false, null, "ภาค", "USER10@EXAMPLE.COM", "USER10@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEOMo/hWJqX4BnP3TE9MwpP2R4IsxsImTrmQaduD6tj6cib8Gs6RHWVoOlN6UQcnjg==", null, false, 5, "1", "ed124fb9-aa5d-4096-bc66-ab11c6af910c", "6404101318", false, "user10@example.com" },
                    { "90ad0a0b-a55d-483f-b54c-2e929249b1e9", 0, "570a9d66-369e-40ba-90ef-5a3cd6fecd73", "user24@example.com", false, "รัฐติกรณ์", "จินะกาศ", false, null, "โอม", "USER24@EXAMPLE.COM", "USER24@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFcXMeWkA/nUoFVICHfxGlfNKesTE4vO9vv1xONLtWxYfQYsxZAmQ/tRfFyDUkBGyQ==", null, false, 13, "1", "297edc76-b266-449f-99b9-3295aa248620", "6404101334", false, "user24@example.com" },
                    { "9ab835e7-8494-42a7-8c1c-86b2299b76b4", 0, "61eaada7-511a-4b98-8262-20d77bff8158", "user32@example.com", false, "พงศกร", "คูณเสนา", false, null, "เพชร", "USER32@EXAMPLE.COM", "USER32@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH7uFXW8CSaNgLONzZLlEsAl1UCZx9nMQq1QFXPllPSERVnHBGwTnGlRycXOhvDMMQ==", null, false, 18, "1", "6cba7beb-8e18-43c9-ab48-f0f6bfd257ff", "6404101365", false, "user32@example.com" },
                    { "9bc9ccd7-b067-4ab6-9ffd-1f9de8d11388", 0, "d0979ca7-ae11-46d2-b6d3-7bcac8d93c42", "user9@example.com", false, "ตะวัน", "สุรินา", false, null, "เจแปน", "USER9@EXAMPLE.COM", "USER9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBawiZQb2eEqqNyQ84v/SSeaogmdZixcldfvmUHrLaxjUkdpvz5QC0+0oJNhzCwOGg==", null, false, 5, "1", "41324e61-08ef-488c-a617-510afd6383c9", "6404101316", false, "user9@example.com" },
                    { "b5b390ae-7f08-4f47-abe4-399e37299b64", 0, "cfd0c51e-ccb9-45c0-b3bf-631fdd052caf", "user22@example.com", false, "ศุภณัฐ", "วิบูลย์พานิช", false, null, "ออม", "USER22@EXAMPLE.COM", "USER22@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOngAuLGaV5AbHeHzAY/Pg3AMpTA3gpoKvJEwUMXMijoGwnqHjJp0KiKqfKi7dqskg==", null, false, 12, "1", "ac062725-7d55-47c8-92ac-122a948bd698", "6404101344", false, "user22@example.com" },
                    { "b618790f-21f1-4f98-9dfa-d9e2ff1db0f6", 0, "0af26313-2fd1-4599-8060-c59e0ddba4aa", "user23@example.com", false, "เศรษฐพงศ์", "อินทร์แสง", false, null, "แบงค์", "USER23@EXAMPLE.COM", "USER23@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJcrPxNNGAKnQoIre0yWAQv/Zk/k4DYKSu9XkkdBRmgWdfuP87Go4DQoTgkcmLNGVQ==", null, false, 13, "1", "6956a44e-7602-4924-b98f-8d5f9cec5a2e", "6404101345", false, "user23@example.com" },
                    { "b801c7c3-0622-47a3-a6a5-1d20f226450f", 0, "aa70df30-49bb-49d8-8176-b994c8721d80", "user26@example.com", false, "สุธิชานนท์", "พูลการขาย", false, null, "เม่น", "USER26@EXAMPLE.COM", "USER26@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKzmrXiCXrgNtBWtbkSdy0uHDhQL33HI/c5+JhuqK+i49FyDTzVeGMNRcKiKiD2mqQ==", null, false, 14, "1", "e1c0413d-d6ff-4ebb-aaee-73507cc780c9", "6404101348", false, "user26@example.com" },
                    { "c9ce84a1-49a8-4366-af07-c59a351140e4", 0, "d3b4fe29-d4bc-4ede-a2e9-c906861cfafe", "user15@example.com", false, "พิมลพรรณ", "เงินทอง", false, null, "โฟร์ท", "USER15@EXAMPLE.COM", "USER15@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHRCmU9h2GoNNC257i76uJU0NXLDHc6XnQXX2cGoYBxUoqVGNJuhsX4EdaEG0JiA+w==", null, false, 8, "1", "93c83155-ae24-4e1c-ba9b-a589ecacf900", "6404101327", false, "user15@example.com" },
                    { "ca23fc27-38de-48c7-b56f-ee23512a5067", 0, "0bc05e12-9da6-41c4-a5d2-618f90fd6556", "user2@example.com", false, "กัญญาพัชร", "ยศสนิท", false, null, "ไอซ์", "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAENUF02a0kWOA9oTpqSCgVhFj7NK8XFIgsMqiSxUjrvIuBgH+yGks6uEjtvDtE3lUrw==", null, false, 2, "1", "d09f5636-98b9-43ca-b501-0a8badbf964b", "6404101303", false, "user2@example.com" },
                    { "d0e334e3-35b6-435a-9123-5588ff88c9cd", 0, "84bdb2c0-0c88-46a2-86cb-00f369cb45d6", "user17@example.com", false, "อดิศร", "วงศ์คำ", false, null, "แนท", "USER17@EXAMPLE.COM", "USER17@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP427Mj0M1qZuFZQaNDkVVCsEDRZe0jbiLSsfOhCsZeBs1cyzhCleFM57R5ciyXJMg==", null, false, 9, "1", "93cfe67a-ebb8-44d3-884c-8475692cba0f", "6404101350", false, "user17@example.com" },
                    { "d90755a8-e05e-4f3c-9d0b-61047af75612", 0, "467372ce-92d5-4a13-96a3-2dd87ebc83d2", "user21@example.com", false, "ศรายุทธ", "เสนอาสา", false, null, "คิม", "USER21@EXAMPLE.COM", "USER21@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKrqj+1scx8o7YXKOkYIt7ixPEQEtSbiXdhZ225peWceU0s0mps+C3o6f+vY4oEyVw==", null, false, 12, "1", "fec1a9ef-248f-4f59-aaea-61ab820754ec", "6404101341", false, "user21@example.com" },
                    { "e6f0959b-7fb2-4793-8695-6acffd9a44a1", 0, "b54d7c53-cf4c-47af-8957-ca0a567996ba", "user13@example.com", false, "ไอลดา", "แสงภิรมย์", false, null, "เฟริ์น", "USER13@EXAMPLE.COM", "USER13@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDSVPIRN8zrSimJu3dvUdszQsd/pKq5szmn/Fzq4HvclAnri9/pTqz1ebuyGvMhr9g==", null, false, 6, "1", "6f2d7a11-96e3-4f3a-8ccc-37abc68740c9", "6404101379", false, "user13@example.com" },
                    { "ed0d41c1-b071-48fd-bca2-330c29a8d7b0", 0, "2e75e105-b795-492a-b330-7f7e2681f1aa", "user8@example.com", false, "ณรงค์เกียรติ", "นามห้วยทอง", false, null, "ก๊อต", "USER8@EXAMPLE.COM", "USER8@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMfmGd/I6rSa4zNZ46XSdWWJA63EmZpz9ojtjaVa9y88wv/K3R3rbmm2rkDaAwLUxg==", null, false, 5, "1", "3b6e855a-71b9-4820-b7bb-48400d9fe702", "6404101312", false, "user8@example.com" },
                    { "ed64316e-f380-49ff-a82c-219d25662d5d", 0, "21a04227-84a2-4a80-bf90-f653d7d232a5", "user30@example.com", false, "ชนันฌ์ณภัสฐ์", "สิงห์คาล", false, null, "สาหร่าย", "USER30@EXAMPLE.COM", "USER30@EXAMPLE.COM", "AQAAAAIAAYagAAAAENGqmKYxxkU8HYuOIFjqICSFiDSOpwd4PuSCOLVGPpIPEP0714oe6lfl8273rN6eUw==", null, false, 17, "1", "55daed9e-531b-43bc-bd1a-0895f155fc73", "6404101357", false, "user30@example.com" },
                    { "ef0896cd-d306-44cd-bd53-454d05459bca", 0, "48504ef6-05d5-4884-bd84-2bca62ca1852", "user27@example.com", false, "ศิระณัฐ", "จันทะกี", false, null, "มาร์ค", "USER27@EXAMPLE.COM", "USER27@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI0Fu9+Yv1QCISRx5VB2XMCYkTgYVqdLxKoKIrCe+xCXXNUvCA+h8/2M5v9OHqxWZw==", null, false, 15, "1", "b20f2e7e-fd82-4710-93a2-ee1f128ae065", "6404101342", false, "user27@example.com" },
                    { "f8e93889-03fa-4415-842a-74fad193f04b", 0, "2fae67ed-b52d-4091-9261-adc8138512b2", "user19@example.com", false, "ลลิษา", "ยอดมณี", false, null, "แบม", "USER19@EXAMPLE.COM", "USER19@EXAMPLE.COM", "AQAAAAIAAYagAAAAECo881HpUYYra4nGV0cB58WMIMnM3us8tPxPMq6r5ZjkV0ZtjosWPnx6VR4xytn+Gg==", null, false, 10, "1", "d7e66299-dcc0-4bee-b5bf-ed546dacc29b", "6404101337", false, "user19@example.com" },
                    { "f93beda2-12fa-4552-8c1a-4f17e1e4c5b7", 0, "c9dbeaac-0cd7-4458-a3e5-c5144b7b5248", "user5@example.com", false, "ขวัญชนก", "เสนีย์วงศ์ ณ อยุธยา", false, null, "แพรวา", "USER5@EXAMPLE.COM", "USER5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKZIvdrDFDAUyQMluvZanklhoRt+3+xvm5VDdovhOY9B4OBv1BzO47TVC5/BKYH5CQ==", null, false, 3, "1", "e99b96a1-7816-44f2-9505-b510fcc0f876", "6404101306", false, "user5@example.com" }
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
