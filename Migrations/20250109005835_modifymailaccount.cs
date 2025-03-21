﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleLogin.Migrations
{
    /// <inheritdoc />
    public partial class modifymailaccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "authcode",
                table: "TbMailAccount",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "redirecUri",
                table: "TbMailAccount",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "authcode",
                table: "TbMailAccount");

            migrationBuilder.DropColumn(
                name: "redirecUri",
                table: "TbMailAccount");
        }
    }
}
