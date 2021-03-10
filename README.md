# RockPaperScissors via TCP 
> This project is simple client-server, rock paper scissors game.

## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Setup](#setup)
* [Features](#features)
* [Status](#status)
* [Inspiration](#inspiration)

## General info
This project is a simple rock paper scissors which utilizes TCP protocol for communication. The project was divided into two seperate Visual Studio projects, one for client and one for server. The GUI was created with WPF, and the structure of the project follows MVVM model. Client and server sockets implementation were taken from official Microsoft example. Project was created as a task for BIT college circle. 

## Screenshots
Linkt to youtube presenting the project: https://youtu.be/VJTXGm1g460

It can be clearly seen that he behaviour of RNG on the AI side is really bad. However I haven't found yet what else could be done to improve it.

## Technologies
* Visual Studio 2019
* WPF

## Setup
You can just run the executables from Debug folder or if you want to change it you can open those two seperate projects in you visual studio.

## Features
To-do list:
* Repair the bug conerning RNG
* Apply some handling of client "freezing" when server is not running

## Status
Project is: _finished_, so far but I will reapair those bugs!

## Inspiration
BIT college circle
