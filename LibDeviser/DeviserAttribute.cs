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
    public bool Abstract { get; set; }

    public bool IsComplexType
    {
      get
      {
        return Type == "element" || Type == "lo_element" ||
        Type == "enum" || Type == "inline_lo_element";
      }
    }



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
      Abstract = Util.readBool(element, "abstract");
    }

    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);

      writer.WriteAttributeString("required", Required.ToString().ToLowerInvariant());
      if (!string.IsNullOrWhiteSpace(Type))
        writer.WriteAttributeString("type", Type);
      if (!string.IsNullOrWhiteSpace(Element))
        writer.WriteAttributeString("element", Element);
      writer.WriteAttributeString("abstract", Abstract.ToString().ToLowerInvariant());
      
    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "attribute");
    }

    public override string ToYuml(bool usecolor = true)
    {
      var builder = new StringBuilder();
      builder.Append(Name);
      if (!string.IsNullOrWhiteSpace(Type))
        builder.Append(" : " + Type);
      if (!Required)
        builder.Append(" use='optional'");
      return builder.ToString();
    }

    public string GetYumlReferences(string source)
    {
      if (Type == "element")
      {
        return string.Format("[{0}]-{1}{3}>[{2}]", source, Name.LowerFirst(), Element,
        Required ? " ..1" : " ..0,1");
      }
      
      if (Type == "enum")
      {
        return string.Format("[{0}]-{1}>[Enumeration;{2}]", source, Name.LowerFirst(), Element);
      }
      
      string elementName = Element;
      var element = Document.Elements.FirstOrDefault(e => e.Name == elementName);
      string listOfName = string.Format("ListOf{0}", elementName.GuessPlural());
      if (element != null && !string.IsNullOrWhiteSpace(element.ListOfName))
        listOfName = element.ListOfName;
      return string.Format("[{0}]-{1}{3}>[{2}]", source, listOfName.LowerFirst(), listOfName,
        Required ? " ..1" : " ..0,1");
    }
  }

}
