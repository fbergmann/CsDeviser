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
    public string XMLName { get; set; }
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

    public override object Clone()
    {
      return new DeviserAttribute(this);
    }


    /// <summary>
    /// Initializes a new instance of the <see cref="DeviserAttribute"/> class.
    /// </summary>
    public DeviserAttribute(DeviserAttribute other) : base(other)
    {
      Type = other.Type;
      Element = other.Element;
      Required = other.Required;
      Abstract = other.Abstract;
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
      XMLName = element.GetAttribute("xmlName");
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
      if (!string.IsNullOrWhiteSpace(XMLName))
        writer.WriteAttributeString("xmlName", XMLName);
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
      string name = Name.LowerFirst();
      if (!string.IsNullOrWhiteSpace(XMLName))
        name = XMLName.LowerFirst();

      builder.Append(name);
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
      string lowerName = Name.LowerFirst();
      if (!string.IsNullOrWhiteSpace(XMLName))
        lowerName = XMLName.LowerFirst();

      if (Type == "element")
      {
        return string.Format("[{2}]<{1}{3}-[{0}]", source, lowerName, Element,
          true ? "" : Required ? " ..1" : " ..0,1");
      }

      if (Type == "inline_lo_element")
      {
        return string.Format("[{0}]-{1}{3}>[{2}]", source, lowerName, Element,
        Required ? " 1..* " : " *");
      }

      if (Type == "enum")
      {
        return string.Format("[{0}]-{1}>[{3}{2}]", source, lowerName, Element, Deviser.EnumPrefix);
      }

      string elementName = Element;
      var element = Document.Elements.FirstOrDefault(e => e.Name == elementName);
      string listOfName = string.Format("ListOf{0}", elementName.GuessPlural());
      var link = listOfName.LowerFirst();
      if (element != null)
      {
        listOfName = element.GetListOfName();
        link = listOfName.LowerFirst();
        if (!string.IsNullOrWhiteSpace(element.ListOfName))
          link = element.ListOfName.LowerFirst();
      }
      return string.Format("[{2}]-{1}{3}>[{0}]", source, link, listOfName,
        true ? "" : Required ? " ..1" : " ..0,1");
    }
  }

}
