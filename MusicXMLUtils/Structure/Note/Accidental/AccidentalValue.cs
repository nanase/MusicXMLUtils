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
    [XmlType(TypeName = "accidental-value")]
    public enum AccidentalValue
    {
        [XmlEnum("sharp")]
        Sharp,

        [XmlEnum("natural")]
        Natural,

        [XmlEnum("flat")]
        Flat,

        [XmlEnum("double-sharp")]
        DoubleSharp,

        [XmlEnum("sharp-sharp")]
        SharpSharp,

        [XmlEnum("flat-flat")]
        FlatFlat,

        [XmlEnum("natural-sharp")]
        NaturalSharp,

        [XmlEnum("natural-flat")]
        NaturalFlat,

        [XmlEnum("quarter-flat")]
        QuarterFlat,

        [XmlEnum("quarter-sharp")]
        QuarterSharp,

        [XmlEnum("three-quarters-flat")]
        ThreeQuartersFlat,

        [XmlEnum("three-quarters-sharp")]
        ThreeQuartersSharp,

        [XmlEnum("sharp-down")]
        SharpDown,

        [XmlEnum("sharp-up")]
        SharpUp,

        [XmlEnum("natural-down")]
        NaturalDown,

        [XmlEnum("natural-up")]
        NaturalUp,

        [XmlEnum("flat-down")]
        FlatDown,

        [XmlEnum("flat-up")]
        FlatUp,

        [XmlEnum("triple-sharp")]
        TripleSharp,

        [XmlEnum("triple-flat")]
        TripleFlat,

        [XmlEnum("slash-quarter-sharp")]
        SlashQuarterSharp,

        [XmlEnum("slash-sharp")]
        SlashSharp,

        [XmlEnum("slash-flat")]
        SlashFlat,

        [XmlEnum("double-slash-flat")]
        DoubleSlashFlat,

        [XmlEnum("sharp-1")]
        Sharp1,

        [XmlEnum("sharp-2")]
        Sharp2,

        [XmlEnum("sharp-3")]
        Sharp3,

        [XmlEnum("sharp-5")]
        Sharp5,

        [XmlEnum("flat-1")]
        Flat1,

        [XmlEnum("flat-2")]
        Flat2,

        [XmlEnum("flat-3")]
        Flat3,

        [XmlEnum("flat-4")]
        Flat4,

        [XmlEnum("sori")]
        Sori,

        [XmlEnum("koron")]
        Koron,
    }
}
