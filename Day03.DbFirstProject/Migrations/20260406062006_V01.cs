using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day03.DbFirstProject.Migrations
{
    /// <inheritdoc />
    public partial class V01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    au_id = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    au_lname = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    au_fname = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    phone = table.Column<string>(type: "char(12)", unicode: false, fixedLength: true, maxLength: 12, nullable: true, defaultValue: "UNKNOWN"),
                    address = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    state = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    zip = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    contract = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPKCL_auidind", x => x.au_id);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    job_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_desc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "New Position - title not formalized yet"),
                    min_lvl = table.Column<byte>(type: "tinyint", nullable: false),
                    max_lvl = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__jobs__6E32B6A5A5F58DDB", x => x.job_id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    stor_id = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    stor_name = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    stor_address = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    state = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    zip = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPK_storeid", x => x.stor_id);
                });

            migrationBuilder.CreateTable(
                name: "titles",
                columns: table => new
                {
                    title_id = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    title = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    type = table.Column<string>(type: "char(12)", unicode: false, fixedLength: true, maxLength: 12, nullable: false, defaultValue: "UNDECIDED"),
                    pub_id = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    price = table.Column<decimal>(type: "money", nullable: true),
                    advance = table.Column<decimal>(type: "money", nullable: true),
                    royalty = table.Column<int>(type: "int", nullable: true),
                    ytd_sales = table.Column<int>(type: "int", nullable: true),
                    notes = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    pubdate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPKCL_titleidind", x => x.title_id);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    emp_id = table.Column<string>(type: "char(9)", unicode: false, fixedLength: true, maxLength: 9, nullable: false),
                    fname = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    minit = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    lname = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    job_id = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    job_lvl = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)10),
                    pub_id = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false, defaultValue: "9952"),
                    hire_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emp_id", x => x.emp_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK__employee__job_id__48CFD27E",
                        column: x => x.job_id,
                        principalTable: "jobs",
                        principalColumn: "job_id");
                });

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    stor_id = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ord_num = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    title_id = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    ord_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    qty = table.Column<short>(type: "smallint", nullable: false),
                    payterms = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPKCL_sales", x => new { x.stor_id, x.ord_num, x.title_id });
                    table.ForeignKey(
                        name: "FK__sales__stor_id__37A5467C",
                        column: x => x.stor_id,
                        principalTable: "stores",
                        principalColumn: "stor_id");
                    table.ForeignKey(
                        name: "FK__sales__title_id__38996AB5",
                        column: x => x.title_id,
                        principalTable: "titles",
                        principalColumn: "title_id");
                });

            migrationBuilder.CreateTable(
                name: "titleauthor",
                columns: table => new
                {
                    au_id = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    title_id = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    au_ord = table.Column<byte>(type: "tinyint", nullable: true),
                    royaltyper = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPKCL_taind", x => new { x.au_id, x.title_id });
                    table.ForeignKey(
                        name: "FK__titleauth__au_id__31EC6D26",
                        column: x => x.au_id,
                        principalTable: "authors",
                        principalColumn: "au_id");
                    table.ForeignKey(
                        name: "FK__titleauth__title__32E0915F",
                        column: x => x.title_id,
                        principalTable: "titles",
                        principalColumn: "title_id");
                });

            migrationBuilder.CreateIndex(
                name: "aunmind",
                table: "authors",
                columns: new[] { "au_lname", "au_fname" });

            migrationBuilder.CreateIndex(
                name: "employee_ind",
                table: "employee",
                columns: new[] { "lname", "fname", "minit" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_employee_job_id",
                table: "employee",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "titleidind",
                table: "sales",
                column: "title_id");

            migrationBuilder.CreateIndex(
                name: "auidind",
                table: "titleauthor",
                column: "au_id");

            migrationBuilder.CreateIndex(
                name: "titleidind",
                table: "titleauthor",
                column: "title_id");

            migrationBuilder.CreateIndex(
                name: "titleind",
                table: "titles",
                column: "title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "sales");

            migrationBuilder.DropTable(
                name: "titleauthor");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "stores");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "titles");
        }
    }
}
