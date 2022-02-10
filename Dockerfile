FROM mcr.microsoft.com/dotnet/aspnet:6.0
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
EXPOSE 443/tcp
ENTRYPOINT ["dotnet", "lab.dll"]

# docker run -p 8000:80 image/name