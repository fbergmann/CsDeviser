using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{
  public class DeviserPlugin : DeviserBase
  {
    public string ExtensionPoint { get; set; }

    public List<DeviserReferenceAttribute> Attributes { get; set; }

    public DeviserPlugin()
    {
      Attributes = new List<DeviserReferenceAttribute>();
    }

    public DeviserPlugin(XmlNode node)
      : this()
    {
      InitializeFrom(node);
    }

    public override void SetParent(DeviserPackage doc)
    {
      foreach (var item in Attributes)
      {
        item.SetParent(doc);
      }

    }
    public override void InitializeFrom(XmlElement element)
    {
      base.InitializeFrom(element);

      ExtensionPoint = element.GetAttribute("extensionPoint");

      Attributes = new List<DeviserReferenceAttribute>();
      Attributes.InitializeFrom(Util.getElement(element, "reference"));
      Attributes.InitializeFrom(Util.getElement(element, "attribute"));
    }

    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);

      if (!string.IsNullOrWhiteSpace(ExtensionPoint))
        writer.WriteAttributeString("extensionPoint", ExtensionPoint);
    }

    public override void WriteElementsTo(XmlWriter writer)
    {
      base.WriteElementsTo(writer);

      Attributes.WriteListWithName(writer, "attributes");

    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "plugin");
    }

  }
}
