using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LibDeviser
{
  public static class Deviser
  {

    public static string ClassColor { get { return "linen"; } }
    public static string EnumColor { get { return "gold"; } }
    public static string ExtensionColor { get { return "palegreen"; } }
    public static string EnumPrefix { get { return "\u00ABEnumeration\u00BB;"; } }

    public static string CompilePackage(string libSBMLSourceDir, 
      string cMake, 
      string vsBatchFile, 
      string swig, 
      string python,  
      string outdir, 
      string packageName)
    {
      var builder = new StringBuilder();
      builder.AppendLine("Compile Package");
      builder.AppendLine("===============");
      builder.AppendLine();

      if (!Directory.Exists(libSBMLSourceDir))
      {
        builder.AppendLine("Error: The libsbml source dir does not exist, please validate your settings.");
        return builder.ToString();
      }

      if (!File.Exists(cMake))
      {
        builder.AppendLine("Error: The CMake executable does not exist, please validate your settings.");
        return builder.ToString();
      }

      if (!File.Exists(vsBatchFile))
      {
        builder.AppendLine("Error: The Visual studio file does not exist, please validate your settings.");
        return builder.ToString();
      }

      if (!Directory.Exists(outdir))
      {
        builder.AppendLine("Error: The outdput dir does not exist, please create it first.");
        return builder.ToString();
      }

      string depDir = Path.Combine(outdir, "install_dependencies");
      if (!Directory.Exists(depDir))
      {
        builder.AppendLine("Error: The dependency install dir does not exist, please compile dependencies first.");
        return builder.ToString();
      }

      var buildDir = Path.Combine(outdir, "build_" + packageName.ToLowerInvariant() + "_package");

      if (!Directory.Exists(buildDir))
        Directory.CreateDirectory(buildDir);

      var temp = new StringBuilder();
      temp.AppendLine("@echo off");
      temp.AppendFormat("call \"{0}\"{1}", vsBatchFile, Environment.NewLine);
      temp.AppendFormat("cmake -G \"NMake Makefiles\" -DCMAKE_BUILD_TYPE=Release -DSWIG_EXECUTABLE=\"{5}\" -DWITH_PYTHON=ON -DPYTHON_EXECUTABLE=\"{6}\" -DPYTHON_LIBRARY=\"{8}\" -DPYTHON_INCLUDE_DIR=\"{7}\" -DLIBSBML_DEPENDENCY_DIR=\"{4}\" -DENABLE_LAYOUT=ON -DENABLE_{3}=ON -DCMAKE_INSTALL_PREFIX=../install_{2}_package  \"{0}\"{1}", libSBMLSourceDir, Environment.NewLine, packageName.ToLowerInvariant(), packageName.ToUpperInvariant(), depDir, swig, python, DeviserSettings.Instance.PythonIncludes, DeviserSettings.Instance.PythonLibrary);
      temp.AppendLine("nmake");
      temp.AppendLine("nmake install");

      var file = Path.Combine(buildDir, "script.bat");
      File.WriteAllText(file, temp.ToString());

      {
        var args = new StringBuilder();
        var info = new ProcessStartInfo
        {
          FileName = file,
          Arguments = args.ToString(),
          WorkingDirectory = buildDir,
          UseShellExecute = false,
          CreateNoWindow = true,
          RedirectStandardError = true,
          RedirectStandardOutput = true,
        };
        var task = RunProcessAsync(info);
        task.Wait();
        builder.AppendLine(task.Result);

      }


      builder.AppendLine();
      builder.AppendLine("DONE");
      builder.AppendLine();

      return builder.ToString();
    }

    public static async void CompilePackageWithProgress(string libSBMLSourceDir,
      string cMake,
      string vsBatchFile,
      string swig,
      string python,
      string outdir,
      string packageName, 
      Action<string> progress
      )
    {
      progress("Compile Package");
      progress("===============");
      progress(Environment.NewLine);

      if (!Directory.Exists(libSBMLSourceDir))
      {
        progress("Error: The libsbml source dir does not exist, please validate your settings.");
        return ;
      }

      if (!File.Exists(cMake))
      {
        progress("Error: The CMake executable does not exist, please validate your settings.");
        return ;
      }

      if (!File.Exists(vsBatchFile))
      {
        progress("Error: The Visual studio file does not exist, please validate your settings.");
        return ;
      }

      if (!Directory.Exists(outdir))
      {
        progress("Error: The outdput dir does not exist, please create it first.");
        return ;
      }

      string depDir = Path.Combine(outdir, "install_dependencies");
      if (!Directory.Exists(depDir))
      {
        progress("Error: The dependency install dir does not exist, please compile dependencies first.");
        return ;
      }

      var buildDir = Path.Combine(outdir, "build_" + packageName.ToLowerInvariant() + "_package");

      if (!Directory.Exists(buildDir))
        Directory.CreateDirectory(buildDir);

      var temp = new StringBuilder();
      temp.AppendLine("@echo off");
      temp.AppendFormat("call \"{0}\"{1}", vsBatchFile, Environment.NewLine);
      temp.AppendFormat("cmake -G \"NMake Makefiles\" -DCMAKE_BUILD_TYPE=Release -DSWIG_EXECUTABLE=\"{5}\" -DWITH_PYTHON=ON -DPYTHON_EXECUTABLE=\"{6}\" -DPYTHON_LIBRARY=\"{8}\" -DPYTHON_INCLUDE_DIR=\"{7}\" -DLIBSBML_DEPENDENCY_DIR=\"{4}\" -DENABLE_LAYOUT=ON -DENABLE_{3}=ON -DCMAKE_INSTALL_PREFIX=../install_{2}_package  \"{0}\"{1}", libSBMLSourceDir, Environment.NewLine, packageName.ToLowerInvariant(), packageName.ToUpperInvariant(), depDir, swig, python, DeviserSettings.Instance.PythonIncludes, DeviserSettings.Instance.PythonLibrary);
      temp.AppendLine("nmake");
      temp.AppendLine("nmake install");

      var file = Path.Combine(buildDir, "script.bat");
      
      File.WriteAllText(file, temp.ToString());

      {
        var args = new StringBuilder();
        var info = new ProcessStartInfo
        {
          FileName = file,
          Arguments = args.ToString(),
          WorkingDirectory = buildDir,
          UseShellExecute = false,
          CreateNoWindow = true,
          RedirectStandardError = true,
          RedirectStandardOutput = true,
        };
        var task = RunProcessAsyncWithProgress(info, progress);
        await task;

      }


      progress(Environment.NewLine);
      progress("DONE");
      progress(Environment.NewLine);

      return ;
    }

    public static string CompileDependencies(string dependenciesSourceDir, 
      string cMake, 
      string vSBatchFile, 
      string outdir)
    {
      var builder = new StringBuilder();
      builder.AppendLine("Compile Dependencies");
      builder.AppendLine("====================");
      builder.AppendLine();

      if (!Directory.Exists(dependenciesSourceDir))
      {
        builder.AppendLine("Error: The dependencies source dir does not exist, please validate your settings.");
        return builder.ToString();
      }

      if (!File.Exists(cMake))
      {
        builder.AppendLine("Error: The CMake executable does not exist, please validate your settings.");
        return builder.ToString();
      }

      if (!File.Exists(vSBatchFile))
      {
        builder.AppendLine("Error: The Visual studio file does not exist, please validate your settings.");
        return builder.ToString();
      }

      if (!Directory.Exists(outdir))
      {
        builder.AppendLine("Error: The output dir does not exist, please create it first");
        return builder.ToString();
      }

      var buildDir = Path.Combine(outdir, "build_dependencies");

      if (!Directory.Exists(buildDir))
        Directory.CreateDirectory(buildDir);

      var temp = new StringBuilder();
      temp.AppendLine("@echo off");
      temp.AppendFormat("call \"{0}\"{1}", vSBatchFile, Environment.NewLine);
      temp.AppendFormat("cmake -G \"NMake Makefiles\" -DCMAKE_BUILD_TYPE=Release -DCMAKE_INSTALL_PREFIX=../install_dependencies  \"{0}\"{1}", dependenciesSourceDir, Environment.NewLine);
      temp.AppendLine("nmake");
      temp.AppendLine("nmake install");

      var file = Path.Combine(buildDir, "script.bat");
      File.WriteAllText(file, temp.ToString());

      {
        var args = new StringBuilder();        
        var info = new ProcessStartInfo
        {
          FileName = file,
          Arguments = args.ToString(),
          WorkingDirectory = buildDir,
          UseShellExecute = false,
          CreateNoWindow = true,
          RedirectStandardError = true,
          RedirectStandardOutput = true,
        };
        var task = RunProcessAsync(info);
        task.Wait();
        builder.AppendLine(task.Result);

      }


      builder.AppendLine();
      builder.AppendLine("DONE");
      builder.AppendLine();

      return builder.ToString();

    }
    
    public static async void CompileDependenciesWithProgress(string dependenciesSourceDir, 
      string cMake, 
      string vSBatchFile, 
      string outdir, 
      Action<string> progress)
    {
      progress("Compile Dependencies");
      progress("====================");
      progress(Environment.NewLine);

      if (!Directory.Exists(dependenciesSourceDir))
      {
        progress("Error: The dependencies source dir does not exist, please validate your settings.");
        return ;
      }

      if (!File.Exists(cMake))
      {
        progress("Error: The CMake executable does not exist, please validate your settings.");
        return;
      }

      if (!File.Exists(vSBatchFile))
      {
        progress("Error: The Visual studio file does not exist, please validate your settings.");
        return ;
      }

      if (!Directory.Exists(outdir))
      {
        progress("Error: The output dir does not exist, please create it first");
        return ;
      }

      var buildDir = Path.Combine(outdir, "build_dependencies");

      if (!Directory.Exists(buildDir))
        Directory.CreateDirectory(buildDir);

      string file;
      if (Util.IsWindows)
      {
        file = Path.Combine(buildDir, "script.bat");
        var temp = new StringBuilder();
        temp.AppendLine("@echo off");
        temp.AppendFormat("call \"{0}\"{1}", vSBatchFile, Environment.NewLine);
        temp.AppendFormat(
          "cmake -G \"NMake Makefiles\" -DCMAKE_BUILD_TYPE=Release -DCMAKE_INSTALL_PREFIX=../install_dependencies  \"{0}\"{1}",
          dependenciesSourceDir, Environment.NewLine);
        temp.AppendLine("nmake");
        temp.AppendLine("nmake install");

        File.WriteAllText(file, temp.ToString());
      }
      else
      {
        file = Path.Combine(buildDir, "script.sh");
        var temp = new StringBuilder();
        temp.AppendFormat(
          "cmake -G \"Unix Makefiles\"-DCMAKE_BUILD_TYPE=Release -DCMAKE_INSTALL_PREFIX=../install_dependencies  \"{0}\"{1}",
          dependenciesSourceDir, Environment.NewLine);
        temp.AppendLine("make");
        temp.AppendLine("make install");
        File.WriteAllText(file, temp.ToString());
      }


      {
        var args = new StringBuilder();        
        var info = new ProcessStartInfo
        {
          FileName = file,
          Arguments = args.ToString(),
          WorkingDirectory = buildDir,
          UseShellExecute = false,
          CreateNoWindow = true,
          RedirectStandardError = true,
          RedirectStandardOutput = true,
        };
        var task = RunProcessAsyncWithProgress(info, progress);
        await task;

      }


      progress(Environment.NewLine);
      progress("DONE");
      progress(Environment.NewLine);

      return ;

    }

    public static Task<string> RunProcessAsyncWithProgress(ProcessStartInfo info,
       Action<string> progress = null, Func<string> computeResult=null)
    {
      // there is no non-generic TaskCompletionSource
      var tcs = new TaskCompletionSource<string>();      


      var process = new Process
      {
        EnableRaisingEvents = true,
        StartInfo = info,
      };
      if (progress != null)
      {
        process.ErrorDataReceived += (sender, args) => progress(args.Data);
        process.OutputDataReceived += (sender, args) => progress(args.Data);
      }

      process.Exited += (sender, args) =>
      {
        if (computeResult != null)
          tcs.SetResult(computeResult());
        else
          tcs.SetResult(string.Empty);
        process.Dispose();
      };

      process.Start();
      process.BeginOutputReadLine();
      process.BeginErrorReadLine();


      return tcs.Task;
    }

    static Task<string> RunProcessAsync(ProcessStartInfo info)
    {
      var result = new StringBuilder();
      return 
        RunProcessAsyncWithProgress(info,
        s => result.AppendLine(s), result.ToString);
    }

    public static string GenerateLatex(string python, string repo, string outDir,
      string packageDesc, string packageName)
    {
      var builder = new StringBuilder();
      builder.AppendLine("Generating Latex");
      builder.AppendLine("================");
      builder.AppendLine();

      string lowerCasePackageName = packageName.ToLowerInvariant();
      string destDir = Path.Combine(outDir, lowerCasePackageName + "-spec");
      if (!Directory.Exists(destDir))
        Directory.CreateDirectory(destDir);
      {
        var args = new StringBuilder();
        args.AppendFormat("\"{0}\" ", Path.Combine(repo, Util.IsWindows ? @"deviser\dev\test\generateLatex.py" : "deviser/dev/test/generateLatex.py"));
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

        var task = RunProcessAsync(info);
        task.Wait();
        builder.AppendLine(task.Result);

      }

      builder.AppendLine();
      builder.AppendLine("DONE");
      builder.AppendLine();

      return builder.ToString();
    }

    public static async void GeneratePackageWithReport(string python, string repo, string outDir,
      string packageDesc, string packageName, Action<string> report)
    {
      report("Generating Package");
      report("==================");
      report(Environment.NewLine);
      

      if (!File.Exists(python))
      {
        report("Error: The python interpreter could not be found, please ensure you have the full path to it entered correctly: '" + python + "'.");
        return;
      }

      if (!File.Exists(Path.Combine(repo, "createDirStruct.py")) ||
          !File.Exists(Path.Combine(repo, "run.py"))
        )
      {
        report("Error: The 'run.py' and 'createDirStruct.py' scripts could not be found in '" + repo + "'.");
        return;
      }

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

        var task = RunProcessAsyncWithProgress(info, report);
        await task;

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

        var task = RunProcessAsyncWithProgress(info, report);
        await task;        

      }

      report(Environment.NewLine);
      report("DONE");
      report(Environment.NewLine);

      return;
    }

    public static string GeneratePackage(string python, string repo, string outDir,
      string packageDesc, string packageName)
    {
      var builder = new StringBuilder();
      builder.AppendLine("Generating Package");
      builder.AppendLine("==================");
      builder.AppendLine();



      if (!File.Exists(python))
      {
        builder.AppendLine("Error: The python interpreter could not be found, please ensure you have the full path to it entered correctly: '" + python + "'.");
        return builder.ToString();
      }

      if (!File.Exists(Path.Combine(repo, "createDirStruct.py")) ||
          !File.Exists(Path.Combine(repo, "run.py"))
        )
      {
        builder.AppendLine("Error: The 'run.py' and 'createDirStruct.py' scripts could not be found in '" + repo + "'.");
        return builder.ToString();
      }

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

        var task = RunProcessAsync(info);
        task.Wait();
        builder.AppendLine(task.Result);

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

        var task = RunProcessAsync(info);
        task.Wait();
        builder.AppendLine(task.Result);

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

    public static async void CompileTexWithProgress(string mikTexDir, 
      string sbmlPkgSpecDir, 
      string outDir, 
      string package, 
      string packageName,
      Action<string> progress)
    {
      progress("Compile Latex");
      progress("=============");
      progress("");

      string lowerCasePackageName = packageName.ToLowerInvariant();
      string destDir = Path.Combine(outDir, lowerCasePackageName + "-spec");
      if (!Directory.Exists(destDir))
      {
        progress("Error: Please 'generate latex' first before trying to compile. (latex dir not present)");
        return;
      }

      if (!File.Exists(Path.Combine(destDir, "apdx-validation.tex")) ||
        !File.Exists(Path.Combine(destDir, "body.tex")) ||
        !File.Exists(Path.Combine(destDir, "macros.tex")))
      {
        progress("Error: Please 'generate latex' first before trying to compile, that should have generated three files: 'body.tex', 'macros.tex' and 'apdx-validation.tex' however those files are not present.");
        return;
      }


      string mainFile = Path.Combine(destDir, "main.tex");
      if (!File.Exists(mainFile))
      {
        string mainText = Properties.Resources.main.Replace("@@PACKAGENAME@@", lowerCasePackageName);
        File.WriteAllText(mainFile, mainText);
      }

      if (Util.IsWindows && !File.Exists(Path.Combine(mikTexDir, "texify.exe")))
      {
        progress("Error: texify.exe was not present in '" + mikTexDir + "' please ensure you have the path entered correctly.");
        return;
      }

      {
        var args = new StringBuilder();
        if (Util.IsWindows)
          args.AppendFormat("--pdf --batch ");
        else
          args.AppendFormat(" -interaction=nonstopmode ");
        args.AppendFormat("main.tex ");
        var info = new ProcessStartInfo
        {
          FileName = Path.Combine(mikTexDir, Util.IsWindows ? "texify.exe" : "pdflatex"),
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

        var task = RunProcessAsyncWithProgress(info, progress);
        await task;
        

      }

      progress("");
      progress("DONE");
      progress("");

      return;
    }


    public static string CompileTex(string mikTexDir, string sbmlPkgSpecDir, string outDir, string package, string packageName)
    {
      var builder = new StringBuilder();
      builder.AppendLine("Compile Latex");
      builder.AppendLine("=============");
      builder.AppendLine();

      string lowerCasePackageName = packageName.ToLowerInvariant();
      string destDir = Path.Combine(outDir, lowerCasePackageName + "-spec");
      if (!Directory.Exists(destDir))
      {
        builder.AppendLine("Error: Please 'generate latex' first before trying to compile. (latex dir not present)");
        return builder.ToString();
      }

      if (!File.Exists(Path.Combine(destDir, "apdx-validation.tex")) ||
        !File.Exists(Path.Combine(destDir, "body.tex")) ||
        !File.Exists(Path.Combine(destDir, "macros.tex")))
      {
        builder.AppendLine("Error: Please 'generate latex' first before trying to compile, that should have generated three files: 'body.tex', 'macros.tex' and 'apdx-validation.tex' however those files are not present.");
        return builder.ToString();
      }


      string mainFile = Path.Combine(destDir, "main.tex");
      if (!File.Exists(mainFile))
      {
        string mainText = Properties.Resources.main.Replace("@@PACKAGENAME@@", lowerCasePackageName);
        File.WriteAllText(mainFile, mainText);
      }

      if (!File.Exists(Path.Combine(mikTexDir, "texify.exe")))
      {
        builder.AppendLine("Error: texify.exe was not present in '" + mikTexDir + "' please ensure you have the path entered correctly.");
        return builder.ToString();
      }

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

        var task = RunProcessAsync(info);
        task.Wait();
        builder.AppendLine(task.Result);

      }

      builder.AppendLine();
      builder.AppendLine("DONE");
      builder.AppendLine();

      return builder.ToString();
    }

    public static string AddPackageToSource(string libSBMLSourceDir, string outDir, string packageName)
    {
      var builder = new StringBuilder();
      builder.AppendLine("Adding Package to Source");
      builder.AppendLine("========================");
      builder.AppendLine();

      var lowerFirst = packageName.LowerFirst();
      var packageDir = Path.Combine(outDir, lowerFirst);
      if (!Directory.Exists(packageDir))
      {
        builder.AppendLine("Error: please export package first.");
        return builder.ToString();
      }

      if (!Directory.Exists(libSBMLSourceDir))
      {
        builder.AppendLine("Error: Missing source dir.");
        return builder.ToString();
      }

      {
        CopyFiles(outDir, 
          Path.Combine(packageDir, @"src"), 
          Path.Combine(libSBMLSourceDir, @"src"), builder);
      }

      {
        CopyFiles(outDir,
          Path.Combine(packageDir, lowerFirst + "-package.cmake"),
          libSBMLSourceDir, builder, false);
      }

      builder.AppendLine();
      builder.AppendLine("DONE");
      builder.AppendLine();

      return builder.ToString();
    }

    private static void CopyFiles(string outDir, string source, string target, StringBuilder builder, bool recursive = true)
    {
      var args = new StringBuilder();
      args.AppendFormat("\"{0}\" ", source);
      args.AppendFormat("\"{0}\" ", target);
      if (recursive)
      args.AppendFormat("/e ");
      args.AppendFormat("/y ");
      var info = new ProcessStartInfo
      {
        FileName = "xcopy",
        Arguments = args.ToString(),
        WorkingDirectory = outDir,
        UseShellExecute = false,
        CreateNoWindow = true,
        RedirectStandardError = true,
        RedirectStandardOutput = true,
      };

      var task = RunProcessAsync(info);
      task.Wait();
      builder.AppendLine(task.Result);
    }

    public static string RemovePackageFromSource(string libSBMLSourceDir, string packageName)
    {
      var builder = new StringBuilder();
      builder.AppendLine("Remove Package From Source");
      builder.AppendLine("==========================");
      builder.AppendLine();

      if (!Directory.Exists(libSBMLSourceDir))
      {
        builder.AppendLine("Error: Missing source dir.");
        return builder.ToString();
      }

      var lowerFirst = packageName.LowerFirst();

      DeleteFile(Path.Combine(libSBMLSourceDir, lowerFirst + "-package.cmake"));
      DeleteFile(Path.Combine(libSBMLSourceDir, @"src\" + lowerFirst + "-package.cmake"));
      DeleteFile(Path.Combine(libSBMLSourceDir, @"src\sbml\packages" + lowerFirst + "-register.cxx"));
      DeleteFile(Path.Combine(libSBMLSourceDir, @"src\sbml\packages" + lowerFirst + "-register.h"));
      DeleteDir(Path.Combine(libSBMLSourceDir, @"src\sbml\packages\" + lowerFirst));

      DeleteRecursive(Path.Combine(libSBMLSourceDir, @"src\bindings"), lowerFirst, builder);

      builder.AppendLine();
      builder.AppendLine("DONE");
      builder.AppendLine();

      return builder.ToString();
    }

    private static void DeleteDir(string dir)
    {
      if (Directory.Exists(dir))
      Directory.Delete(dir, true);
    }

    private static void DeleteFile(string file)
    {
      if (!File.Exists(file)) return;
      
      File.Delete(file);
    }

    private static void DeleteRecursive(string dir, string filter, StringBuilder builder)
    {
      var args = new StringBuilder();
      args.AppendFormat("/C ");
      args.AppendFormat("del "); 
      args.AppendFormat("\"*{0}*\" ", filter);
      args.AppendFormat("/s ");
      args.AppendFormat("/q ");
      var info = new ProcessStartInfo
      {
        FileName = "cmd",
        Arguments = args.ToString(),
        WorkingDirectory = dir,
        UseShellExecute = false,
        CreateNoWindow = true,
        RedirectStandardError = true,
        RedirectStandardOutput = true,
      };

      var task = RunProcessAsync(info);
      task.Wait();
      builder.AppendLine(task.Result);      
    }


    public static string TestPackage(string pythonInterpreter, string outDir, string packageName)
    {
      var builder = new StringBuilder();
      builder.AppendLine("Test package");
      builder.AppendLine("============");
      builder.AppendLine();

      var installDir = Path.Combine(outDir, "install_" + packageName + @"_package\bindings\python\libsbml");
      if (!Directory.Exists(installDir))
      {
        builder.AppendLine("Error: Missing install dir, maybe the last compile run was not successful?");
        return builder.ToString();
      }

      var interpreter = pythonInterpreter;
      var test = Path.Combine(Path.GetDirectoryName(pythonInterpreter), @"Scripts\ipython.exe");
      if (File.Exists(test))
        interpreter = test;

      if (!File.Exists(interpreter))
      {
        builder.AppendLine("Error: Missing interpreter, check settings.");
        return builder.ToString();
      }

      var args = new StringBuilder();
      var info = new ProcessStartInfo
      {
        FileName = interpreter,
        Arguments = args.ToString(),
        WorkingDirectory = installDir,
        UseShellExecute = false,
        CreateNoWindow = false,
        RedirectStandardError = false,
        RedirectStandardOutput = false,
      };

      info.EnvironmentVariables.Remove("PYTHONPATH");
      info.EnvironmentVariables.Add("PYTHONPATH", installDir);
      Process.Start(info);

      builder.AppendLine();
      builder.AppendLine("DONE");
      builder.AppendLine();

      return builder.ToString();
    }
  }
}
