using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace LibDeviser
{
  public sealed class DeviserVersion : DeviserBase
  {

    public int Level { get; set; }
    public int Version { get; set; }
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

    public List<DeviserMapping> Mappings { get; set; }


    public DeviserClass GetElement(string name)
    {
      return Elements.FirstOrDefault(e => e.Name == name);
    }

    public DeviserEnum GetEnum(string name)
    {
      return Enums.FirstOrDefault(e => e.Name == name);
    }

    public DeviserPlugin GetPlugin(string name)
    {
      return Plugins.FirstOrDefault(e => e.ExtensionPoint == name);
    }

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

    public override void ClearDirty()
    {
      Dirty = false;
      Elements.ClearDirty();
      Plugins.ClearDirty();
      Enums.ClearDirty();
      Mappings.ClearDirty();
    }

    public DeviserVersion()
    {
      Elements = new List<DeviserClass>();
      Plugins = new List<DeviserPlugin>();
      Enums = new List<DeviserEnum>();
      Mappings = new List<DeviserMapping>();

    }

    public override object Clone()
    {
      return new DeviserVersion(this);
    }

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

    public DeviserVersion(XmlElement node)
      : this()
    {
      InitializeFrom(node);
    }

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

    public override void SetParent(DeviserPackage doc)
    {
      Elements.SetParent(doc);
      Plugins.SetParent(doc);
      Enums.SetParent(doc);
      Mappings.SetParent(doc);
    }

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

    public override void WriteElementsTo(XmlWriter writer)
    {
      base.WriteElementsTo(writer);

      Elements.WriteListWithName(writer, "elements");
      Plugins.WriteListWithName(writer, "plugins");
      Enums.WriteListWithName(writer, "enums");
      Mappings.WriteListWithName(writer, "mappings");

    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "pkgVersion");
    }
    public override string ToString()
    {
      return string.Format("Version: {0},{1},{2}", Level, Version, PackageVersion);
    }
  }
}