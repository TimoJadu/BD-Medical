using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObserverAPI
{
    public class GeneratorManager: Iobservable
    {
        public string url = "http://localhost:2491/api/SecondaryWebAPI/Generator";
        private string _Value;

        public string Value
        {
            get { return _Value; }
            set
            {
                if (_Value != value)
                {
                    _Value = value;
                    OnValueChanged();
                }
            }
        }

        public event EventHandler ValueChanged;

        private void OnValueChanged()
        {
            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }
    }
}