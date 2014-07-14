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
    [XmlType("attributes")]
    public class Attributes
    {
        [XmlElement("footnote")]
        public FormattedText Footnote { get; set; }

        [XmlElement("level")]
        public Level Level { get; set; }

        [XmlElement("divisions")]
        public decimal Divisions { get; set; }

        [XmlIgnore]
        public bool DivisionsSpecified { get; set; }

        [XmlElement("key")]
        public Key[] Key { get; set; }

        [XmlElement("time")]
        public Time[] Time { get; set; }

        [XmlElement("staves", DataType = "nonNegativeInteger")]
        public string Staves { get; set; }

        [XmlElement("part-symbol")]
        public PartSymbol PartSymbol { get; set; }

        [XmlElement("instruments", DataType = "nonNegativeInteger")]
        public string Instruments { get; set; }

        [XmlElement("clef")]
        public Clef[] Clef { get; set; }

        [XmlElement("staff-details")]
        public StaffDetails[] StaffDetails { get; set; }

        [XmlElement("transpose")]
        public Transpose[] Transpose { get; set; }

        [XmlElement("directive")]
        public AttributesDirective[] Directive { get; set; }

        [XmlElement("measure-style")]
        public MeasureStyle[] MeasureStyle { get; set; }
    }
}
