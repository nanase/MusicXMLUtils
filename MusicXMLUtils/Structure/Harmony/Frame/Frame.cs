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
    [XmlType("frame")]
    public class Frame
    {
        #region -- Public Properties --
        [XmlElement("frame-strings", DataType = "positiveInteger")]
        public string FrameStrings { get; set; }

        [XmlElement("frame-frets", DataType = "positiveInteger")]
        public string FrameFrets { get; set; }

        [XmlElement("first-fret")]
        public FirstFret FirstFret { get; set; }

        [XmlElement("frame-note")]
        public FrameNote[] FrameNote { get; set; }

        [XmlAttribute("default-x")]
        public decimal DefaultX { get; set; }

        [XmlIgnore]
        public bool DefaultXSpecified { get; set; }

        [XmlAttribute("default-y")]
        public decimal DefaultY { get; set; }

        [XmlIgnore]
        public bool DefaultYSpecified { get; set; }

        [XmlAttribute("relative-x")]
        public decimal RelativeX { get; set; }

        [XmlIgnore]
        public bool RelativeXSpecified { get; set; }

        [XmlAttribute("relative-y")]
        public decimal RelativeY { get; set; }

        [XmlIgnore]
        public bool RelativeYSpecified { get; set; }

        [XmlAttribute("color", DataType = "token")]
        public string Color { get; set; }

        [XmlAttribute("halign")]
        public LeftCenterRight Halign { get; set; }

        [XmlIgnore]
        public bool HalignSpecified { get; set; }

        [XmlAttribute("valign")]
        public ValignImage Valign { get; set; }

        [XmlIgnore]
        public bool ValignSpecified { get; set; }

        [XmlAttribute("height")]
        public decimal Height { get; set; }

        [XmlIgnore]
        public bool HeightSpecified { get; set; }

        [XmlAttribute("width")]
        public decimal Width { get; set; }

        [XmlIgnore]
        public bool WidthSpecified { get; set; }

        [XmlAttribute("unplayed", DataType = "token")]
        public string Unplayed { get; set; }
        #endregion
    }
}
