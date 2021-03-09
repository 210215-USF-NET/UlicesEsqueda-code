# base image for the image. You need thiis to run the app.
FROM mcr.microsoft.com/dotnet/sdk:5.0 as build

#baby of mkdir and cd (it makes the directory if it doesn't exist and navigates to that directory)
WORKDIR /app

# Copy the sln and csproj files first to restore them and the deps
COPY *.sln ./
COPY ToHBL/*.csproj ToHBL/
COPY ToHDL/*.csproj ToHDL/
COPY ToHModels/*.csproj ToHModels/
COPY ToHMVC/*.csproj ToHMVC/
COPY ToHTests/*.csproj ToHTests/

# To restore all dependencies that I might need.
RUN dotnet restore

# This is me just copying my codebase (But there are some things I don't want copied over)
COPY . ./

# Make it executable
RUN dotnet publish ToHMVC -c Release -o publish --no-restore


# Were doing a multi stage build. After we restore out codebase our app and create a deployable version of it using publish,
# we leave the code base, and we only take the publish version of it to the final image that will be built
# so that we won't have to deploy the SDK which is memory heavy or our code base (to protect our implementation details)
# What we are deploying to the public is a runtime, and an execcutable version of our app.
FROM mcr.microsoft.com/dotnet/aspnet:5.0 as runtime

WORKDIR /app

# From the earlier build, get the publish folder.
COPY --from=build /app/publish ./

# Run this executable on this container.
CMD ["dotnet", "ToHMVC.dll"]
