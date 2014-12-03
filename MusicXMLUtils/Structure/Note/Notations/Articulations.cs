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
    [XmlType("articulations")]
    public class Articulations : ItemHolder<ArticulationsItem>
    {
        [XmlElement("accent", typeof(EmptyPlacement))]
        [XmlElement("breath-mark", typeof(BreathMark))]
        [XmlElement("caesura", typeof(EmptyPlacement))]
        [XmlElement("detached-legato", typeof(EmptyPlacement))]
        [XmlElement("doit", typeof(EmptyLine))]
        [XmlElement("falloff", typeof(EmptyLine))]
        [XmlElement("other-articulation", typeof(PlacementText))]
        [XmlElement("plop", typeof(EmptyLine))]
        [XmlElement("scoop", typeof(EmptyLine))]
        [XmlElement("spiccato", typeof(EmptyPlacement))]
        [XmlElement("staccatissimo", typeof(EmptyPlacement))]
        [XmlElement("staccato", typeof(EmptyPlacement))]
        [XmlElement("stress", typeof(EmptyPlacement))]
        [XmlElement("strong-accent", typeof(StrongAccent))]
        [XmlElement("tenuto", typeof(EmptyPlacement))]
        [XmlElement("unstress", typeof(EmptyPlacement))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public override object[] Items { get; set; }

        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public override ArticulationsItem[] ItemsElementName { get; set; }
    }
}
