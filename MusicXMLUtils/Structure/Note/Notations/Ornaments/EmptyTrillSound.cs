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
    [XmlInclude(typeof(Mordent))]
    [GeneratedCode("xsd", "4.0.30319.18020")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(TypeName = "empty-trill-sound")]
    public class EmptyTrillSound
    {
        #region -- Public Properties --
        [XmlAttribute("placement")]
        public AboveBelow Placement { get; set; }

        [XmlIgnore]
        public bool PlacementSpecified { get; set; }

        [XmlAttribute("start-note")]
        public StartNote StartNote { get; set; }

        [XmlIgnore]
        public bool StartNoteSpecified { get; set; }

        [XmlAttribute("trill-step")]
        public TrillStep TrillStep { get; set; }

        [XmlIgnore]
        public bool TrillStepSpecified { get; set; }

        [XmlAttribute("two-note-turn")]
        public TwoNoteTurn TwoNoteTurn { get; set; }

        [XmlIgnore]
        public bool TwoNoteTurnSpecified { get; set; }

        [XmlAttribute("accelerate")]
        public YesNo Accelerate { get; set; }

        [XmlIgnore]
        public bool AccelerateSpecified { get; set; }

        [XmlAttribute("beats")]
        public decimal Beats { get; set; }

        [XmlIgnore]
        public bool BeatsSpecified { get; set; }

        [XmlAttribute("second-beat")]
        public decimal SecondBeat { get; set; }

        [XmlIgnore]
        public bool SecondBeatSpecified { get; set; }

        [XmlAttribute("last-beat")]
        public decimal LastBeat { get; set; }

        [XmlIgnore]
        public bool LastBeatSpecified { get; set; }
        #endregion
    }
}
