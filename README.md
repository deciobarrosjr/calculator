# Project Name
> The purpose of this Hello World is the development of a backend calculator with the following basic functions:
>
>	addition
>	subtraction
>	division 
>	multiplication
>	memory In/Out
>	power
>
> NOTE: This little Hello World is not intended to be an example of the best programming practices in each language. The main objective is to create a very simple 
>       application in order to exercise some features and functionality on the cloud.


## Table of Contents
* [General Info](#general-information)
* [Addition](#technologies-used)
* [Subtraction](#features)
* [Division](#screenshots)
* [Multiplication](#setup)
* [Memory In/Out](#usage)
* [Power](#project-status)



## General Information
- This small backend application was developed to be used on the following example activities:
-   CI/CD pipeliine implementation using GitHub and Terraform.
-   CI/CD pipeline using Spinnaker.
- These are the technical requirement of each function:
-   Each function exposed as a Web API route.
-   Each function should have two routes. the function itself and the healthy check.
-   Will be deployed on google kubernetes.
-   Will use a nginx as a reverse proxy to each microservice.   


## Addition
- Developed using C#
- The following routes will be exposed when running the application on the development environment:
-   http://localhost:5174/sum?x=3&y=5
-   http://localhost:5174/Healthcheck


## Subtraction
- Developed using Python.
- The following routes will be exposed when running the application on the development environment:
-   http://localhost:5175/sum?x=3&y=5
-   http://localhost:5175/Healthcheck


## Division
- T.B.D.


## Multiplication
- T.B.D.


## Memory In/Out
- T.B.D.


## Power
- T.B.D.



## Contact
Created by [deciobarrosjr@hotmail.com] - feel free to contact me!

