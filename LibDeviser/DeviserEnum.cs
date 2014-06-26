using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{
  public class DeviserEnum : DeviserBase
  {
    public string Name { get; set; }
    public List<DeviserEnumValue> Values { get; set; }

    public DeviserEnum()
    {
      Values = new List<DeviserEnumValue>();
    }

    public DeviserEnum(XmlNode node)
      : this()
    {
      InitializeFrom(node);
    }

    public override void SetParent(DeviserPackage doc)
    {
      Document = doc;
      Values.SetParent(doc);
    }

    public override void InitializeFrom(XmlElement element)
    {
      base.InitializeFrom(element);

      Name = element.GetAttribute("name");

      Values = new List<DeviserEnumValue>();
      Values.InitializeFrom(Util.getElement(element, "enumValue"));

    }

    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);

      if (!string.IsNullOrWhiteSpace(Name))
        writer.WriteAttributeString("name", Name);
    }

    public override void WriteElementsTo(XmlWriter writer)
    {
      base.WriteElementsTo(writer);

      Values.WriteListWithName(writer, "enumValues");
    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "enum");
    }
  }
}
