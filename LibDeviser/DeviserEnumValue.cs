using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{
  public class DeviserEnumValue : DeviserBase
  {
    public string Name { get; set; }
    public string Value { get; set; }

    public DeviserEnumValue(DeviserEnumValue other) : base(other)
    {
      Name = other.Name;
      Value = other.Value;
    }

    public override object Clone()
    {
      return new DeviserEnumValue(this);
    }

    public DeviserEnumValue()
    {
    }

    public DeviserEnumValue(XmlNode node)
      : this()
    {
      InitializeFrom(node);
    }


    public override void InitializeFrom(XmlElement element)
    {
      base.InitializeFrom(element);

      Name = element.GetAttribute("name");
      Value = element.GetAttribute("value");
    }

    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);

      if (!string.IsNullOrWhiteSpace(Name))
        writer.WriteAttributeString("name", Name);
      if (!string.IsNullOrWhiteSpace(Value))
        writer.WriteAttributeString("value", Value);

    }

    public override string ToYuml(bool usecolor = true)
    {
      if (string.IsNullOrWhiteSpace(Value))
        return Name;
      return string.Format("{0} = {1}", Name, Value);
    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "enumValue");
    }

    
  }
}
