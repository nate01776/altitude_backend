# IO.Swagger - ASP.NET Core 2.0 Server

This is service is designed to return current information and historical data related to the Doomsday Clock maintained by the Bulletin of Atomic Scientists. There is a lightweight front end application designed to emmulate the motif of the clock as described here - https://www.theatlantic.com/entertainment/archive/2015/11/doomsday-clock-michael-bierut-design/412936/

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
