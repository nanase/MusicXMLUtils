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
    [XmlType(TypeName = "direction-type")]
    public class DirectionType
    {
        [XmlElement("accordion-registration", typeof(AccordionRegistration))]
        [XmlElement("bracket", typeof(Bracket))]
        [XmlElement("coda", typeof(EmptyPrintStyleAlign))]
        [XmlElement("damp", typeof(EmptyPrintStyleAlign))]
        [XmlElement("damp-all", typeof(EmptyPrintStyleAlign))]
        [XmlElement("dashes", typeof(Dashes))]
        [XmlElement("dynamics", typeof(Dynamics))]
        [XmlElement("eyeglasses", typeof(EmptyPrintStyleAlign))]
        [XmlElement("harp-pedals", typeof(HarpPedals))]
        [XmlElement("image", typeof(Image))]
        [XmlElement("metronome", typeof(Metronome))]
        [XmlElement("octave-shift", typeof(OctaveShift))]
        [XmlElement("other-direction", typeof(OtherDirection))]
        [XmlElement("pedal", typeof(Pedal))]
        [XmlElement("percussion", typeof(Percussion))]
        [XmlElement("principal-voice", typeof(PrincipalVoice))]
        [XmlElement("rehearsal", typeof(FormattedText))]
        [XmlElement("scordatura", typeof(Scordatura))]
        [XmlElement("segno", typeof(EmptyPrintStyleAlign))]
        [XmlElement("string-mute", typeof(StringMute))]
        [XmlElement("wedge", typeof(Wedge))]
        [XmlElement("words", typeof(FormattedText))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType7[] ItemsElementName { get; set; }
    }
}
