using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{
  public class DeviserConcrete : DeviserBase
  {
    public string Name { get; set; }
    public string Element { get; set; }
    public int MinNumChildren { get; set; }
    public int MaxNumChildren { get; set; }

    public DeviserConcrete(DeviserConcrete other) : base(other)
    {
      Name = other.Name;
      Element = other.Element;
    }

    public override object Clone()
    {
      return new DeviserConcrete(this);
    }

    public DeviserConcrete()
    {
    }

    public DeviserConcrete(XmlNode node)
      : this()
    {
      InitializeFrom(node);
    }


    public override void InitializeFrom(XmlElement element)
    {
      base.InitializeFrom(element);

      Name = element.GetAttribute("name");
      Element = element.GetAttribute("element");
      MinNumChildren = Util.readInt(element, "minNumChildren");
      MaxNumChildren = Util.readInt(element, "maxNumChildren");
    }

    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);

      if (!string.IsNullOrWhiteSpace(Name))
        writer.WriteAttributeString("name", Name);
      if (!string.IsNullOrWhiteSpace(Element))
        writer.WriteAttributeString("element", Element);
      if (MinNumChildren != 0)
        writer.WriteAttributeString("minNumChildren", MinNumChildren.ToString());
      if (MaxNumChildren != 0)
        writer.WriteAttributeString("maxNumChildren", MaxNumChildren.ToString());

    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "concrete");
    }

  }
}
