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
using System.Xml.Serialization;

namespace MusicXMLUtils.Structure
{
    [GeneratedCode("xsd", "4.0.30319.18020")]
    [Serializable]
    [XmlType(TypeName = "beater-value")]
    public enum BeaterValue
    {
        [XmlEnum("bow")]
        Bow,

        [XmlEnum("chime hammer")]
        ChimeHammer,

        [XmlEnum("coin")]
        Coin,

        [XmlEnum("finger")]
        Finger,

        [XmlEnum("fingernail")]
        Fingernail,

        [XmlEnum("fist")]
        Fist,

        [XmlEnum("guiro scraper")]
        GuiroScraper,

        [XmlEnum("hammer")]
        Hammer,

        [XmlEnum("hand")]
        Hand,

        [XmlEnum("jazz stick")]
        JazzStick,

        [XmlEnum("knitting needle")]
        KnittingNeedle,

        [XmlEnum("metal hammer")]
        MetalHammer,

        [XmlEnum("snare stick")]
        SnareStick,

        [XmlEnum("spoon mallet")]
        SpoonMallet,

        [XmlEnum("triangle beater")]
        TriangleBeater,

        [XmlEnum("triangle beater plain")]
        TriangleBeaterPlain,

        [XmlEnum("wire brush")]
        WireBrush,
    }
}
