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
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MusicXMLUtils.Structure
{
    [GeneratedCode("xsd", "4.0.30319.18020")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot("score-partwise", Namespace = "", IsNullable = false)]
    public class ScorePartwise
    {
        public ScorePartwise()
        {
            this.Version = "3.0";
        }

        [XmlElement("work")]
        public Work Work { get; set; }

        [XmlElement("movement-number")]
        public string MovementNumber { get; set; }

        [XmlElement("movement-title")]
        public string MovementTitle { get; set; }

        [XmlElement("identification")]
        public Identification Identification { get; set; }

        [XmlElement("defaults")]
        public Defaults Defaults { get; set; }

        [XmlElement("credit")]
        public Credit[] Credit { get; set; }

        [XmlElement("part-list")]
        public PartList PartList { get; set; }

        [XmlElement("part")]
        public ScorePartwisePart[] Part { get; set; }

        [XmlAttribute(DataType = "token")]
        [DefaultValue("3.0")]
        public string Version { get; set; }

        public static ScorePartwise Deserialize(string filepath)
        {
            // ソース出典:
            // MusicXmlSchema2.0
            // https://github.com/AidenStrydom/MusicXmlSchema2.0

            if (!File.Exists(filepath))
                throw new FileNotFoundException();

            using (Stream st = new FileStream(filepath, FileMode.Open))
                return (ScorePartwise)new XmlSerializer(typeof(ScorePartwise)).Deserialize(st);
        }

        public static void Serialize(string filepath, ScorePartwise scorepartwise)
        {
            // ソース出典:
            // MusicXmlSchema2.0
            // https://github.com/AidenStrydom/MusicXmlSchema2.0

            if (scorepartwise == null)
                return;

            var serializer = new XmlSerializer(typeof(ScorePartwise));
            using (var xmlTextWriter = new XmlTextWriter(filepath, System.Text.Encoding.UTF8) { Formatting = Formatting.Indented })
            using (var writer = XmlWriter.Create(xmlTextWriter, new XmlWriterSettings { OmitXmlDeclaration = true }))
            {
                writer.WriteStartDocument();
                writer.WriteDocType("score-partwise", "-//Recordare//DTD MusicXML 2.0 Partwise//EN", "http://www.musicxml.org/dtds/partwise.dtd", null);

                var nullSpace = new XmlSerializerNamespaces();
                nullSpace.Add("", "");

                serializer.Serialize(writer, scorepartwise, nullSpace);
            }
        }
    }
}
