namespace YourDynastySite.Models
{
    public class PersonViewModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Дата рождения/Возраст
        /// </summary>
        public string Birthday { get; set; }

        /// <summary>
        /// Место рождения
        /// </summary>
        public string Birthplace { get; set; }

        /// <summary>
        /// Последнее место службы
        /// </summary>
        public string LastDutyStation { get; set; }

        /// <summary>
        /// Воинское звание
        /// </summary>
        public string Rank { get; set; }

        /// <summary>
        /// Причина выбытия
        /// </summary>
        public string ReasonOut { get; set; }

        /// <summary>
        /// Первичное место захоронения
        /// </summary>
        public string BurialPlace { get; set; }

        /// <summary>
        /// Дата выбытия
        /// </summary>
        public string BurialDate { get; set; }

        /// <summary>
        /// Название источника донесения
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Ссылка на источник memorial
        /// </summary>
        public string Link { get; set; }
    }
}
