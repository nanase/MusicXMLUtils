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
    [XmlType("sound")]
    public class Sound
    {
        [XmlElement("midi-device")]
        public MidiDevice[] MidiDevice { get; set; }

        [XmlElement("midi-instrument")]
        public MidiInstrument[] MidiInstrument { get; set; }

        [XmlElement("play")]
        public Play[] Play { get; set; }

        [XmlElement("offset")]
        public Offset Offset { get; set; }

        [XmlAttribute("tempo")]
        public decimal Tempo { get; set; }

        [XmlIgnore]
        public bool TempoSpecified { get; set; }

        [XmlAttribute("dynamics")]
        public decimal Dynamics { get; set; }

        [XmlIgnore]
        public bool DynamicsSpecified { get; set; }

        [XmlAttribute("dacapo")]
        public YesNo Dacapo { get; set; }

        [XmlIgnore]
        public bool DacapoSpecified { get; set; }

        [XmlAttribute("segno", DataType = "token")]
        public string Segno { get; set; }

        [XmlAttribute("dalsegno", DataType = "token")]
        public string Dalsegno { get; set; }

        [XmlAttribute("coda", DataType = "token")]
        public string Coda { get; set; }

        [XmlAttribute("tocoda", DataType = "token")]
        public string Tocoda { get; set; }

        [XmlAttribute("divisions")]
        public decimal Divisions { get; set; }

        [XmlIgnore]
        public bool DivisionsSpecified { get; set; }

        [XmlAttribute("forward-repeat")]
        public YesNo ForwardRepeat { get; set; }

        [XmlIgnore]
        public bool ForwardRepeatSpecified { get; set; }

        [XmlAttribute("fine", DataType = "token")]
        public string Fine { get; set; }

        [XmlAttribute("time-only", DataType = "token")]
        public string TimeOnly { get; set; }

        [XmlAttribute("pizzicato")]
        public YesNo Pizzicato { get; set; }

        [XmlIgnore]
        public bool PizzicatoSpecified { get; set; }

        [XmlAttribute("pan")]
        public decimal Pan { get; set; }

        [XmlIgnore]
        public bool PanSpecified { get; set; }

        [XmlAttribute("elevation")]
        public decimal Elevation { get; set; }

        [XmlIgnore]
        public bool ElevationSpecified { get; set; }

        [XmlAttribute("damper-pedal")]
        public string DamperPedal { get; set; }

        [XmlAttribute("soft-pedal")]
        public string SoftPedal { get; set; }

        [XmlAttribute("sostenuto-pedal")]
        public string SostenutoPedal { get; set; }
    }
}
