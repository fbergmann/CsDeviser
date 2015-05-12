using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{

  /// <summary>
  /// base class for all deviser elements
  /// </summary>
  public class DeviserBase : ICloneable
  {
    /// <summary>
    /// Get set Dirty state of package
    /// </summary>
    public bool Dirty { get; set; }

    /// <summary>
    /// Gets a value indicating whether this instance has modification.
    /// </summary>
    /// <value>
    /// <c>true</c> if this instance has modification; otherwise, <c>false</c>.
    /// </value>
    public virtual bool HasModification
    {
      get { return Dirty; }      
    }

    /// <summary>
    /// Clears the modification flag.
    /// </summary>
    public virtual void ClearDirty()
    {
      Dirty = false;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DeviserBase"/> class.
    /// </summary>
    public DeviserBase()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DeviserBase"/> class from another element.
    /// </summary>
    /// <param name="other">The other element.</param>
    public DeviserBase(DeviserBase other)
    {
    }

    /// <summary>
    /// Initializes from and xml node.
    /// </summary>
    /// <param name="node">The xml node.</param>
    public virtual void InitializeFrom(XmlNode node)
    {
      InitializeFrom((XmlElement)node);
    }

    /// <summary>
    /// Initializes from an xml element.
    /// </summary>
    /// <param name="element">The xml element.</param>
    public virtual void InitializeFrom(XmlElement element)
    {

    }

    /// <summary>
    /// Writes to an xml writer.
    /// </summary>
    /// <param name="writer">The writer.</param>
    public virtual void WriteTo(XmlWriter writer)
    {
      WriteAttributesTo(writer);
      WriteElementsTo(writer);
    }


    /// <summary>
    /// Writes the element with specified name to the writer.
    /// </summary>
    /// <param name="writer">The writer.</param>
    /// <param name="name">The xml element name.</param>
    public virtual void WriteElementWithNameTo(XmlWriter writer, string name)
    {
      writer.WriteStartElement(name);
      WriteAttributesTo(writer);
      WriteElementsTo(writer);
      writer.WriteEndElement();
    }

    /// <summary>
    /// Writes the attributes to the writer.
    /// </summary>
    /// <param name="writer">The writer.</param>
    public virtual void WriteAttributesTo(XmlWriter writer)
    {

    }

    /// <summary>
    /// Writes the child elements to the writer.
    /// </summary>
    /// <param name="writer">The writer.</param>
    public virtual void WriteElementsTo(XmlWriter writer)
    {

    }

    /// <summary>
    /// Returns an XML string representation of this element.
    /// </summary>
    /// <returns></returns>
    public virtual string ToXmlString()
    {
      var builder = new StringBuilder();
      var settings = new XmlWriterSettings { Indent = true, Encoding = Encoding.UTF8, OmitXmlDeclaration = true };
      using (var writer = XmlWriter.Create(builder, settings))
      {
        writer.WriteStartDocument();
        WriteTo(writer);
        writer.WriteEndDocument();
      }
      return builder.ToString();
    }

    /// <summary>
    /// Gets or sets optional user data.
    /// </summary>
    /// <value>
    /// The user data.
    /// </value>
    public object UserData { get; set; }

    /// <summary>
    /// Gets or sets the parent document.
    /// </summary>
    /// <value>
    /// The document.
    /// </value>
    public DeviserPackage Document { get; set; }

    /// <summary>
    /// Sets the parent document.
    /// </summary>
    /// <param name="doc">The document to assume as parent.</param>
    public virtual void SetParent(DeviserPackage doc)
    {
      Document = doc;
    }

    /// <summary>
    /// generates a yUML representation of this element.
    /// </summary>
    /// <param name="usecolor">if set to <c>true</c> a string containing colors is to be generated.</param>
    /// <returns></returns>
    public virtual string ToYuml(bool usecolor = true)
    {
      return "";
    }

    /// <summary>
    /// Creates a new object that is a copy of the current instance.
    /// </summary>
    /// <returns>
    /// A new object that is a copy of this instance.
    /// </returns>
    public virtual object Clone()
    {
      return new DeviserBase(this);
    }
  }
}
