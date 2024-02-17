using FakeHumans.Models;

namespace FakeHumans.Other;

public static class HumanContainer
{
    public static List<Human> Russians { get; set; } = new List<Human> 
    {
        new Human
        {
            FullName = "IVANOV DMITRY VLADIMIROVICH",
            DOB = new DateOnly(1999, 11, 10),
            Sex = "MALE",
            Country = "RUSSIA",
            CIT = "RUSSIA",
            Height = 191,
            EyesColor = "BROWN"
        },
        new Human
        {
            FullName = "KABARIDZE GURAM NODAROVICH",
            DOB = new DateOnly(2003, 11, 10),
            Sex = "MALE",
            Country = "GEORGIA",
            CIT = "RUSSIA",
            Height = 180,
            EyesColor = "BROWN"
        },
        new Human
        {
            FullName = "ORLOV SERGEY ALEKSANDROVICH",
            DOB = new DateOnly(1986, 02, 25),
            Sex = "MALE",
            Country = "RUSSIA",
            CIT = "RUSSIA",
            Height = 171,
            EyesColor = "BLUE-GREEN"
        },
        new Human
        {
            FullName = "DEMITROV MIHAIL VLADISLAVOVICH",
            DOB = new DateOnly(1997, 05, 19),
            Sex = "MALE",
            Country = "RUSSIA",
            CIT = "RUSSIA",
            Height = 187,
            EyesColor = "BLUE"
        }
    };

    public static List<Human> Germans { get; set; } = new List<Human>
    {
        new Human
        {
            FullName = "MAX MULLER",
            DOB = new DateOnly(1980, 9, 25),
            Sex = "MALE",
            Country = "GERMANY",
            CIT = "GERMANY",
            Height = 182,
            EyesColor = "BROWN"
        },
        new Human
        {
            FullName = "FELIX SCHMIDT",
            DOB = new DateOnly(1975, 7, 12),
            Sex = "MALE",
            Country = "GERMANY",
            CIT = "GERMANY",
            Height = 176,
            EyesColor = "BLUE"
        },
        new Human
        {
            FullName = "SEBASTIAN WAGNER",
            DOB = new DateOnly(1988, 4, 30),
            Sex = "MALE",
            Country = "GERMANY",
            CIT = "GERMANY",
            Height = 190,
            EyesColor = "GREEN"
        },
        new Human
        {
            FullName = "LUKAS FISHER",
            DOB = new DateOnly(1993, 11, 8),
            Sex = "MALE",
            Country = "GERMANY",
            CIT = "GERMANY",
            Height = 178,
            EyesColor = "BROWN"
        }
    };

    public static List<Human> Americans { get; set; } = new List<Human>
    {
        new Human
        {
            FullName = "JOHN SMITH",
            DOB = new DateOnly(1985, 6, 15),
            Sex = "MALE",
            Country = "USA",
            CIT = "USA",
            Height = 180,
            EyesColor = "BROWN"
        },
        new Human
        {
            FullName = "MICHAEL DAVIDSON",
            DOB = new DateOnly(1990, 3, 22),
            Sex = "MALE",
            Country = "USA",
            CIT = "USA",
            Height = 165,
            EyesColor = "GREEN"
        },
        new Human
        {
            FullName = "GERALD RICHARDSON JR",
            DOB = new DateOnly(1978, 8, 10),
            Sex = "MALE",
            Country = "USA",
            CIT = "USA",
            Height = 175,
            EyesColor = "BLUE"
        },
        new Human
        {
            FullName = "DONALD BRAVOS",
            DOB = new DateOnly(1983, 12, 5),
            Sex = "MALE",
            Country = "USA",
            CIT = "USA",
            Height = 186,
            EyesColor = "HAZEL"
        }
    };

    public static List<Human> Italians { get; set; } = new List<Human>
    {
        new Human
        {
            FullName = "MARCO ROSSI",
            DOB = new DateOnly(1985, 3, 15),
            Sex = "MALE",
            Country = "ITALY",
            CIT = "ITALY",
            Height = 175,
            EyesColor = "BROWN"
        },
        new Human
        {
            FullName = "GIOVANNI BIANCHI",
            DOB = new DateOnly(1977, 8, 22),
            Sex = "MALE",
            Country = "ITALY",
            CIT = "ITALY",
            Height = 180,
            EyesColor = "GREEN"
        },
        new Human
        {
            FullName = "LUACA FERRARI",
            DOB = new DateOnly(1990, 5, 10),
            Sex = "MALE",
            Country = "ITALY",
            CIT = "ITALY",
            Height = 182,
            EyesColor = "BROWN"
        },
        new Human
        {
            FullName = "ANTONIO RUSSO",
            DOB = new DateOnly(1983, 12, 5),
            Sex = "MALE",
            Country = "ITALY",
            CIT = "ITALY",
            Height = 178,
            EyesColor = "BLUE"
        }
    };
}
