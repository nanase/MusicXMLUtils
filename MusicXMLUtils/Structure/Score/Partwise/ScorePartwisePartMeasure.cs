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
    [XmlType(TypeName = "scorepartwisePartMeasure", AnonymousType = true)]
    public class ScorePartwisePartMeasure
    {
        [XmlElement("attributes", typeof(Attributes))]
        [XmlElement("backup", typeof(Backup))]
        [XmlElement("barline", typeof(BarLine))]
        [XmlElement("bookmark", typeof(Bookmark))]
        [XmlElement("direction", typeof(Direction))]
        [XmlElement("figured-bass", typeof(FiguredBass))]
        [XmlElement("forward", typeof(Forward))]
        [XmlElement("grouping", typeof(Grouping))]
        [XmlElement("harmony", typeof(Harmony))]
        [XmlElement("link", typeof(Link))]
        [XmlElement("note", typeof(Note))]
        [XmlElement("print", typeof(Print))]
        [XmlElement("sound", typeof(Sound))]
        public object[] Items { get; set; }

        [XmlAttribute("number", DataType = "token")]
        public string Number { get; set; }

        [XmlAttribute("implicit")]
        public YesNo Implicit { get; set; }

        [XmlIgnore]
        public bool ImplicitSpecified { get; set; }

        [XmlAttribute("non-controlling")]
        public YesNo NonControlling { get; set; }

        [XmlIgnore]
        public bool NonControllingSpecified { get; set; }

        [XmlAttribute("width")]
        public decimal Width { get; set; }

        [XmlIgnore]
        public bool WidthSpecified { get; set; }
    }
}