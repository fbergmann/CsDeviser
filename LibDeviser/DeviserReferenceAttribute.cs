using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{
  public class DeviserReferenceAttribute : DeviserBase
  {
    public string Name { get; set; }


    public DeviserReferenceAttribute()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DeviserReferenceAttribute"/> class.
    /// </summary>
    public DeviserReferenceAttribute(DeviserReferenceAttribute other) : base(other)
    {
      Name = other.Name;
    }

    public override object Clone()
    {
      return new DeviserReferenceAttribute(this);
    }

    public DeviserReferenceAttribute(XmlNode node)
      : this()
    {
      InitializeFrom(node);
    }


    public override void InitializeFrom(XmlElement element)
    {
      base.InitializeFrom(element);

      Name = element.GetAttribute("name");
    }

    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);

      if (!string.IsNullOrWhiteSpace(Name))
        writer.WriteAttributeString("name", Name);

    }

    public override string ToYuml(bool usecolor=true)
    {
      return Name;
    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "reference");
    }

  }
}
