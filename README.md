## Prerequisites
- Docker should be installed
- DotNet should be installed(.Net6.0 preferably)

## Installation
Go to console and type the following commands to create the certificate for the ShippingApi:
```sh
dotnet dev-certs https^
    -ep %USERPROFILE%\.aspnet\https\ShippingApiCert.pfx^
    -p CertPassw0rd2022
dotnet dev-certs https --trust
```

Then type a command to setup a Shipping database:
```sh
docker run --name shippingdb^
    -e ACCEPT_EULA=Y^
    -e SA_PASSWORD=yourStrongPassword12345^
    -e MSSQL_PID=Express^
    -p 1433:1433^
    -d mcr.microsoft.com/mssql/server:2017-latest-ubuntu
```

After the database has been up and running select a directory for ShippingApp and run:
```sh
git clone https://github.com/Havrylei/ShippingApp.git
cd ShippingApp
docker compose up -d
```

Once it finishes, go to the http://localhost/ link.