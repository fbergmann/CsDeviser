using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{

  public class DeviserClass : DeviserBase
  {
    public string Name { get; set; }
    public string BaseClass { get; set; }

    public string TypeCode { get; set; }
    public bool HasListOf { get; set; }
    public bool HasMath { get; set; }
    public bool HasChildren { get; set; }

    public bool Abstract { get; set; }
    public string ElementName { get; set; }
    public string ListOfName { get; set; }

    public bool ChildrenOverwriteElementName { get; set; }

    /// <summary>
    /// Code to be included in header file
    /// </summary>
    public string AdditionalDeclarations { get; set; }

    /// <summary>
    /// Code to be included in implementation file
    /// </summary>
    public string AdditionalDefinitions { get; set; }



    public List<DeviserAttribute> Attributes { get; set; }
    public List<DeviserListOfAttribute> ListOfAttributes { get; set; }
    public List<DeviserConcrete> Concretes { get; set; }

    public DeviserClass()
    {
      BaseClass = "SBase";
      Attributes = new List<DeviserAttribute>();
      ListOfAttributes = new List<DeviserListOfAttribute>();
      Concretes = new List<DeviserConcrete>();
    }

    public DeviserClass(XmlNode node)
      : this()
    {
      InitializeFrom(node);
    }


    public override void InitializeFrom(XmlElement element)
    {
      base.InitializeFrom(element);

      Name = element.GetAttribute("name");
      BaseClass = element.GetAttribute("baseClass");

      TypeCode = element.GetAttribute("typeCode");
      HasListOf = Util.readBool(element, "hasListOf");
      HasChildren = Util.readBool(element, "hasChildren");
      HasMath = Util.readBool(element, "hasMath");
      Abstract = Util.readBool(element, "abstract");
      ChildrenOverwriteElementName = Util.readBool(element, "childrenOverwriteElementName");
      ElementName = element.GetAttribute("elementName");
      ListOfName = element.GetAttribute("listOfName");

      AdditionalDeclarations = element.GetAttribute("additionalDecls");
      AdditionalDefinitions = element.GetAttribute("additionalDefs");

      Attributes = new List<DeviserAttribute>();
      Attributes.InitializeFrom(Util.getElement(element, "attribute"));
      ListOfAttributes = new List<DeviserListOfAttribute>();
      ListOfAttributes.InitializeFrom(Util.getElement(element, "listOfAttribute"));
      Concretes = new List<DeviserConcrete>();
      Concretes.InitializeFrom(Util.getElement(element, "concrete"));
    }

    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);

      if (!string.IsNullOrWhiteSpace(Name))
        writer.WriteAttributeString("name", Name);
      if (!string.IsNullOrWhiteSpace(TypeCode))
        writer.WriteAttributeString("typeCode", TypeCode);

      writer.WriteAttributeString("hasListOf", HasListOf.ToString().ToLowerInvariant());
      writer.WriteAttributeString("hasChildren", HasChildren.ToString().ToLowerInvariant());
      writer.WriteAttributeString("hasMath", HasMath.ToString().ToLowerInvariant());
      writer.WriteAttributeString("childrenOverwriteElementName", ChildrenOverwriteElementName.ToString().ToLowerInvariant());

      if (!string.IsNullOrWhiteSpace(BaseClass))
        writer.WriteAttributeString("baseClass", BaseClass);

      writer.WriteAttributeString("abstract", Abstract.ToString().ToLowerInvariant());

      if (!string.IsNullOrWhiteSpace(ElementName))
        writer.WriteAttributeString("elementName", ElementName);

      if (!string.IsNullOrWhiteSpace(ListOfName))
        writer.WriteAttributeString("listOfName", ListOfName);

      if (!string.IsNullOrWhiteSpace(AdditionalDeclarations))
        writer.WriteAttributeString("additionalDecls", AdditionalDeclarations);
      if (!string.IsNullOrWhiteSpace(AdditionalDefinitions))
        writer.WriteAttributeString("additionalDefs", AdditionalDefinitions);


    }

    public override void WriteElementsTo(XmlWriter writer)
    {
      base.WriteElementsTo(writer);

      Attributes.WriteListWithName(writer, "attributes");
      ListOfAttributes.WriteListWithName(writer, "listOfAttributes");
      Concretes.WriteListWithName(writer, "concretes");

    }


    public override void SetParent(DeviserPackage doc)
    {
      Document = doc;
      Attributes.SetParent(doc);
      ListOfAttributes.SetParent(doc);
      Concretes.SetParent(doc);

    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "element");
    }

  }
}
