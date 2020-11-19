using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Again_Paint
{
    class Container
    {
        public delegate void ObjectAddDelegate(Drawer f);
        public ObjectAddDelegate NotifyDelegate { get; set; }
        public event ObjectAddDelegate NotifyEvent;
        public List<Drawer> cFigures = new List<Drawer>();
        public void ToXml(string fileName)
        {
            XmlWriter writer = XmlWriter.Create(fileName);
        }
        public int Count
        {
            get { return cFigures.Count(); }
        }
        public Drawer this[int index]
        {
            get
            {
                return cFigures[index];
            }
            set
            {
                cFigures[index] = value;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return cFigures.GetEnumerator();
        }
        public void AddToContainer(Drawer figure) 
        { 
            cFigures.Add(figure);
            NotifyEvent?.Invoke(figure); 
        }
        public Drawer GetByIndex(int index) => cFigures[index];

    }
}
