using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace LibDeviser
{
  public class DeviserVersion : DeviserBase
  {
    /// <summary>
    /// the core level that this version is being integrated in
    /// </summary>
    public int Level { get; set; }
    
    /// <summary>
    /// the core version that this version is integrated in
    /// </summary>
    public int Version { get; set; }
    
    /// <summary>
    /// the version of this package
    /// </summary>
    public int PackageVersion { get; set; }

    /// <summary>
    /// All Elements defined by this Package
    /// </summary>
    public List<DeviserClass> Elements { get; set; }

    /// <summary>
    /// All Extension Points  of this package
    /// </summary>
    public List<DeviserPlugin> Plugins { get; set; }

    /// <summary>
    /// All Enumerations defined by this package
    /// </summary>
    public List<DeviserEnum> Enums { get; set; }

    /// <summary>
    /// Mappings to elements defined in another package
    /// </summary>
    public List<DeviserMapping> Mappings { get; set; }

    /// <summary>
    /// Returns an element with the given name
    /// </summary>
    /// <param name="name">name of the element to return</param>
    /// <returns>the element or null in case it does not exist</returns>
    public DeviserClass GetElement(string name)
    {
      return Elements.FirstOrDefault(e => e.Name == name);
    }

    /// <summary>
    /// Returns an enum with the given name
    /// </summary>
    /// <param name="name">name of the enum to return</param>
    /// <returns>the enum or null in case it does not exist</returns>
    public DeviserEnum GetEnum(string name)
    {
      return Enums.FirstOrDefault(e => e.Name == name);
    }

    /// <summary>
    /// Returns a plugin with the given name
    /// </summary>
    /// <param name="name">name of the plugin to return</param>
    /// <returns>the plugin or null in case it does not exist</returns>
    public DeviserPlugin GetPlugin(string name)
    {
      return Plugins.FirstOrDefault(e => e.ExtensionPoint == name);
    }

    /// <summary>
    /// Checks whether the version element or any of its children have modification
    /// </summary>
    public override bool HasModification
    {
      get
      {
        return Dirty 
          ||  Elements.Any(item => item.HasModification)
          ||  Plugins.Any(item => item.HasModification)
          ||  Enums.Any(item => item.HasModification)
          ||  Mappings.Any(item => item.HasModification)
          ;
      }
    }

    /// <summary>
    /// Resets the modification flag on the version and all its children
    /// </summary>
    public override void ClearDirty()
    {
      Dirty = false;
      Elements.ClearDirty();
      Plugins.ClearDirty();
      Enums.ClearDirty();
      Mappings.ClearDirty();
    }

    /// <summary>
    /// Creates a new version
    /// </summary>
    public DeviserVersion()
    {
      Elements = new List<DeviserClass>();
      Plugins = new List<DeviserPlugin>();
      Enums = new List<DeviserEnum>();
      Mappings = new List<DeviserMapping>();

    }

    /// <summary>
    /// Clones this version
    /// </summary>
    /// <returns>a deep clone of this version</returns>
    public override object Clone()
    {
      return new DeviserVersion(this);
    }

    /// <summary>
    /// Copy constructor
    /// </summary>
    /// <param name="other">another version object to initialize from</param>
    public DeviserVersion(DeviserVersion other) : this()

    {
      Plugins = other.Plugins.CloneAll();
      Enums = other.Enums.CloneAll();
      Mappings = other.Mappings.CloneAll();
      Elements = other.Elements.CloneAll();

      Level = other.Level;
      Version = other.Version;
      PackageVersion = other.PackageVersion;

    }

    /// <summary>
    /// Initializes a version object from an xml node
    /// </summary>
    /// <param name="node">the node to read from</param>
    public DeviserVersion(XmlElement node)
      : this()
    {
      InitializeFrom(node);
    }

    /// <summary>
    /// Parses the given element
    /// </summary>
    /// <param name="element">the element to read the attributes from</param>
    public override void InitializeFrom(XmlElement element)
    {

      Level = Util.readInt(element, "level");
      Version = Util.readInt(element, "version");
      PackageVersion = Util.readInt(element, "pkg_version");

      Elements.InitializeFrom(Util.getElement(element, "element"));
      Plugins.InitializeFrom(Util.getElement(element, "plugin"));
      Enums.InitializeFrom(Util.getElement(element, "enum"));
      Mappings.InitializeFrom(Util.getElement(element, "mapping"));

    }

    /// <summary>
    /// Sets the document as parent for all child elements
    /// </summary>
    /// <param name="doc">the document to take as parent document</param>
    public override void SetParent(DeviserPackage doc)
    {
      Elements.SetParent(doc);
      Plugins.SetParent(doc);
      Enums.SetParent(doc);
      Mappings.SetParent(doc);
    }

    /// <summary>
    /// Writes all attributes to the given writer
    /// </summary>
    /// <param name="writer">the writer to write to</param>
    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);

      if (Level != 0)
        writer.WriteAttributeString("level", Level.ToString());

      if (Version != 0)
        writer.WriteAttributeString("version", Version.ToString());

      if (PackageVersion != 0)
        writer.WriteAttributeString("pkg_version", PackageVersion.ToString());

    }

    /// <summary>
    /// Writes all child elements to the given writer
    /// </summary>
    /// <param name="writer">the writer to write to</param>
    public override void WriteElementsTo(XmlWriter writer)
    {
      base.WriteElementsTo(writer);

      Elements.WriteListWithName(writer, "elements");
      Plugins.WriteListWithName(writer, "plugins");
      Enums.WriteListWithName(writer, "enums");
      Mappings.WriteListWithName(writer, "mappings");

    }

    /// <summary>
    /// Creates a new pkgVersion element and adds it to the writer
    /// </summary>
    /// <param name="writer">the writer to write to</param>
    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "pkgVersion");
    }

    /// <summary>
    /// Returns a string representation of this version
    /// </summary>
    /// <returns>a string representation of this version</returns>
    public override string ToString()
    {
      return string.Format("Version: {0},{1},{2}", Level, Version, PackageVersion);
    }

    /// <summary>
    /// Utility function finding all classes used by this package
    /// </summary>
    public void InitializeMappings()
    {
      var usedClasses = UsedClasses;

      usedClasses.RemoveAll(Util.CoreClasses.Contains);
      usedClasses.RemoveAll(DefinedClasses.Contains);
      usedClasses.Remove("ASTNode*");
      usedClasses.Remove("const ASTNode*");
      usedClasses.Remove("XMLNode*");
      usedClasses.Remove("const XMLNode*");

      foreach (var item in usedClasses)
      {
        if (Mappings.All(el => el.Name != item))
        {
          Mappings.Add(new DeviserMapping { Name = item });
        }
      }
    }

    /// <summary>
    /// Returns a list of all used classes of this version
    /// </summary>
    public List<string> UsedClasses
    {

      get
      {
        var result = Elements.Select(el => el.BaseClass).Distinct().ToList();

        foreach (var element in Elements)
        {
          foreach (var attribute in element.Attributes)
          {
            if (attribute.Type == "element")
              if (!result.Contains(attribute.Element))
                result.Add(attribute.Element);
          }
        }

        var elements = Elements.SelectMany(el => el.Attributes.Where(a => a.Type == "element").Select(a2 => a2.Element)).Distinct().ToList();
        result.AddRange(elements);
        var plugins = Plugins.Select(plug => plug.ExtensionPoint).Distinct().ToList();
        result.AddRange(plugins);
        result = result.Distinct().ToList();
        result.Remove("");
        result.Sort();
        return result;

      }
    }

    /// <summary>
    /// Returns a list of all classes defined by this version
    /// </summary>
    public List<string> DefinedClasses
    {
      get { return Elements.Select(el => el.Name).ToList(); }
    }
  }
}