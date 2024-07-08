#load nuget:?package=Chocolatey.Cake.Recipe&version=0.28.4

///////////////////////////////////////////////////////////////////////////////
// TOOLS
///////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////
// SCRIPT
///////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////
// CUSTOM TASKS
///////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////
// RECIPE SCRIPT
///////////////////////////////////////////////////////////////////////////////

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context,
    buildSystem: BuildSystem,
    sourceDirectoryPath: ".",
    solutionFilePath: "./Chocolatey.BestPractices.sln",
    solutionDirectoryPath: ".",
    title: "Chocolatey.BestPractices",
    repositoryOwner: "chocolatey",
    repositoryName: "Chocolatey.BestPractices",
    productName: "Chocolatey.BestPractices",
    productDescription: "Chocolatey.BestPractices is a product of Chocolatey Software, Inc. - All Rights Reserved.",
    productCopyright: string.Format("Copyright © 2024 - {0} Chocolatey Software, Inc. - All Rights Reserved.", DateTime.Now.Year),
    treatWarningsAsErrors: false,
    preferDotNetGlobalToolUsage: !IsRunningOnWindows(),
    shouldStrongNameOutputAssemblies: false,
    shouldStrongNameSignDependentAssemblies: false,
    shouldRunAnalyze: false,
    shouldRunInspectCode: false,
    shouldRunILMerge: false,
    shouldRunChocolatey: false,
    shouldRunDotNetPack: true,
    shouldRunOpenCover: false,
    shouldRunPSScriptAnalyzer: false,
    shouldRunReportGenerator: false,
    shouldRunReportUnit: false,
    shouldRunTests: false);

ToolSettings.SetToolSettings(context: Context);

BuildParameters.PrintParameters(Context);

Build.RunDotNet();
