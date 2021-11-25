using Microsoft.EntityFrameworkCore.Migrations;

namespace BbcSrUI.Data.Migrations
{
    public partial class TablesCustomName2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_MyRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_MyUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_MyUserClaims_MyUsers_UserId",
                table: "MyUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_MyUserLogins_MyUsers_UserId",
                table: "MyUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_MyUserRoles_MyRoles_RoleId",
                table: "MyUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_MyUserRoles_MyUsers_UserId",
                table: "MyUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyUsers",
                table: "MyUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyUserRoles",
                table: "MyUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyUserLogins",
                table: "MyUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyUserClaims",
                table: "MyUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyRoles",
                table: "MyRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "MyUsers",
                newName: "TicketUsers");

            migrationBuilder.RenameTable(
                name: "MyUserRoles",
                newName: "TicketUserRoles");

            migrationBuilder.RenameTable(
                name: "MyUserLogins",
                newName: "TicketUserLogins");

            migrationBuilder.RenameTable(
                name: "MyUserClaims",
                newName: "TicketUserClaims");

            migrationBuilder.RenameTable(
                name: "MyRoles",
                newName: "TicketRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "TicketUserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "TicketRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_MyUserRoles_RoleId",
                table: "TicketUserRoles",
                newName: "IX_TicketUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_MyUserLogins_UserId",
                table: "TicketUserLogins",
                newName: "IX_TicketUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MyUserClaims_UserId",
                table: "TicketUserClaims",
                newName: "IX_TicketUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "TicketRoleClaims",
                newName: "IX_TicketRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketUsers",
                table: "TicketUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketUserRoles",
                table: "TicketUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketUserLogins",
                table: "TicketUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketUserClaims",
                table: "TicketUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketRoles",
                table: "TicketRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketUserTokens",
                table: "TicketUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketRoleClaims",
                table: "TicketRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketRoleClaims_TicketRoles_RoleId",
                table: "TicketRoleClaims",
                column: "RoleId",
                principalTable: "TicketRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketUserClaims_TicketUsers_UserId",
                table: "TicketUserClaims",
                column: "UserId",
                principalTable: "TicketUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketUserLogins_TicketUsers_UserId",
                table: "TicketUserLogins",
                column: "UserId",
                principalTable: "TicketUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketUserRoles_TicketRoles_RoleId",
                table: "TicketUserRoles",
                column: "RoleId",
                principalTable: "TicketRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketUserRoles_TicketUsers_UserId",
                table: "TicketUserRoles",
                column: "UserId",
                principalTable: "TicketUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketUserTokens_TicketUsers_UserId",
                table: "TicketUserTokens",
                column: "UserId",
                principalTable: "TicketUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketRoleClaims_TicketRoles_RoleId",
                table: "TicketRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketUserClaims_TicketUsers_UserId",
                table: "TicketUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketUserLogins_TicketUsers_UserId",
                table: "TicketUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketUserRoles_TicketRoles_RoleId",
                table: "TicketUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketUserRoles_TicketUsers_UserId",
                table: "TicketUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketUserTokens_TicketUsers_UserId",
                table: "TicketUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketUserTokens",
                table: "TicketUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketUsers",
                table: "TicketUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketUserRoles",
                table: "TicketUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketUserLogins",
                table: "TicketUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketUserClaims",
                table: "TicketUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketRoles",
                table: "TicketRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketRoleClaims",
                table: "TicketRoleClaims");

            migrationBuilder.RenameTable(
                name: "TicketUserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "TicketUsers",
                newName: "MyUsers");

            migrationBuilder.RenameTable(
                name: "TicketUserRoles",
                newName: "MyUserRoles");

            migrationBuilder.RenameTable(
                name: "TicketUserLogins",
                newName: "MyUserLogins");

            migrationBuilder.RenameTable(
                name: "TicketUserClaims",
                newName: "MyUserClaims");

            migrationBuilder.RenameTable(
                name: "TicketRoles",
                newName: "MyRoles");

            migrationBuilder.RenameTable(
                name: "TicketRoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_TicketUserRoles_RoleId",
                table: "MyUserRoles",
                newName: "IX_MyUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketUserLogins_UserId",
                table: "MyUserLogins",
                newName: "IX_MyUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketUserClaims_UserId",
                table: "MyUserClaims",
                newName: "IX_MyUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyUsers",
                table: "MyUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyUserRoles",
                table: "MyUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyUserLogins",
                table: "MyUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyUserClaims",
                table: "MyUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyRoles",
                table: "MyRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_MyRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "MyRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_MyUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "MyUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyUserClaims_MyUsers_UserId",
                table: "MyUserClaims",
                column: "UserId",
                principalTable: "MyUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyUserLogins_MyUsers_UserId",
                table: "MyUserLogins",
                column: "UserId",
                principalTable: "MyUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyUserRoles_MyRoles_RoleId",
                table: "MyUserRoles",
                column: "RoleId",
                principalTable: "MyRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyUserRoles_MyUsers_UserId",
                table: "MyUserRoles",
                column: "UserId",
                principalTable: "MyUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
