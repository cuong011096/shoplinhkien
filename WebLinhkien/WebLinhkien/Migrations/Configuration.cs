namespace WebLinhkien.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Helpers;
    using System.Web.Security;
    using WebLinhkien.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "WebLinhkien.ShopDatabaseContext";
        }

        protected override void Seed(WebLinhkien.Models.ShopDatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        //    List<Role> roles = new List<Role>()
        //    {
        //        new Role() { Name = "User"},
        //        new Role() {  Name = "Admin"}
        //    };

        //    List<Role> rolesDb = new List<Role>();

        //    foreach (var role in roles)
        //    {
        //        rolesDb.Add(context.Roles.Add(role));
        //    }
        //    Accounts taikhoan_1 = new Accounts()
        //    {
        //        Usernames = "abc",
        //        Passwords = Crypto.HashPassword("123"),
        //        NameUser = "Nguyễn Văn Cường",
        //        Gender = "Nam",

        //        Tel = "1234567890",
        //        Addresss = "asdasdsa",
        //        email = "cuongnguyen0196@gmail.com",
        //        IDRole = 1,
        //        createsdate = DateTime.Now,
        //        Roles = rolesDb.Last()
        //    };
        //    Accounts taikhoan_2 = new Accounts()
        //    {
        //        Usernames = "cuong",
        //        Passwords = Crypto.HashPassword("123"),
        //        NameUser = "Nguyễn Văn Cường",
        //        Gender = "Nam",

        //        Tel = "1234567890",
        //        Addresss = "asdasdsa",
        //        email = "cuongnguyen0196@gmail.com",
        //        IDRole = 2,
        //        createsdate = DateTime.Now,
        //        Roles = rolesDb.First()
        //    };

        //    context.Accounts.Add(taikhoan_1);
        //    context.Accounts.Add(taikhoan_2);

        //    Categories a = new Categories();
        //    a.Name = "Bộ vi xử lý";
        //    a.Type = "CPU";
        //    Categories b = new Categories();
        //    b.Name = "Card màn hình";
        //    b.Type = "VGA";
        //    Categories c = new Categories();
        //    c.Name = "Nguồn máy tính";
        //    c.Type = "PSU";
        //    Categories d = new Categories();
        //    d.Name = "Bộ nhớ trong";
        //    d.Type = "RAM";
        //    Categories e = new Categories();
        //    e.Name = "Ổ Cứng";
        //    e.Type = "STORAGE";
        //    Categories f = new Categories();
        //    f.Name = "Chuột máy tính";
        //    f.Type = "MOUSE";
 
        //    List<Products> products = new List<Products>()
        //    {
        //         new Products(){Product_Code="CPU", Name="CPU Intel Core i7-9700K (3.6 Upto 4.6GHz/ 8C8T/ 12MB/ Coffee Lake-R)", Image = "cpu1.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3000000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = a},
        //        new Products(){Product_Code="CPU", Name="CPU Intel Core i7-9700K (3.6 Upto 4.6GHz/ 8C8T/ 12MB/ Coffee Lake-R)", Image = "cpu2.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 4100000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = a},
        //        new Products(){Product_Code="CPU", Name="CPU Intel Core i7-9700K (3.6 Upto 4.6GHz/ 8C8T/ 12MB/ Coffee Lake-R)", Image = "cpu3.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3000000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = a},
        //        new Products(){Product_Code="CPU", Name="CPU Intel Core i7-9700K (3.6 Upto 4.6GHz/ 8C8T/ 12MB/ Coffee Lake-R)", Image = "cpu4.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3300000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = a},
        //        new Products(){Product_Code="CPU", Name="CPU Intel Core i7-9700K (3.6 Upto 4.6GHz/ 8C8T/ 12MB/ Coffee Lake-R)", Image = "cpu5.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3600000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = a},
        //        new Products(){Product_Code="CPU", Name="CPU Intel Core i7-9700K (3.6 Upto 4.6GHz/ 8C8T/ 12MB/ Coffee Lake-R)", Image = "cpu6.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3300000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = a},

        //        new Products(){Product_Code="CARD", Name="Card màn hình GIGABYTE GeForce GTX 1050Ti 4GB GDDR5 WindForce (GV-N105TWF2OC-4GD)", Image = "card1.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3000000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = b},
        //        new Products(){Product_Code="CARD", Name="Card màn hình GIGABYTE GeForce GTX 1050Ti 4GB GDDR5 WindForce (GV-N105TWF2OC-4GD)", Image = "card2.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3600000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = b},
        //        new Products(){Product_Code="CARD", Name="Card màn hình GIGABYTE GeForce GTX 1050Ti 4GB GDDR5 WindForce (GV-N105TWF2OC-4GD)", Image = "card3.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3900000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = b},
        //        new Products(){Product_Code="CARD", Name="Card màn hình GIGABYTE GeForce GTX 1050Ti 4GB GDDR5 WindForce (GV-N105TWF2OC-4GD)", Image = "card4.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 4000000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = b},
        //        new Products(){Product_Code="CARD", Name="Card màn hình GIGABYTE GeForce GTX 1050Ti 4GB GDDR5 WindForce (GV-N105TWF2OC-4GD)", Image = "card5.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3600000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = b},
        //        new Products(){Product_Code="CARD", Name="Card màn hình GIGABYTE GeForce GTX 1050Ti 4GB GDDR5 WindForce (GV-N105TWF2OC-4GD)", Image = "card6.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3400000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = b},

        //        new Products(){Product_Code="PSU", Name="Nguồn máy tính Raidmax RX-400XT - 400W)", Image = "psu1.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3000000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = c},
        //        new Products(){Product_Code="PSU", Name="Nguồn máy tính Raidmax RX-400XT - 400W", Image = "psu2.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 2900000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = c},
        //        new Products(){Product_Code="PSU", Name="Nguồn máy tính Raidmax RX-400XT - 400W", Image = "psu3.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3400000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = c},
        //        new Products(){Product_Code="PSU", Name="Nguồn máy tính Raidmax RX-400XT - 400W", Image = "psu4.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3600000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = c},
        //        new Products(){Product_Code="PSU", Name="Nguồn máy tính Raidmax RX-400XT - 400W", Image = "psu5.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3300000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = c},
        //        new Products(){Product_Code="PSU", Name="Nguồn máy tính Raidmax RX-400XT - 400W", Image = "psu6.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 4300000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = c},

        //        new Products(){Product_Code="RAM", Name="RAM DDR4 Corsair Vengeance LPX 8GB (2666) CMK8GX4M1A2666C16", Image = "ram1.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 2700000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = d},
        //        new Products(){Product_Code="RAM", Name="RAM DDR4 Corsair Vengeance LPX 8GB (2666) CMK8GX4M1A2666C16", Image = "ram2.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3600000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = d},
        //        new Products(){Product_Code="RAM", Name="RAM DDR4 Corsair Vengeance LPX 8GB (2666) CMK8GX4M1A2666C16", Image = "ram3.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3800000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = d},
        //        new Products(){Product_Code="RAM", Name="RAM DDR4 Corsair Vengeance LPX 8GB (2666) CMK8GX4M1A2666C16", Image = "ram4.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 4300000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = d},
        //        new Products(){Product_Code="RAM", Name="RAM DDR4 Corsair Vengeance LPX 8GB (2666) CMK8GX4M1A2666C16", Image = "ram5.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3300000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = d},
        //        new Products(){Product_Code="RAM", Name="RAM DDR4 Corsair Vengeance LPX 8GB (2666) CMK8GX4M1A2666C16", Image = "ram6.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 2900000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = d},

        //        new Products(){Product_Code="STORAGE", Name="Ổ cứng HDD IBM 600GB 2.5 SAS 3 - 00WG690", Image = "ocung1.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3700000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = e},
        //        new Products(){Product_Code="STORAGE", Name="Ổ cứng HDD IBM 600GB 2.5 SAS 3 - 00WG690", Image = "ocung2.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 5500000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = e},
        //        new Products(){Product_Code="STORAGE", Name="Ổ cứng HDD IBM 600GB 2.5 SAS 3 - 00WG690", Image = "ocung3.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 4000000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = e},
        //        new Products(){Product_Code="STORAGE", Name="Ổ cứng HDD IBM 600GB 2.5 SAS 3 - 00WG690", Image = "ocung4.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3400000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = e},
        //        new Products(){Product_Code="STORAGE", Name="Ổ cứng HDD IBM 600GB 2.5 SAS 3 - 00WG690", Image = "ocung5.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 2500000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = e},
        //        new Products(){Product_Code="STORAGE", Name="Ổ cứng HDD IBM 600GB 2.5 SAS 3 - 00WG690", Image = "ocung6.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 2000000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = e},

        //        new Products(){Product_Code="MOUSE", Name="Chuột máy tính Sumtax Fox-2", Image = "chuot1.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3300000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = f},
        //        new Products(){Product_Code="MOUSE", Name="Chuột máy tính Sumtax Fox-2", Image = "chuot2.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 4600000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = f},
        //        new Products(){Product_Code="MOUSE", Name="Chuột máy tính Sumtax Fox-2", Image = "chuot3.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 3500000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = f},
        //        new Products(){Product_Code="MOUSE", Name="Chuột máy tính Sumtax Fox-2", Image = "chuot4.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 4000000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = f},
        //        new Products(){Product_Code="MOUSE", Name="Chuột máy tính Sumtax Fox-2", Image = "chuot5.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 5000000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = f},
        //        new Products(){Product_Code="MOUSE", Name="Chuột máy tính Sumtax Fox-2", Image = "chuot6.jpg",
        //             Descriptions ="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //            Parameter="Socket: LGA 1151-v2 , Intel Core thế hệ thứ 9. Tốc độ xử lý: 3.6 GHz - 4.9 GHz(8 nhân, 8 luồng).Bộ nhớ đệm: 12MB. Đồ họa tích hợp: Intel UHD Graphics 630",
        //             Quanlity = 10,Price = 5000000, Hot="Hot", Createdates = DateTime.Now, Datesupdate = DateTime.Now,viewcount = 0 , Categories = f},

        //    };
        //    List<Products> ProductsAfterInsert = new List<Products>();
        //    foreach (var product in products)
        //    {
        //        ProductsAfterInsert.Add(context.Products.Add(product));
        //    }
        //    TypeBlog m = new TypeBlog();
        //    m.Name = "vệ sinh thùng cpu";

        //    TypeBlog n = new TypeBlog();
        //    n.Name = "cách thay thanh ram";

        //    TypeBlog p = new TypeBlog();
        //    p.Name = "nên sử dụng loại chuột nào tốt";
        //    List<Blog> blogs = new List<Blog>()
        //    {
        //    new Blog()
        //    {
        //        Title = "cách tản nhiệt cpu hiệu quả nhất",
        //        CreateDay = DateTime.Now,
        //        image1 = "cpu5.jpg",
        //        HeadBlog = "Nhiệt độ CPU quá cao là tình trạng rất phổ biến đối với PC/laptop hiện nay, gây ra khá nhiều phiền toái và lo ngại về tuổi thọ của máy tính cho người dùng. Dấu hiệu rõ ràng nhất để nhận biết CPU bị quá nhiệt (overheating) là máy tự động tắt ngúm sau khi chạy một ứng dụng hoặc game nặng nào đó!",
        //        BodyBlog = "Nhiệt độ quá cao chưa hẳn đã gây hại ngay cho CPU, tuy nhiên nếu để tình trạng này diễn ra trong thời gian dài, chắc chắn nó sẽ khiến PC nhà bạn giảm tuổi thọ và dễ hỏng hóc đi trông thấy.<br> Cụ thể, đối với nền tảng desktop (máy tính để bàn), khi CPU chạy ở chế độ không tải, nhiệt độ con chip quá nóng hoàn toàn không phải là vấn đề đáng lo ngại nếu PC vẫn hoạt động ổn định. Bởi nếu CPU của bạn đạt ngưỡng nhiệt độ nguy hiểm, cơ chế bảo vệ phần cứng sẽ được kích hoạt và tự động tắt nguồn hoặc giảm hiệu năng của CPU, trước khi nhiệt độ cao gây ra bất kỳ hỏng hóc nào cho các thiết bị bên trong của bạn. <br>Vậy với laptop thì sao? Nền tảng thiết bị này chắc chắn phức tạp hơn desktop, khi việc làm mát CPU và GPU đều bó hẹp trong một không gian nhỏ hẹp. Tuy nhiên hầu hết các laptop hiện đại cũng đều được trang bị cơ chế phòng thủ nhiệt. Khi phát hiện nhiệt độ quá cao, máy sẽ tự động tắt và ngăn mọi nguy hại cho CPU bên trong laptop. Trước đó, bạn cũng sẽ cảm nhận rõ hiệu năng của giảm xuống do cơ chế phòng thủ trên đã giảm xung của CPU/GPU để đưa nhiệt độ chip xử lý xuống tới mức an toàn.<br>Vì vậy, nếu CPU của bạn có bị quá nhiệt đi chăng nữa, thiết bị vẫn có cách tự bảo vệ cho chính nó và bạn không cần quá lo lắng. Điều đáng lưu tâm ở đây, nếu để CPU bị quá nhiệt trong thời gian dài sẽ ảnh hưởng lớn tới trải nghiệm sử dụng thiết bị của bạn, gây giảm tuổi thọ cho các phần cứng quan trọng như ổ cứng, RAM và bảng mạch.",
        //        FootBlog = "Để biết được nhiệt độ trên thiết bị là bao nhiêu, chúng ta có thể dễ dàng sử dụng rất nhiều những ứng dụng có sẵn như HWMonitor hoặc HWiNFO 64, chạy những phần mềm này song song khi chơi game hoặc khi dùng các ứng dụng nặng để kiểm tra nhiệt độ lúc PC chạy ở công suất cao.</ p > Nếu CPU ở chế độ không tải (chạy các tác vụ nhẹ) nhưng nhiệt độ vẫn đạt ngưỡng 80 độ C trở lên, đây là lúc bạn nên đi kiểm tra, vệ sinh lại máy càng sớm càng tốt. Nguyên nhân có thể do quạt tản nhiệt hoạt động kém, kem tản nhiệt đã hết tác dụng, lỗ thoát nhiệt dính bụi, v.v... Nên nhớ mốc nhiệt độ lý tưởng nhất của CPU trên desktop nên rơi vào khoảng từ dưới 50 tới 70°C.Còn đối với những trường hợp ép xung (Overclocking), hãy thận trọng vì theo lý thuyết, nhiệt độ lúc này có thể lên tới 90°C. Mặc dù vẫn nằm trong khung nhiệt độ an toàn, chưa vượt quá ngưỡng 105 - 110°C đối với hầu hết các mẫu CPU, tuy nhiên đừng quá lạm dụng và sử dụng máy ở nhiệt độ quá cao trong thời gian dài, bạn sẽ dễ dàng khiến thiết bị của mình bị giảm tuổi thọ, hỏng hóc lúc nào không hay. Lời khuyên ở đây, nếu bạn ép xung và duy trì CPU ở nhiệt độ cao, hãy cố gắng để mức nhiệt dưới 80°C, cao nhất không nên vượt quá 85°C"
        //        , Type = "Cpu"
        //    },
        //    new Blog()
        //    {
        //        Title = "cách tản nhiệt cpu hiệu quả nhất",
        //        CreateDay = DateTime.Now,
        //        image1 = "cpu4.jpg",
        //        HeadBlog = "Nhiệt độ CPU quá cao là tình trạng rất phổ biến đối với PC/laptop hiện nay, gây ra khá nhiều phiền toái và lo ngại về tuổi thọ của máy tính cho người dùng. Dấu hiệu rõ ràng nhất để nhận biết CPU bị quá nhiệt (overheating) là máy tự động tắt ngúm sau khi chạy một ứng dụng hoặc game nặng nào đó!",
        //        BodyBlog = "Nhiệt độ quá cao chưa hẳn đã gây hại ngay cho CPU, tuy nhiên nếu để tình trạng này diễn ra trong thời gian dài, chắc chắn nó sẽ khiến PC nhà bạn giảm tuổi thọ và dễ hỏng hóc đi trông thấy.<br> Cụ thể, đối với nền tảng desktop (máy tính để bàn), khi CPU chạy ở chế độ không tải, nhiệt độ con chip quá nóng hoàn toàn không phải là vấn đề đáng lo ngại nếu PC vẫn hoạt động ổn định. Bởi nếu CPU của bạn đạt ngưỡng nhiệt độ nguy hiểm, cơ chế bảo vệ phần cứng sẽ được kích hoạt và tự động tắt nguồn hoặc giảm hiệu năng của CPU, trước khi nhiệt độ cao gây ra bất kỳ hỏng hóc nào cho các thiết bị bên trong của bạn. <br>Vậy với laptop thì sao? Nền tảng thiết bị này chắc chắn phức tạp hơn desktop, khi việc làm mát CPU và GPU đều bó hẹp trong một không gian nhỏ hẹp. Tuy nhiên hầu hết các laptop hiện đại cũng đều được trang bị cơ chế phòng thủ nhiệt. Khi phát hiện nhiệt độ quá cao, máy sẽ tự động tắt và ngăn mọi nguy hại cho CPU bên trong laptop. Trước đó, bạn cũng sẽ cảm nhận rõ hiệu năng của giảm xuống do cơ chế phòng thủ trên đã giảm xung của CPU/GPU để đưa nhiệt độ chip xử lý xuống tới mức an toàn.<br>Vì vậy, nếu CPU của bạn có bị quá nhiệt đi chăng nữa, thiết bị vẫn có cách tự bảo vệ cho chính nó và bạn không cần quá lo lắng. Điều đáng lưu tâm ở đây, nếu để CPU bị quá nhiệt trong thời gian dài sẽ ảnh hưởng lớn tới trải nghiệm sử dụng thiết bị của bạn, gây giảm tuổi thọ cho các phần cứng quan trọng như ổ cứng, RAM và bảng mạch.",
        //        FootBlog = "Để biết được nhiệt độ trên thiết bị là bao nhiêu, chúng ta có thể dễ dàng sử dụng rất nhiều những ứng dụng có sẵn như HWMonitor hoặc HWiNFO 64, chạy những phần mềm này song song khi chơi game hoặc khi dùng các ứng dụng nặng để kiểm tra nhiệt độ lúc PC chạy ở công suất cao.</ p > Nếu CPU ở chế độ không tải (chạy các tác vụ nhẹ) nhưng nhiệt độ vẫn đạt ngưỡng 80 độ C trở lên, đây là lúc bạn nên đi kiểm tra, vệ sinh lại máy càng sớm càng tốt. Nguyên nhân có thể do quạt tản nhiệt hoạt động kém, kem tản nhiệt đã hết tác dụng, lỗ thoát nhiệt dính bụi, v.v... Nên nhớ mốc nhiệt độ lý tưởng nhất của CPU trên desktop nên rơi vào khoảng từ dưới 50 tới 70°C.Còn đối với những trường hợp ép xung (Overclocking), hãy thận trọng vì theo lý thuyết, nhiệt độ lúc này có thể lên tới 90°C. Mặc dù vẫn nằm trong khung nhiệt độ an toàn, chưa vượt quá ngưỡng 105 - 110°C đối với hầu hết các mẫu CPU, tuy nhiên đừng quá lạm dụng và sử dụng máy ở nhiệt độ quá cao trong thời gian dài, bạn sẽ dễ dàng khiến thiết bị của mình bị giảm tuổi thọ, hỏng hóc lúc nào không hay. Lời khuyên ở đây, nếu bạn ép xung và duy trì CPU ở nhiệt độ cao, hãy cố gắng để mức nhiệt dưới 80°C, cao nhất không nên vượt quá 85°C"
        //        ,Type = "Cpu"
        //    },
        //    new Blog()
        //    {
        //        Title = "cách tản nhiệt cpu hiệu quả nhất",
        //        CreateDay = DateTime.Now,
        //        image1 = "cpu6.jpg",
        //        HeadBlog = "Nhiệt độ CPU quá cao là tình trạng rất phổ biến đối với PC/laptop hiện nay, gây ra khá nhiều phiền toái và lo ngại về tuổi thọ của máy tính cho người dùng. Dấu hiệu rõ ràng nhất để nhận biết CPU bị quá nhiệt (overheating) là máy tự động tắt ngúm sau khi chạy một ứng dụng hoặc game nặng nào đó!",
        //        BodyBlog = "Nhiệt độ quá cao chưa hẳn đã gây hại ngay cho CPU, tuy nhiên nếu để tình trạng này diễn ra trong thời gian dài, chắc chắn nó sẽ khiến PC nhà bạn giảm tuổi thọ và dễ hỏng hóc đi trông thấy.<br> Cụ thể, đối với nền tảng desktop (máy tính để bàn), khi CPU chạy ở chế độ không tải, nhiệt độ con chip quá nóng hoàn toàn không phải là vấn đề đáng lo ngại nếu PC vẫn hoạt động ổn định. Bởi nếu CPU của bạn đạt ngưỡng nhiệt độ nguy hiểm, cơ chế bảo vệ phần cứng sẽ được kích hoạt và tự động tắt nguồn hoặc giảm hiệu năng của CPU, trước khi nhiệt độ cao gây ra bất kỳ hỏng hóc nào cho các thiết bị bên trong của bạn. <br>Vậy với laptop thì sao? Nền tảng thiết bị này chắc chắn phức tạp hơn desktop, khi việc làm mát CPU và GPU đều bó hẹp trong một không gian nhỏ hẹp. Tuy nhiên hầu hết các laptop hiện đại cũng đều được trang bị cơ chế phòng thủ nhiệt. Khi phát hiện nhiệt độ quá cao, máy sẽ tự động tắt và ngăn mọi nguy hại cho CPU bên trong laptop. Trước đó, bạn cũng sẽ cảm nhận rõ hiệu năng của giảm xuống do cơ chế phòng thủ trên đã giảm xung của CPU/GPU để đưa nhiệt độ chip xử lý xuống tới mức an toàn.<br>Vì vậy, nếu CPU của bạn có bị quá nhiệt đi chăng nữa, thiết bị vẫn có cách tự bảo vệ cho chính nó và bạn không cần quá lo lắng. Điều đáng lưu tâm ở đây, nếu để CPU bị quá nhiệt trong thời gian dài sẽ ảnh hưởng lớn tới trải nghiệm sử dụng thiết bị của bạn, gây giảm tuổi thọ cho các phần cứng quan trọng như ổ cứng, RAM và bảng mạch.",
        //        FootBlog = "Để biết được nhiệt độ trên thiết bị là bao nhiêu, chúng ta có thể dễ dàng sử dụng rất nhiều những ứng dụng có sẵn như HWMonitor hoặc HWiNFO 64, chạy những phần mềm này song song khi chơi game hoặc khi dùng các ứng dụng nặng để kiểm tra nhiệt độ lúc PC chạy ở công suất cao.</ p > Nếu CPU ở chế độ không tải (chạy các tác vụ nhẹ) nhưng nhiệt độ vẫn đạt ngưỡng 80 độ C trở lên, đây là lúc bạn nên đi kiểm tra, vệ sinh lại máy càng sớm càng tốt. Nguyên nhân có thể do quạt tản nhiệt hoạt động kém, kem tản nhiệt đã hết tác dụng, lỗ thoát nhiệt dính bụi, v.v... Nên nhớ mốc nhiệt độ lý tưởng nhất của CPU trên desktop nên rơi vào khoảng từ dưới 50 tới 70°C.Còn đối với những trường hợp ép xung (Overclocking), hãy thận trọng vì theo lý thuyết, nhiệt độ lúc này có thể lên tới 90°C. Mặc dù vẫn nằm trong khung nhiệt độ an toàn, chưa vượt quá ngưỡng 105 - 110°C đối với hầu hết các mẫu CPU, tuy nhiên đừng quá lạm dụng và sử dụng máy ở nhiệt độ quá cao trong thời gian dài, bạn sẽ dễ dàng khiến thiết bị của mình bị giảm tuổi thọ, hỏng hóc lúc nào không hay. Lời khuyên ở đây, nếu bạn ép xung và duy trì CPU ở nhiệt độ cao, hãy cố gắng để mức nhiệt dưới 80°C, cao nhất không nên vượt quá 85°C"
        //       , Type = "Cpu"
        //    },
        //    new Blog()
        //    {
        //        Title = "cách lắp ram hiệu quả nhất",
        //        CreateDay = DateTime.Now,
        //        image1 = "ram4.jpg",
        //        HeadBlog = "Nhiệt độ CPU quá cao là tình trạng rất phổ biến đối với PC/laptop hiện nay, gây ra khá nhiều phiền toái và lo ngại về tuổi thọ của máy tính cho người dùng. Dấu hiệu rõ ràng nhất để nhận biết CPU bị quá nhiệt (overheating) là máy tự động tắt ngúm sau khi chạy một ứng dụng hoặc game nặng nào đó!",
        //        BodyBlog = "Nhiệt độ quá cao chưa hẳn đã gây hại ngay cho CPU, tuy nhiên nếu để tình trạng này diễn ra trong thời gian dài, chắc chắn nó sẽ khiến PC nhà bạn giảm tuổi thọ và dễ hỏng hóc đi trông thấy.<br> Cụ thể, đối với nền tảng desktop (máy tính để bàn), khi CPU chạy ở chế độ không tải, nhiệt độ con chip quá nóng hoàn toàn không phải là vấn đề đáng lo ngại nếu PC vẫn hoạt động ổn định. Bởi nếu CPU của bạn đạt ngưỡng nhiệt độ nguy hiểm, cơ chế bảo vệ phần cứng sẽ được kích hoạt và tự động tắt nguồn hoặc giảm hiệu năng của CPU, trước khi nhiệt độ cao gây ra bất kỳ hỏng hóc nào cho các thiết bị bên trong của bạn. <br>Vậy với laptop thì sao? Nền tảng thiết bị này chắc chắn phức tạp hơn desktop, khi việc làm mát CPU và GPU đều bó hẹp trong một không gian nhỏ hẹp. Tuy nhiên hầu hết các laptop hiện đại cũng đều được trang bị cơ chế phòng thủ nhiệt. Khi phát hiện nhiệt độ quá cao, máy sẽ tự động tắt và ngăn mọi nguy hại cho CPU bên trong laptop. Trước đó, bạn cũng sẽ cảm nhận rõ hiệu năng của giảm xuống do cơ chế phòng thủ trên đã giảm xung của CPU/GPU để đưa nhiệt độ chip xử lý xuống tới mức an toàn.<br>Vì vậy, nếu CPU của bạn có bị quá nhiệt đi chăng nữa, thiết bị vẫn có cách tự bảo vệ cho chính nó và bạn không cần quá lo lắng. Điều đáng lưu tâm ở đây, nếu để CPU bị quá nhiệt trong thời gian dài sẽ ảnh hưởng lớn tới trải nghiệm sử dụng thiết bị của bạn, gây giảm tuổi thọ cho các phần cứng quan trọng như ổ cứng, RAM và bảng mạch.",
        //        FootBlog = "Để biết được nhiệt độ trên thiết bị là bao nhiêu, chúng ta có thể dễ dàng sử dụng rất nhiều những ứng dụng có sẵn như HWMonitor hoặc HWiNFO 64, chạy những phần mềm này song song khi chơi game hoặc khi dùng các ứng dụng nặng để kiểm tra nhiệt độ lúc PC chạy ở công suất cao.</ p > Nếu CPU ở chế độ không tải (chạy các tác vụ nhẹ) nhưng nhiệt độ vẫn đạt ngưỡng 80 độ C trở lên, đây là lúc bạn nên đi kiểm tra, vệ sinh lại máy càng sớm càng tốt. Nguyên nhân có thể do quạt tản nhiệt hoạt động kém, kem tản nhiệt đã hết tác dụng, lỗ thoát nhiệt dính bụi, v.v... Nên nhớ mốc nhiệt độ lý tưởng nhất của CPU trên desktop nên rơi vào khoảng từ dưới 50 tới 70°C.Còn đối với những trường hợp ép xung (Overclocking), hãy thận trọng vì theo lý thuyết, nhiệt độ lúc này có thể lên tới 90°C. Mặc dù vẫn nằm trong khung nhiệt độ an toàn, chưa vượt quá ngưỡng 105 - 110°C đối với hầu hết các mẫu CPU, tuy nhiên đừng quá lạm dụng và sử dụng máy ở nhiệt độ quá cao trong thời gian dài, bạn sẽ dễ dàng khiến thiết bị của mình bị giảm tuổi thọ, hỏng hóc lúc nào không hay. Lời khuyên ở đây, nếu bạn ép xung và duy trì CPU ở nhiệt độ cao, hãy cố gắng để mức nhiệt dưới 80°C, cao nhất không nên vượt quá 85°C"
        //       , Type = "Ram"
        //    },
        //    new Blog()
        //    {
        //        Title = "cách lắp ram hiệu quả nhất",
        //        CreateDay = DateTime.Now,
        //        image1 = "ram5.jpg",
        //        HeadBlog = "Nhiệt độ CPU quá cao là tình trạng rất phổ biến đối với PC/laptop hiện nay, gây ra khá nhiều phiền toái và lo ngại về tuổi thọ của máy tính cho người dùng. Dấu hiệu rõ ràng nhất để nhận biết CPU bị quá nhiệt (overheating) là máy tự động tắt ngúm sau khi chạy một ứng dụng hoặc game nặng nào đó!",
        //        BodyBlog = "Nhiệt độ quá cao chưa hẳn đã gây hại ngay cho CPU, tuy nhiên nếu để tình trạng này diễn ra trong thời gian dài, chắc chắn nó sẽ khiến PC nhà bạn giảm tuổi thọ và dễ hỏng hóc đi trông thấy.<br> Cụ thể, đối với nền tảng desktop (máy tính để bàn), khi CPU chạy ở chế độ không tải, nhiệt độ con chip quá nóng hoàn toàn không phải là vấn đề đáng lo ngại nếu PC vẫn hoạt động ổn định. Bởi nếu CPU của bạn đạt ngưỡng nhiệt độ nguy hiểm, cơ chế bảo vệ phần cứng sẽ được kích hoạt và tự động tắt nguồn hoặc giảm hiệu năng của CPU, trước khi nhiệt độ cao gây ra bất kỳ hỏng hóc nào cho các thiết bị bên trong của bạn. <br>Vậy với laptop thì sao? Nền tảng thiết bị này chắc chắn phức tạp hơn desktop, khi việc làm mát CPU và GPU đều bó hẹp trong một không gian nhỏ hẹp. Tuy nhiên hầu hết các laptop hiện đại cũng đều được trang bị cơ chế phòng thủ nhiệt. Khi phát hiện nhiệt độ quá cao, máy sẽ tự động tắt và ngăn mọi nguy hại cho CPU bên trong laptop. Trước đó, bạn cũng sẽ cảm nhận rõ hiệu năng của giảm xuống do cơ chế phòng thủ trên đã giảm xung của CPU/GPU để đưa nhiệt độ chip xử lý xuống tới mức an toàn.<br>Vì vậy, nếu CPU của bạn có bị quá nhiệt đi chăng nữa, thiết bị vẫn có cách tự bảo vệ cho chính nó và bạn không cần quá lo lắng. Điều đáng lưu tâm ở đây, nếu để CPU bị quá nhiệt trong thời gian dài sẽ ảnh hưởng lớn tới trải nghiệm sử dụng thiết bị của bạn, gây giảm tuổi thọ cho các phần cứng quan trọng như ổ cứng, RAM và bảng mạch.",
        //        FootBlog = "Để biết được nhiệt độ trên thiết bị là bao nhiêu, chúng ta có thể dễ dàng sử dụng rất nhiều những ứng dụng có sẵn như HWMonitor hoặc HWiNFO 64, chạy những phần mềm này song song khi chơi game hoặc khi dùng các ứng dụng nặng để kiểm tra nhiệt độ lúc PC chạy ở công suất cao.</ p > Nếu CPU ở chế độ không tải (chạy các tác vụ nhẹ) nhưng nhiệt độ vẫn đạt ngưỡng 80 độ C trở lên, đây là lúc bạn nên đi kiểm tra, vệ sinh lại máy càng sớm càng tốt. Nguyên nhân có thể do quạt tản nhiệt hoạt động kém, kem tản nhiệt đã hết tác dụng, lỗ thoát nhiệt dính bụi, v.v... Nên nhớ mốc nhiệt độ lý tưởng nhất của CPU trên desktop nên rơi vào khoảng từ dưới 50 tới 70°C.Còn đối với những trường hợp ép xung (Overclocking), hãy thận trọng vì theo lý thuyết, nhiệt độ lúc này có thể lên tới 90°C. Mặc dù vẫn nằm trong khung nhiệt độ an toàn, chưa vượt quá ngưỡng 105 - 110°C đối với hầu hết các mẫu CPU, tuy nhiên đừng quá lạm dụng và sử dụng máy ở nhiệt độ quá cao trong thời gian dài, bạn sẽ dễ dàng khiến thiết bị của mình bị giảm tuổi thọ, hỏng hóc lúc nào không hay. Lời khuyên ở đây, nếu bạn ép xung và duy trì CPU ở nhiệt độ cao, hãy cố gắng để mức nhiệt dưới 80°C, cao nhất không nên vượt quá 85°C"
        //        , Type = "Ram"
        //    },
        //    new Blog()
        //    {
        //        Title = "cách lắp ram hiệu quả nhất",
        //        CreateDay = DateTime.Now,
        //        image1 = "ram6.jpg",
        //        HeadBlog = "Nhiệt độ CPU quá cao là tình trạng rất phổ biến đối với PC/laptop hiện nay, gây ra khá nhiều phiền toái và lo ngại về tuổi thọ của máy tính cho người dùng. Dấu hiệu rõ ràng nhất để nhận biết CPU bị quá nhiệt (overheating) là máy tự động tắt ngúm sau khi chạy một ứng dụng hoặc game nặng nào đó!",
        //        BodyBlog = "Nhiệt độ quá cao chưa hẳn đã gây hại ngay cho CPU, tuy nhiên nếu để tình trạng này diễn ra trong thời gian dài, chắc chắn nó sẽ khiến PC nhà bạn giảm tuổi thọ và dễ hỏng hóc đi trông thấy.<br> Cụ thể, đối với nền tảng desktop (máy tính để bàn), khi CPU chạy ở chế độ không tải, nhiệt độ con chip quá nóng hoàn toàn không phải là vấn đề đáng lo ngại nếu PC vẫn hoạt động ổn định. Bởi nếu CPU của bạn đạt ngưỡng nhiệt độ nguy hiểm, cơ chế bảo vệ phần cứng sẽ được kích hoạt và tự động tắt nguồn hoặc giảm hiệu năng của CPU, trước khi nhiệt độ cao gây ra bất kỳ hỏng hóc nào cho các thiết bị bên trong của bạn. <br>Vậy với laptop thì sao? Nền tảng thiết bị này chắc chắn phức tạp hơn desktop, khi việc làm mát CPU và GPU đều bó hẹp trong một không gian nhỏ hẹp. Tuy nhiên hầu hết các laptop hiện đại cũng đều được trang bị cơ chế phòng thủ nhiệt. Khi phát hiện nhiệt độ quá cao, máy sẽ tự động tắt và ngăn mọi nguy hại cho CPU bên trong laptop. Trước đó, bạn cũng sẽ cảm nhận rõ hiệu năng của giảm xuống do cơ chế phòng thủ trên đã giảm xung của CPU/GPU để đưa nhiệt độ chip xử lý xuống tới mức an toàn.<br>Vì vậy, nếu CPU của bạn có bị quá nhiệt đi chăng nữa, thiết bị vẫn có cách tự bảo vệ cho chính nó và bạn không cần quá lo lắng. Điều đáng lưu tâm ở đây, nếu để CPU bị quá nhiệt trong thời gian dài sẽ ảnh hưởng lớn tới trải nghiệm sử dụng thiết bị của bạn, gây giảm tuổi thọ cho các phần cứng quan trọng như ổ cứng, RAM và bảng mạch.",
        //        FootBlog = "Để biết được nhiệt độ trên thiết bị là bao nhiêu, chúng ta có thể dễ dàng sử dụng rất nhiều những ứng dụng có sẵn như HWMonitor hoặc HWiNFO 64, chạy những phần mềm này song song khi chơi game hoặc khi dùng các ứng dụng nặng để kiểm tra nhiệt độ lúc PC chạy ở công suất cao.</ p > Nếu CPU ở chế độ không tải (chạy các tác vụ nhẹ) nhưng nhiệt độ vẫn đạt ngưỡng 80 độ C trở lên, đây là lúc bạn nên đi kiểm tra, vệ sinh lại máy càng sớm càng tốt. Nguyên nhân có thể do quạt tản nhiệt hoạt động kém, kem tản nhiệt đã hết tác dụng, lỗ thoát nhiệt dính bụi, v.v... Nên nhớ mốc nhiệt độ lý tưởng nhất của CPU trên desktop nên rơi vào khoảng từ dưới 50 tới 70°C.Còn đối với những trường hợp ép xung (Overclocking), hãy thận trọng vì theo lý thuyết, nhiệt độ lúc này có thể lên tới 90°C. Mặc dù vẫn nằm trong khung nhiệt độ an toàn, chưa vượt quá ngưỡng 105 - 110°C đối với hầu hết các mẫu CPU, tuy nhiên đừng quá lạm dụng và sử dụng máy ở nhiệt độ quá cao trong thời gian dài, bạn sẽ dễ dàng khiến thiết bị của mình bị giảm tuổi thọ, hỏng hóc lúc nào không hay. Lời khuyên ở đây, nếu bạn ép xung và duy trì CPU ở nhiệt độ cao, hãy cố gắng để mức nhiệt dưới 80°C, cao nhất không nên vượt quá 85°C"
        //        , Type = "Ram"
        //    },
        //    new Blog()
        //    {
        //        Title = "cách dùng chuột tốt nhất",
        //        CreateDay = DateTime.Now,
        //        image1 = "chuot4.jpg",
        //        HeadBlog = "Nhiệt độ CPU quá cao là tình trạng rất phổ biến đối với PC/laptop hiện nay, gây ra khá nhiều phiền toái và lo ngại về tuổi thọ của máy tính cho người dùng. Dấu hiệu rõ ràng nhất để nhận biết CPU bị quá nhiệt (overheating) là máy tự động tắt ngúm sau khi chạy một ứng dụng hoặc game nặng nào đó!",
        //        BodyBlog = "Nhiệt độ quá cao chưa hẳn đã gây hại ngay cho CPU, tuy nhiên nếu để tình trạng này diễn ra trong thời gian dài, chắc chắn nó sẽ khiến PC nhà bạn giảm tuổi thọ và dễ hỏng hóc đi trông thấy.<br> Cụ thể, đối với nền tảng desktop (máy tính để bàn), khi CPU chạy ở chế độ không tải, nhiệt độ con chip quá nóng hoàn toàn không phải là vấn đề đáng lo ngại nếu PC vẫn hoạt động ổn định. Bởi nếu CPU của bạn đạt ngưỡng nhiệt độ nguy hiểm, cơ chế bảo vệ phần cứng sẽ được kích hoạt và tự động tắt nguồn hoặc giảm hiệu năng của CPU, trước khi nhiệt độ cao gây ra bất kỳ hỏng hóc nào cho các thiết bị bên trong của bạn. <br>Vậy với laptop thì sao? Nền tảng thiết bị này chắc chắn phức tạp hơn desktop, khi việc làm mát CPU và GPU đều bó hẹp trong một không gian nhỏ hẹp. Tuy nhiên hầu hết các laptop hiện đại cũng đều được trang bị cơ chế phòng thủ nhiệt. Khi phát hiện nhiệt độ quá cao, máy sẽ tự động tắt và ngăn mọi nguy hại cho CPU bên trong laptop. Trước đó, bạn cũng sẽ cảm nhận rõ hiệu năng của giảm xuống do cơ chế phòng thủ trên đã giảm xung của CPU/GPU để đưa nhiệt độ chip xử lý xuống tới mức an toàn.<br>Vì vậy, nếu CPU của bạn có bị quá nhiệt đi chăng nữa, thiết bị vẫn có cách tự bảo vệ cho chính nó và bạn không cần quá lo lắng. Điều đáng lưu tâm ở đây, nếu để CPU bị quá nhiệt trong thời gian dài sẽ ảnh hưởng lớn tới trải nghiệm sử dụng thiết bị của bạn, gây giảm tuổi thọ cho các phần cứng quan trọng như ổ cứng, RAM và bảng mạch.",
        //        FootBlog = "Để biết được nhiệt độ trên thiết bị là bao nhiêu, chúng ta có thể dễ dàng sử dụng rất nhiều những ứng dụng có sẵn như HWMonitor hoặc HWiNFO 64, chạy những phần mềm này song song khi chơi game hoặc khi dùng các ứng dụng nặng để kiểm tra nhiệt độ lúc PC chạy ở công suất cao.</ p > Nếu CPU ở chế độ không tải (chạy các tác vụ nhẹ) nhưng nhiệt độ vẫn đạt ngưỡng 80 độ C trở lên, đây là lúc bạn nên đi kiểm tra, vệ sinh lại máy càng sớm càng tốt. Nguyên nhân có thể do quạt tản nhiệt hoạt động kém, kem tản nhiệt đã hết tác dụng, lỗ thoát nhiệt dính bụi, v.v... Nên nhớ mốc nhiệt độ lý tưởng nhất của CPU trên desktop nên rơi vào khoảng từ dưới 50 tới 70°C.Còn đối với những trường hợp ép xung (Overclocking), hãy thận trọng vì theo lý thuyết, nhiệt độ lúc này có thể lên tới 90°C. Mặc dù vẫn nằm trong khung nhiệt độ an toàn, chưa vượt quá ngưỡng 105 - 110°C đối với hầu hết các mẫu CPU, tuy nhiên đừng quá lạm dụng và sử dụng máy ở nhiệt độ quá cao trong thời gian dài, bạn sẽ dễ dàng khiến thiết bị của mình bị giảm tuổi thọ, hỏng hóc lúc nào không hay. Lời khuyên ở đây, nếu bạn ép xung và duy trì CPU ở nhiệt độ cao, hãy cố gắng để mức nhiệt dưới 80°C, cao nhất không nên vượt quá 85°C"
        //        , Type = "Mouse"
        //    },
        //    new Blog()
        //    {
        //        Title = "cách dùng chuột tốt nhất",
        //        CreateDay = DateTime.Now,
        //        image1 = "chuot5.jpg",
        //        HeadBlog = "Nhiệt độ CPU quá cao là tình trạng rất phổ biến đối với PC/laptop hiện nay, gây ra khá nhiều phiền toái và lo ngại về tuổi thọ của máy tính cho người dùng. Dấu hiệu rõ ràng nhất để nhận biết CPU bị quá nhiệt (overheating) là máy tự động tắt ngúm sau khi chạy một ứng dụng hoặc game nặng nào đó!",
        //        BodyBlog = "Nhiệt độ quá cao chưa hẳn đã gây hại ngay cho CPU, tuy nhiên nếu để tình trạng này diễn ra trong thời gian dài, chắc chắn nó sẽ khiến PC nhà bạn giảm tuổi thọ và dễ hỏng hóc đi trông thấy.<br> Cụ thể, đối với nền tảng desktop (máy tính để bàn), khi CPU chạy ở chế độ không tải, nhiệt độ con chip quá nóng hoàn toàn không phải là vấn đề đáng lo ngại nếu PC vẫn hoạt động ổn định. Bởi nếu CPU của bạn đạt ngưỡng nhiệt độ nguy hiểm, cơ chế bảo vệ phần cứng sẽ được kích hoạt và tự động tắt nguồn hoặc giảm hiệu năng của CPU, trước khi nhiệt độ cao gây ra bất kỳ hỏng hóc nào cho các thiết bị bên trong của bạn. <br>Vậy với laptop thì sao? Nền tảng thiết bị này chắc chắn phức tạp hơn desktop, khi việc làm mát CPU và GPU đều bó hẹp trong một không gian nhỏ hẹp. Tuy nhiên hầu hết các laptop hiện đại cũng đều được trang bị cơ chế phòng thủ nhiệt. Khi phát hiện nhiệt độ quá cao, máy sẽ tự động tắt và ngăn mọi nguy hại cho CPU bên trong laptop. Trước đó, bạn cũng sẽ cảm nhận rõ hiệu năng của giảm xuống do cơ chế phòng thủ trên đã giảm xung của CPU/GPU để đưa nhiệt độ chip xử lý xuống tới mức an toàn.<br>Vì vậy, nếu CPU của bạn có bị quá nhiệt đi chăng nữa, thiết bị vẫn có cách tự bảo vệ cho chính nó và bạn không cần quá lo lắng. Điều đáng lưu tâm ở đây, nếu để CPU bị quá nhiệt trong thời gian dài sẽ ảnh hưởng lớn tới trải nghiệm sử dụng thiết bị của bạn, gây giảm tuổi thọ cho các phần cứng quan trọng như ổ cứng, RAM và bảng mạch.",
        //        FootBlog = "Để biết được nhiệt độ trên thiết bị là bao nhiêu, chúng ta có thể dễ dàng sử dụng rất nhiều những ứng dụng có sẵn như HWMonitor hoặc HWiNFO 64, chạy những phần mềm này song song khi chơi game hoặc khi dùng các ứng dụng nặng để kiểm tra nhiệt độ lúc PC chạy ở công suất cao.</ p > Nếu CPU ở chế độ không tải (chạy các tác vụ nhẹ) nhưng nhiệt độ vẫn đạt ngưỡng 80 độ C trở lên, đây là lúc bạn nên đi kiểm tra, vệ sinh lại máy càng sớm càng tốt. Nguyên nhân có thể do quạt tản nhiệt hoạt động kém, kem tản nhiệt đã hết tác dụng, lỗ thoát nhiệt dính bụi, v.v... Nên nhớ mốc nhiệt độ lý tưởng nhất của CPU trên desktop nên rơi vào khoảng từ dưới 50 tới 70°C.Còn đối với những trường hợp ép xung (Overclocking), hãy thận trọng vì theo lý thuyết, nhiệt độ lúc này có thể lên tới 90°C. Mặc dù vẫn nằm trong khung nhiệt độ an toàn, chưa vượt quá ngưỡng 105 - 110°C đối với hầu hết các mẫu CPU, tuy nhiên đừng quá lạm dụng và sử dụng máy ở nhiệt độ quá cao trong thời gian dài, bạn sẽ dễ dàng khiến thiết bị của mình bị giảm tuổi thọ, hỏng hóc lúc nào không hay. Lời khuyên ở đây, nếu bạn ép xung và duy trì CPU ở nhiệt độ cao, hãy cố gắng để mức nhiệt dưới 80°C, cao nhất không nên vượt quá 85°C"
        //        , Type = "Mouse"
        //    },
        //    new Blog()
        //    {
        //        Title = "cách dùng chuột tốt nhất",
        //        CreateDay = DateTime.Now,
        //        image1 = "chuot6.jpg",
        //        HeadBlog = "Nhiệt độ CPU quá cao là tình trạng rất phổ biến đối với PC/laptop hiện nay, gây ra khá nhiều phiền toái và lo ngại về tuổi thọ của máy tính cho người dùng. Dấu hiệu rõ ràng nhất để nhận biết CPU bị quá nhiệt (overheating) là máy tự động tắt ngúm sau khi chạy một ứng dụng hoặc game nặng nào đó!",
        //        BodyBlog = "Nhiệt độ quá cao chưa hẳn đã gây hại ngay cho CPU, tuy nhiên nếu để tình trạng này diễn ra trong thời gian dài, chắc chắn nó sẽ khiến PC nhà bạn giảm tuổi thọ và dễ hỏng hóc đi trông thấy.<br> Cụ thể, đối với nền tảng desktop (máy tính để bàn), khi CPU chạy ở chế độ không tải, nhiệt độ con chip quá nóng hoàn toàn không phải là vấn đề đáng lo ngại nếu PC vẫn hoạt động ổn định. Bởi nếu CPU của bạn đạt ngưỡng nhiệt độ nguy hiểm, cơ chế bảo vệ phần cứng sẽ được kích hoạt và tự động tắt nguồn hoặc giảm hiệu năng của CPU, trước khi nhiệt độ cao gây ra bất kỳ hỏng hóc nào cho các thiết bị bên trong của bạn. <br>Vậy với laptop thì sao? Nền tảng thiết bị này chắc chắn phức tạp hơn desktop, khi việc làm mát CPU và GPU đều bó hẹp trong một không gian nhỏ hẹp. Tuy nhiên hầu hết các laptop hiện đại cũng đều được trang bị cơ chế phòng thủ nhiệt. Khi phát hiện nhiệt độ quá cao, máy sẽ tự động tắt và ngăn mọi nguy hại cho CPU bên trong laptop. Trước đó, bạn cũng sẽ cảm nhận rõ hiệu năng của giảm xuống do cơ chế phòng thủ trên đã giảm xung của CPU/GPU để đưa nhiệt độ chip xử lý xuống tới mức an toàn.<br>Vì vậy, nếu CPU của bạn có bị quá nhiệt đi chăng nữa, thiết bị vẫn có cách tự bảo vệ cho chính nó và bạn không cần quá lo lắng. Điều đáng lưu tâm ở đây, nếu để CPU bị quá nhiệt trong thời gian dài sẽ ảnh hưởng lớn tới trải nghiệm sử dụng thiết bị của bạn, gây giảm tuổi thọ cho các phần cứng quan trọng như ổ cứng, RAM và bảng mạch.",
        //        FootBlog = "Để biết được nhiệt độ trên thiết bị là bao nhiêu, chúng ta có thể dễ dàng sử dụng rất nhiều những ứng dụng có sẵn như HWMonitor hoặc HWiNFO 64, chạy những phần mềm này song song khi chơi game hoặc khi dùng các ứng dụng nặng để kiểm tra nhiệt độ lúc PC chạy ở công suất cao.</ p > Nếu CPU ở chế độ không tải (chạy các tác vụ nhẹ) nhưng nhiệt độ vẫn đạt ngưỡng 80 độ C trở lên, đây là lúc bạn nên đi kiểm tra, vệ sinh lại máy càng sớm càng tốt. Nguyên nhân có thể do quạt tản nhiệt hoạt động kém, kem tản nhiệt đã hết tác dụng, lỗ thoát nhiệt dính bụi, v.v... Nên nhớ mốc nhiệt độ lý tưởng nhất của CPU trên desktop nên rơi vào khoảng từ dưới 50 tới 70°C.Còn đối với những trường hợp ép xung (Overclocking), hãy thận trọng vì theo lý thuyết, nhiệt độ lúc này có thể lên tới 90°C. Mặc dù vẫn nằm trong khung nhiệt độ an toàn, chưa vượt quá ngưỡng 105 - 110°C đối với hầu hết các mẫu CPU, tuy nhiên đừng quá lạm dụng và sử dụng máy ở nhiệt độ quá cao trong thời gian dài, bạn sẽ dễ dàng khiến thiết bị của mình bị giảm tuổi thọ, hỏng hóc lúc nào không hay. Lời khuyên ở đây, nếu bạn ép xung và duy trì CPU ở nhiệt độ cao, hãy cố gắng để mức nhiệt dưới 80°C, cao nhất không nên vượt quá 85°C"
        //        , Type = "Mouse"
        //    },
        //};
        //    List<Blog> BlogsAfterInsert = new List<Blog>();
        //    foreach (var blog in blogs)
        //    {
        //        BlogsAfterInsert.Add(context.Blogs.Add(blog));
        //    }
        //    context.SaveChanges();
            base.Seed(context);
        }
    }
}
