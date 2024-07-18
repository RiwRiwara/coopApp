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
                    { 1, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4271), null, null, null, null, 1, 4, null, 4, null },
                    { 2, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4430), null, null, null, "File2.pdf", 1, 5, "Project 1", 5, "Not Started" },
                    { 3, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4443), null, null, null, "File3.pdf", 1, 6, "Project 1", 6, "Not Started" },
                    { 4, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4448), null, null, null, null, 1, 7, null, 7, null },
                    { 5, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4453), null, null, null, "File5.pdf", 1, 8, "Project 1", 8, "Not Started" },
                    { 6, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4461), null, null, null, "File6.pdf", 1, 9, "Project 1", 9, "Not Started" },
                    { 7, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4467), null, null, null, null, 1, 10, null, 10, null },
                    { 8, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4469), null, null, null, null, 1, 11, null, 11, null },
                    { 9, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4471), null, null, null, null, 1, 12, null, 12, null },
                    { 10, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4474), null, null, null, null, 1, 13, null, 13, null },
                    { 11, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4476), null, null, null, null, 2, 4, null, 4, null },
                    { 12, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4482), null, null, null, "File2.pdf", 2, 5, "Project 2", 5, "Not Started" },
                    { 13, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4488), null, null, null, "File3.pdf", 2, 6, "Project 2", 6, "Not Started" },
                    { 14, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4493), null, null, null, null, 2, 7, null, 7, null },
                    { 15, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4497), null, null, null, "File5.pdf", 2, 8, "Project 2", 8, "Not Started" },
                    { 16, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4504), null, null, null, "File6.pdf", 2, 9, "Project 2", 9, "Not Started" },
                    { 17, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4509), null, null, null, null, 2, 10, null, 10, null },
                    { 18, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4513), null, null, null, null, 2, 11, null, 11, null },
                    { 19, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4514), null, null, null, null, 2, 12, null, 12, null },
                    { 20, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4517), null, null, null, null, 2, 13, null, 13, null },
                    { 21, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4519), null, null, null, null, 3, 4, null, 4, null },
                    { 22, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4523), null, null, null, "File2.pdf", 3, 5, "Project 3", 5, "Not Started" },
                    { 23, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4531), null, null, null, "File3.pdf", 3, 6, "Project 3", 6, "Not Started" },
                    { 24, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4547), null, null, null, null, 3, 7, null, 7, null },
                    { 25, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4551), null, null, null, "File5.pdf", 3, 8, "Project 3", 8, "Not Started" },
                    { 26, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4559), null, null, null, "File6.pdf", 3, 9, "Project 3", 9, "Not Started" },
                    { 27, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4564), null, null, null, null, 3, 10, null, 10, null },
                    { 28, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4567), null, null, null, null, 3, 11, null, 11, null },
                    { 29, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4569), null, null, null, null, 3, 12, null, 12, null },
                    { 30, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4580), null, null, null, null, 3, 13, null, 13, null },
                    { 31, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4614), null, null, null, null, 4, 4, null, 4, null },
                    { 32, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4620), null, null, null, "File2.pdf", 4, 5, "Project 4", 5, "Not Started" },
                    { 33, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4627), null, null, null, "File3.pdf", 4, 6, "Project 4", 6, "Not Started" },
                    { 34, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4795), null, null, null, null, 4, 7, null, 7, null },
                    { 35, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4801), null, null, null, "File5.pdf", 4, 8, "Project 4", 8, "Not Started" },
                    { 36, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4864), null, null, null, "File6.pdf", 4, 9, "Project 4", 9, "Not Started" },
                    { 37, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4869), null, null, null, null, 4, 10, null, 10, null },
                    { 38, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4871), null, null, null, null, 4, 11, null, 11, null },
                    { 39, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4873), null, null, null, null, 4, 12, null, 12, null },
                    { 40, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4875), null, null, null, null, 4, 13, null, 13, null },
                    { 41, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4877), null, null, null, null, 5, 4, null, 4, null },
                    { 42, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4882), null, null, null, "File2.pdf", 5, 5, "Project 5", 5, "Not Started" },
                    { 43, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4890), null, null, null, "File3.pdf", 5, 6, "Project 5", 6, "Not Started" },
                    { 44, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4895), null, null, null, null, 5, 7, null, 7, null },
                    { 45, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4900), null, null, null, "File5.pdf", 5, 8, "Project 5", 8, "Not Started" },
                    { 46, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4908), null, null, null, "File6.pdf", 5, 9, "Project 5", 9, "Not Started" },
                    { 47, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4913), null, null, null, null, 5, 10, null, 10, null },
                    { 48, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4915), null, null, null, null, 5, 11, null, 11, null },
                    { 49, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4917), null, null, null, null, 5, 12, null, 12, null },
                    { 50, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4919), null, null, null, null, 5, 13, null, 13, null },
                    { 51, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4921), null, null, null, null, 6, 4, null, 4, null },
                    { 52, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4925), null, null, null, "File2.pdf", 6, 5, "Project 6", 5, "Not Started" },
                    { 53, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4933), null, null, null, "File3.pdf", 6, 6, "Project 6", 6, "Not Started" },
                    { 54, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4938), null, null, null, null, 6, 7, null, 7, null },
                    { 55, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4943), null, null, null, "File5.pdf", 6, 8, "Project 6", 8, "Not Started" },
                    { 56, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4950), null, null, null, "File6.pdf", 6, 9, "Project 6", 9, "Not Started" },
                    { 57, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4955), null, null, null, null, 6, 10, null, 10, null },
                    { 58, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4957), null, null, null, null, 6, 11, null, 11, null },
                    { 59, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4959), null, null, null, null, 6, 12, null, 12, null },
                    { 60, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4961), null, null, null, null, 6, 13, null, 13, null },
                    { 61, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4963), null, null, null, null, 7, 4, null, 4, null },
                    { 62, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4967), null, null, null, "File2.pdf", 7, 5, "Project 7", 5, "Not Started" },
                    { 63, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4975), null, null, null, "File3.pdf", 7, 6, "Project 7", 6, "Not Started" },
                    { 64, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4980), null, null, null, null, 7, 7, null, 7, null },
                    { 65, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4984), null, null, null, "File5.pdf", 7, 8, "Project 7", 8, "Not Started" },
                    { 66, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4995), null, null, null, "File6.pdf", 7, 9, "Project 7", 9, "Not Started" },
                    { 67, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(4999), null, null, null, null, 7, 10, null, 10, null },
                    { 68, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5002), null, null, null, null, 7, 11, null, 11, null },
                    { 69, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5003), null, null, null, null, 7, 12, null, 12, null },
                    { 70, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5005), null, null, null, null, 7, 13, null, 13, null },
                    { 71, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5007), null, null, null, null, 8, 4, null, 4, null },
                    { 72, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5012), null, null, null, "File2.pdf", 8, 5, "Project 8", 5, "Not Started" },
                    { 73, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5020), null, null, null, "File3.pdf", 8, 6, "Project 8", 6, "Not Started" },
                    { 74, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5024), null, null, null, null, 8, 7, null, 7, null },
                    { 75, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5029), null, null, null, "File5.pdf", 8, 8, "Project 8", 8, "Not Started" },
                    { 76, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5036), null, null, null, "File6.pdf", 8, 9, "Project 8", 9, "Not Started" },
                    { 77, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5041), null, null, null, null, 8, 10, null, 10, null },
                    { 78, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5043), null, null, null, null, 8, 11, null, 11, null },
                    { 79, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5123), null, null, null, null, 8, 12, null, 12, null },
                    { 80, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5125), null, null, null, null, 8, 13, null, 13, null },
                    { 81, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5128), null, null, null, null, 9, 4, null, 4, null },
                    { 82, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5133), null, null, null, "File2.pdf", 9, 5, "Project 9", 5, "Not Started" },
                    { 83, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5140), null, null, null, "File3.pdf", 9, 6, "Project 9", 6, "Not Started" },
                    { 84, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5145), null, null, null, null, 9, 7, null, 7, null },
                    { 85, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5150), null, null, null, "File5.pdf", 9, 8, "Project 9", 8, "Not Started" },
                    { 86, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5158), null, null, null, "File6.pdf", 9, 9, "Project 9", 9, "Not Started" },
                    { 87, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5162), null, null, null, null, 9, 10, null, 10, null },
                    { 88, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5164), null, null, null, null, 9, 11, null, 11, null },
                    { 89, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5166), null, null, null, null, 9, 12, null, 12, null },
                    { 90, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5168), null, null, null, null, 9, 13, null, 13, null },
                    { 91, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5170), null, null, null, null, 10, 4, null, 4, null },
                    { 92, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5177), null, null, null, "File2.pdf", 10, 5, "Project 10", 5, "Not Started" },
                    { 93, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5185), null, null, null, "File3.pdf", 10, 6, "Project 10", 6, "Not Started" },
                    { 94, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5190), null, null, null, null, 10, 7, null, 7, null },
                    { 95, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5195), null, null, null, "File5.pdf", 10, 8, "Project 10", 8, "Not Started" },
                    { 96, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5203), null, null, null, "File6.pdf", 10, 9, "Project 10", 9, "Not Started" },
                    { 97, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5209), null, null, null, null, 10, 10, null, 10, null },
                    { 98, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5210), null, null, null, null, 10, 11, null, 11, null },
                    { 99, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5212), null, null, null, null, 10, 12, null, 12, null },
                    { 100, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5214), null, null, null, null, 10, 13, null, 13, null },
                    { 101, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5216), null, null, null, null, 11, 4, null, 4, null },
                    { 102, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5221), null, null, null, "File2.pdf", 11, 5, "Project 11", 5, "Not Started" },
                    { 103, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5228), null, null, null, "File3.pdf", 11, 6, "Project 11", 6, "Not Started" },
                    { 104, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5233), null, null, null, null, 11, 7, null, 7, null },
                    { 105, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5238), null, null, null, "File5.pdf", 11, 8, "Project 11", 8, "Not Started" },
                    { 106, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5245), null, null, null, "File6.pdf", 11, 9, "Project 11", 9, "Not Started" },
                    { 107, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5250), null, null, null, null, 11, 10, null, 10, null },
                    { 108, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5252), null, null, null, null, 11, 11, null, 11, null },
                    { 109, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5254), null, null, null, null, 11, 12, null, 12, null },
                    { 110, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5256), null, null, null, null, 11, 13, null, 13, null },
                    { 111, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5258), null, null, null, null, 12, 4, null, 4, null },
                    { 112, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5262), null, null, null, "File2.pdf", 12, 5, "Project 12", 5, "Not Started" },
                    { 113, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5270), null, null, null, "File3.pdf", 12, 6, "Project 12", 6, "Not Started" },
                    { 114, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5275), null, null, null, null, 12, 7, null, 7, null },
                    { 115, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5279), null, null, null, "File5.pdf", 12, 8, "Project 12", 8, "Not Started" },
                    { 116, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5287), null, null, null, "File6.pdf", 12, 9, "Project 12", 9, "Not Started" },
                    { 117, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5292), null, null, null, null, 12, 10, null, 10, null },
                    { 118, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5294), null, null, null, null, 12, 11, null, 11, null },
                    { 119, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5296), null, null, null, null, 12, 12, null, 12, null },
                    { 120, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5298), null, null, null, null, 12, 13, null, 13, null },
                    { 121, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5300), null, null, null, null, 13, 4, null, 4, null },
                    { 122, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5304), null, null, null, "File2.pdf", 13, 5, "Project 13", 5, "Not Started" },
                    { 123, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5312), null, null, null, "File3.pdf", 13, 6, "Project 13", 6, "Not Started" },
                    { 124, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5317), null, null, null, null, 13, 7, null, 7, null },
                    { 125, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5322), null, null, null, "File5.pdf", 13, 8, "Project 13", 8, "Not Started" },
                    { 126, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5329), null, null, null, "File6.pdf", 13, 9, "Project 13", 9, "Not Started" },
                    { 127, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5335), null, null, null, null, 13, 10, null, 10, null },
                    { 128, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5336), null, null, null, null, 13, 11, null, 11, null },
                    { 129, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5338), null, null, null, null, 13, 12, null, 12, null },
                    { 130, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5398), null, null, null, null, 13, 13, null, 13, null },
                    { 131, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5400), null, null, null, null, 14, 4, null, 4, null },
                    { 132, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5406), null, null, null, "File2.pdf", 14, 5, "Project 14", 5, "Not Started" },
                    { 133, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5413), null, null, null, "File3.pdf", 14, 6, "Project 14", 6, "Not Started" },
                    { 134, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5418), null, null, null, null, 14, 7, null, 7, null },
                    { 135, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5422), null, null, null, "File5.pdf", 14, 8, "Project 14", 8, "Not Started" },
                    { 136, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5430), null, null, null, "File6.pdf", 14, 9, "Project 14", 9, "Not Started" },
                    { 137, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5435), null, null, null, null, 14, 10, null, 10, null },
                    { 138, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5437), null, null, null, null, 14, 11, null, 11, null },
                    { 139, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5439), null, null, null, null, 14, 12, null, 12, null },
                    { 140, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5441), null, null, null, null, 14, 13, null, 13, null },
                    { 141, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5443), null, null, null, null, 15, 4, null, 4, null },
                    { 142, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5447), null, null, null, "File2.pdf", 15, 5, "Project 15", 5, "Not Started" },
                    { 143, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5455), null, null, null, "File3.pdf", 15, 6, "Project 15", 6, "Not Started" },
                    { 144, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5460), null, null, null, null, 15, 7, null, 7, null },
                    { 145, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5465), null, null, null, "File5.pdf", 15, 8, "Project 15", 8, "Not Started" },
                    { 146, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5472), null, null, null, "File6.pdf", 15, 9, "Project 15", 9, "Not Started" },
                    { 147, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5477), null, null, null, null, 15, 10, null, 10, null },
                    { 148, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5479), null, null, null, null, 15, 11, null, 11, null },
                    { 149, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5481), null, null, null, null, 15, 12, null, 12, null },
                    { 150, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5483), null, null, null, null, 15, 13, null, 13, null },
                    { 151, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5485), null, null, null, null, 16, 4, null, 4, null },
                    { 152, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5489), null, null, null, "File2.pdf", 16, 5, "Project 16", 5, "Not Started" },
                    { 153, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5497), null, null, null, "File3.pdf", 16, 6, "Project 16", 6, "Not Started" },
                    { 154, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5501), null, null, null, null, 16, 7, null, 7, null },
                    { 155, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5506), null, null, null, "File5.pdf", 16, 8, "Project 16", 8, "Not Started" },
                    { 156, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5513), null, null, null, "File6.pdf", 16, 9, "Project 16", 9, "Not Started" },
                    { 157, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5518), null, null, null, null, 16, 10, null, 10, null },
                    { 158, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5520), null, null, null, null, 16, 11, null, 11, null },
                    { 159, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5522), null, null, null, null, 16, 12, null, 12, null },
                    { 160, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5524), null, null, null, null, 16, 13, null, 13, null },
                    { 161, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5526), null, null, null, null, 17, 4, null, 4, null },
                    { 162, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5530), null, null, null, "File2.pdf", 17, 5, "Project 17", 5, "Not Started" },
                    { 163, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5537), null, null, null, "File3.pdf", 17, 6, "Project 17", 6, "Not Started" },
                    { 164, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5543), null, null, null, null, 17, 7, null, 7, null },
                    { 165, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5548), null, null, null, "File5.pdf", 17, 8, "Project 17", 8, "Not Started" },
                    { 166, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5555), null, null, null, "File6.pdf", 17, 9, "Project 17", 9, "Not Started" },
                    { 167, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5560), null, null, null, null, 17, 10, null, 10, null },
                    { 168, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5562), null, null, null, null, 17, 11, null, 11, null },
                    { 169, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5564), null, null, null, null, 17, 12, null, 12, null },
                    { 170, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5565), null, null, null, null, 17, 13, null, 13, null },
                    { 171, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5568), null, null, null, null, 18, 4, null, 4, null },
                    { 172, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5572), null, null, null, "File2.pdf", 18, 5, "Project 18", 5, "Not Started" },
                    { 173, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5579), null, null, null, "File3.pdf", 18, 6, "Project 18", 6, "Not Started" },
                    { 174, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5584), null, null, null, null, 18, 7, null, 7, null },
                    { 175, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5641), null, null, null, "File5.pdf", 18, 8, "Project 18", 8, "Not Started" },
                    { 176, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5649), null, null, null, "File6.pdf", 18, 9, "Project 18", 9, "Not Started" },
                    { 177, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5654), null, null, null, null, 18, 10, null, 10, null },
                    { 178, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5656), null, null, null, null, 18, 11, null, 11, null },
                    { 179, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5658), null, null, null, null, 18, 12, null, 12, null },
                    { 180, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5659), null, null, null, null, 18, 13, null, 13, null },
                    { 181, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5662), null, null, null, null, 19, 4, null, 4, null },
                    { 182, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5666), null, null, null, "File2.pdf", 19, 5, "Project 19", 5, "Not Started" },
                    { 183, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5674), null, null, null, "File3.pdf", 19, 6, "Project 19", 6, "Not Started" },
                    { 184, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5678), null, null, null, null, 19, 7, null, 7, null },
                    { 185, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5683), null, null, null, "File5.pdf", 19, 8, "Project 19", 8, "Not Started" },
                    { 186, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5691), null, null, null, "File6.pdf", 19, 9, "Project 19", 9, "Not Started" },
                    { 187, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5696), null, null, null, null, 19, 10, null, 10, null },
                    { 188, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5698), null, null, null, null, 19, 11, null, 11, null },
                    { 189, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5700), null, null, null, null, 19, 12, null, 12, null },
                    { 190, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5701), null, null, null, null, 19, 13, null, 13, null },
                    { 191, new DateTime(2024, 8, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5703), null, null, null, null, 20, 4, null, 4, null },
                    { 192, new DateTime(2024, 9, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5708), null, null, null, "File2.pdf", 20, 5, "Project 20", 5, "Not Started" },
                    { 193, new DateTime(2024, 10, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5715), null, null, null, "File3.pdf", 20, 6, "Project 20", 6, "Not Started" },
                    { 194, new DateTime(2024, 11, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5720), null, null, null, null, 20, 7, null, 7, null },
                    { 195, new DateTime(2024, 12, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5725), null, null, null, "File5.pdf", 20, 8, "Project 20", 8, "Not Started" },
                    { 196, new DateTime(2025, 1, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5732), null, null, null, "File6.pdf", 20, 9, "Project 20", 9, "Not Started" },
                    { 197, new DateTime(2025, 2, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5737), null, null, null, null, 20, 10, null, 10, null },
                    { 198, new DateTime(2025, 3, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5739), null, null, null, null, 20, 11, null, 11, null },
                    { 199, new DateTime(2025, 4, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5741), null, null, null, null, 20, 12, null, 12, null },
                    { 200, new DateTime(2025, 5, 19, 1, 36, 55, 201, DateTimeKind.Local).AddTicks(5743), null, null, null, null, 20, 13, null, 13, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProjectId", "RoleId", "SecurityStamp", "StudentID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0028683d-94db-4815-8df3-4692f8a6dfda", 0, "dd96ce8c-79f1-43e1-be75-5c2ae99b4b6d", "user25@example.com", false, "สุจิตรา", "ปานการะเกตุ", false, null, "โม", "USER25@EXAMPLE.COM", "USER25@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFepaFL0s9bHqVmVG/qFABrb5eoSoMLBOvnrRT+eDNuAZPkuqP/yx3OGEYwT+nc3Vg==", null, false, 14, "1", "79d1e2fc-f04e-4ad9-8193-9a3f0b584f97", "6404101347", false, "user25@example.com" },
                    { "13134941-9c65-4c53-9ada-587aacd81a2b", 0, "0db5fe63-f647-4738-993e-6553d2590907", "staff@example.com", false, "Jane", "Doe", false, null, "Janie", "STAFF@EXAMPLE.COM", "STAFF@EXAMPLE.COM", "AQAAAAIAAYagAAAAEME0F6HUD+iNMYeAniOrVqBXO3VxcXl6z2j/S+K0U1qrQWOeGSsfsvkcdUmA6MZoRA==", null, false, 0, "2", "7b986567-60a8-488f-acdb-068e9f25d213", null, false, "staff@example.com" },
                    { "1c21effe-d460-4cbf-b32f-fbaa09a9df88", 0, "22e37965-b24a-4d8d-9a05-1207e15e0ed1", "user8@example.com", false, "ณรงค์เกียรติ", "นามห้วยทอง", false, null, "ก๊อต", "USER8@EXAMPLE.COM", "USER8@EXAMPLE.COM", "AQAAAAIAAYagAAAAELRLjkCTd3Tffvexl7qNBwyNSgSG2qe3Tx7ZkiCHWKhMVXbtCURbjpduQCSGno4Jjw==", null, false, 5, "1", "3fe95bcb-cffd-4a66-8a28-1cdde560b218", "6404101312", false, "user8@example.com" },
                    { "2087a1a9-8f48-4fd2-a7b7-8f70085e689a", 0, "e51e79d0-71c1-49c3-9db9-813d2ddb90e4", "user11@example.com", false, "ณภัทร", "บัวบาน", false, null, "หนึ่ง", "USER11@EXAMPLE.COM", "USER11@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF0QadNbmA2qmms270cStMAVbNJwIgu9s+g8AsdjFmsRiWr4peapKj6z6JAmJObbrA==", null, false, 5, "1", "5f0c02b2-ccb1-408f-913b-e70b8b1132e1", "6404101359", false, "user11@example.com" },
                    { "27afd22d-da71-4b53-9f27-af7cded4be5f", 0, "19f777fd-4a4e-47af-be39-ef578748b1ff", "user18@example.com", false, "อภิวัฒน์", "ไชยา", false, null, "ฟิว", "USER18@EXAMPLE.COM", "USER18@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHzf7CfCF0tvoyB8qnNYDYDB1TaVQAWovU3Cy3CIMiD7Rb4kksIRRZQ9CE1VjmZbsw==", null, false, 9, "1", "45037776-47e6-4241-978a-0be591305e60", "6404101377", false, "user18@example.com" },
                    { "297034e1-5a17-4250-a0c7-7c17d4c2a0d2", 0, "ec5345e0-6f05-436d-92fb-d6f8f60736ae", "user32@example.com", false, "พงศกร", "คูณเสนา", false, null, "เพชร", "USER32@EXAMPLE.COM", "USER32@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMXJml4lpJPztmpyV6dPtMxfKw55EQ8dPqVfmxRU5WjR986z73drZMqUJk9+F3nwkQ==", null, false, 18, "1", "c51c31e2-3d45-4a65-a405-8d3bfbdfa66a", "6404101365", false, "user32@example.com" },
                    { "2b7bb993-6314-4448-99ce-accf6e53d34d", 0, "6c43f455-1294-4b52-a379-01462581ed1b", "user30@example.com", false, "ชนันฌ์ณภัสฐ์", "สิงห์คาล", false, null, "สาหร่าย", "USER30@EXAMPLE.COM", "USER30@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE++oyeFyA5MfliHQ5AwJy/yDO1hm2LAT3WR5wKy9uXx9P6m45A7Ztb4lSmMUbRc2Q==", null, false, 17, "1", "1ed0498e-9a1a-4b99-83a0-c0f8b7b6d416", "6404101357", false, "user30@example.com" },
                    { "2d8e01c5-3063-413a-b485-d6ac71d5ac71", 0, "a006f4c4-42a1-462e-9cee-6fc956ccbc6d", "user27@example.com", false, "ศิระณัฐ", "จันทะกี", false, null, "มาร์ค", "USER27@EXAMPLE.COM", "USER27@EXAMPLE.COM", "AQAAAAIAAYagAAAAELfsmkgvoar+wzCauLUsZhQ1z1+acihHdyexkqmdaADhgm08LAYZqO8nymW78+lljQ==", null, false, 15, "1", "e03c71f3-229d-485e-9e74-ba0964270cc5", "6404101342", false, "user27@example.com" },
                    { "2e0a6fe4-6cc0-43e0-b49e-d6c64b017dcc", 0, "13d204bd-9073-4aff-9760-e61649514765", "user4@example.com", false, "อัจฉริยะณัฐ", "ปะฏิเต", false, null, "ต้อง", "USER4@EXAMPLE.COM", "USER4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKK45ZCX8zEs9OfL6hN2p+mPprwjutAtraHNsoTbTINyatMx7I2SGUBeTjy7xS8P1w==", null, false, 2, "1", "6d5c0024-f2bf-4e2f-b62e-81861b51fa2d", "6404101378", false, "user4@example.com" },
                    { "4209c265-8260-4e79-b747-0cd8ef96b912", 0, "3b1c313c-3fab-49bb-b831-e5291c99f76d", "user12@example.com", false, "มณฑารบ", "ชาวโพงพาง", false, null, "มัดหมี่", "USER12@EXAMPLE.COM", "USER12@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKEdEHN/3w/hrykXX+U4M5ideHSvBuu1MWg5GxJDDIz+ZNMheWvZ29SmRgeuZixq0A==", null, false, 6, "1", "854f7be1-42bc-4542-a83f-06fb05cfccd9", "6404101369", false, "user12@example.com" },
                    { "42d5e302-5546-47f2-821d-aa7e2fe8867f", 0, "08888f11-61b1-4939-a908-0c1a832abb73", "teacher@example.com", false, "Jim", "Beam", false, null, "Jimmy", "TEACHER@EXAMPLE.COM", "TEACHER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGRegNQQcHdNbcNfSGocklBATtalWZqn21UkdHng+sj8UTD+yHxhoWVmp3DWVg3Ayw==", null, false, 0, "3", "6ebabc41-2e41-49c6-bdbe-c9454d553091", null, false, "teacher@example.com" },
                    { "45bd4fe3-1f8f-4396-8205-47370bdd52c9", 0, "478c17e8-aa73-455f-97f2-b17f189afdc3", "user17@example.com", false, "อดิศร", "วงศ์คำ", false, null, "แนท", "USER17@EXAMPLE.COM", "USER17@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB4mD7/gQS1aZEsSqVKgYSpWg8K3WkiD3rCX9d2reQLVddeGQj2Z66j7MHl9ZvG73Q==", null, false, 9, "1", "4c2c6a96-ceb0-48a0-a892-6d9b683980a2", "6404101350", false, "user17@example.com" },
                    { "56daf29e-0143-45ce-8f83-b4e38d5eaae3", 0, "c03cc839-ae9d-4314-987d-1e8b1649ebcd", "user6@example.com", false, "เมธาวัฒน์", "มหาวัน", false, null, "ตะวัน", "USER6@EXAMPLE.COM", "USER6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMGSWEQ4LxwuFHQ1yKiT+ZTwWHbSaoqsUIAUF2OSC4lqK2UHgbIYcOjlWHoLxVpPbA==", null, false, 3, "1", "63810654-4cb8-4e35-ab0d-de324710a390", "6404101332", false, "user6@example.com" },
                    { "5d296348-d573-4355-ba17-026d504857f4", 0, "bf19c2b0-a8ca-4e48-a921-1cf2561aabae", "user10@example.com", false, "ไตรภาค", "สิทธิแก้ว", false, null, "ภาค", "USER10@EXAMPLE.COM", "USER10@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOir6XlvxtVpvVTymLXH2adhG98WvtzAdfTInsgv3c1DgVxHXMTNUm1tP5/6hJX1tw==", null, false, 5, "1", "1243f37c-487b-41d5-85d6-4918a2eac297", "6404101318", false, "user10@example.com" },
                    { "7289f624-06c9-4bde-8c55-9e60db5cf26e", 0, "564aad3b-be43-4d8a-b942-3991cbc739eb", "user15@example.com", false, "พิมลพรรณ", "เงินทอง", false, null, "โฟร์ท", "USER15@EXAMPLE.COM", "USER15@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKSNIQeyYNghf7gXblHbmDaG+ghM9eSjDF/IuJvbS2WVEEr2Rz5sJXJyV0iHhNBy9Q==", null, false, 8, "1", "08b64dfe-7337-47e4-8466-ef9b6acd0727", "6404101327", false, "user15@example.com" },
                    { "7ea6379e-a4b8-401a-aa15-f0acb4d46355", 0, "0b0f8a3c-4d9b-4c4c-a791-1fbdedc482a1", "user31@example.com", false, "รุ่งเจริญ", "โพธิ์ศรี", false, null, "เพชร", "USER31@EXAMPLE.COM", "USER31@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKOb/mzooed73oQ6M2bVRl5l/NOYvI4vINyBCoCuS2G7rDld81s2ap0Wiz3+rvWcsg==", null, false, 18, "1", "1f58f214-e19e-4d15-b75e-fcd88702ba65", "6404101335", false, "user31@example.com" },
                    { "7ef64821-0a64-40b6-9359-bb59d33deb7b", 0, "4bf468d0-c091-44d2-bac2-d3fff4c2c771", "user26@example.com", false, "สุธิชานนท์", "พูลการขาย", false, null, "เม่น", "USER26@EXAMPLE.COM", "USER26@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEhyCgrTJwtCCZ09h0RpPquUjAtudNrhmBQodKPlBMieTYHf5/H0hAqP6myqjYBCHQ==", null, false, 14, "1", "72881c49-05a8-4636-8735-0fb184fbfd15", "6404101348", false, "user26@example.com" },
                    { "802b6c59-565f-4a56-9da4-9e23396a6c95", 0, "927acd39-9604-41ef-84db-4ab6df731d21", "user24@example.com", false, "รัฐติกรณ์", "จินะกาศ", false, null, "โอม", "USER24@EXAMPLE.COM", "USER24@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFMaNCHhv7kj1F0H6n5hi5xchVgmK/4qc4oSi9g9jHrqUPR8PFOjQaxGZFlvrVbW0w==", null, false, 13, "1", "094213d7-877c-4a23-8ed4-2a747c5d5842", "6404101334", false, "user24@example.com" },
                    { "8732eafe-27f0-41aa-9d2c-1e791a018d60", 0, "4b018126-6ba6-4df1-a02f-30b6efb1b5da", "user14@example.com", false, "ผดุงเกียรติ", "สุตาโย", false, null, "บอย", "USER14@EXAMPLE.COM", "USER14@EXAMPLE.COM", "AQAAAAIAAYagAAAAEC+Y33flXwH/QkPTy6R7as+/XuWUooPM9QlyKEtc1zuX3GmecIYaiQx4vyRlFWyCYw==", null, false, 7, "1", "92f0e5d6-87e7-4e6a-b6e4-5c698c0f0400", "6404101325", false, "user14@example.com" },
                    { "8ae54314-cf82-4cb5-ba89-b561cccbb0eb", 0, "28d6b6a5-0551-46da-87eb-eaec30e13546", "user20@example.com", false, "วชรพล", "ไชยวรรณ", false, null, "เติ้ง", "USER20@EXAMPLE.COM", "USER20@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDdEOoxj1XqDwxKirY8pDzFhKBypUQb8TkIkZO1ZGRYQDLelpd2JIzDLe1BK+QbvYA==", null, false, 11, "1", "f856a8a4-ea97-4b6d-afde-399975e9b548", "6404101338", false, "user20@example.com" },
                    { "97386e73-99e8-4ecf-a12f-8112cf8944ab", 0, "2726b4a2-d48d-4fdf-af10-54f72e277ace", "user7@example.com", false, "ฐิติพงษ์", "เรือนสุภา", false, null, "", "USER7@EXAMPLE.COM", "USER7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHKQZ4BFGg0nEhQD0yCAsVM9U87W+p/+AQuUyFu+LZ6c/KHkiph0PoKFYwGyPN/V0g==", null, false, 4, "1", "5904d36d-91f9-4c0b-848f-bf605a2fd2e8", "6404101311", false, "user7@example.com" },
                    { "9e7d3222-681a-40fd-9272-71b0a6ba9cc2", 0, "c64f2873-1b5a-4abf-92d1-b92df3bee4f5", "user9@example.com", false, "ตะวัน", "สุรินา", false, null, "เจแปน", "USER9@EXAMPLE.COM", "USER9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAdj6Q2q/0xN01fIhZa8lUFN/+zbUbclGDkFQgfI2yCHulSdq3Yxr4B3fmE4v1BSfA==", null, false, 5, "1", "2afa4f3e-4336-474b-bb4c-deb57d525b15", "6404101316", false, "user9@example.com" },
                    { "9ef150da-1cba-4da4-ad12-5290db4f0ace", 0, "02731c06-a23b-4ae9-9a70-d384a5ec4e28", "user29@example.com", false, "กณิศนันท์", "ทองสกุล", false, null, "แยม", "USER29@EXAMPLE.COM", "USER29@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOhKZTSFWgfdLQ5iZP1wN3zzQVjkH887UMU93RtnqN/eGlzTgtdS5HcN8tOhgl56fA==", null, false, 16, "1", "3f05a964-fad5-4c90-9210-fccafad12bd2", "6404101354", false, "user29@example.com" },
                    { "a5e95363-a50d-44c9-b786-cc9beb5b8e59", 0, "8186fa86-1016-4b0e-9a63-89f27c42ce15", "user3@example.com", false, "นิมมิตา", "สมริน", false, null, "มิ้น", "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIB5lyQ1ughmgCFjClEXj8zBbQOHV734EX7dOTneGWJCP/K11oE5Zjj7oaMVXY2dCA==", null, false, 2, "1", "6143dba3-6eef-4af8-b2ab-775a87f3828d", "6404101324", false, "user3@example.com" },
                    { "a70b0da8-348a-41ad-83d0-eaf5e5991a36", 0, "00c3f280-0bd9-481a-a389-6497397ea481", "user2@example.com", false, "กัญญาพัชร", "ยศสนิท", false, null, "ไอซ์", "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAENrvyw8M22UaxsitVpR5I/l2qBoCFpHn8MriQCiFZDyy0N6QCeLaB1iVPdvoA21kSg==", null, false, 2, "1", "6211042c-4cd8-49da-a115-bac9db447bb8", "6404101303", false, "user2@example.com" },
                    { "b0858a2a-bdca-423a-a27a-0e1f710ba472", 0, "660deb63-0e8c-4e0d-bb77-bbaf2c393039", "user16@example.com", false, "ภราดร", "ศรีทา", false, null, "บอล", "USER16@EXAMPLE.COM", "USER16@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOwVwtWo/j11OKpLxJ7iAbDoIRXpwTwT32wkvBl4zxHmPwwF1B+ve3bmvhqYXZGZlA==", null, false, 8, "1", "62f4630a-39a9-429b-84a7-28f9eefd5915", "6404101330", false, "user16@example.com" },
                    { "b674bcc7-47c8-4cf0-9267-31d4c0a13e31", 0, "0a239d57-fffe-4996-a347-aaa4e071e909", "user23@example.com", false, "เศรษฐพงศ์", "อินทร์แสง", false, null, "แบงค์", "USER23@EXAMPLE.COM", "USER23@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFVHWLputPdo6CvM4FMp/UOWJ5uy1/d25WKwdDEaPug6AUuMElDNuKgVVbSU0d/eeQ==", null, false, 13, "1", "ee45095d-92d3-4314-b746-246c01186e91", "6404101345", false, "user23@example.com" },
                    { "be342f29-6105-4698-a36e-134f0d5afbb5", 0, "02bf26f1-313a-4c3d-8348-18df3379b116", "user34@example.com", false, "กุณช์ศุภณัฐ", "ศรีตาบุตรวรัตถ์", false, null, "ยู", "USER34@EXAMPLE.COM", "USER34@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJYaokfwNJ/w0vTaHrh3Eoch9vazSP3hViv+W4gbkjVgQxq/NlCOcM8bbw/8M0BAaQ==", null, false, 20, "1", "95755e02-bbd9-4030-a029-bb6ce7da2e57", "6404101356", false, "user34@example.com" },
                    { "c394e347-1c9e-40d2-97cb-18564e70d315", 0, "bf747ad1-2dd0-4c88-b30a-cc65a6319847", "user1@example.com", false, "ฐิติกร", "เรือนมนต์", false, null, "ไนท์", "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAXjsMuEQ3zHZ0nSVD3F9VSeSp66yya849ef2dLoR0gUjbKaKZ1eYDswKk/+vysjfQ==", null, false, 1, "1", "d83d9b8a-eb23-4745-aea2-b71e550533ec", "6304101389", false, "user1@example.com" },
                    { "c6221077-ece2-4c0f-9934-ad730f944d47", 0, "007f318b-335c-480a-a259-8ed0f3bcf190", "user19@example.com", false, "ลลิษา", "ยอดมณี", false, null, "แบม", "USER19@EXAMPLE.COM", "USER19@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHKEuFgXR+XVk9FGdyZMmlFu/tlu0TWv/gjWaML2rG7CgzelDqvFrDwfcwjcNlcVCA==", null, false, 10, "1", "cfd27689-ea99-4b9c-8b19-8c2f2f4fdb84", "6404101337", false, "user19@example.com" },
                    { "d1de421f-0bb6-4c9a-aff2-ef3bd638e12a", 0, "e14cf411-44e6-4553-982c-eb2b68df6497", "user5@example.com", false, "ขวัญชนก", "เสนีย์วงศ์ ณ อยุธยา", false, null, "แพรวา", "USER5@EXAMPLE.COM", "USER5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO4HqEJytnt+SOeHvIFTWqWhb330WhHsqonv+D82b7Qu0SM28Y/9AFwdFXJGAiggLg==", null, false, 3, "1", "0a064931-99c9-4fcd-92fa-cf80b435f9f2", "6404101306", false, "user5@example.com" },
                    { "dd4d0b09-89df-4de2-adda-eea57fea23f1", 0, "843a922d-d14a-4012-a50d-b6a3f65deb25", "user21@example.com", false, "ศรายุทธ", "เสนอาสา", false, null, "คิม", "USER21@EXAMPLE.COM", "USER21@EXAMPLE.COM", "AQAAAAIAAYagAAAAEA1VKsnH/BhFUjzhGCeKstjuRxfhoZfRcmgNUxuXBBhm2AKP9wAOkeVum8ArtYksUQ==", null, false, 12, "1", "55f1dc8d-9a8a-48bb-855e-a29a6b687fd5", "6404101341", false, "user21@example.com" },
                    { "e24a317a-c5b4-4b57-abc9-536a82771061", 0, "ffd19077-1795-4624-b47c-d9eb576c1290", "user22@example.com", false, "ศุภณัฐ", "วิบูลย์พานิช", false, null, "ออม", "USER22@EXAMPLE.COM", "USER22@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPIqz82RpLokz/e2DiudIPSElSwzvnBOUGZilvENG0C3wSC/PikvqJx6lL4ahox0bw==", null, false, 12, "1", "03aa5d2e-6b59-44f4-9ee7-e20f8be04a10", "6404101344", false, "user22@example.com" },
                    { "e5863984-5b3d-4b2e-a818-9ac8dd3196a2", 0, "e9880eab-75f5-4f47-9e89-655cf596cc27", "user13@example.com", false, "ไอลดา", "แสงภิรมย์", false, null, "เฟริ์น", "USER13@EXAMPLE.COM", "USER13@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDDmCRmQqAidh+0RBlLhjxDZUpUeqyNoVkKyEkQoizRxQYMwU6bFaxKxCEPX/+jeWw==", null, false, 6, "1", "a2696229-b544-4e27-9bd4-15e4b313123c", "6404101379", false, "user13@example.com" },
                    { "ee159504-d46c-42f0-8e0f-dda842d50ce0", 0, "236ae84e-fecd-4eb9-b0ec-078a20b02572", "user28@example.com", false, "สุนิสา", "ผาด่าน", false, null, "ชิ", "USER28@EXAMPLE.COM", "USER28@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB1UkA2+ui/1TQsf3m1q1y8jcTNC21UDrmjxh+S1ezgPCX/Iolijuh86btDnmgjEew==", null, false, 15, "1", "2f604e02-5f5b-411d-97db-5456ff395be1", "6404101349", false, "user28@example.com" },
                    { "ef42e45e-a349-4afd-b31e-d5541752de82", 0, "592dbc5d-7d5a-4a06-9896-627cbb301d6d", "user33@example.com", false, "ศิริชัย", "เกษมสุข", false, null, "โอม", "USER33@EXAMPLE.COM", "USER33@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEGkiXJp98Hhq1rtjBq/DAlSOeBfjJ2bRMLRDnHnm2nGrUqqIAwUUJIW/wlT6RS8Bg==", null, false, 19, "1", "2a9ba5ae-c9b5-4dbb-855c-8b8a4aa925d7", "6404101372", false, "user33@example.com" }
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
