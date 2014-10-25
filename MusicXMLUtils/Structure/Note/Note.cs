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
    [XmlType("note")]
    public class Note
    {
        [XmlElement("chord", typeof(Empty))]
        [XmlElement("cue", typeof(Empty))]
        [XmlElement("duration", typeof(decimal))]
        [XmlElement("grace", typeof(Grace))]
        [XmlElement("pitch", typeof(Pitch))]
        [XmlElement("rest", typeof(Rest))]
        [XmlElement("tie", typeof(Tie))]
        [XmlElement("unpitched", typeof(Unpitched))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public NoteItem[] ItemsElementName { get; set; }

        [XmlElement("instrument")]
        public Instrument Instrument { get; set; }

        [XmlElement("footnote")]
        public FormattedText Footnote { get; set; }

        [XmlElement("level")]
        public Level Level { get; set; }

        [XmlElement("voice")]
        public string Voice { get; set; }

        [XmlElement("type")]
        public NoteType Type { get; set; }

        [XmlElement("dot")]
        public EmptyPlacement[] Dot { get; set; }

        [XmlElement("accidental")]
        public Accidental Accidental { get; set; }

        [XmlElement("time-modification")]
        public TimeModification TimeModification { get; set; }

        [XmlElement("stem")]
        public Stem Stem { get; set; }

        [XmlElement("notehead")]
        public Notehead Notehead { get; set; }

        [XmlElement("notehead-text")]
        public NoteheadText NoteheadText { get; set; }

        [XmlElement("staff", DataType = "positiveInteger")]
        public string Staff { get; set; }

        [XmlElement("beam")]
        public Beam[] Beam { get; set; }

        [XmlElement("notations")]
        public Notations[] Notations { get; set; }

        [XmlElement("lyric")]
        public Lyric[] Lyric { get; set; }

        [XmlElement("play")]
        public Play Play { get; set; }

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

        [XmlAttribute("font-family", DataType = "token")]
        public string FontFamily { get; set; }

        [XmlAttribute("font-style")]
        public FontStyle FontStyle { get; set; }

        [XmlIgnore]
        public bool FontStyleSpecified { get; set; }

        [XmlAttribute("font-size")]
        public string FontSize { get; set; }

        [XmlAttribute("font-weight")]
        public FontWeight FontWeight { get; set; }

        [XmlIgnore]
        public bool FontWeightSpecified { get; set; }

        [XmlAttribute("color", DataType = "token")]
        public string Color { get; set; }

        [XmlAttribute("print-dot")]
        public YesNo PrintDot { get; set; }

        [XmlIgnore]
        public bool PrintDotSpecified { get; set; }

        [XmlAttribute("print-lyric")]
        public YesNo PrintLyric { get; set; }

        [XmlIgnore]
        public bool PrintLyricSpecified { get; set; }

        [XmlAttribute("dynamics")]
        public decimal Dynamics { get; set; }

        [XmlIgnore]
        public bool DynamicsSpecified { get; set; }

        [XmlAttribute("end-dynamics")]
        public decimal EndDynamics { get; set; }

        [XmlIgnore]
        public bool EndDynamicsSpecified { get; set; }

        [XmlAttribute("attack")]
        public decimal Attack { get; set; }

        [XmlIgnore]
        public bool AttackSpecified { get; set; }

        [XmlAttribute("release")]
        public decimal Release { get; set; }

        [XmlIgnore]
        public bool ReleaseSpecified { get; set; }

        [XmlAttribute("time-only", DataType = "token")]
        public string TimeOnly { get; set; }

        [XmlAttribute("pizzicato")]
        public YesNo Pizzicato { get; set; }

        [XmlIgnore]
        public bool PizzicatoSpecified { get; set; }
    }
}
