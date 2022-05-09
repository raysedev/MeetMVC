using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetMVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sexuality",
                table: "AspNetUsers",
                newName: "Sexuality");

            migrationBuilder.RenameColumn(
                name: "lookingFor",
                table: "AspNetUsers",
                newName: "LookingFor");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "AspNetUsers",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "AspNetUsers",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "AspNetUsers",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "AspNetUsers",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "about",
                table: "AspNetUsers",
                newName: "About");

            migrationBuilder.RenameColumn(
                name: "Avatar",
                table: "AspNetUsers",
                newName: "ImagePath");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sexuality",
                table: "AspNetUsers",
                newName: "sexuality");

            migrationBuilder.RenameColumn(
                name: "LookingFor",
                table: "AspNetUsers",
                newName: "lookingFor");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "AspNetUsers",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "AspNetUsers",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "AspNetUsers",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "AspNetUsers",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "About",
                table: "AspNetUsers",
                newName: "about");

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "AspNetUsers",
                newName: "Avatar");
        }
    }
}
