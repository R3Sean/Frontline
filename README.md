# Frontline
Frontline Coding Challenge

This repository contains a solution to the Frontline Coding Challenge as a C# .NET Console Application.

The project contains classes for ProblemOne and ProblemTwo as they are described in the challenge directions.  These classes derive from a ProblemBase class which is extended for common properties in both string manipulation solutions.

A static StringHelper class is utilized to encapsulate most of the string manipulation functions required in developing this solution.

The output is writen to the console window to prove the solution concepts have been fulfilled in this exercise.  The code could ultimately be used in a library project referenced by a web, web service or windows forms solution as well.

The following text will be output in the console window upon running the solution:
This is the results of the Firstline Problem 1 solution:
---------------------------------------------------------
Parse the string:
(id,created,employee(id,firstname,employeeType(id), lastname),location)
---------------------------------------------------------
Version One:
---------------------------------------------------------
id
created
employee
-id
-firstname
-employeeType
--id
-lastname
location
---------------------------------------------------------
Bonus: Output in alphabetical order:
---------------------------------------------------------

created
employee
-employeeType
--id
-firstname
-id
-lastname
id
location


---------------------------------------------------------


---------------------------------------------------------
This is the output of Firstline Problem 2 solution:
---------------------------------------------------------
Challenge: Reverse each word of a string but maintain the positioning of capitalization, punctuation, and special characters.
Input String: My name is Albert McDonald.
---------------------------------------------------------
Ym eman si Trebla DlAnodcm.
---------------------------------------------------------

Other Examples of solution:
Input String: My name is Albert$ Mc'Donald.
---------------------------------------------------------
Ym eman si Trebla$ Dl'Anodcm.

---------------------------------------------------------
Input String: !My %$a... is () AlBert .Mc'DonalD.
---------------------------------------------------------
!Ym %$a... si () TrEbla .Dl'AnodcM.

---------------------------------------------------------
Input String: !My Na..m.E is (9) $AlBer6t .Mc'DonalD?
---------------------------------------------------------
!Ym Em..a.N si (9) $T6Rebla .Dl'AnodcM?

-----------------------END-------------------------------
---Please scroll up to view output from both solutions---


