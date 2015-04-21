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
    public string ListOfClassName { get; set; }

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


    public override object Clone()
    {
      return new DeviserClass(this);
    }

    public DeviserClass(DeviserClass other) : base(other)
    {
      BaseClass = other.BaseClass;
      Attributes = other.Attributes.CloneAll();
      ListOfAttributes = other.ListOfAttributes.CloneAll();
      Concretes = other.Concretes.CloneAll();

      Name = other.Name;
      BaseClass = other.BaseClass;
      TypeCode = other.TypeCode;
      HasChildren = other.HasChildren;
      HasListOf = other.HasListOf;
      Abstract = other.Abstract;
      ChildrenOverwriteElementName = other.ChildrenOverwriteElementName;
      ElementName = other.ElementName;
      ListOfName = other.ListOfName;
      ListOfClassName = other.ListOfClassName;

      AdditionalDeclarations = other.AdditionalDeclarations;
      AdditionalDefinitions = other.AdditionalDefinitions;

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
      ListOfClassName = element.GetAttribute("listOfClassName");

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

      if (!string.IsNullOrWhiteSpace(ListOfClassName))
        writer.WriteAttributeString("listOfClassName", ListOfClassName);

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

    public string GetListOfName()
    {
      if (!string.IsNullOrWhiteSpace(ListOfClassName))
        return ListOfClassName;
      if (!string.IsNullOrWhiteSpace(ListOfName))
        return ListOfName;
      return "ListOf" + Name.GuessPlural();
    }

    public override void SetParent(DeviserPackage doc)
    {
      Document = doc;
      Attributes.SetParent(doc);
      ListOfAttributes.SetParent(doc);
      Concretes.SetParent(doc);

    }

    public override string ToYuml(bool usecolor = true)
    {
      var builder = new StringBuilder();
      if (!string.IsNullOrWhiteSpace(BaseClass))
      {
        builder.AppendFormat("[{0}]<>-", BaseClass);
      }
      builder.Append("[" + Name);
      if (Attributes.Any())
        builder.Append("|");
      var list = new List<DeviserAttribute>();
      for (int i = 0; i < Attributes.Count; i++)
      {
        if (Attributes[i].IsComplexType)
        {
          list.Add(Attributes[i]);
          //continue;
        }

        builder.Append(Attributes[i].ToYuml());
        if (i + 1 < Attributes.Count)
          builder.Append(";");
      }
      if (usecolor)
        builder.AppendFormat("{{bg:{0}}}", Deviser.ClassColor);

      builder.Append("]");
      builder.AppendLine();
      foreach (var item in list)
      {
        builder.AppendLine(item.GetYumlReferences(Name));
      }
      if (HasListOf)
      {
        string listOf = GetListOfName();
        builder.Append("[ListOf]<>-[" + listOf);
        if (ListOfAttributes.Any())
          builder.Append("|");
        list = new List<DeviserAttribute>();
        for (int i = 0; i < ListOfAttributes.Count; i++)
        {
          if (ListOfAttributes[i].IsComplexType)
          {
            list.Add(ListOfAttributes[i]);
            //continue;
          }
          builder.Append(ListOfAttributes[i].ToYuml());
          if (i + 1 < ListOfAttributes.Count)
            builder.Append(";");
        }

        builder.Append("]");
        builder.AppendLine();
        builder.AppendLine(string.Format("[{2}]-{1}  1..*>[{0}]", listOf, Name.LowerFirst(), Name));

        foreach (var item in list)
        {
          builder.AppendLine(item.GetYumlReferences(Name));
        }

      }

      builder.AppendLine();
      return builder.ToString();
    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "element");
    }

  }
}
