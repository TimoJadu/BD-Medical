using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObserverAPI
{
    ///public delegate void StateChangeHandler(string newValue);

    public class Processor
    {
        public Processor(Iobservable observable)
        {
            observable.ValueChanged += TheValueChanged;
        }

        private void TheValueChanged(Object sender, EventArgs e)
        {
            Console.Out.WriteLine("Value changed to " +
                ((Iobservable)sender).Value);
        }
    }

}