using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace CoopWeb.Data
{
    public class ProjectSeed
    {
        public ProjectSeed()
        {
        }

        public List<Project> GetProjects()
        {
var projects = new List<Project>
        {
            new Project
            {
                ProjectId = 1,
                ProjectName = "การพัฒนาฟอเร็กซ์เอ็กซ์เพิร์ทแอดไวเซอร์ และเว็บไชต์เพื่อการจัดจำหน่าย",
                WorkPlace = "บริษัท โกลเด้น อาวเออร์ สตูดิโอ จำกัด",
                Chairman = "อ.อลงกต กองมณี",
                Director1 = "ผศ.ก่องกาญจน์ ดุลยไชย",
                Director2 = "ผศ.ก่องกาญจน์ ดุลยไชย", 
            },
            new Project
            {
                ProjectId = 2,
                ProjectName = "หุ่นยนต์ตรวจโรคพืชอัตโนมัติ",
                WorkPlace = "บริษัท ควอนต้า ซินเนอร์จี้ จำกัด",
                Chairman = "อ.ดร.พยุงศักดิ์ เกษมสำราญ",
                Director1 = "ผศ.ภานุวัฒน์ เมฆะ",
                Director2 = "ผศ.ภานุวัฒน์ เมฆะ",
            },
            new Project
            {
                ProjectId = 3,
                ProjectName = "ระบบจองห้องประชุมงานเพื่อเชื่อมต่อกับระบบบริหารทรัพยากรบุคคล",
                WorkPlace = "บริษัทดูดี อินดีด คอร์ปอเรชัน จํากัด",
                Chairman = "ผศ.ภานุวัฒน์ เมฆะ",
                Director1 =  "อ.ดร.พยุงศักดิ์ เกษมสำรา",
                Director2 = "อ.ดร.พยุงศักดิ์ เกษมสำราญ",
            },
            new Project
            {
                ProjectId = 4,
                ProjectName = "การพัฒนาระบบ AI สำหรับใช้ใน NPC ในเมตาเวิร์ส",
                WorkPlace = "บริษัท เอ็นดีเอฟ เดฟ จำกัด",
                Chairman = "อ.ดร.สมนึก สินธุปวน",
                Director1 = "ผศ.ดร.พาสน์ ปราโมกข์ช",
                Director2 = "ผศ.ดร.พาสน์ ปราโมกข์ชน", 
            },
            new Project
            {
                ProjectId = 5,
                ProjectName = "เพย์โซลูชั่นเช็คสลิป",
                WorkPlace = "บริษัทเพย์โซลูชั่น จำกัด (เชียงใหม่)",
                Chairman = "ผศ.ก่องกาญจน์ ดุลยไชย",
                Director1 =  "อ.อรรถวิท ชังคมานนท์",
                Director2 = "อ.อรรถวิท ชังคมานนท์"
            },
            new Project
            {
                ProjectId = 6,
                ProjectName = "ระบบการแจ้งเตือนการชำระเงินผ่านแอปพลิเคชั่นไลน์",
                WorkPlace = "บริษัทเพย์โซลูชั่น จำกัด (กรุงเทพ)",
                Chairman = "อ.อรรถวิท ชังคมานนท์",
                Director1 = "ผศ.ก่องกาญจน์ ดุลยไชย",
                Director2 = "ผศ.ก่องกาญจน์ ดุลยไชย"
            },
            new Project
            {
                ProjectId = 7,
                ProjectName = "SecureManage : ระบบสำหรับบริหารจัดการ Pentest และ PoC ตามมาตรฐาน OWASP",
                WorkPlace = "บริษัท ไอเน็ต แมเนจ์ เซอร์วิสเซส จำกัด",
                Chairman = "ผศ.ดร.ปวีณ เขื่อนแก้ว",
                Director1 =  "อ.อรรถวิท ชังคมานนท์",
                Director2 = "อ.อรรถวิท ชังคมานนท์"
            },
            new Project
            {
                ProjectId = 8,
                ProjectName = "ระบบจัดการลำดับคิว",
                WorkPlace = "บริษัท ไอโซแคร์ ซิสเตมส์ จำกัด",
                Chairman = "ผศ.ดร.สนิท สิทธิ",
                Director1 =  "อ.อลงกต กองมณี",
                Director2 =  "ผศ.ภานุวัฒน์ เมฆะ", 
            },
            new Project
            {
                ProjectId = 9,
                ProjectName = "ระบบจัดการบริการดูแลและบำรุงรักษา",
                WorkPlace = "บริษัท ลูคัส สแทรททิจี จำกัด",
                Chairman = "อ.ดร.สมนึก สินธุปวน",
                Director1 =  "อ.อลงกต กองมณี",
                Director2 = "อ.อลงกต กองมณี",
            },
            new Project
            {
                ProjectId = 10,
                ProjectName = "ระบบสนับสนุนและรายงานผลธนาคารเวชกรรม",
                WorkPlace = "บริษัท ไอบิท แบงก์ จำกัด",
                Chairman = "ผศ.ภานุวัฒน์ เมฆะ",
                Director1 =  "อ.ดร.พยุงศักดิ์ เกษมสำรา",
                Director2 = "อ.ดร.พยุงศักดิ์ เกษมสำราญ",
            },
            new Project
            {
                ProjectId = 11,
                ProjectName = "บริษัท ควอนต้า ซินเนอร์จี้ จำกัด",
                WorkPlace = "อ.ดร.พยุงศักดิ์ เกษมสำราญ",
                Chairman = "ผศ.ภานุวัฒน์ เมฆะ",
                Director1 = "ผศ.ภานุวัฒน์ เมฆะ",
                Director2 = "ผศ.ภานุวัฒน์ เมฆะ",
            },
            new Project
            {
                ProjectId = 12,
                ProjectName = "ระบบจองห้องประชุมงานเพื่อเชื่อมต่อกับระบบบริหารทรัพยากรบุคคล",
                WorkPlace = "บริษัทดูดี อินดีด คอร์ปอเรชัน จำกัด",
                Chairman = "อ.ดร.พยุงศักดิ์ เกษมสำราญ",
                Director1 =  "อ.ดร.พยุงศักดิ์ เกษมสำรา",
                Director2 = "อ.ดร.พยุงศักดิ์ เกษมสำราญ",
            },
            new Project
            {
                ProjectId = 13,
                ProjectName = "SecureManage : ระบบสำหรับบริหารจัดการ Pentest และ PoC ตามมาตรฐาน OWASP",
                WorkPlace = "บริษัท ไอเน็ต แมเนจ์ เซอร์วิสเซส จำกัด",
                Chairman = "ผศ.ดร.ปวีณ เขื่อนแก้ว",
                Director1 =  "อ.อรรถวิท ชังคมานนท์",
                Director2 = "อ.อรรถวิท ชังคมานนท์"
            },
            new Project
            {
                ProjectId = 14,
                ProjectName = "ระบบการแจ้งเตือนการชำระเงินผ่านแอปพลิเคชั่นไลน์",
                WorkPlace = "บริษัทเพย์โซลูชั่น จำกัด (กรุงเทพ)",
                Chairman = "อ.อรรถวิท ชังคมานนท์",
                Director1 = "ผศ.ก่องกาญจน์ ดุลยไชย",
                Director2 = "ผศ.ก่องกาญจน์ ดุลยไชย"
            },
            new Project
            {
                ProjectId = 15,
                ProjectName = "ระบบสนับสนุนและรายงานผลธนาคารเวชกรรม",
                WorkPlace = "บริษัท ไอบิท แบงก์ จำกัด",
                Chairman = "ผศ.ภานุวัฒน์ เมฆะ",
                Director1 =  "อ.ดร.พยุงศักดิ์ เกษมสำรา",
                Director2 = "อ.ดร.พยุงศักดิ์ เกษมสำราญ",
            },
            new Project
            {
                ProjectId = 16,
                ProjectName = "ระบบจัดการลำดับคิว",
                WorkPlace = "บริษัท ไอโซแคร์ ซิสเตมส์ จำกัด",
                Chairman = "ผศ.ดร.สนิท สิทธิ",
                Director1 =  "อ.อลงกต กองมณี",
            },
            new Project
            {
                ProjectId = 17,
                ProjectName = "ระบบจัดการบริการดูแลและบำรุงรักษา",
                WorkPlace = "บริษัท ลูคัส สแทรททิจี จำกัด",
                Chairman = "อ.ดร.สมนึก สินธุปวน",
                Director1 =  "อ.อลงกต กองมณี",
                Director2 = "อ.อลงกต กองมณี", 
            },
            new Project
            {
                ProjectId = 18,
                ProjectName = "ระบบจองห้องประชุมงานเพื่อเชื่อมต่อกับระบบบริหารทรัพยากรบุคคล",
                WorkPlace = "บริษัทดูดี อินดีด คอร์ปอเรชัน จำกัด",
                Chairman = "อ.ดร.พยุงศักดิ์ เกษมสำราญ",
                Director1 =  "อ.ดร.พยุงศักดิ์ เกษมสำรา",
                Director2 = "อ.ดร.พยุงศักดิ์ เกษมสำราญ",
            },
            new Project
            {
                ProjectId = 19,
                ProjectName = "SecureManage : ระบบสำหรับบริหารจัดการ Pentest และ PoC ตามมาตรฐาน OWASP",
                WorkPlace = "บริษัท ไอเน็ต แมเนจ์ เซอร์วิสเซส จำกัด",
                Chairman = "ผศ.ดร.ปวีณ เขื่อนแก้ว",
                Director1 =  "อ.อรรถวิท ชังคมานนท์",
                Director2 = "อ.อรรถวิท ชังคมานนท์"
            },
            new Project
            {
                ProjectId = 20,
                ProjectName = "ระบบการแจ้งเตือนการชำระเงินผ่านแอปพลิเคชั่นไลน์",
                WorkPlace = "บริษัทเพย์โซลูชั่น จำกัด (กรุงเทพ)",
                Chairman = "อ.อรรถวิท ชังคมานนท์",
                Director1 = "ผศ.ก่องกาญจน์ ดุลยไชย",
                Director2 = "ผศ.ก่องกาญจน์ ดุลยไชย"
            },
        };

        return projects;
    }

        public List<Stage> GetStages()
        {
            var stages = new List<Stage>();
            int stageId = 1;
            for (int i = 1; i <= 20; i++)
                for (int j = 1; j <= 10; j++)
                {

                    if ((j + 3) == 5 || (j + 3) == 6 || (j + 3) == 8 || (j + 3) == 9)
                    {

                        var stage = new Stage
                        {
                            Id = stageId++,
                            ProjectId = i,
                            StageNumber = j + 3,
                            StageId = j + 3,
                            StageName = $"Stage {j} for Project {i}",
                            Status = "Not Started",
                            Deadline = DateTime.Now.AddMonths(j),
                            FilePath = $"File{j}.pdf"
                        };
                        stages.Add(stage);

                    }else{
                        var stage = new Stage
                        {
                            Id = stageId++,
                            ProjectId = i,
                            StageNumber = j + 3,
                            StageId = j + 3,
                            Deadline = DateTime.Now.AddMonths(j),
                        };
                        stages.Add(stage);
                    }

                }
            return stages;
        }

    }
}
