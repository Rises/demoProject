#tool "nuget:?package=xunit.runner.console"
#tool nuget:?package=Codecov
#addin nuget:?package=Cake.Codecov


var target = Argument("target", "Upload-Coverage");

Task("Default")
	.IsDependentOn("Upload-Coverage");
	
Task("Upload-Coverage")
	.IsDependentOn("Artifacts")
    .Does(() =>{
    // Upload a coverage report.
    Codecov("coverage.xml");
});


Task("Artifacts")
	.IsDependentOn("CopyFiles")
	.Does(() =>
	{
		// Zip all files in the bin directory.
		Zip("./output/bin", "./output/bin/build.zip");
	});

Task("CopyFiles")
	.IsDependentOn("Unit-tests")
	.Does(() =>{
		var path = "./demoProject/bin/Debug";
		var files = GetFiles(path + "/**/*.dll");
		// Copy all exe and dll files to the output directory.
		CopyFiles(files, "./output/bin");
	});

Task("Unit-tests")
	.IsDependentOn("Build")
		.Does(() => {
		 MSTest("./demoProject-test/bin/Debug/demoProject-test.dll");
	});

Task("Build")
	.IsDependentOn("Clean")
	.Does(() => {
	 MSBuild("./demoProject.sln");
	});
	
Task("Clean")
    .Does(() =>{
    CleanDirectory("./demoProject/demoProject-test/bin/Debug");
});

RunTarget(target);