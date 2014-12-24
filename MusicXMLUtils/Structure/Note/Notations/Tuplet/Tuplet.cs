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
    [XmlType("tuplet")]
    public class Tuplet
    {
        #region -- Public Properties --
        [XmlElement("tuplet-actual")]
        public TupletPortion TupletActual { get; set; }

        [XmlElement("tuplet-normal")]
        public TupletPortion TupletNormal { get; set; }

        [XmlAttribute("type")]
        public StartStop Type { get; set; }

        [XmlAttribute("number", DataType = "positiveInteger")]
        public string Number { get; set; }

        [XmlAttribute("bracket")]
        public YesNo Bracket { get; set; }

        [XmlIgnore]
        public bool BracketSpecified { get; set; }

        [XmlAttribute("show-number")]
        public ShowTuplet ShowNumber { get; set; }

        [XmlIgnore]
        public bool ShowNumberSpecified { get; set; }

        [XmlAttribute("show-type")]
        public ShowTuplet ShowType { get; set; }

        [XmlIgnore]
        public bool ShowTypeSpecified { get; set; }

        [XmlAttribute("line-shape")]
        public LineShape LineShape { get; set; }

        [XmlIgnore]
        public bool LineShapeSpecified { get; set; }

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

        [XmlAttribute("placement")]
        public AboveBelow Placement { get; set; }

        [XmlIgnore]
        public bool PlacementSpecified { get; set; }
        #endregion
    }
}
