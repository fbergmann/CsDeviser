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

    /// <summary>
    /// Code to be included in header file
    /// </summary>
    public string AdditionalDeclarations { get; set; }

    /// <summary>
    /// Code to be included in implementation file
    /// </summary>
    public string AdditionalDefinitions { get; set; }

    public string TypeCode { get; set; }
    public string Package { get; set; }

    public List<DeviserReferenceAttribute> References { get; set; }
    public List<DeviserAttribute> Attributes { get; set; }

    public DeviserPlugin()
    {
      Attributes = new List<DeviserAttribute>();
      References = new List<DeviserReferenceAttribute>();
    }

    public DeviserPlugin(XmlNode node)
      : this()
    {
      InitializeFrom(node);
    }

    public override void SetParent(DeviserPackage doc)
    {
      Document = doc;
      Attributes.SetParent(doc);
      References.SetParent(doc);
    }

    public override string ToYuml(bool usecolor=true)
    {
      var builder = new StringBuilder();
      builder.Append("[" + ExtensionPoint);
      if (Attributes.Any() || References.Any())
        builder.Append("|");
      var list = new List<DeviserAttribute>();
      for (int i = 0; i < Attributes.Count; i++)
      {
        var item = Attributes[i];
        if (Attributes[i].IsComplexType)
        {
          list.Add(Attributes[i]);
          //continue;
        }
        builder.Append(item.ToYuml(usecolor));
        if (i + 1 < Attributes.Count)
        {
          builder.Append(";");
        }
      }
      if (usecolor)
        builder.Append("{bg:" + Deviser.ExtensionColor + "}");

      builder.Append("]");
      builder.AppendLine();

      foreach (var item in list)
      {
        builder.AppendLine(item.GetYumlReferences(ExtensionPoint));
      }


      for (int i = 0; i < References.Count; i++)
      {
        var item = References[i];
        builder.AppendLine("["+ExtensionPoint+ "]->[" + item.Name + "]");
      }

      
      return builder.ToString();
    }

    public override void InitializeFrom(XmlElement element)
    {
      base.InitializeFrom(element);

      ExtensionPoint = element.GetAttribute("extensionPoint");
      AdditionalDeclarations = element.GetAttribute("additionalDecls");
      AdditionalDefinitions = element.GetAttribute("additionalDefs");
      TypeCode = element.GetAttribute("typecode");
      Package = element.GetAttribute("package");

      References = new List<DeviserReferenceAttribute>();
      References.InitializeFrom(Util.getElement(element, "reference"));
      Attributes = new List<DeviserAttribute>();
      Attributes.InitializeFrom(Util.getElement(element, "attribute"));
    }

    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);

      if (!string.IsNullOrWhiteSpace(TypeCode))
        writer.WriteAttributeString("typecode", TypeCode);
      if (!string.IsNullOrWhiteSpace(Package))
        writer.WriteAttributeString("package", Package);

      if (!string.IsNullOrWhiteSpace(ExtensionPoint))
        writer.WriteAttributeString("extensionPoint", ExtensionPoint);
      if (!string.IsNullOrWhiteSpace(AdditionalDeclarations))
        writer.WriteAttributeString("additionalDecls", AdditionalDeclarations);
      if (!string.IsNullOrWhiteSpace(AdditionalDefinitions))
        writer.WriteAttributeString("additionalDefs", AdditionalDefinitions);

    }

    public override void WriteElementsTo(XmlWriter writer)
    {
      base.WriteElementsTo(writer);

      References.WriteListWithName(writer, "references");
      Attributes.WriteListWithName(writer, "attributes");

    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "plugin");
    }

  }
}
