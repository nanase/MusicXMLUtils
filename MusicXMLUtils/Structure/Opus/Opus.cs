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
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicXMLUtils.Structure
{
    [GeneratedCode("xsd", "4.0.30319.18020")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType("opus")]
    public class Opus
    {
        #region -- Public Properties --
        [XmlAttribute(AttributeName = "href", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string HRef { get; set; }

        [XmlAttribute(AttributeName = "type", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public OpusType Type { get; set; }

        [XmlIgnore]
        public bool TypeSpecified { get; set; }

        [XmlAttribute(AttributeName = "role", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "token")]
        public string Role { get; set; }

        [XmlAttribute(AttributeName = "title", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "token")]
        public string Title { get; set; }

        [XmlAttribute(AttributeName = "show", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        [DefaultValue(OpusShow.Replace)]
        public OpusShow Show { get; set; }

        [XmlAttribute(AttributeName = "actuate", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        [DefaultValue(OpusActuate.OnRequest)]
        public OpusActuate Actuate { get; set; }
        #endregion

        #region -- Constructors --
        public Opus()
        {
            this.Type = OpusType.Simple;
            this.Show = OpusShow.Replace;
            this.Actuate = OpusActuate.OnRequest;
        }
        #endregion
    }
}
