using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibDeviser
{
  public static class Util
  {

    /// <summary>
    /// Helper determining whether this assembly runs on Windows or not
    /// </summary>
    public static bool IsWindows
    {
      get
      {
        
        int p = (int)Environment.OSVersion.Platform;        
        if ((p == 4) || (p == 6) || (p == 128))
        {
          return false;
        }

        return true;
      }
    }

    /// <summary>
    /// Returns the file filter for executable files (.exe for windows / .* for other platforms)
    /// </summary>
    public static string ExecutableFilter 
    {
      get
      {
        if (IsWindows)
          return "Executables|*.exe;*.bat;*.cmd;*.com|All files|*.*";
        return "All files|*.*";
      }
    }


    public static void ClearDirty<T>(this List<T> list)
      where T : DeviserBase
    {
      foreach (var item in list)
      {
        item.ClearDirty();
      }      
    }

    public static List<T> CloneAll<T>(this List<T> list)
      where T : DeviserBase
    {
      var result = new List<T>();
      foreach (var item in list)
      {
        result.Add((T)item.Clone());
      }
      return result;
    }

    public static int ToInt(this string str)
    {
      int val;
      if (!int.TryParse(str, out val))
        return 0;
      return val;
    }

    public static void SetParent<T>(this List<T> list, DeviserPackage doc)
      where T : DeviserBase
    {
      foreach (var item in list)
      {
        item.SetParent(doc);
      }
      
    }

    public static string LowerFirst(this string str)
    {
      string result = str.Substring(0, 1).ToLowerInvariant() + str.Substring(1, str.Length -1);      
      return result;
    }

    public static string GuessPlural(this string str)
    {
      if (str.EndsWith("Information")) return str;
      if (str.EndsWith("Index")) return str.Replace("Index", "Indices");
      if (str.EndsWith("s")) return str;
      if (str.EndsWith("x")) return str + "es";
      return str + "s";
    }

    public static List<string> CoreClasses
    {
    get {
      return CoreClassesTypeCodeMap.Keys.ToList();
    }
      
  }

    public static Dictionary<string, string> CoreClassesTypeCodeMap
    {
      get { 
        var result = new Dictionary<string, string>();
        foreach (var line in Properties.Resources.CoreClasses.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries))
        {
          var entries = line.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
          if (entries.Length == 2)
          {
            result[entries[0]] = entries[1];
          }
        }
        return result;
      }
    }

    public static void InitializeFrom<T>(this List<T> list, XmlNodeList nodes, DeviserPackage parent = null)
   where T : DeviserBase, new()
    {
      if (nodes == null || nodes.Count == 0)
        return;

      foreach (var item in nodes)
      {
        var element = new T { Document = parent };
        element.InitializeFrom((XmlElement)item);
        list.Add(element);
      }
    }

    public static void WriteListWithName<T>(this List<T> list, XmlWriter writer, string name)
      where T : DeviserBase
    {
      if (writer == null || list == null || list.Count <= 0 || string.IsNullOrWhiteSpace(name))
        return;

      writer.WriteStartElement(name);
      foreach (var item in list)
        item.WriteTo(writer);
      writer.WriteEndElement();
    }

    public static bool readBool(string sDouble, bool defaultValue = false)
    {
      var dResult = defaultValue;
      var sTemp = sDouble;
      if (string.IsNullOrEmpty(sDouble)) return dResult;
      if (sTemp.Contains(",")) sTemp = sTemp.Replace(',', '.');
      if (sTemp.Contains("%")) sTemp = sTemp.Replace("%", "");
      bool.TryParse(sTemp, out dResult);

      return dResult;
    }

    public static bool readBool(XmlNode oNode, string sAttribute, bool defaultValue = false)
    {
      var sTemp = getAttribute(oNode, sAttribute);
      return readBool(sTemp, defaultValue);
    }

    public static int readInt(string sDouble, int defaultValue = 0)
    {
      var dResult = defaultValue;
      var sTemp = sDouble;
      if (string.IsNullOrEmpty(sDouble)) return dResult;
      if (sTemp.Contains(",")) sTemp = sTemp.Replace(',', '.');
      if (sTemp.Contains("%")) sTemp = sTemp.Replace("%", "");
      int.TryParse(sTemp, out dResult);

      return dResult;
    }

    public static int readInt(XmlNode oNode, string sAttribute, int defaultValue = 0)
    {
      var sTemp = getAttribute(oNode, sAttribute);
      return readInt(sTemp, defaultValue);
    }

    public static double readDouble(string sDouble, double defaultValue = 0.0)
    {
      var dResult = defaultValue;
      var sTemp = sDouble;
      if (string.IsNullOrEmpty(sDouble)) return dResult;
      if (sTemp.Contains(",")) sTemp = sTemp.Replace(',', '.');
      if (sTemp.Contains("%")) sTemp = sTemp.Replace("%", "");
      double.TryParse(sTemp, out dResult);

      return dResult;
    }

    public static double readDouble(XmlNode oNode, string sAttribute, double defaultValue = 0.0)
    {
      var sTemp = getAttribute(oNode, sAttribute);
      return readDouble(sTemp, defaultValue);
    }

    public static String getAttribute(XmlNode oNode, string sAttribute)
    {
      if (oNode == null || oNode.Attributes == null) return String.Empty;

      foreach (XmlAttribute attrib in oNode.Attributes)
      {
        if (attrib.Name == sAttribute)
          return attrib.Value;
      }

      return String.Empty;
    }

    public static XmlNodeList getElement(XmlElement element, string sTagName, string sNamespace)
    {
      var result = element.GetElementsByTagName(sTagName, sNamespace);
      if (result.Count > 0)
        return result;
      return null;
    }

    public static XmlNodeList getElement(XmlElement element, string sTagName)
    {
      var result = element.GetElementsByTagName(sTagName);
      if (result.Count > 0)
        return result;
      return null;
    }

    public static XmlElement getFirstElement(XmlElement element, string sTagName, string sNamespace)
    {
      var result = element.GetElementsByTagName(sTagName, sNamespace);
      if (result.Count > 0)
        return (XmlElement)result[0];
      return null;
    }

    public static XmlElement getFirstElement(XmlElement element, string sTagName)
    {
      var result = element.GetElementsByTagName(sTagName);
      if (result.Count > 0)
        return (XmlElement)result[0];
      return null;
    }

    public static bool hasElement(XmlElement element, string sTagName, string sNamespace)
    {
      var result = element.GetElementsByTagName(sTagName, sNamespace);
      if (result.Count > 0)
        return true;
      return false;
    }

    public static bool hasElement(XmlElement element, string sTagName)
    {
      var result = element.GetElementsByTagName(sTagName);
      if (result.Count > 0)
        return true;
      return false;
    }

    public static bool hasChildElement(XmlElement element, string sTagName)
    {
      if (!element.HasChildNodes) return false;
      return element.ChildNodes.Cast<XmlNode>().Any(oNode => oNode.Name == sTagName);
    }

    public static XmlElement getChildElement(XmlElement element, string sTagName)
    {
      if (element == null) return null;
      if (!element.HasChildNodes) return null;
      return element.ChildNodes.Cast<XmlNode>().Where(oNode => oNode.Name == sTagName).Cast<XmlElement>().FirstOrDefault();
    }

    /// <summary>
    /// Properly indents the given xml
    /// </summary>
    /// <param name="sXML">xml content</param>
    /// <returns>indented xml content</returns>
    public static string ReformatXML(string sXML)
    {
      try
      {
        var doc = new XmlDocument();
        doc.LoadXml(sXML);

        var oBuilder = new StringBuilder();
        using (var writer = new StringWriter(oBuilder))
        {
          var oWriter = new XmlTextWriter(writer) { Formatting = Formatting.Indented };
          doc.WriteContentTo(oWriter);
          oWriter.Close();
        }

        return oBuilder.ToString();
      }
      catch (Exception)
      {
        return sXML;
      }
    }

  }
}
