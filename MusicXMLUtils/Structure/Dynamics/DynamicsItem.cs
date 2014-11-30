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
    public enum DynamicsItem
    {
        [XmlEnum("f")]
        F,

        [XmlEnum("ff")]
        Ff,

        [XmlEnum("fff")]
        Fff,

        [XmlEnum("ffff")]
        Ffff,

        [XmlEnum("fffff")]
        Fffff,

        [XmlEnum("ffffff")]
        Ffffff,

        [XmlEnum("fp")]
        Fp,

        [XmlEnum("fz")]
        Fz,

        [XmlEnum("mf")]
        Mf,

        [XmlEnum("mp")]
        Mp,

        [XmlEnum("other-dynamics")]
        OtherDynamics,

        [XmlEnum("p")]
        P,

        [XmlEnum("pp")]
        Pp,

        [XmlEnum("ppp")]
        Ppp,

        [XmlEnum("pppp")]
        Pppp,

        [XmlEnum("ppppp")]
        Ppppp,

        [XmlEnum("pppppp")]
        Pppppp,

        [XmlEnum("rf")]
        Rf,

        [XmlEnum("rfz")]
        Rfz,

        [XmlEnum("sf")]
        Sf,

        [XmlEnum("sffz")]
        Sffz,

        [XmlEnum("sfp")]
        Sfp,

        [XmlEnum("sfpp")]
        Sfpp,

        [XmlEnum("sfz")]
        Sfz,
    }
}
