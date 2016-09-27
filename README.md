# Magic8Ball
A sample for how to call batch jobs with docker

Docker containers start instantly, and always start in a clean state. So, why not run your batch jobs as containers?
In this really simple sample, I pass a string (a question for the magic 8 ball) and return an answer. This could take a customer_id and process their taxes, or create a thumbnail for a image url passed in.

## Building
Using Visual Studio, select Release from the configuration and build the project.

The **Magic8Ball.exe** is output to `/bin/Release/Magic8Ball.exe`

## Dockerfile
```
FROM microsoft/windowsservercore

# copies the application to the container
ADD bin/debug/Magic8Ball.exe /Magic8Ball.exe

# sets the application as the running app when the container is started
ENTRYPOINT Magic8Ball.exe
```

## Running the container

Run the following command:

`docker run <dockerhub-id>/magic8ball "Are you a square container?"`

  The answer to your question: 'Are you a square container?' is Without a doubt

If you run the `docker ps -a` command from PowerShell, you can see that the container is still running. 

```
CONTAINER ID        IMAGE                       COMMAND                  CREATED             STATUS
PORTS               NAMES
472e21524998        spboyer/magic8ball          "cmd /S /C Magic8Ball"   39 seconds ago      Exited (0) 4 seconds ago
                    evil_euler
```

If you add `--rm` as an OPTION to the `docker run` command, the container will be removed as soon as the "Exit" signal is received by the container. 

`docker run --rm <dockerhub-id>/magic8ball "Are you a square container?"`

The **STATUS** column shows at 4 seconds ago, the container was complete and could be shut down.  This is a behavior given the scenario above we would want to perform.


