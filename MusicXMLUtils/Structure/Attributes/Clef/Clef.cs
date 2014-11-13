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
    [XmlType("clef")]
    public class Clef
    {
        [XmlElement("sign")]
        public ClefSign Sign { get; set; }

        [XmlElement("line", DataType = "integer")]
        public string Line { get; set; }

        [XmlElement("clef-octave-change", DataType = "integer")]
        public string ClefOctaveChange { get; set; }

        [XmlAttribute("number", DataType = "positiveInteger")]
        public string Number { get; set; }

        [XmlAttribute("additional")]
        public YesNo Additional { get; set; }

        [XmlIgnore]
        public bool AdditionalSpecified { get; set; }

        [XmlAttribute("size")]
        public SymbolSize Size { get; set; }

        [XmlIgnore]
        public bool SizeSpecified { get; set; }

        [XmlAttribute("after-barline")]
        public YesNo AfterBarline { get; set; }

        [XmlIgnore]
        public bool AfterBarlineSpecified { get; set; }

        [XmlAttribute("print-object")]
        public YesNo PrintObject { get; set; }

        [XmlIgnore]
        public bool PrintObjectSpecified { get; set; }

        public Clef()
        {
        }

        public Clef(ClefSign sign, string line)
        {
            if (line == null)
                throw new ArgumentNullException("line");

            this.Sign = sign;
            this.Line = line;
        }

        public Clef(ClefSign sign, int line)
        {
            this.Sign = sign;
            this.Line = line.ToString();
        }
    }
}
