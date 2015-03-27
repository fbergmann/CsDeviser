using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;

namespace LibDeviser
{
  public static class Deviser
  {
    public static string GenerateLatex(string python, string repo, string outDir,
      string packageDesc, string packageName)
    {
      var builder = new StringBuilder();
      builder.AppendLine("Generating Latex");
      builder.AppendLine("================");
      builder.AppendLine();


      string destDir = Path.Combine(outDir, packageName + "-spec");
      if (!Directory.Exists(destDir))
        Directory.CreateDirectory(destDir);
      {
        var args = new StringBuilder();
        args.AppendFormat("\"{0}\" ", Path.Combine(repo, @"deviser\dev\test\generateLatex.py"));
        args.AppendFormat("\"{0}\" ", packageDesc);
        var info = new ProcessStartInfo
        {
          FileName = python,
          Arguments = args.ToString(),
          WorkingDirectory = destDir,
          UseShellExecute = false,
          CreateNoWindow = true, 
          RedirectStandardError = true, 
          RedirectStandardOutput = true,
        };

        var p = Process.Start(info);
        p.WaitForExit();

        var result = p.StandardOutput.ReadToEnd();
        if (!string.IsNullOrWhiteSpace(result)) 
        builder.AppendLine(result);        
        var error = p.StandardError.ReadToEnd();
        if (!string.IsNullOrWhiteSpace(error)) 
        builder.AppendLine(error);

      }

      builder.AppendLine();
      builder.AppendLine("DONE");
      builder.AppendLine();

      return builder.ToString();
    }

    public static string GeneratePackage(string python, string repo, string outDir, 
      string packageDesc, string packageName)
    {
      var builder = new StringBuilder();
      builder.AppendLine("Generating Package");
      builder.AppendLine("================");
      builder.AppendLine();

      if (!Directory.Exists(Path.Combine(outDir, packageName.ToLowerInvariant())))
      {
        var args = new StringBuilder();
        args.AppendFormat("\"{0}\" ", Path.Combine(repo, "createDirStruct.py"));
        args.AppendFormat("\"{0}\" ", packageName.ToLowerInvariant());
        var info = new ProcessStartInfo
        {
          FileName = python,
          Arguments = args.ToString(),
          WorkingDirectory = outDir,
          UseShellExecute = false,
          CreateNoWindow = true,
          RedirectStandardError = true,
          RedirectStandardOutput = true,
        };

        var p = Process.Start(info);
        p.WaitForExit();

        var result = p.StandardOutput.ReadToEnd();
        if (!string.IsNullOrWhiteSpace(result))
          builder.AppendLine(result);
        var error = p.StandardError.ReadToEnd();
        if (!string.IsNullOrWhiteSpace(error))
          builder.AppendLine(error);
      }
      {
        var args = new StringBuilder();
        args.AppendFormat("\"{0}\" ", Path.Combine(repo, "run.py"));
        args.AppendFormat("\"{0}\" ", packageName.ToLowerInvariant());
        args.AppendFormat("\"{0}\" ", packageDesc);
        var info = new ProcessStartInfo
        {
          FileName = python,
          Arguments = args.ToString(),
          WorkingDirectory = outDir,
          UseShellExecute = false,
          CreateNoWindow = true,
          RedirectStandardError = true,
          RedirectStandardOutput = true,
        };

        var p = Process.Start(info);
        p.WaitForExit();

        var result = p.StandardOutput.ReadToEnd();
        if (!string.IsNullOrWhiteSpace(result))
          builder.AppendLine(result);
        var error = p.StandardError.ReadToEnd();
        if (!string.IsNullOrWhiteSpace(error))
          builder.AppendLine(error);
      }

      builder.AppendLine();
      builder.AppendLine("DONE");
      builder.AppendLine();

      return builder.ToString();
    }

    public static void OpenDir(string outDir)
    {
      try
      {
        Process.Start(outDir);
      }
      catch (Exception ex)
      {
        Debug.WriteLine("Couldn't open: " + outDir + " ex: " + ex);
      }
    }

    public static string CompileTex(string mikTexDir, string sbmlPkgSpecDir, string outDir, string package, string packageName)
    {
      var builder = new StringBuilder();
      builder.AppendLine("Compile Latex");
      builder.AppendLine("================");
      builder.AppendLine();

      string destDir = Path.Combine(outDir, packageName + "-spec");
      string mainFile = Path.Combine(destDir, "main.tex");
      if (!File.Exists(mainFile))
      {
        File.WriteAllText(mainFile, Properties.Resources.main.Replace("@@PACKAGENAME@@", packageName));
      }

      if (!Directory.Exists(destDir))
        Directory.CreateDirectory(destDir);
      {
        var args = new StringBuilder();
        args.AppendFormat("--pdf --batch ");
        args.AppendFormat("main.tex ");
        var info = new ProcessStartInfo
        {
          FileName = Path.Combine(mikTexDir, "texify.exe"),
          Arguments = args.ToString(),
          WorkingDirectory = destDir,
          UseShellExecute = false,
          CreateNoWindow = true,
          RedirectStandardError = true,
          RedirectStandardOutput = true,
        };

        info.EnvironmentVariables.Remove("TEXINPUTS");
        if (sbmlPkgSpecDir.EndsWith("\\"))
          sbmlPkgSpecDir = sbmlPkgSpecDir.Substring(0, sbmlPkgSpecDir.Length - 1) + "//";
        info.EnvironmentVariables.Add("TEXINPUTS", sbmlPkgSpecDir);
        info.EnvironmentVariables.Add("BIBINPUTS", sbmlPkgSpecDir);

        var p = Process.Start(info);
        //p.WaitForExit();

        var result = p.StandardOutput.ReadToEnd();
        if (!string.IsNullOrWhiteSpace(result))
          builder.AppendLine(result);
        var error = p.StandardError.ReadToEnd();
        if (!string.IsNullOrWhiteSpace(error))
          builder.AppendLine(error);

      }

      builder.AppendLine();
      builder.AppendLine("DONE");
      builder.AppendLine();

      return builder.ToString();
    }
  }
}
