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

    public bool IsListOf
    {
      get
      {
        return Type == "lo_element";
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

    public DeviserClass GetUnderLyingElement()
    {
      if (Document == null) return null;
      return Document.Elements.FirstOrDefault(e => e.Name == Element);
    }
    public override string ToYuml(bool usecolor = true)
    {
      var builder = new StringBuilder();
      builder.Append(Name);
      if (!string.IsNullOrWhiteSpace(Type))
      { 
        if (!IsComplexType)
        { 
          builder.Append(" : " + Type);
        }
        else
        {
          var element = GetUnderLyingElement();
          if (element == null)
            if (IsListOf)
              builder.Append(" : " + "ListOf" + Element.GuessPlural());
            else
              builder.Append(" : " + Element);
          else
            if (IsListOf)
            builder.Append(" : " + element.GetListOfName());
            else 
            builder.Append(" : " + element.Name);


        }
      }
      if (!Required)
        builder.Append(" use=\u201Coptional\u201D");
      return builder.ToString();
    }

    public string GetYumlReferences(string source)
    {
      if (Type == "element")
      {
        return string.Format("[{2}]<{1}{3}-[{0}]", source, Name.LowerFirst(), Element,
          true ? "" : Required ? " ..1" : " ..0,1");
      }

      if (Type == "inline_lo_element")
      {
        return string.Format("[{0}]-{1}{3}>[{2}]", source, Name.LowerFirst(), Element,
        Required ? " 1..* " : " *");
      }

      if (Type == "enum")
      {
        return string.Format("[{0}]-{1}>[{3}{2}]", source, Name.LowerFirst(), Element, Deviser.EnumPrefix);
      }
      
      string elementName = Element;
      var element = Document.Elements.FirstOrDefault(e => e.Name == elementName);
      string listOfName = string.Format("ListOf{0}", elementName.GuessPlural());
      if (element != null && !string.IsNullOrWhiteSpace(element.ListOfName))
        listOfName = element.ListOfName;
      return string.Format("[{2}]-{1}{3}>[{0}]", source, listOfName.LowerFirst(), listOfName,
        true ? "" : Required ? " ..1" : " ..0,1");
    }
  }

}
