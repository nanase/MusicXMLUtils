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
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MusicXMLUtils.Structure
{
    public abstract class ScoreBase<T> where T: ScoreBase<T>
    {
        public ScoreBase()
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

        [XmlAttribute(DataType = "token")]
        [DefaultValue("3.0")]
        public string Version { get; set; }

        [XmlIgnore]
        protected abstract string DocTypeName { get; }

        [XmlIgnore]
        protected abstract string DocTypePubID { get; }

        [XmlIgnore]
        protected abstract string DocTypeSysID { get; } 

        public static T Deserialize(string filepath)
        {
            // ソース出典:
            // MusicXmlSchema2.0
            // https://github.com/AidenStrydom/MusicXmlSchema2.0

            if (!File.Exists(filepath))
                throw new FileNotFoundException();

            using (Stream st = new FileStream(filepath, FileMode.Open))
                return (T)new XmlSerializer(typeof(T)).Deserialize(st);
        }

        public static void Serialize(string filepath, T score)
        {
            // ソース出典:
            // MusicXmlSchema2.0
            // https://github.com/AidenStrydom/MusicXmlSchema2.0

            if (score == null)
                return;

            var serializer = new XmlSerializer(typeof(T));
            using (var xmlTextWriter = new XmlTextWriter(filepath, System.Text.Encoding.UTF8) { Formatting = Formatting.Indented })
            using (var writer = XmlWriter.Create(xmlTextWriter, new XmlWriterSettings { OmitXmlDeclaration = true }))
            {
                writer.WriteStartDocument();
                writer.WriteDocType(score.DocTypeName, score.DocTypePubID, score.DocTypeSysID, null);

                var nullSpace = new XmlSerializerNamespaces();
                nullSpace.Add("", "");

                serializer.Serialize(writer, score, nullSpace);
            }
        }
    }
}
