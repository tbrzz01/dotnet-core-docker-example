# dotnet-core-docker-example
Creating dummy dotnet core Web api example

# Building/Running
You will need to install dotnet core.

1. `dotnet restore`
2. `dotnet build`
3. `dotnet run`

You will now be able to open browser at localhost:5000.
	* http://localhost:5000/swagger/ui
	* http://localhost:5000/Values/2

# Building Docker Image

1. `docker build -t dotnet-value-api-image .`

# Running Docker Image

1. `docker run -d -p 80:5000 —-name hello-values dotnet-value-api-image`

localhost:80 will port forward to docker image at 5000