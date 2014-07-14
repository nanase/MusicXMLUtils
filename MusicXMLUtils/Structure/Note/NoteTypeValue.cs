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
    [XmlType(TypeName = "note-type-value")]
    public enum NoteTypeValue
    {
        [XmlEnum("1024th")]
        Item1024th,

        [XmlEnum("512th")]
        Item512th,

        [XmlEnum("256th")]
        Item256th,

        [XmlEnum("128th")]
        Item128th,

        [XmlEnum("64th")]
        Item64th,

        [XmlEnum("32nd")]
        Item32nd,

        [XmlEnum("16th")]
        Item16th,

        [XmlEnum("eighth")]
        Eighth,

        [XmlEnum("quarter")]
        Quarter,

        [XmlEnum("half")]
        Half,

        [XmlEnum("whole")]
        Whole,

        [XmlEnum("breve")]
        Breve,

        [XmlEnum("long")]
        Long,

        [XmlEnum("maxima")]
        Maxima,
    }
}
