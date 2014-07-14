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
    [XmlType("dynamics")]
    public class Dynamics
    {
        [XmlElement("f", typeof(Empty))]
        [XmlElement("ff", typeof(Empty))]
        [XmlElement("fff", typeof(Empty))]
        [XmlElement("ffff", typeof(Empty))]
        [XmlElement("fffff", typeof(Empty))]
        [XmlElement("ffffff", typeof(Empty))]
        [XmlElement("fp", typeof(Empty))]
        [XmlElement("fz", typeof(Empty))]
        [XmlElement("mf", typeof(Empty))]
        [XmlElement("mp", typeof(Empty))]
        [XmlElement("other-dynamics", typeof(string))]
        [XmlElement("p", typeof(Empty))]
        [XmlElement("pp", typeof(Empty))]
        [XmlElement("ppp", typeof(Empty))]
        [XmlElement("pppp", typeof(Empty))]
        [XmlElement("ppppp", typeof(Empty))]
        [XmlElement("pppppp", typeof(Empty))]
        [XmlElement("rf", typeof(Empty))]
        [XmlElement("rfz", typeof(Empty))]
        [XmlElement("sf", typeof(Empty))]
        [XmlElement("sffz", typeof(Empty))]
        [XmlElement("sfp", typeof(Empty))]
        [XmlElement("sfpp", typeof(Empty))]
        [XmlElement("sfz", typeof(Empty))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType5[] ItemsElementName { get; set; }

        [XmlAttribute("placement")]
        public AboveBelow Placement { get; set; }

        [XmlIgnore]
        public bool PlacementSpecified { get; set; }

        [XmlAttribute("underline", DataType = "nonNegativeInteger")]
        public string Underline { get; set; }

        [XmlAttribute("overline", DataType = "nonNegativeInteger")]
        public string Overline { get; set; }

        [XmlAttribute("line-through", DataType = "nonNegativeInteger")]
        public string LineThrough { get; set; }

        [XmlAttribute("enclosure")]
        public EnclosureShape Enclosure { get; set; }

        [XmlIgnore]
        public bool EnclosureSpecified { get; set; }
    }
}
