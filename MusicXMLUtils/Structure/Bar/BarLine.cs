/* MusicXMLUtils / Structure and Implementation of the MusicXML 3.0 

LICENSE - The MIT License (MIT)

Copyright (c) 2014 Tomona Nanase

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace MusicXMLUtils.Structure
{
    [GeneratedCode("xsd", "4.0.30319.18020")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType("barline")]
    public class BarLine
    {
        #region -- Public Properties --
        [XmlElement("bar-style")]
        public BarStyleColor BarStyle { get; set; }

        [XmlElement("footnote")]
        public FormattedText Footnote { get; set; }

        [XmlElement("level")]
        public Level Level { get; set; }

        [XmlElement("wavy-line")]
        public WavyLine WavyLine { get; set; }

        [XmlElement("segno")]
        public EmptyPrintStyleAlign Segno { get; set; }

        [XmlElement("coda")]
        public EmptyPrintStyleAlign Coda { get; set; }

        [XmlElement("fermata")]
        public Fermata[] Fermata { get; set; }

        [XmlElement("ending")]
        public Ending Ending { get; set; }

        [XmlElement("repeat")]
        public Repeat Repeat { get; set; }

        [XmlAttribute("location")]
        [DefaultValue(RightLeftMiddle.Right)]
        public RightLeftMiddle Location { get; set; }

        [XmlAttribute("segno1", DataType = "token")]
        public string Segno1 { get; set; }

        [XmlAttribute("coda1", DataType = "token")]
        public string Coda1 { get; set; }

        [XmlAttribute("divisions")]
        public decimal Divisions { get; set; }

        [XmlIgnore]
        public bool DivisionsSpecified { get; set; }
        #endregion

        #region -- Constructor --
        public BarLine()
        {
            this.Location = RightLeftMiddle.Right;
        }
        #endregion
    }
}
