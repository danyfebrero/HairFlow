using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HairFlow.Data.Migrations
{
    public partial class AddAdminAccount : Migration
    {
        const string ADMIN_USER_GUID= "286a546e-4c26-4f71-8865-852938fe18bd";
        const string ADMIN_ROLE_GUID = "d546b519-7d2b-4fa8-9f95-c5a2240ad77e";
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            var passwordHash = hasher.HashPassword(null, "admin"); //TODO hide password
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
