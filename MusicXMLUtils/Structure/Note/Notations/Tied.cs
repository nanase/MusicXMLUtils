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
    [XmlType("tied")]
    public class Tied
    {
        #region -- Public Properties --
        [XmlAttribute("type")]
        public StartStopContinue Type { get; set; }

        [XmlAttribute("number", DataType = "positiveInteger")]
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

        [XmlAttribute("orientation")]
        public OverUnder Orientation { get; set; }

        [XmlIgnore]
        public bool OrientationSpecified { get; set; }

        [XmlAttribute("bezier-offset")]
        public decimal BezierOffset { get; set; }

        [XmlIgnore]
        public bool BezierOffsetSpecified { get; set; }

        [XmlAttribute("bezier-offset2")]
        public decimal BezierOffset2 { get; set; }

        [XmlIgnore]
        public bool BezierOffset2Specified { get; set; }

        [XmlAttribute("bezier-x")]
        public decimal BezierX { get; set; }

        [XmlIgnore]
        public bool BezierXSpecified { get; set; }

        [XmlAttribute("bezier-y")]
        public decimal BezierY { get; set; }

        [XmlIgnore]
        public bool BezierYSpecified { get; set; }

        [XmlAttribute("bezier-x2")]
        public decimal BezierX2 { get; set; }

        [XmlIgnore]
        public bool BezierX2Specified { get; set; }

        [XmlAttribute("bezier-y2")]
        public decimal BezierY2 { get; set; }

        [XmlIgnore]
        public bool BezierY2Specified { get; set; }

        [XmlAttribute("color", DataType = "token")]
        public string Color { get; set; }
        #endregion
    }
}
