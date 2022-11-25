namespace WowPersonParsers.Helpers
{
    public static class ObdMemorialHelper
    {
        public const string Name = "Имя";
        public const string Surname = "Фамилия";
        public const string MiddleName = "Отчество";
        public const string Birthday = "Дата рождения/Возраст";
        public const string Birthplace = "Место рождения";
        public const string LastDutyStation = "Последнее место службы";
        public const string Rank = "Воинское звание";
        public const string Reason = "Причина выбытия";
        public const string BurialDate = "Дата выбытия";
        public const string BurialPlace = "Первичное место захоронения";
        public const string Source = "Название источника донесения";

        private static readonly Dictionary<string, string> _props = new ()
        {
            { Name, nameof(Name) },
            { Surname, nameof(Surname) },
            { MiddleName, nameof(MiddleName) },
            { Birthday, nameof(Birthday) },
            { Birthplace, nameof(Birthplace) },
            { LastDutyStation, nameof(LastDutyStation) },
            { Rank, nameof(Rank) },
            { Reason, nameof(Reason) },
            { BurialDate, nameof(BurialDate) },
            { BurialPlace, nameof(BurialPlace) },
            { Source, nameof(Source) }
        };

        public static string GetPropName(this string text) => _props.TryGetValue(text, out string value) ? value : string.Empty;

    }
}
