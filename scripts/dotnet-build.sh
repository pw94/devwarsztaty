#!/bin/bash
cd ..
projects=(Warsztaty.Api Warsztaty.Messages Warsztaty.Service)
for project in ${projects[*]}
do
	echo ========================================================
	echo Building project: $project
	echo ========================================================
	dotnet build $project/$project.csproj
done