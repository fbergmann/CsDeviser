﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace LibDeviser
{
  [Serializable]
  public class DeviserSettings
  {
    public string PythonInterpreter { get; set; }
    private string _PythonIncludes;
    public string PythonIncludes
    {
      get
      {
        if (!string.IsNullOrWhiteSpace(_PythonIncludes))
          return _PythonIncludes;
        if (string.IsNullOrWhiteSpace(PythonInterpreter))
          return string.Empty;
        var path = Path.GetDirectoryName(PythonInterpreter);
        string dirPath = Path.Combine(path, "include");
        if (Directory.Exists(dirPath))
        return dirPath;
        return string.Empty;
      }
      set { _PythonIncludes = value; }
    }

    private string _PythonLibrary;
    public string PythonLibrary
    {
      get
      {
        if (!string.IsNullOrWhiteSpace(_PythonLibrary))
          return _PythonLibrary;
        if (string.IsNullOrWhiteSpace(PythonInterpreter))
          return string.Empty;
        var path = Path.GetDirectoryName(PythonInterpreter);
        var libs = Path.Combine(path, "libs");
        if (Directory.Exists(libs))
        {
        var files = Directory.GetFiles(libs, "python*.lib", SearchOption.TopDirectoryOnly);
        if (files.Length == 0) return string.Empty;
        return files[0];
        }
        return string.Empty;

      }
      set { _PythonLibrary = value; }
    }

    public string DeviserRepository { get; set; }
    public string DefaultOutputDir { get; set; }
    public string SBMLPkgSpecDir { get; set; }
    public string MikTexDir { get; set; }
    public string LibSBMLSourceDir { get; set; }
    public string DependenciesSourceDir { get; set; }
    public string VSBatchFile{ get; set; }
    public string CMake { get; set; }
    public string Swig { get; set; }

    public static DeviserSettings Instance
    {
      get
      {
        if (_instance == null)
          _instance = GetDefault(new Size(800, 600));
        return _instance; 
      }
      set {         
        _instance = value;
        _instance.Save();
      }
    }

    public void Save()
    {
      WriteXmlToFile(ConfigFile);
    }

    private static DeviserSettings _instance;

    public static string ConfigFile
    {
      get
      {
        return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "deviser_config.xml");
      }
    }

    public static DeviserSettings GetDefault(Size current)
    {
      var instance = FromXmlFile(ConfigFile);
      if (instance == null)
      {
        var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var master = dir == null ? "" : Path.Combine(dir, "default_config.xml");
        if (File.Exists(master))
          instance = FromXmlFile(master);
        if (instance == null)
          return new DeviserSettings
          {
            Height = current.Height,
            Width = current.Width
          };
      }

      _instance = instance;
      return instance;
    }

    public int Width { get; set; }

    public int Height { get; set; }

    public static DeviserSettings FromXmlFile(string fileName)
    {
      try
      {
        var serializer = new System.Xml.Serialization.XmlSerializer(typeof(DeviserSettings));
        var text = File.ReadAllText(fileName);
        using (var stringReader = new StringReader(text))
        {
          return (DeviserSettings)serializer.Deserialize(stringReader);
        }
      }
      catch (Exception ex)
      {
        Debug.WriteLine("Could not load settings: {0}\n\n{1}", ex.Message, ex.StackTrace);
        return null;
      }
    }

    public void WriteXmlToFile(string fileName)
    {
      var serializer = new System.Xml.Serialization.XmlSerializer(GetType());
      using (var stream = new StringWriter())
      {
        serializer.Serialize(stream, this);
        stream.Flush();
        File.WriteAllText(fileName, stream.ToString());
      }
    }

    public bool CanGenerate
    {
      get
      {
        return !string.IsNullOrWhiteSpace(DeviserRepository) && 
          Directory.Exists(DeviserRepository) &&
          !string.IsNullOrWhiteSpace(PythonInterpreter) && 
          File.Exists(PythonInterpreter);
      }
    }

    public bool CanCompileTeX
    {
      get
      {
        return !string.IsNullOrWhiteSpace(MikTexDir) &&
          Directory.Exists(MikTexDir) &&
          !string.IsNullOrWhiteSpace(SBMLPkgSpecDir) &&
          Directory.Exists(SBMLPkgSpecDir);
      }
    }

    public bool CanCompilePackage
    {
      get
      {
				return ( !Util.IsWindows || ( !string.IsNullOrWhiteSpace(VSBatchFile) && File.Exists(VSBatchFile) ) ) &&
               !string.IsNullOrWhiteSpace(LibSBMLSourceDir) && Directory.Exists(LibSBMLSourceDir) &&
               !string.IsNullOrWhiteSpace(DependenciesSourceDir) && Directory.Exists(DependenciesSourceDir) &&
               !string.IsNullOrWhiteSpace(CMake) && File.Exists(CMake);
      }
    }

  }
}