using System;

namespace PraticeClass
{
    public class Person
    {
        private readonly DateTime _birthday;

        public string Name { get; set; }

        public Person(DateTime birthday)
        {
            this._birthday = birthday;
        }

        /// <summary>
        /// field _birthday 的封裝
        /// </summary>
        public DateTime Birthday
        {
            get { return _birthday; }
        }

        public int GetAge()
        {
            var timeSpan = DateTime.Today - this.Birthday;
            return timeSpan.Days / 365;
        }
    }
}
