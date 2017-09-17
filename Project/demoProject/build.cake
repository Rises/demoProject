#tool "nuget:?package=xunit.runner.console"
#tool nuget:?package=Codecov
#addin nuget:?package=Cake.Codecov



var target = Argument("target", "Upload-Coverage");

Task("Default")
	.IsDependentOn("Upload-Coverage");
	
Task("Upload-Coverage")
	.IsDependentOn("Unit-tests")
    .Does(() =>{
    // Upload a coverage report.
    Codecov("coverage.xml");
});

Task("Artifacts")
	.IsDependentOn("CopyFiles")
	.Does(() =>
	{
		// Zip all files in the bin directory.
		Zip("./demoProject/output/bin", "./demoProject/output/bin/build.zip");
	});

Task("CopyFiles")
	.IsDependentOn("Unit-tests")
	.Does(() =>{
		var path = "./demoProject/demoProject/bin/Debug";
		var files = GetFiles(path + "/**/*.dll")
		+ GetFiles(path + "/**/*.exe") + GetFiles(path + "/**/*.pdb") + GetFiles(path + "/**/*.config");
		// Copy all exe and dll files to the output directory.
		CopyFiles(files, "./demoProject/output/bin");
	});

Task("Unit-tests")
	.IsDependentOn("Build")
		.Does(() => {
		 MSTest("./demoProject/demoProject-test/bin/Debug/demoProject-test.dll");
	});

Task("Build")
	.IsDependentOn("Clean")
	.Does(() => {
	 MSBuild("./demoProject/demoProject.sln");
	});
	
Task("Clean")
    .Does(() =>{
    CleanDirectory("./demoProject/demoProject-test/bin/Debug");
});

RunTarget(target);