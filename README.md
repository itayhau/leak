# Memory Leaker
The purpose of this project is to test and observe memory leaks

Instructions:

1. Pull the repo to your host
2. Use this command to build the image:
  docker build -t memoryleaker .
3. Use this command to run the container:
  docker run memoryleaker -d
4. Use this command to use bash in the container:
  docker exec -it <CONTAINER_ID> /bin/bash
5. Use this command to copy the tmp folder to the host:
  docker cp <CONTAINER_ID>:/tmp/. "c:/dumps/"
  
Good luck
