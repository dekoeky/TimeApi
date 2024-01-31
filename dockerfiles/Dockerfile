FROM alpine
RUN apk update && apk add libstdc++ icu
COPY ./TimeApi/bin/Release/net8.0/publish/ /app/publish
EXPOSE 8080
EXPOSE 8081
EXPOSE 5000
EXPOSE 80
EXPOSE 443
# COPY . /rommel



# apk update
# apk add libstdc++
# apk add icu