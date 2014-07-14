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
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType3
    {
        [XmlEnum("arrow")]
        Arrow,

        [XmlEnum("bend")]
        Bend,

        [XmlEnum("double-tongue")]
        DoubleTongue,

        [XmlEnum("down-bow")]
        DownBow,

        [XmlEnum("fingering")]
        Fingering,

        [XmlEnum("fingernails")]
        Fingernails,

        [XmlEnum("fret")]
        Fret,

        [XmlEnum("hammer-on")]
        HammerOn,

        [XmlEnum("handbell")]
        Handbell,

        [XmlEnum("harmonic")]
        Harmonic,

        [XmlEnum("heel")]
        Heel,

        [XmlEnum("hole")]
        Hole,

        [XmlEnum("open-string")]
        OpenString,

        [XmlEnum("other-technical")]
        OtherTechnical,

        [XmlEnum("pluck")]
        Pluck,

        [XmlEnum("pull-off")]
        PullOff,

        [XmlEnum("snap-pizzicato")]
        SnapPizzicato,

        [XmlEnum("stopped")]
        Stopped,

        [XmlEnum("string")]
        String,

        [XmlEnum("tap")]
        Tap,

        [XmlEnum("thumb-position")]
        ThumbPosition,

        [XmlEnum("toe")]
        Toe,

        [XmlEnum("triple-tongue")]
        TripleTongue,

        [XmlEnum("up-bow")]
        UpBow,
    }
}
