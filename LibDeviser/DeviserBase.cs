using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{
  public class DeviserBase
  {
    /// <summary>
    /// Get set Dirty state of package
    /// </summary>
    public bool Dirty { get; set; }

    public virtual void InitializeFrom(XmlNode node)
    {
      InitializeFrom((XmlElement)node);
    }

    public virtual void InitializeFrom(XmlElement element)
    {

    }

    public virtual void WriteTo(XmlWriter writer)
    {
      WriteAttributesTo(writer);
      WriteElementsTo(writer);
    }


    public virtual void WriteElementWithNameTo(XmlWriter writer, string name)
    {
      writer.WriteStartElement(name);
      WriteAttributesTo(writer);
      WriteElementsTo(writer);
      writer.WriteEndElement();
    }

    public virtual void WriteAttributesTo(XmlWriter writer)
    {

    }

    public virtual void WriteElementsTo(XmlWriter writer)
    {

    }

    public virtual string ToXmlString()
    {
      var builder = new StringBuilder();
      var settings = new XmlWriterSettings { Indent = true, Encoding = Encoding.UTF8, OmitXmlDeclaration = true };
      using (var writer = XmlWriter.Create(builder, settings))
      {
        writer.WriteStartDocument();
        WriteTo(writer);
        writer.WriteEndDocument();
      }
      return builder.ToString();
    }

    public object UserData { get; set; }

    public DeviserPackage Document { get; set; }

    public virtual void SetParent(DeviserPackage doc)
    {
      Document = doc;
    }

  }
}
