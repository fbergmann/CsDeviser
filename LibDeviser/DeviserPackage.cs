﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{
  /// <summary>
  /// The main entry point for a deviser package
  /// </summary>
  public class DeviserPackage : DeviserBase
  {

    /// <summary>
    /// Name of the package
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Full Name of the package
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Start number for the type codes enum
    /// </summary>
    public int StartNumber { get; set; }

    /// <summary>
    /// Offset for validation
    /// </summary>
    public int Offset { get; set; }

    /// <summary>
    /// The version of the xml format
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// boolean indicating whether the package is required or not
    /// </summary>
    public bool Required { get; set; }

    /// <summary>
    /// Code to be included in header file
    /// </summary>
    public string AdditionalDeclarations { get; set; }

    /// <summary>
    /// Code to be included in implementation file
    /// </summary>
    public string AdditionalDefinitions { get; set; }

    /// <summary>
    /// All Elements defined by this Package
    /// </summary>
    public List<DeviserClass> Elements {
      get { return Versions.SelectMany(v => v.Elements).ToList(); }
    }

    /// <summary>
    /// All Extension Points  of this package
    /// </summary>
    public List<DeviserPlugin> Plugins
    {
      get { return Versions.SelectMany(v => v.Plugins).ToList(); }
    }

    /// <summary>
    /// All Enumerations defined by this package
    /// </summary>
    public List<DeviserEnum> Enums {
      get { return Versions.SelectMany(v => v.Enums).ToList(); }
    }

    /// <summary>
    /// All mappings to other packages
    /// </summary>
    public List<DeviserMapping> Mappings {
      get { return Versions.SelectMany(v => v.Mappings).ToList(); }
    }

    /// <summary>
    /// All Versions of the currently package
    /// </summary>
    public List<DeviserVersion> Versions { get; set; }

    /// <summary>
    /// the currently selected version
    /// </summary>
    public DeviserVersion CurrentVersion { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    public DeviserPackage ()
    {
      Versions = new List<DeviserVersion>();
      Version = 1;
    }

    /// <summary>
    /// Initializes a new package from an xml node
    /// </summary>
    /// <param name="node">the node to initialize from</param>
    public DeviserPackage(XmlNode node) : this()
    {
      InitializeFrom(node);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DeviserPackage"/> class from the given file.
    /// </summary>
    /// <param name="fileName">Name of the file.</param>
    public DeviserPackage(string fileName)  : this()
    {
      ReadFromFile(fileName);
    }

    public DeviserClass GetElement(string name, object tag = null)
    {
      if (tag != null && tag is DeviserVersion)
        return ((DeviserVersion)tag).Elements.FirstOrDefault(e => e.Name == name);
      return Elements.FirstOrDefault(e => e.Name == name);
    }

    public DeviserEnum GetEnum(string name, object tag = null)
    {
      if (tag != null && tag is DeviserVersion)
        return ((DeviserVersion)tag).Enums.FirstOrDefault(e => e.Name == name);
      return Enums.FirstOrDefault(e => e.Name == name);
    }

    public DeviserPlugin GetPlugin(string name, object tag = null)
    {
      if (tag != null && tag is DeviserVersion)
        return ((DeviserVersion)tag).Plugins.FirstOrDefault(e => e.ExtensionPoint == name);
      return Plugins.FirstOrDefault(e => e.ExtensionPoint == name);
    }

    public override void InitializeFrom(XmlElement element)
    {
      Name = element.GetAttribute("name");
      FullName = element.GetAttribute("fullname");
      AdditionalDeclarations = element.GetAttribute("additionalDecls");
      AdditionalDefinitions = element.GetAttribute("additionalDefs");


      StartNumber = Util.readInt(element, "number");
      Offset = Util.readInt(element, "offset");
      Version = Util.readInt(element, "version");
      Required = Util.readBool(element, "required");

      Versions.InitializeFrom(Util.getElement(element, "pkgVersion"));

      if (Versions.Count == 0)
      {
        // legacy support
        Versions.Add(new DeviserVersion(element) {Version = 0, PackageVersion = Version});
      }

      CurrentVersion = Versions.FirstOrDefault();

      SetParent(this);
    }


    public bool HasAdditionalCode {
      get
      {
        return !string.IsNullOrWhiteSpace(AdditionalDeclarations) || !string.IsNullOrWhiteSpace(AdditionalDefinitions);
      }
    }

    public override bool HasModification
    {
      get
      {
        return Dirty || Versions.Any(item => item.HasModification);
      }
    }

    public override void ClearDirty()
    {
      Dirty = false;
      Versions.ClearDirty();
    }


    public override void SetParent(DeviserPackage doc)
    {
      Document = doc;

      Versions.SetParent(doc);

    }

    public void ReadFromFile(string fileName)
    {
      ReadFromString(File.ReadAllText(fileName));
    }

    public void ReadFromString(string packageDocument)
    {
      var oDocument = new XmlDocument();
      oDocument.LoadXml(packageDocument);

      Versions = new List<DeviserVersion>();

      InitializeFrom(oDocument.DocumentElement);
    }
    
    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);
      
      if (!string.IsNullOrWhiteSpace(Name))
        writer.WriteAttributeString("name", Name);

      if (!string.IsNullOrWhiteSpace(FullName))
        writer.WriteAttributeString("fullname", FullName);
      
      if (StartNumber != 0)
        writer.WriteAttributeString("number", StartNumber.ToString());
      
      if (Offset!= 0)
        writer.WriteAttributeString("offset", Offset.ToString());

      // version here is now re-used to track the xml version 
      if (Version == 0)
        Version = 1;
      writer.WriteAttributeString("version", Version.ToString());

      writer.WriteAttributeString("required", Required ? "true" : "false");

      if (!string.IsNullOrWhiteSpace(AdditionalDeclarations))
        writer.WriteAttributeString("additionalDecls", AdditionalDeclarations);
      if (!string.IsNullOrWhiteSpace(AdditionalDefinitions))
        writer.WriteAttributeString("additionalDefs", AdditionalDefinitions);

    }

    public override void WriteElementsTo(XmlWriter writer)
    {
      base.WriteElementsTo(writer);

      Versions.WriteListWithName(writer, "versions");
      
    }

    public static DeviserPackage FromFile(string fileName)
    {
      return new DeviserPackage(fileName);
    }

    public static DeviserPackage FromString(string packageDocument)
    {
      var info = new DeviserPackage();
      info.ReadFromString(packageDocument);
      return info;
    }

    /// <summary>
    /// Writes out the DeviserPackage object to the given fileName
    /// </summary>
    /// <param name="fileName">fileName to write to</param>
    public void WriteTo(string fileName)
    {
      FixHiddenBooleanAttributes();
      ClearDirty();
      File.WriteAllText(fileName, ToXmlString());
    }

    public override string ToXmlString()
    {
      var builder = new StringBuilder();
      using (var createWriter = new StringWriter(builder))
      {
        var settings = new XmlWriterSettings { Indent = true, Encoding = Encoding.UTF8, OmitXmlDeclaration = true };
        //settings.ConformanceLevel = ConformanceLevel.Document;
        var writer = XmlWriter.Create(createWriter, settings);
        WriteTo(writer);
        writer.Close();
        createWriter.Flush();
        createWriter.Close();
      }

      return String.Format("<?xml version=\"1.0\" encoding=\"utf-8\"?>{0}{1}",
                 Environment.NewLine,
                 Util.ReformatXML(builder.ToString()));
    }



    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "package");
    }

    /// <summary>
    /// Go through all elements, and verify that the hasChildren element is set correctly
    /// </summary>
    /// <param name="log"></param>
    /// <param name="correct"></param>
    private void TestForInconsistenciesInHasChildren(List<DeviserMessage> log, bool correct)
    {
      foreach (var item in Elements)
      {
        var hasChildren = item.HasChildren;
        int numChildren = 0;

        foreach (var attr in item.Attributes)
        {
          if ((attr.Type == "element" && attr.Name != "math") || attr.Type == "lo_element" || attr.Type == "inline_lo_element")
            ++numChildren;
        }
        
        foreach (var attr in item.ListOfAttributes)
        {
          if (attr.Type == "element" || attr.Type == "lo_element" || attr.Type == "inline_lo_element")
            ++numChildren;
        }

        if (hasChildren && numChildren == 0)
        {
          log.Add(new DeviserMessage
          {
            Message = string.Format("Class: '{0}' has hasChildren=true, but no children", item.Name),
            Element = item
          });
          
          if (correct)
            item.HasChildren = false;
        }

        if (!hasChildren && numChildren > 0)
        {
          log.Add(new DeviserMessage
          {
            Message = string.Format("Class: '{0}' has hasChildren=false, but children", item.Name),
            Element = item
          });
          
          if (correct)
            item.HasChildren = true;
        }
      }
    }

    private void TestForInconsistenciesInHasMath(List<DeviserMessage> log, bool correct)
    {
      foreach (var item in Elements)
      {
        var hasMath = item.HasMath;
        int numChildren = 0;
        foreach (var attr in item.Attributes)
        {
          if (attr.Name == "math")
            ++numChildren;
        }

        foreach (var attr in item.ListOfAttributes)
        {
          if (attr.Name == "math")
            ++numChildren;
        }

        if (hasMath && numChildren == 0)
        {
          log.Add(new DeviserMessage
          {
            Message = string.Format("Class: '{0}' has hasMath=true, but no math child", item.Name),
            Element = item
          });
          if (correct)
          {
            item.Attributes.Add(new DeviserAttribute {Name="math", Type="element", Element="ASTNode*"});            
          }
        }

        if (!hasMath && numChildren > 0)
        {
          log.Add(new DeviserMessage
          {
            Message = string.Format("Class: '{0}' has a child 'math' but hasMath=false", item.Name),
            Element = item
          });
          if (correct)
            item.HasMath = true;
        }
      }
    }

    private void TestForInconsistenciesInHasListOf(List<DeviserMessage> log, bool correct)
    {
      foreach (var current in Elements)
      {
        var hasListOf = current.HasListOf;

        int countUses = 0;
        foreach (var item in Elements)
        {
          if (item == current) continue;

          foreach (var attr in item.Attributes)
          {
            if (attr.Type != "lo_element" && attr.Type != "inline_lo_element") continue;
            if (attr.Element != current.Name) continue;

            ++countUses;
            if (!hasListOf)
            {
              log.Add(new DeviserMessage
              {
                Message = string.Format("Class: '{0}' uses a list of '{1}', which is not marked having a list.",
                  item.Name, current.Name),
                Element = item
              });
              if (correct)
                current.HasListOf = true;
            }
          }
        }

        foreach (var item in Plugins)
        {
          foreach (var attr in item.Attributes)
          {
            if (attr.Type != "lo_element" && attr.Type != "inline_lo_element") continue;
            if (attr.Element != current.Name) continue;

            ++countUses;
            if (!hasListOf)
            {
              log.Add(new DeviserMessage
              {
                Message = string.Format("Plugin for '{0}' uses a list of '{1}', which is not marked having a list.",
                  item.ExtensionPoint, current.Name),
                Element = item
              });
              if (correct)
                current.HasListOf = true;
            }
          }

          foreach(var reference in item.References)
          {
            if (reference.Name != current.GetListOfName()) continue;
            ++countUses;
            if (!hasListOf)
            {
              log.Add(new DeviserMessage
              {
                Message = string.Format("Plugin for '{0}' uses a list of '{1}', which is not marked having a list.",
                  item.ExtensionPoint, current.Name),
                Element = item
              });
              if (correct)
                current.HasListOf = true;
            }
          }
        }

        if (hasListOf && countUses == 0)
        {
          log.Add(new DeviserMessage
          {
            Message = string.Format("Class: '{0}' is marked as having a list of, but no listOf of it is used.", current.Name),
            Element = current
          });
          if (correct)
            current.HasListOf = false;
        }

      }
    }

    private void TestForInconsistenciesInAbstract(List<DeviserMessage> log, bool correct)
    {
      foreach (var current in Elements)
      {
        var isAbstract = current.IsBaseClass;

        int countUses = 0;
        foreach (var item in Elements)
        {
          if (item == current) continue;
          if (item.BaseClass == current.Name)
          {
            ++countUses;
            if (!isAbstract)
            {
              log.Add(new DeviserMessage
              {
                Message = string.Format("Class: '{0}' uses BaseClass '{1}', which is not marked as 'isBaseClass'.", item.Name, item.BaseClass),
                Element = item
              });
              if (correct)
                current.IsBaseClass = true;                
            }
          }
        }

        if (isAbstract && countUses== 0)
        {
          log.Add(new DeviserMessage
          {
            Message = string.Format("Class: '{0}' is marked as 'isBaseClass', but not used.", current.Name),
            Element = current
          });
          if (correct)
            current.IsBaseClass = false;
        }

      }
    }

    /// <summary>
    /// Analyze description for inconsistencies
    /// </summary>
    /// <param name="correct"></param>
    /// <returns></returns>
    public List<DeviserMessage> AnalyzeDescription(bool correct = false)
    {
      var log = new List<DeviserMessage>();

      // test for inconsistencies in elements
      //TestForInconsistenciesInHasChildren(log, correct);

      if (string.IsNullOrWhiteSpace(Name))
      {
        log.Add(new DeviserMessage { Message = "Package: missing name attribute.", Element = this} );
      }

      if (string.IsNullOrWhiteSpace(FullName))
      {
        log.Add(new DeviserMessage { Message = "Package: missing full name attribute.", Element = this });
        if (correct)
        {
          FullName = Name;
        }
      }

      TestForInconsistenciesInHasListOf(log, correct);
      TestForInconsistenciesInAbstract(log, correct);
      //TestForInconsistenciesInHasMath(log, correct);

      return log;
    }

    /// <summary>
    /// This method sets the legacy attributes for 'math' and 'children'
    /// </summary>
    public void FixHiddenBooleanAttributes()
    {
      var log = new List<DeviserMessage>();

      // test for inconsistencies in elements
      TestForInconsistenciesInHasChildren(log, true);
      TestForInconsistenciesInHasMath(log, true);
    }


    public override string ToYuml(bool usecolor = true)
    {
      var builder = new StringBuilder();
      foreach (var item in Plugins)
        builder.Append(item.ToYuml(usecolor));
      foreach (var item in Enums)
        builder.Append(item.ToYuml(usecolor));
      foreach (var item in Elements)
        builder.Append(item.ToYuml(usecolor));
      return builder.ToString();
    }
  }
}
