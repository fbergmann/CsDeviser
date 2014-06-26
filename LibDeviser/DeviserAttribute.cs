using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{

  public class DeviserAttribute : DeviserReferenceAttribute
  {
    public string Type { get; set; }
    public string Element { get; set; }
    public bool Required { get; set; }


    public DeviserAttribute()
    {
    }

    public DeviserAttribute(XmlNode node)
      : this()
    {
      InitializeFrom(node);
    }


    public override void InitializeFrom(XmlElement element)
    {
      base.InitializeFrom(element);

      Type = element.GetAttribute("type");
      Element = element.GetAttribute("element");
      Required = Util.readBool(element, "required");
    }

    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);

      writer.WriteAttributeString("required", Required.ToString().ToLowerInvariant());
      if (!string.IsNullOrWhiteSpace(Type))
        writer.WriteAttributeString("type", Type);
      if (!string.IsNullOrWhiteSpace(Element))
        writer.WriteAttributeString("element", Element);

    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "attribute");
    }

  }
}
