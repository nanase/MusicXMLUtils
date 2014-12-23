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
    [XmlType("slide")]
    public class Slide
    {
        #region -- Public Properties --
        [XmlAttribute("type")]
        public StartStop Type { get; set; }

        [XmlAttribute("number", DataType = "positiveInteger")]
        [DefaultValue("1")]
        public string Number { get; set; }

        [XmlAttribute("line-type")]
        public LineType LineType { get; set; }

        [XmlIgnore]
        public bool LineTypeSpecified { get; set; }

        [XmlAttribute("dash-length")]
        public decimal DashLength { get; set; }

        [XmlIgnore]
        public bool DashLengthSpecified { get; set; }

        [XmlAttribute("space-length")]
        public decimal SpaceLength { get; set; }

        [XmlIgnore]
        public bool SpaceLengthSpecified { get; set; }

        [XmlAttribute("accelerate")]
        public YesNo Accelerate { get; set; }

        [XmlIgnore]
        public bool AccelerateSpecified { get; set; }

        [XmlAttribute("beats")]
        public decimal Beats { get; set; }

        [XmlIgnore]
        public bool BeatsSpecified { get; set; }

        [XmlAttribute("first-beat")]
        public decimal FirstBeat { get; set; }

        [XmlIgnore]
        public bool FirstBeatSpecified { get; set; }

        [XmlAttribute("last-beat")]
        public decimal LastBeat { get; set; }

        [XmlIgnore]
        public bool LastBeatSpecified { get; set; }

        [XmlText]
        public string Value { get; set; }
        #endregion

        #region -- Constructors --
        public Slide()
        {
            this.Number = "1";
        }
        #endregion
    }
}
