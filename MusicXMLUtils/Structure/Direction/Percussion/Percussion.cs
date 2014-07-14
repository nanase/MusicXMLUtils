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
    [XmlType("percussion")]
    public class Percussion
    {
        [XmlElement("beater", typeof(Beater))]
        [XmlElement("effect", typeof(Effect))]
        [XmlElement("glass", typeof(Glass))]
        [XmlElement("membrane", typeof(Membrane))]
        [XmlElement("metal", typeof(Metal))]
        [XmlElement("other-percussion", typeof(string))]
        [XmlElement("pitched", typeof(Pitched))]
        [XmlElement("stick", typeof(Stick))]
        [XmlElement("stick-location", typeof(StickLocation))]
        [XmlElement("timpani", typeof(Empty))]
        [XmlElement("wood", typeof(Wood))]
        public object Item { get; set; }

        [XmlAttribute("enclosure")]
        public EnclosureShape Enclosure { get; set; }

        [XmlIgnore]
        public bool EnclosureSpecified { get; set; }
    }
}
