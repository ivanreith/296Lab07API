using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_Lab07.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Story",
                columns: table => new
                {
                    StoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoryTitle = table.Column<string>(maxLength: 50, nullable: false),
                    StoryTopic = table.Column<string>(maxLength: 25, nullable: false),
                    StoryText = table.Column<string>(maxLength: 250, nullable: false),
                    PosterId = table.Column<string>(nullable: true),
                    StoryTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.StoryID);
                    table.ForeignKey(
                        name: "FK_Story_AppUser_PosterId",
                        column: x => x.PosterId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentText = table.Column<string>(nullable: false),
                    CommentDate = table.Column<DateTime>(nullable: false),
                    CommenterId = table.Column<string>(nullable: false),
                    StoriesModelFormStoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AppUser_CommenterId",
                        column: x => x.CommenterId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Story_StoriesModelFormStoryID",
                        column: x => x.StoriesModelFormStoryID,
                        principalTable: "Story",
                        principalColumn: "StoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommenterId",
                table: "Comments",
                column: "CommenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_StoriesModelFormStoryID",
                table: "Comments",
                column: "StoriesModelFormStoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Story_PosterId",
                table: "Story",
                column: "PosterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Story");

            migrationBuilder.DropTable(
                name: "AppUser");
        }
    }
}
