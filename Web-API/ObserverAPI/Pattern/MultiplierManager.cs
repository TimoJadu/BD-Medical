using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObserverAPI
{
    public class MultiplierManager : Iobservable
    {
        public string url = "http://localhost:2491/api/SecondaryWebAPI/Multiplier?multiplicand=";
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

    public interface Iobservable
    {
        string Value { get; set; }
        event EventHandler ValueChanged;
    }
}