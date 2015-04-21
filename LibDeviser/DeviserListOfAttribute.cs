using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace LibDeviser
{
  public class DeviserListOfAttribute : DeviserAttribute
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="DeviserListOfAttribute"/> class.
    /// </summary>
    public DeviserListOfAttribute()
    {
      
    }

    public override object Clone()
    {
      return new DeviserListOfAttribute(this);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DeviserListOfAttribute"/> class.
    /// </summary>
    public DeviserListOfAttribute(DeviserListOfAttribute other) : base(other)
    {
      
    }


    public DeviserListOfAttribute(XmlNode node)
    {
      InitializeFrom(node);
    }

    public override void WriteTo(XmlWriter writer)
    {
      WriteElementWithNameTo(writer, "listOfAttribute");
    }

  }
}
