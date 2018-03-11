using System.Collections;

namespace PraticeClass
{
    public class Encapsulation
    {
        private readonly ArrayList _list;
        public Encapsulation()
        {
            this._list = new ArrayList();
        }

        public ArrayList List
        {
            get
            {
                return this._list;
            }
        }
    }
}
