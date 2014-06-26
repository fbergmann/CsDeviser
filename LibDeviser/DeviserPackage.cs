using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{

  public class DeviserPackage : DeviserBase
  {
    /// <summary>
    /// Name of the package
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Start number for the type codes enum
    /// </summary>
    public int StartNumber { get; set; }

    /// <summary>
    /// Offset for validation
    /// </summary>
    public int Offset { get; set; }

    /// <summary>
    /// All Elements defined by this Package
    /// </summary>
    public List<DeviserClass> Elements { get; set; }

    /// <summary>
    /// All Extension Points  of this package
    /// </summary>
    public List<DeviserPlugin> Plugins { get; set; }

    public DeviserPackage ()
    {
      Elements = new List<DeviserClass>();
      Plugins = new List<DeviserPlugin>();
    }

    public DeviserPackage(XmlNode node) : this()
    {
      InitializeFrom(node);
    }


    public DeviserPackage(string fileName)  : this()
    {
      ReadFromFile(fileName);
    }

    public DeviserClass GetElement(string name)
    {
      return Elements.FirstOrDefault(e => e.Name == name);
    }

    public DeviserPlugin GetPlugin(string name)
    {
      return Plugins.FirstOrDefault(e => e.ExtensionPoint == name);
    }


    public override void InitializeFrom(XmlElement element)
    {
      Name = element.GetAttribute("name");

      StartNumber = Util.readInt(element, "number");
      Offset = Util.readInt(element, "offset");
                  
      Elements.InitializeFrom(Util.getElement(element, "element"));
      Plugins.InitializeFrom(Util.getElement(element, "plugin"));

      SetParent(this);
    }

    public override void SetParent(DeviserPackage doc)
    {
      Document = doc;
      Elements.SetParent(doc);
      Plugins.SetParent(doc);
    }

    public void ReadFromFile(string fileName)
    {
      ReadFromString(File.ReadAllText(fileName));
    }

    public void ReadFromString(string packageDocument)
    {
      var oDocument = new XmlDocument();
      oDocument.LoadXml(packageDocument);

      Elements = new List<DeviserClass>();
      Plugins = new List<DeviserPlugin>();

      InitializeFrom(oDocument.DocumentElement);
    }
    
    public override void WriteAttributesTo(XmlWriter writer)
    {
      base.WriteAttributesTo(writer);
      
      if (!string.IsNullOrWhiteSpace(Name))
        writer.WriteAttributeString("name", Name);
      
      if (StartNumber != 0)
        writer.WriteAttributeString("number", StartNumber.ToString());
      
      if (Offset!= 0)
        writer.WriteAttributeString("offset", Offset.ToString());

    }

    public override void WriteElementsTo(XmlWriter writer)
    {
      base.WriteElementsTo(writer);

      Elements.WriteListWithName(writer, "elements");
      Plugins.WriteListWithName(writer, "plugins");

      
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
    /// Writes out the SedMLInfo object to the given fileName the format will be SED-ML
    /// </summary>
    /// <param name="fileName">fileName to write to</param>
    public void WriteTo(string fileName)
    {
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
  }
}
