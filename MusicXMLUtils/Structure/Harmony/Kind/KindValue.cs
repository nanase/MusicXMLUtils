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
    [XmlType(TypeName = "kind-value")]
    public enum KindValue
    {
        [XmlEnum("major")]
        Major,

        [XmlEnum("minor")]
        Minor,

        [XmlEnum("augmented")]
        Augmented,

        [XmlEnum("diminished")]
        Diminished,

        [XmlEnum("dominant")]
        Dominant,

        [XmlEnum("major-seventh")]
        MajorSeventh,

        [XmlEnum("minor-seventh")]
        MinorSeventh,

        [XmlEnum("diminished-seventh")]
        DiminishedSeventh,

        [XmlEnum("augmented-seventh")]
        AugmentedSeventh,

        [XmlEnum("half-diminished")]
        HalfDiminished,

        [XmlEnum("major-minor")]
        MajorMinor,

        [XmlEnum("major-sixth")]
        MajorSixth,

        [XmlEnum("minor-sixth")]
        MinorSixth,

        [XmlEnum("dominant-ninth")]
        DominantNinth,

        [XmlEnum("major-ninth")]
        MajorNinth,

        [XmlEnum("minor-ninth")]
        MinorNinth,

        [XmlEnum("dominant-11th")]
        dominant11th,

        [XmlEnum("major-11th")]
        major11th,

        [XmlEnum("minor-11th")]
        minor11th,

        [XmlEnum("dominant-13th")]
        dominant13th,

        [XmlEnum("major-13th")]
        major13th,

        [XmlEnum("minor-13th")]
        minor13th,

        [XmlEnum("suspended-second")]
        SuspendedSecond,

        [XmlEnum("suspended-fourth")]
        SuspendedFourth,

        [XmlEnum("Neapolitan")]
        Neapolitan,

        [XmlEnum("Italian")]
        Italian,

        [XmlEnum("French")]
        French,

        [XmlEnum("German")]
        German,

        [XmlEnum("pedal")]
        Pedal,

        [XmlEnum("power")]
        Power,

        [XmlEnum("Tristan")]
        Tristan,

        [XmlEnum("other")]
        Other,

        [XmlEnum("none")]
        None,
    }
}
