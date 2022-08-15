using Microsoft.EntityFrameworkCore;
using ShippingApi.Infrastructure.Entities;

namespace ShippingApi.Infrastructure.Extensions
{
    public static class CountrySeed
    {
        public static void SeedCountries(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Afghanistan",
                        Code = "AF"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Aland Islands",
                        Code = "AX"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Albania",
                        Code = "AL"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Algeria",
                        Code = "DZ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "American Samoa",
                        Code = "AS"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Andorra",
                        Code = "AD"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Angola",
                        Code = "AO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Anguilla",
                        Code = "AI"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Antarctica",
                        Code = "AQ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Antigua and Barbuda",
                        Code = "AG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Argentina",
                        Code = "AR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Armenia",
                        Code = "AM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Aruba",
                        Code = "AW"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Australia",
                        Code = "AU"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Austria",
                        Code = "AT"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Azerbaijan",
                        Code = "AZ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bahamas",
                        Code = "BS"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bahrain",
                        Code = "BH"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bangladesh",
                        Code = "BD"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Barbados",
                        Code = "BB"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Belarus",
                        Code = "BY"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Belgium",
                        Code = "BE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Belize",
                        Code = "BZ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Benin",
                        Code = "BJ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bermuda",
                        Code = "BM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bhutan",
                        Code = "BT"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bolivia",
                        Code = "BO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bonaire Saint Eustatius and Saba",
                        Code = "BQ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bosnia and Herzegovina",
                        Code = "BA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Botswana",
                        Code = "BW"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bouvet Island",
                        Code = "BV"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Brazil",
                        Code = "BR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "British Indian Ocean Territory",
                        Code = "IO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "British Virgin Islands",
                        Code = "VG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Brunei",
                        Code = "BN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bulgaria",
                        Code = "BG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Burkina Faso",
                        Code = "BF"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Burundi",
                        Code = "BI"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cambodia",
                        Code = "KH"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cameroon",
                        Code = "CM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Canada",
                        Code = "CA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cape Verde",
                        Code = "CV"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cayman Islands",
                        Code = "KY"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Central African Republic",
                        Code = "CF"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Chad",
                        Code = "TD"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Chile",
                        Code = "CL"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "China",
                        Code = "CN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Christmas Island",
                        Code = "CX"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cocos Islands",
                        Code = "CC"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Colombia",
                        Code = "CO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Comoros",
                        Code = "KM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cook Islands",
                        Code = "CK"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Costa Rica",
                        Code = "CR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Croatia",
                        Code = "HR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cuba",
                        Code = "CU"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Curacao",
                        Code = "CW"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cyprus",
                        Code = "CY"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Czech Republic",
                        Code = "CZ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Democratic Republic of the Congo",
                        Code = "CD"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Denmark",
                        Code = "DK"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Djibouti",
                        Code = "DJ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Dominica",
                        Code = "DM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Dominican Republic",
                        Code = "DO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "East Timor",
                        Code = "TL"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ecuador",
                        Code = "EC"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Egypt",
                        Code = "EG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "El Salvador",
                        Code = "SV"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Equatorial Guinea",
                        Code = "GQ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Eritrea",
                        Code = "ER"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Estonia",
                        Code = "EE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ethiopia",
                        Code = "ET"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Falkland Islands",
                        Code = "FK"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Faroe Islands",
                        Code = "FO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fiji",
                        Code = "FJ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Finland",
                        Code = "FI"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "France",
                        Code = "FR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "French Guiana",
                        Code = "GF"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "French Polynesia",
                        Code = "PF"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "French Southern Territories",
                        Code = "TF"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Gabon",
                        Code = "GA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Gambia",
                        Code = "GM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Georgia",
                        Code = "GE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Germany",
                        Code = "DE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ghana",
                        Code = "GH"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Gibraltar",
                        Code = "GI"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Greece",
                        Code = "GR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Greenland",
                        Code = "GL"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Grenada",
                        Code = "GD"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Guadeloupe",
                        Code = "GP"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Guam",
                        Code = "GU"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Guatemala",
                        Code = "GT"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Guernsey",
                        Code = "GG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Guinea",
                        Code = "GN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Guinea-Bissau",
                        Code = "GW"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Guyana",
                        Code = "GY"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Haiti",
                        Code = "HT"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Heard Island and McDonald Islands",
                        Code = "HM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Honduras",
                        Code = "HN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Hong Kong",
                        Code = "HK"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Hungary",
                        Code = "HU"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Iceland",
                        Code = "IS"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "India",
                        Code = "IN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Indonesia",
                        Code = "ID"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Iran",
                        Code = "IR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Iraq",
                        Code = "IQ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ireland",
                        Code = "IE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Isle of Man",
                        Code = "IM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Israel",
                        Code = "IL"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Italy",
                        Code = "IT"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ivory Coast",
                        Code = "CI"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Jamaica",
                        Code = "JM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Japan",
                        Code = "JP"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Jersey",
                        Code = "JE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Jordan",
                        Code = "JO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Kazakhstan",
                        Code = "KZ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Kenya",
                        Code = "KE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Kiribati",
                        Code = "KI"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Kosovo",
                        Code = "XK"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Kuwait",
                        Code = "KW"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Kyrgyzstan",
                        Code = "KG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Laos",
                        Code = "LA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Latvia",
                        Code = "LV"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Lebanon",
                        Code = "LB"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Lesotho",
                        Code = "LS"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Liberia",
                        Code = "LR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Libya",
                        Code = "LY"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Liechtenstein",
                        Code = "LI"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Lithuania",
                        Code = "LT"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Luxembourg",
                        Code = "LU"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Macao",
                        Code = "MO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Macedonia",
                        Code = "MK"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Madagascar",
                        Code = "MG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Malawi",
                        Code = "MW"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Malaysia",
                        Code = "MY"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Maldives",
                        Code = "MV"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mali",
                        Code = "ML"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Malta",
                        Code = "MT"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Marshall Islands",
                        Code = "MH"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Martinique",
                        Code = "MQ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mauritania",
                        Code = "MR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mauritius",
                        Code = "MU"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mayotte",
                        Code = "YT"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mexico",
                        Code = "MX"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Micronesia",
                        Code = "FM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Moldova",
                        Code = "MD"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Monaco",
                        Code = "MC"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mongolia",
                        Code = "MN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Montenegro",
                        Code = "ME"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Montserrat",
                        Code = "MS"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Morocco",
                        Code = "MA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mozambique",
                        Code = "MZ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Myanmar",
                        Code = "MM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Namibia",
                        Code = "NA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Nauru",
                        Code = "NR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Nepal",
                        Code = "NP"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Netherlands",
                        Code = "NL"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Netherlands Antilles",
                        Code = "AN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "New Caledonia",
                        Code = "NC"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "New Zealand",
                        Code = "NZ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Nicaragua",
                        Code = "NI"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Niger",
                        Code = "NE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Nigeria",
                        Code = "NG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Niue",
                        Code = "NU"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Norfolk Island",
                        Code = "NF"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "North Korea",
                        Code = "KP"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Northern Mariana Islands",
                        Code = "MP"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Norway",
                        Code = "NO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Oman",
                        Code = "OM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pakistan",
                        Code = "PK"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Palau",
                        Code = "PW"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Palestinian Territory",
                        Code = "PS"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Panama",
                        Code = "PA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Papua New Guinea",
                        Code = "PG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Paraguay",
                        Code = "PY"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Peru",
                        Code = "PE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Philippines",
                        Code = "PH"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pitcairn",
                        Code = "PN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Poland",
                        Code = "PL"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Portugal",
                        Code = "PT"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Puerto Rico",
                        Code = "PR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Qatar",
                        Code = "QA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Republic of the Congo",
                        Code = "CG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Reunion",
                        Code = "RE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Romania",
                        Code = "RO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Russia",
                        Code = "RU"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rwanda",
                        Code = "RW"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Saint Barthelemy",
                        Code = "BL"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Saint Helena",
                        Code = "SH"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Saint Kitts and Nevis",
                        Code = "KN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Saint Lucia",
                        Code = "LC"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Saint Martin",
                        Code = "MF"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Saint Pierre and Miquelon",
                        Code = "PM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Saint Vincent and the Grenadines",
                        Code = "VC"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Samoa",
                        Code = "WS"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "San Marino",
                        Code = "SM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sao Tome and Principe",
                        Code = "ST"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Saudi Arabia",
                        Code = "SA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Senegal",
                        Code = "SN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Serbia",
                        Code = "RS"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Serbia and Montenegro",
                        Code = "CS"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Seychelles",
                        Code = "SC"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sierra Leone",
                        Code = "SL"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Singapore",
                        Code = "SG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sint Maarten",
                        Code = "SX"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Slovakia",
                        Code = "SK"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Slovenia",
                        Code = "SI"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Solomon Islands",
                        Code = "SB"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Somalia",
                        Code = "SO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "South Africa",
                        Code = "ZA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "South Georgia and the South Sandwich Islands",
                        Code = "GS"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "South Korea",
                        Code = "KR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "South Sudan",
                        Code = "SS"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Spain",
                        Code = "ES"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sri Lanka",
                        Code = "LK"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sudan",
                        Code = "SD"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Suriname",
                        Code = "SR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Svalbard and Jan Mayen",
                        Code = "SJ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Swaziland",
                        Code = "SZ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sweden",
                        Code = "SE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Switzerland",
                        Code = "CH"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Syria",
                        Code = "SY"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Taiwan",
                        Code = "TW"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Tajikistan",
                        Code = "TJ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Tanzania",
                        Code = "TZ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Thailand",
                        Code = "TH"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Togo",
                        Code = "TG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Tokelau",
                        Code = "TK"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Tonga",
                        Code = "TO"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Trinidad and Tobago",
                        Code = "TT"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Tunisia",
                        Code = "TN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Turkey",
                        Code = "TR"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Turkmenistan",
                        Code = "TM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Turks and Caicos Islands",
                        Code = "TC"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Tuvalu",
                        Code = "TV"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "U.S. Virgin Islands",
                        Code = "VI"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Uganda",
                        Code = "UG"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ukraine",
                        Code = "UA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "United Arab Emirates",
                        Code = "AE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "United Kingdom",
                        Code = "GB"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "United States",
                        Code = "US"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "United States Minor Outlying Islands",
                        Code = "UM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Uruguay",
                        Code = "UY"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Uzbekistan",
                        Code = "UZ"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Vanuatu",
                        Code = "VU"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Vatican",
                        Code = "VA"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Venezuela",
                        Code = "VE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Vietnam",
                        Code = "VN"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Wallis and Futuna",
                        Code = "WF"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Western Sahara",
                        Code = "EH"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Yemen",
                        Code = "YE"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zambia",
                        Code = "ZM"
                    },
                    new Country
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zimbabwe",
                        Code = "ZW"
                    }
                );
        }
    }
}
