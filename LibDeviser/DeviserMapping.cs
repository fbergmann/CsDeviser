using System.Xml;

namespace LibDeviser
{
  public class DeviserMapping: DeviserBase
  {
    public string Name { get; set; }
    public string Package { get; set; }

    public DeviserMapping()
    {
    }

    public DeviserMapping(DeviserMapping other) : base(other)
    {
      Name = other.Name;
      Package = other.Package;
    }

    public override object Clone()
    {
      return new DeviserMapping(this);
    }

    public DeviserMapping(XmlNode node)
      : this()
    {
      InitializeFrom(node);
    }


    public override void InitializeFrom(XmlElement element)
    {
      base.InitializeFrom(element);

      Name = element.GetAttribute("name");
      Package = element.GetAttribute("package");
    }

    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);

      if (!string.IsNullOrWhiteSpace(Name))
        writer.WriteAttributeString("name", Name);
      if (!string.IsNullOrWhiteSpace(Package))
        writer.WriteAttributeString("package", Package);

    }

    public override string ToYuml(bool usecolor = true)
    {
      if (string.IsNullOrWhiteSpace(Package))
        return Name;
      return string.Format("{0} = {1}", Name, Package);
    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "mapping");
    }


  }
}