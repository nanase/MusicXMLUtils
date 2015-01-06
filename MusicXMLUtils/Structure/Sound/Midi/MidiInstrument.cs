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
    [XmlType(TypeName = "midi-instrument")]
    public class MidiInstrument
    {
        #region -- Public Properties --
        [XmlElement("midi-channel", DataType = "positiveInteger")]
        public string MidiChannel { get; set; }

        [XmlElement("midi-name")]
        public string MidiName { get; set; }

        [XmlElement("midi-bank", DataType = "positiveInteger")]
        public string MidiBank { get; set; }

        [XmlElement("midi-program", DataType = "positiveInteger")]
        public string MidiProgram { get; set; }

        [XmlElement("midi-unpitched", DataType = "positiveInteger")]
        public string MidiUnpitched { get; set; }

        [XmlElement("volume")]
        public decimal Volume { get; set; }

        [XmlIgnore]
        public bool VolumeSpecified { get; set; }

        [XmlElement("pan")]
        public decimal Pan { get; set; }

        [XmlIgnore]
        public bool PanSpecified { get; set; }

        [XmlElement("elevation")]
        public decimal Elevation { get; set; }

        [XmlIgnore]
        public bool ElevationSpecified { get; set; }

        [XmlAttribute("id", DataType = "IDREF")]
        public string Id { get; set; }
        #endregion
    }
}
