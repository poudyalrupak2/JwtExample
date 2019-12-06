using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProject.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillingInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TableNo = table.Column<int>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    Vat = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Pan = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookingNo = table.Column<string>(nullable: true),
                    CheckIn = table.Column<DateTime>(nullable: false),
                    CheckoutDate = table.Column<DateTime>(nullable: false),
                    NoOfPersons = table.Column<string>(nullable: true),
                    ShortDescriptions = table.Column<string>(nullable: true),
                    AdvancedAmount = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.BookingId);
                });

            migrationBuilder.CreateTable(
                name: "Bookingtables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNo = table.Column<int>(nullable: false),
                    Itemname = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    ItemId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookingtables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Continent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContinentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    NationalIdNo = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dailyStocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    quantity = table.Column<int>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dailyStocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Demo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "drinkCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drinkCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "foodCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Descriprion = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hotels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Ownername = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngridiantsNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngridiantsNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    randompass = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    thumbnail = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "QunatityType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantityType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QunatityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisteredCostumers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    NationalIdNo = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredCostumers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tableRegisters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNo = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tableRegisters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "billingItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    ItemType = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    BillingInfoId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billingItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_billingItems_BillingInfos_BillingInfoId",
                        column: x => x.BillingInfoId,
                        principalTable: "BillingInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "billing",
                columns: table => new
                {
                    BillingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    RemainAmount = table.Column<decimal>(nullable: false),
                    BillNo = table.Column<string>(nullable: true),
                    CheckOutDate = table.Column<DateTime>(nullable: false),
                    NoOfDays = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing", x => x.BillingId);
                    table.ForeignKey(
                        name: "FK_billing_bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "drinkRegisters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    UnitName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    DrinkCategoryId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drinkRegisters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_drinkRegisters_drinkCategories_DrinkCategoryId",
                        column: x => x.DrinkCategoryId,
                        principalTable: "drinkCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegisterFoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Ingredients = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    FoodCategoryId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegisterFoods_foodCategories_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "foodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "facilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true),
                    HotelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_facilities_hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HotelImages",
                columns: table => new
                {
                    HotelImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(nullable: true),
                    Size = table.Column<long>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    HotelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelImages", x => x.HotelImageId);
                    table.ForeignKey(
                        name: "FK_HotelImages_hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(nullable: true),
                    RoomNo = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false),
                    NoofBeds = table.Column<int>(nullable: false),
                    Roomtype = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true),
                    BookingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.id);
                    table.ForeignKey(
                        name: "FK_rooms_bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rooms_hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "stockIngs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngridiantsNameId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockIngs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stockIngs_IngridiantsNames_IngridiantsNameId",
                        column: x => x.IngridiantsNameId,
                        principalTable: "IngridiantsNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuReg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuCategoryid = table.Column<int>(nullable: true),
                    Itemname = table.Column<string>(nullable: true),
                    Ingrident = table.Column<string>(nullable: true),
                    MenuContinentId = table.Column<int>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Thumbnail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuReg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuReg_Menu_MenuCategoryid",
                        column: x => x.MenuCategoryid,
                        principalTable: "Menu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuReg_Continent_MenuContinentId",
                        column: x => x.MenuContinentId,
                        principalTable: "Continent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ingridiants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    IngridiantsNameId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    QuantityType = table.Column<string>(nullable: true),
                    PricePerUnit = table.Column<decimal>(nullable: false),
                    Westage = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false),
                    PaidIn = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    BroughtDate = table.Column<string>(nullable: true),
                    BroughtBy = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingridiants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ingridiants_IngridiantsNames_IngridiantsNameId",
                        column: x => x.IngridiantsNameId,
                        principalTable: "IngridiantsNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ingridiants_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrinkImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(nullable: true),
                    Size = table.Column<long>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    DrinkCategoryId = table.Column<int>(nullable: true),
                    DrinkRegisterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrinkImage_drinkCategories_DrinkCategoryId",
                        column: x => x.DrinkCategoryId,
                        principalTable: "drinkCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DrinkImage_drinkRegisters_DrinkRegisterId",
                        column: x => x.DrinkRegisterId,
                        principalTable: "drinkRegisters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(nullable: true),
                    Size = table.Column<long>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    FoodCategoryId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    EditedAt = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<string>(nullable: true),
                    RegisterFoodId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodImage_foodCategories_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "foodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodImage_RegisterFoods_RegisterFoodId",
                        column: x => x.RegisterFoodId,
                        principalTable: "RegisterFoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomImage",
                columns: table => new
                {
                    RoomImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(nullable: true),
                    Size = table.Column<long>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    Roomid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomImage", x => x.RoomImageId);
                    table.ForeignKey(
                        name: "FK_RoomImage_rooms_Roomid",
                        column: x => x.Roomid,
                        principalTable: "rooms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(nullable: true),
                    Size = table.Column<long>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    MenuRegistrationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Image_MenuReg_MenuRegistrationId",
                        column: x => x.MenuRegistrationId,
                        principalTable: "MenuReg",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IngrediantsAndFoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegisterFoodId = table.Column<int>(nullable: false),
                    RegisterIngridiantsId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngrediantsAndFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngrediantsAndFoods_RegisterFoods_RegisterFoodId",
                        column: x => x.RegisterFoodId,
                        principalTable: "RegisterFoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngrediantsAndFoods_ingridiants_RegisterIngridiantsId",
                        column: x => x.RegisterIngridiantsId,
                        principalTable: "ingridiants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_billing_BookingId",
                table: "billing",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_billingItems_BillingInfoId",
                table: "billingItems",
                column: "BillingInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_DrinkImage_DrinkCategoryId",
                table: "DrinkImage",
                column: "DrinkCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DrinkImage_DrinkRegisterId",
                table: "DrinkImage",
                column: "DrinkRegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_drinkRegisters_DrinkCategoryId",
                table: "drinkRegisters",
                column: "DrinkCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_facilities_HotelId",
                table: "facilities",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodImage_FoodCategoryId",
                table: "FoodImage",
                column: "FoodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodImage_RegisterFoodId",
                table: "FoodImage",
                column: "RegisterFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelImages_HotelId",
                table: "HotelImages",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_MenuRegistrationId",
                table: "Image",
                column: "MenuRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_IngrediantsAndFoods_RegisterFoodId",
                table: "IngrediantsAndFoods",
                column: "RegisterFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_IngrediantsAndFoods_RegisterIngridiantsId",
                table: "IngrediantsAndFoods",
                column: "RegisterIngridiantsId");

            migrationBuilder.CreateIndex(
                name: "IX_ingridiants_IngridiantsNameId",
                table: "ingridiants",
                column: "IngridiantsNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ingridiants_VendorId",
                table: "ingridiants",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuReg_MenuCategoryid",
                table: "MenuReg",
                column: "MenuCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_MenuReg_MenuContinentId",
                table: "MenuReg",
                column: "MenuContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterFoods_FoodCategoryId",
                table: "RegisterFoods",
                column: "FoodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomImage_Roomid",
                table: "RoomImage",
                column: "Roomid");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_BookingId",
                table: "rooms",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_HotelId",
                table: "rooms",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_stockIngs_IngridiantsNameId",
                table: "stockIngs",
                column: "IngridiantsNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "billing");

            migrationBuilder.DropTable(
                name: "billingItems");

            migrationBuilder.DropTable(
                name: "Bookingtables");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "dailyStocks");

            migrationBuilder.DropTable(
                name: "Demo");

            migrationBuilder.DropTable(
                name: "DrinkImage");

            migrationBuilder.DropTable(
                name: "facilities");

            migrationBuilder.DropTable(
                name: "FoodImage");

            migrationBuilder.DropTable(
                name: "HotelImages");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "IngrediantsAndFoods");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "QunatityType");

            migrationBuilder.DropTable(
                name: "RegisteredCostumers");

            migrationBuilder.DropTable(
                name: "RoomImage");

            migrationBuilder.DropTable(
                name: "stockIngs");

            migrationBuilder.DropTable(
                name: "tableRegisters");

            migrationBuilder.DropTable(
                name: "BillingInfos");

            migrationBuilder.DropTable(
                name: "drinkRegisters");

            migrationBuilder.DropTable(
                name: "MenuReg");

            migrationBuilder.DropTable(
                name: "RegisterFoods");

            migrationBuilder.DropTable(
                name: "ingridiants");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "drinkCategories");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Continent");

            migrationBuilder.DropTable(
                name: "foodCategories");

            migrationBuilder.DropTable(
                name: "IngridiantsNames");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "hotels");
        }
    }
}
