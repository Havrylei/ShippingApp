using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingApi.Migrations
{
    public partial class ChangeCountryTableKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Countries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AQ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AX");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "AZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BB");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BQ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "BZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CX");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "CZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "DE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "DJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "DK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "DM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "DO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "DZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "EC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "EE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "EG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "EH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ER");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ES");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ET");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "FI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "FJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "FK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "FM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "FO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "FR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GB");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GQ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "GY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "HK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "HM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "HN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "HR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "HT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "HU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ID");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "IE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "IL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "IM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "IN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "IO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "IQ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "IR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "IS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "IT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "JE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "JM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "JO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "JP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "KE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "KG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "KH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "KI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "KM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "KN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "KP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "KR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "KW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "KY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "KZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "LA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "LB");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "LC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "LI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "LK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "LR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "LS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "LT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "LU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "LV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "LY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ME");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ML");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MQ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MX");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "MZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "NZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "OM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "PY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "QA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "RE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "RO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "RS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "RU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "RW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SB");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ST");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SX");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "SZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "TZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "UA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "UG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "UM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "US");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "UY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "UZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "VA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "VC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "VE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "VG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "VI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "VN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "VU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "WF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "WS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "XK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "YE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "YT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ZA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ZM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ZW");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Countries",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("010c6d19-c6cf-438e-8e35-d0e75edb44c1"), "JO", "Jordan" },
                    { new Guid("0120c779-998b-4dc5-b2fa-bce41a520f78"), "TV", "Tuvalu" },
                    { new Guid("020e4d0c-5179-43d4-bdd8-5b7952c53605"), "CM", "Cameroon" },
                    { new Guid("021c15db-1c34-40e9-af03-d8fd95b55d22"), "GH", "Ghana" },
                    { new Guid("02315f29-2806-4517-b8f4-a3011336be35"), "KE", "Kenya" },
                    { new Guid("02cddf42-df8d-47d8-abde-56a693264da6"), "BB", "Barbados" },
                    { new Guid("03519c65-0a42-49ea-99d4-2d075d6777d8"), "IR", "Iran" },
                    { new Guid("03b33a9e-b35c-4108-829b-65111df98ff5"), "UM", "United States Minor Outlying Islands" },
                    { new Guid("045b9e56-7c5b-4460-b3cf-d1ed2af8dd1b"), "GL", "Greenland" },
                    { new Guid("04a27ff9-b7b4-4f91-b30f-ef0a8545e283"), "VA", "Vatican" },
                    { new Guid("060ccf46-4171-4f14-a6a3-9d89fad31407"), "RS", "Serbia" },
                    { new Guid("076f8631-ade3-4ee7-93ab-73b29336ac2c"), "SG", "Singapore" },
                    { new Guid("08886a3c-70f4-454b-bc04-f14b013c27a1"), "TO", "Tonga" },
                    { new Guid("0a99693c-9b26-48eb-94a0-986c6cd36177"), "AR", "Argentina" },
                    { new Guid("0ccb8243-83d7-41b6-b1db-7ca9f455af31"), "UG", "Uganda" },
                    { new Guid("0efead88-1bd2-4a69-aa02-da2093320d75"), "BM", "Bermuda" },
                    { new Guid("1109d9c6-dc66-4deb-9399-d524166f6eab"), "PG", "Papua New Guinea" },
                    { new Guid("110b08e3-dd29-4421-a3e4-5eb2e03feeb2"), "SO", "Somalia" },
                    { new Guid("1115add0-2364-485b-bcfb-ffaeee2fbf55"), "PR", "Puerto Rico" },
                    { new Guid("126295e7-1113-46c2-9fe7-d7697ff3470a"), "CI", "Ivory Coast" },
                    { new Guid("12d82e02-f6c2-4798-bf87-91b0f2f19a86"), "MR", "Mauritania" },
                    { new Guid("15147505-e1a5-4fda-88ad-ef0342d9d0e2"), "DM", "Dominica" },
                    { new Guid("1662994d-09d3-47da-8da9-c8dfc3b31e37"), "KR", "South Korea" },
                    { new Guid("17a3d049-9868-4372-b5ef-904989c02f37"), "WS", "Samoa" },
                    { new Guid("1a75cc99-cd4b-4997-afd6-e0738f2b2fc7"), "CO", "Colombia" },
                    { new Guid("1b900e20-f78d-435b-966c-8fdfa43c1fa2"), "PH", "Philippines" },
                    { new Guid("1b934370-4433-4d69-a092-14505b60a6f4"), "MG", "Madagascar" },
                    { new Guid("1fa1253a-6155-49d1-b02e-ad337c3c475b"), "LK", "Sri Lanka" },
                    { new Guid("20489a9e-a866-4e50-ad19-8cab1ed37c84"), "MN", "Mongolia" },
                    { new Guid("22844636-6508-4a7b-82b5-2f473d19bb26"), "TN", "Tunisia" },
                    { new Guid("22a52038-371c-4ff4-b424-0d96e598d40c"), "SK", "Slovakia" },
                    { new Guid("252e98b6-1f05-4e1c-a87b-eb750675bc7e"), "BE", "Belgium" },
                    { new Guid("25d4ce4d-a825-4503-a2c9-0d21d2934882"), "SX", "Sint Maarten" },
                    { new Guid("25e35639-9fe6-4c68-8c85-446b00c7103b"), "GI", "Gibraltar" },
                    { new Guid("26b873c3-654d-46bf-b5fe-a68f9fb717e3"), "GB", "United Kingdom" },
                    { new Guid("26d506c6-0e42-4022-b497-df284aa80516"), "JM", "Jamaica" },
                    { new Guid("2706a61d-fc02-4744-b225-9c9ddb0bba50"), "GE", "Georgia" },
                    { new Guid("274327c7-a7e6-4ed5-88a4-6876bfb64f09"), "AZ", "Azerbaijan" },
                    { new Guid("27a4c12c-ef6f-4f62-b3cb-6d330981485a"), "SY", "Syria" },
                    { new Guid("2869413d-cba6-4150-9d74-50b4c93d6413"), "FK", "Falkland Islands" },
                    { new Guid("294c3ac0-ffdd-49ac-859a-c95a577c111f"), "EH", "Western Sahara" },
                    { new Guid("2a1ac426-2d84-420c-bac5-af5ae365129c"), "BW", "Botswana" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("2c7ffdd8-b626-4a92-9d30-025f1d85478a"), "SN", "Senegal" },
                    { new Guid("2d572f1e-6087-4a69-9c25-13ff8758dd6c"), "SR", "Suriname" },
                    { new Guid("2d7898f8-9307-4576-8f8a-db0a5f2eb0f9"), "BO", "Bolivia" },
                    { new Guid("2ee47afa-e8e6-40e3-9346-6fa084669845"), "KY", "Cayman Islands" },
                    { new Guid("305abcc1-d2c5-424a-9954-8bd592f6c0b1"), "BY", "Belarus" },
                    { new Guid("319725d0-ee10-491e-b67a-aeae8d2a2a4c"), "DK", "Denmark" },
                    { new Guid("31cb8022-b41e-423e-bcaa-49bd32a260bc"), "TM", "Turkmenistan" },
                    { new Guid("32b83b25-565b-4ed5-8537-4a51590df98c"), "CZ", "Czech Republic" },
                    { new Guid("32d9d116-f2e2-48a5-91a8-bd60a19160eb"), "NI", "Nicaragua" },
                    { new Guid("341e0da2-058a-43cf-bc71-f5479a4189d8"), "BI", "Burundi" },
                    { new Guid("34d7f9bd-58f7-47c6-b8d2-cef275561cc3"), "VG", "British Virgin Islands" },
                    { new Guid("35d65a96-2b4b-4120-9a7c-d0808a1b7cf7"), "YE", "Yemen" },
                    { new Guid("367e1e9e-bc32-4336-b36d-8bca31822be9"), "AO", "Angola" },
                    { new Guid("3a538d50-216f-4170-a277-6469e8d703df"), "UY", "Uruguay" },
                    { new Guid("3a6ad880-ab94-4fdc-b7f4-ddf036158003"), "CH", "Switzerland" },
                    { new Guid("3b1ac3bc-753a-4687-ba58-f99b0df20927"), "PE", "Peru" },
                    { new Guid("3b4556c6-8b42-47e9-adb1-d1432ffec833"), "US", "United States" },
                    { new Guid("3df460f6-be3c-45ad-94b4-29b611766b99"), "TR", "Turkey" },
                    { new Guid("3e0dd1f6-00d4-4984-996d-abb648b48ce3"), "KG", "Kyrgyzstan" },
                    { new Guid("3e753541-fd64-47af-9a6e-6478090adacd"), "LR", "Liberia" },
                    { new Guid("411f36f7-c8fd-4dcc-964c-ab96a7bdcce7"), "TD", "Chad" },
                    { new Guid("419c2c51-d52d-4d1e-aa42-93be52d808bb"), "PL", "Poland" },
                    { new Guid("420bcb23-4fee-4288-b3c1-b1d33a5fcf96"), "SA", "Saudi Arabia" },
                    { new Guid("433c734e-add9-4128-a4a5-d8e2cac73ec2"), "HT", "Haiti" },
                    { new Guid("43dcd0de-0fe8-4bc3-b2fa-6b05ba26cc03"), "AM", "Armenia" },
                    { new Guid("45371370-cae1-44ab-9bcb-65c6d69722ec"), "PN", "Pitcairn" },
                    { new Guid("4667ca27-936c-4829-93f7-285e8eb7b0ee"), "DO", "Dominican Republic" },
                    { new Guid("46b6b14d-0d06-47c8-9666-4c436aa7a1af"), "BT", "Bhutan" },
                    { new Guid("4b42f515-f3e9-4c28-8bae-b7b69a3c7cd5"), "AW", "Aruba" },
                    { new Guid("4b543d3c-14ab-4b3f-8ec1-31723cf35847"), "PK", "Pakistan" },
                    { new Guid("4e000dc1-8a16-4f6a-8cd4-b4f8c84178d8"), "PA", "Panama" },
                    { new Guid("4f189a54-b79e-4209-bc68-0fa69f1fdb9e"), "TJ", "Tajikistan" },
                    { new Guid("4f1d431e-6e09-4f15-ad79-da133354afc5"), "MQ", "Martinique" },
                    { new Guid("4fa2a81c-b3d9-4c5b-a6bd-406fa074d36e"), "LV", "Latvia" },
                    { new Guid("50cd818a-8650-4486-9284-106a49705e13"), "PT", "Portugal" },
                    { new Guid("50ec6dba-d5ef-4a15-975b-d1f5c22c3791"), "CR", "Costa Rica" },
                    { new Guid("51141eb8-459a-4d8e-b9ca-0602aed42187"), "LU", "Luxembourg" },
                    { new Guid("5153a6e7-b056-4b11-a56c-5e5bc323d3e2"), "LY", "Libya" },
                    { new Guid("515686e8-1b0a-4e7b-8b77-048051930a91"), "BR", "Brazil" },
                    { new Guid("51a04d61-e313-4298-ac4d-707b0f824be8"), "YT", "Mayotte" },
                    { new Guid("51ad381a-3bd6-41a7-8521-ac0077405bc8"), "XK", "Kosovo" },
                    { new Guid("521b8361-a403-4d4f-9bf0-0f3583714e81"), "BF", "Burkina Faso" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("53e9fa6c-10fe-4b83-81fa-759ed39687a8"), "KM", "Comoros" },
                    { new Guid("54216853-fac0-4ae7-9a4e-912a63e489ea"), "MH", "Marshall Islands" },
                    { new Guid("5505f1f0-734c-4553-8554-2cb2caf4e9de"), "GG", "Guernsey" },
                    { new Guid("552939da-21ec-495e-a59b-713cd77fcf95"), "MK", "Macedonia" },
                    { new Guid("5678bc91-ba2b-4cf2-ba10-ae4deb23efe7"), "BH", "Bahrain" },
                    { new Guid("579b5918-df2d-4ae2-98b7-36cf0d2f8179"), "AN", "Netherlands Antilles" },
                    { new Guid("57d096c0-1fcd-4676-9b68-c27f45d58d84"), "UA", "Ukraine" },
                    { new Guid("58203c3e-3732-454b-a2a4-80125a23943a"), "GR", "Greece" },
                    { new Guid("58c5c1dc-0697-4d17-98aa-cb1eb1554f1f"), "BZ", "Belize" },
                    { new Guid("5916e9f8-9bfa-444f-9879-9ce2d300806d"), "BN", "Brunei" },
                    { new Guid("59b7ad30-bb6f-4fb9-bc44-58eb143a1b50"), "MV", "Maldives" },
                    { new Guid("5a3a2b55-8f64-432f-aad7-28554e10f241"), "AX", "Aland Islands" },
                    { new Guid("5a4e97c8-83f2-4154-8d60-dfed549253ad"), "LA", "Laos" },
                    { new Guid("5aafa585-c8c3-4cf1-b694-de77c006a16c"), "CS", "Serbia and Montenegro" },
                    { new Guid("5aba8501-41af-4b4c-aaf4-ac6b74a8cda8"), "KI", "Kiribati" },
                    { new Guid("5d8aebc8-9906-4849-af74-33ae0f413308"), "WF", "Wallis and Futuna" },
                    { new Guid("5ea0541e-9037-4c50-bfbc-f93282f173ae"), "BG", "Bulgaria" },
                    { new Guid("5f65235f-d320-4833-adc6-67631bd37f38"), "AU", "Australia" },
                    { new Guid("60162d63-4fc0-428b-abf5-9b0cfa7f2312"), "OM", "Oman" },
                    { new Guid("60ed91af-85f1-4862-9d64-46eda498901d"), "IT", "Italy" },
                    { new Guid("62656d6b-497f-4752-b903-142b3277b323"), "CK", "Cook Islands" },
                    { new Guid("6424a525-3a22-4300-82b8-b9177ffbb1cc"), "JP", "Japan" },
                    { new Guid("66f6ca55-6615-4c67-b4d5-0b299f7b8db2"), "FI", "Finland" },
                    { new Guid("671ab069-8299-4059-8d60-5b41e4f1c558"), "MY", "Malaysia" },
                    { new Guid("67755bc4-e041-4ee0-ab85-06689632f71c"), "LI", "Liechtenstein" },
                    { new Guid("67a71039-ab91-47fc-a395-69a1554bd62f"), "MO", "Macao" },
                    { new Guid("67d197b0-ddbe-46e2-b9b2-007e1edf9921"), "MC", "Monaco" },
                    { new Guid("68b4e565-35e7-4601-9d1c-7dfa5f1b695e"), "LC", "Saint Lucia" },
                    { new Guid("69752e89-1a3a-440b-8273-edb97ee739ff"), "VI", "U.S. Virgin Islands" },
                    { new Guid("6dd54c5e-31f9-49e2-aff3-acb8a813b449"), "NF", "Norfolk Island" },
                    { new Guid("6e4ec4ce-d123-4e31-a317-a2a9636ace4a"), "FR", "France" },
                    { new Guid("6ea53e31-2698-4835-8efc-0c5918025f24"), "SE", "Sweden" },
                    { new Guid("6ead6a45-f729-42e7-9f5b-70437c970199"), "KZ", "Kazakhstan" },
                    { new Guid("6ef87f20-2399-489a-ab56-7bdfe9f7b76f"), "GQ", "Equatorial Guinea" },
                    { new Guid("736f469e-4269-46df-b0e1-208abbb880b2"), "TT", "Trinidad and Tobago" },
                    { new Guid("7421da32-0b4a-418f-bb39-f39fcd140362"), "IS", "Iceland" },
                    { new Guid("749630a9-1c9e-42a4-9aff-ea069ac16133"), "DZ", "Algeria" },
                    { new Guid("7518c837-8ba7-40fb-b733-c4089c631389"), "GF", "French Guiana" },
                    { new Guid("76638bc9-d011-4145-bf02-1576f87bb939"), "ML", "Mali" },
                    { new Guid("76b258c3-7e41-46df-851f-2c84d687e0d4"), "IE", "Ireland" },
                    { new Guid("778b3d9b-6b2f-41e0-9d71-7fc943e5895c"), "SZ", "Swaziland" },
                    { new Guid("78ad3c5d-873e-4b60-81a9-2f56d9b9421f"), "GD", "Grenada" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("78fba52f-3486-4bca-a3d5-0c67c6630443"), "DJ", "Djibouti" },
                    { new Guid("7c455e2b-9f54-4755-ab9f-0205d60cf72f"), "QA", "Qatar" },
                    { new Guid("7c45761e-82cd-4bf0-b88d-222195747789"), "FO", "Faroe Islands" },
                    { new Guid("81ed7475-98ef-492b-93b9-07cc1e09821c"), "PS", "Palestinian Territory" },
                    { new Guid("82210ba2-e8c2-4831-b233-d059dcbb7179"), "TZ", "Tanzania" },
                    { new Guid("82db40ea-eb83-4a53-bcdf-209629d7675f"), "ST", "Sao Tome and Principe" },
                    { new Guid("832721e8-6b1a-4ea1-8d6d-270460579dea"), "VU", "Vanuatu" },
                    { new Guid("834be208-8ca5-4c11-8336-57c96609c1e1"), "AI", "Anguilla" },
                    { new Guid("84d35fe2-fdb7-40ac-94dd-c2b9146e2e03"), "GA", "Gabon" },
                    { new Guid("86aade6a-6ad2-4e25-b9a1-923fffe3ed4f"), "MP", "Northern Mariana Islands" },
                    { new Guid("879b084c-8f66-407e-aadc-fd53334b4b82"), "CV", "Cape Verde" },
                    { new Guid("88189348-0146-41dc-8107-dc3b68236f7d"), "MU", "Mauritius" },
                    { new Guid("885ca960-f376-4904-879e-3dc330aa587d"), "CD", "Democratic Republic of the Congo" },
                    { new Guid("897942e2-d6f6-4cb0-b523-4643bdd52c61"), "BL", "Saint Barthelemy" },
                    { new Guid("8afabbd8-6eef-4649-8448-a0d39f65702e"), "GP", "Guadeloupe" },
                    { new Guid("8c036ca1-6376-4875-86f5-86ea473fd6ae"), "TK", "Tokelau" },
                    { new Guid("8e26ebf8-a9d9-4c6a-b0fc-1734965b27ad"), "EG", "Egypt" },
                    { new Guid("8f978893-7384-488f-9c9a-243a22034391"), "CF", "Central African Republic" },
                    { new Guid("9093b25d-db91-4afe-b4c0-1dfe4c0d9b7f"), "AL", "Albania" },
                    { new Guid("91542005-1b98-4d38-bb3d-c6fa0d20d368"), "PM", "Saint Pierre and Miquelon" },
                    { new Guid("9165c62c-1d40-4173-8e5c-f01057d94a28"), "HM", "Heard Island and McDonald Islands" },
                    { new Guid("934de1af-afce-4a8f-aa31-0912957cd366"), "CC", "Cocos Islands" },
                    { new Guid("9432c48d-9701-40da-93d0-4927401874bb"), "BQ", "Bonaire Saint Eustatius and Saba" },
                    { new Guid("94da56cd-e9ae-44c6-8c01-324630ab88f5"), "NE", "Niger" },
                    { new Guid("94e76938-f5e4-4c52-b089-af96714931a2"), "TL", "East Timor" },
                    { new Guid("95cc9bdd-4965-473e-a0b2-dd795c55acc6"), "ER", "Eritrea" },
                    { new Guid("95cdd89a-19db-4def-9dd1-333ecea905d2"), "CW", "Curacao" },
                    { new Guid("9820bdc5-ff40-42e9-83b5-533ce8d35275"), "KW", "Kuwait" },
                    { new Guid("992eea7b-0298-49e9-8a2c-ac2ede91b75d"), "ME", "Montenegro" },
                    { new Guid("996f0109-5180-41fb-a972-f89864763ef4"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("99ac3442-842f-4b0e-b001-2f2a147a1746"), "NU", "Niue" },
                    { new Guid("9a5bf306-073b-4c9b-bd11-5903b51db464"), "RW", "Rwanda" },
                    { new Guid("9b522149-e902-47d2-8314-232cac802465"), "AG", "Antigua and Barbuda" },
                    { new Guid("9c3ac7e0-c51c-40ce-a81f-55d1c8b9802d"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("9c444c45-d922-4267-b2b4-0f4e0d422cff"), "TH", "Thailand" },
                    { new Guid("9ca31e28-88b8-4ec0-b482-ba0d39ec22dd"), "SJ", "Svalbard and Jan Mayen" },
                    { new Guid("9f18879a-a1b3-46b1-b115-effdb0082d7f"), "ID", "Indonesia" },
                    { new Guid("a075a982-60d8-42fa-b51c-31251a1af8a7"), "MA", "Morocco" },
                    { new Guid("a1f9befd-c77f-4ae9-9f1c-1ffbf44a3d85"), "GT", "Guatemala" },
                    { new Guid("a2327898-6eba-4181-b6d0-0ff4258a005f"), "MS", "Montserrat" },
                    { new Guid("a2b5f9c6-6dda-46de-a04e-f36ff0825fdf"), "TC", "Turks and Caicos Islands" },
                    { new Guid("a5c8a478-99a3-47e7-acf1-8f22d5f89ea8"), "SI", "Slovenia" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("aafe5a8f-21b5-4e03-8eb4-49f5bf679a09"), "NL", "Netherlands" },
                    { new Guid("ab148a7b-af1d-429f-b9db-8a38945ea85a"), "CU", "Cuba" },
                    { new Guid("ab51097a-beac-4c21-b50e-06d85d349614"), "GN", "Guinea" },
                    { new Guid("ab7a2c78-8665-4d8b-9865-587026b909e0"), "HU", "Hungary" },
                    { new Guid("ae2b96b4-87a7-4b1b-a90d-706ffc275929"), "EC", "Ecuador" },
                    { new Guid("b1e61bb7-f1c0-4826-88a1-cad5b0f999e3"), "KH", "Cambodia" },
                    { new Guid("b39931c3-ae8c-4330-bed0-0c640b172c75"), "LT", "Lithuania" },
                    { new Guid("b75979c7-b93f-42a8-a17a-453456e96d21"), "FJ", "Fiji" },
                    { new Guid("b9c82b04-0c35-435f-a922-9121d0b131d5"), "GM", "Gambia" },
                    { new Guid("bb654cce-255d-4fb4-856a-e266d0ba4c3b"), "RU", "Russia" },
                    { new Guid("bbb119c9-f59a-455b-91df-f9bdfc899861"), "SL", "Sierra Leone" },
                    { new Guid("beff92ec-24c2-4d58-a2bd-61ee63d3a796"), "GU", "Guam" },
                    { new Guid("bf66644b-1eff-40e9-aaac-bc8e5dce4026"), "AQ", "Antarctica" },
                    { new Guid("c05b3158-0b0b-4e6e-97c8-d3b2a6781daa"), "IO", "British Indian Ocean Territory" },
                    { new Guid("c18f8fca-d696-48ed-8d87-f29f5f582bba"), "ZM", "Zambia" },
                    { new Guid("c225c326-5eb3-4e86-8293-df0885678864"), "SS", "South Sudan" },
                    { new Guid("c29771b8-e284-4203-8de6-f299a9e252eb"), "TW", "Taiwan" },
                    { new Guid("c3aa5e2f-1d54-4c5c-8452-cefa08964db1"), "KP", "North Korea" },
                    { new Guid("c53fdafe-2256-4e86-86e8-93f915e41e26"), "NP", "Nepal" },
                    { new Guid("c630d70b-81b9-4a65-8cf8-7bd88e2d12b6"), "BV", "Bouvet Island" },
                    { new Guid("c64deef5-f6b2-4975-b702-9aac1794f49d"), "IN", "India" },
                    { new Guid("c78d2ab0-612e-4854-8b59-4f483075a351"), "AF", "Afghanistan" },
                    { new Guid("c7ae8f92-026c-4b73-8022-a2b2ce373efe"), "ZW", "Zimbabwe" },
                    { new Guid("cb0e4ed9-a5c8-4ff6-a980-1a768bcd323d"), "EE", "Estonia" },
                    { new Guid("ccdadd9a-40f9-4709-93c9-bf2c7f929ebf"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("ce320fc7-1421-4995-970f-c050d275a0b9"), "BD", "Bangladesh" },
                    { new Guid("ce73a5e5-2e36-469c-8a91-1ca274217e99"), "RO", "Romania" },
                    { new Guid("cef6fd1e-fe16-40d0-a2c9-17148fdfb3c1"), "PY", "Paraguay" },
                    { new Guid("cf6d633c-f54f-41dd-acf9-31baa248b5e6"), "GW", "Guinea-Bissau" },
                    { new Guid("cfe6fc2b-fa4b-4121-b3b0-99cbba30e35f"), "MM", "Myanmar" },
                    { new Guid("d06bd687-6f5b-411b-bf35-540ac3a14635"), "AS", "American Samoa" },
                    { new Guid("d3463a03-06c6-4d0d-afce-e59c30a40670"), "DE", "Germany" },
                    { new Guid("d4011780-af3b-460b-99fb-9a330e57e224"), "TG", "Togo" },
                    { new Guid("d4750d54-1344-4caa-ab61-a7957552f363"), "CN", "China" },
                    { new Guid("d8861e22-1ed4-4452-a837-200c4328125f"), "GY", "Guyana" },
                    { new Guid("d8d5d697-0a30-46f8-b8e1-a8142b031095"), "SH", "Saint Helena" },
                    { new Guid("d9aec02e-2622-43cb-b70b-38f19a60f12d"), "BS", "Bahamas" },
                    { new Guid("dad6a274-e6c6-4ed8-bc23-f1795c482474"), "MW", "Malawi" },
                    { new Guid("db5ef375-f778-4a52-b67f-d5882da0da47"), "SC", "Seychelles" },
                    { new Guid("dbae8e68-743b-4489-87bd-4d55c9b655b6"), "FM", "Micronesia" },
                    { new Guid("dcffc723-199b-4c54-a7ea-58647dcc706c"), "CG", "Republic of the Congo" },
                    { new Guid("dd1186f2-81a1-4204-82bd-998e4faf5b43"), "IL", "Israel" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("defb7ef4-a691-4bf7-83f1-b4a9f48f0390"), "SM", "San Marino" },
                    { new Guid("dfdee4b9-0871-4c49-8ef5-bb47921be429"), "ES", "Spain" },
                    { new Guid("e02d4087-4f9e-4866-b793-6e00a8f8c223"), "HK", "Hong Kong" },
                    { new Guid("e159ccb2-831b-47a9-958d-ab47aa9fdaac"), "NO", "Norway" },
                    { new Guid("e17f9089-d34a-493d-96d5-8125820db44a"), "MZ", "Mozambique" },
                    { new Guid("e22765c4-37b6-4f8a-8be7-069168b7d2a7"), "PW", "Palau" },
                    { new Guid("e32d5907-aea6-41d1-9c85-d6c7179d4133"), "MD", "Moldova" },
                    { new Guid("e3c01914-609b-4f07-b937-1a262ce7eebd"), "IQ", "Iraq" },
                    { new Guid("e41a7310-f06d-4f51-b31a-da793821eb95"), "CA", "Canada" },
                    { new Guid("e450f713-fd80-4fc1-a881-b551299b17c1"), "NR", "Nauru" },
                    { new Guid("e693fb53-43a6-4c52-99f8-a76276e234d5"), "PF", "French Polynesia" },
                    { new Guid("e82bad63-87c5-4227-bfc2-6e29d97fcfc1"), "SB", "Solomon Islands" },
                    { new Guid("e853e150-5016-49fa-8df2-b664b4617a99"), "IM", "Isle of Man" },
                    { new Guid("e8e8d773-bba6-4607-9b81-c10d66c37317"), "AT", "Austria" },
                    { new Guid("ec301cf4-e6d3-48e0-a49b-e8399ec2f4c0"), "AE", "United Arab Emirates" },
                    { new Guid("ecb16cec-f1c3-42dd-a672-d65706f308fe"), "SD", "Sudan" },
                    { new Guid("ecb796ba-0020-48ed-9ff5-2d7dfcfbf4fc"), "JE", "Jersey" },
                    { new Guid("ecdd5070-8261-48a0-ad67-e954f0325c88"), "RE", "Reunion" },
                    { new Guid("ed43499a-abf3-4a3a-be4d-e9c82037d0c8"), "BJ", "Benin" },
                    { new Guid("efbf97bc-5df4-401e-aa33-fe96eaf76839"), "ZA", "South Africa" },
                    { new Guid("f0b80579-9d19-419d-b1b4-2e45c5238cf9"), "MX", "Mexico" },
                    { new Guid("f1221d51-2868-4dfb-b199-c595dbbf02dd"), "GS", "South Georgia and the South Sandwich Islands" },
                    { new Guid("f1717e08-6d41-4ffb-be01-864777b76510"), "CY", "Cyprus" },
                    { new Guid("f18ed599-4adb-491a-ae19-8083ec44dbdb"), "ET", "Ethiopia" },
                    { new Guid("f2a11532-f612-44ab-80c2-2482028d5019"), "SV", "El Salvador" },
                    { new Guid("f5195a9d-3fba-4d3d-92ed-b56f151b4087"), "UZ", "Uzbekistan" },
                    { new Guid("f590e513-95ec-42b7-9240-062c7cda4868"), "LB", "Lebanon" },
                    { new Guid("f5c2f7fc-59ed-4903-add4-ba60cdbe3985"), "NZ", "New Zealand" },
                    { new Guid("f5d8ea11-5aa0-46ae-9109-4dc8fc32ca66"), "HN", "Honduras" },
                    { new Guid("f6ef76bb-61bd-475e-9c2f-f11f6083395f"), "TF", "French Southern Territories" },
                    { new Guid("f7002427-1e66-40c1-b22f-3bef7f6aa803"), "NC", "New Caledonia" },
                    { new Guid("f71309dc-138e-4220-ad77-1ddab20965f6"), "NG", "Nigeria" },
                    { new Guid("f899fbac-f6d8-4c83-b332-7bb88d92fd8f"), "VN", "Vietnam" },
                    { new Guid("f90080b2-c6bd-4ab8-bf5e-442450012fd0"), "CL", "Chile" },
                    { new Guid("f9b69cf6-8220-449a-976a-176461a42540"), "AD", "Andorra" },
                    { new Guid("fa948058-f3a1-4783-ae4e-070b714dd277"), "VE", "Venezuela" },
                    { new Guid("faf6c0d1-ee2b-4e19-a731-c480c0ba68a0"), "NA", "Namibia" },
                    { new Guid("fcb99754-151d-4b36-84d0-da74a9663923"), "MT", "Malta" },
                    { new Guid("fd60ad79-10aa-44cf-a2c4-abd29bdd6d81"), "LS", "Lesotho" },
                    { new Guid("fe0db153-37d9-4e9c-9306-817a1fa25aa4"), "CX", "Christmas Island" },
                    { new Guid("fe22137d-9964-4a23-853f-0694e679ebd5"), "HR", "Croatia" },
                    { new Guid("ffe48143-ef78-4193-a3ad-57910439d48d"), "MF", "Saint Martin" }
                });
        }
    }
}
