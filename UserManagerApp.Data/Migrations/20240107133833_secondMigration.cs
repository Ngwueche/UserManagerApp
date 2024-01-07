using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagerApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Regular", null },
                    { "2", null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "GitHub", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Twitter", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "7e13f81d-f1fe-4976-89fa-3ab724cb933c", "wisdomngwueche@gmail.com", false, "Wisdom", "ngwueche", "", "Ngwueche", false, null, null, null, null, null, false, "9bef242f-ca0e-4795-bf82-e528d7f5dd8a", "wisdomngwueche", false, "wisdomngwueche" },
                    { "2", 0, "1f842d4d-2beb-403b-8afd-20891619ee7b", "addamgbede@gmail.com", false, "Ada", "addamgbede", "", "Mgbede", false, null, null, null, null, null, false, "510cbf85-187c-4a96-8df8-c8ac4d973d5f", "addamgbede", false, "addamgbede" },
                    { "3", 0, "3edb9d44-766c-4d40-8c23-1789ac44beda", "nnennahumphery@gmail.com", false, "Nnenna", "nnennahumphery", "", "Humphery", false, null, null, null, null, null, false, "c671a37d-48c9-41ce-81e2-c9c15f9811fd", "nnennahumphery", false, "nnennahumphery" },
                    { "4", 0, "f5bb4818-fc50-490e-bfc3-2f241b466940", "covenantebube@gmail.com", false, "Covenant", "covenantebube", "", "Ebube", false, null, null, null, null, null, false, "90d1177d-5223-429d-a55d-e230971fe223", "covenantebube", false, "covenantebube" },
                    { "5", 0, "3e54993c-8806-477a-8e1a-31c77b9056e8", "ebeleokolo@gmail.com", false, "Ebele", "E_okolo", "", "Okolo", false, null, null, null, null, null, false, "c02cfb75-fc05-4228-84da-5149ea6362f0", "ebeleokolo", false, "E_okolo" },
                    { "6", 0, "a94fdfde-8cdd-4675-899d-28f7e7f5b219", "uto@gmail.com", false, "Utobi", "O_uto", "", "Ozoeze", false, null, null, null, null, null, false, "92717138-80ff-4d47-8cb6-bc73b357a5ca", "ozoeze", false, "O_uto" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");
        }
    }
}
