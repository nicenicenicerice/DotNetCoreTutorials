namespace LangConsoleApp.Categories
{
    [Flags]
    internal enum FlagCategory
    {
        None = 0,
        F01 = 1,
        F02 = 2,
        F03 = F01 | F02,
        F04 = 4,
        F05 = F01 | F04,
        F06 = F02 | F04,
        F07 = F01 | F02 | F04,
        F08 = 8,
        ALL = F01 | F02 | F04 | F08,
    }
}
