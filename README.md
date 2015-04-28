## Deviser 
This repository contains a project for editing SBML L3 Package specifications in a basic XML format. It is meant to be used with the [python auto-generator](https://github.com/skeating/auto-generator/) and will be used by the generator for the [libSEDML](https://github.com/fbergmann/libSEDML/) library. 

## User Interface
The current version is still in flux, however the basic components are there: each package can contain a number of version. Each version can add new new classes to libSBML, whenever existing elements should be extended, then Plug-ins are used. Lastly, it is possible to specify new enumerations for the language. 

 ![Screenshot of the Deviser UI](https://raw.githubusercontent.com/fbergmann/CsDeviser/master/doc/user-interface.png)

Added in the latest version is a visualization based on the [yUML](http://yuml.me/) restless services. It visualizes the complete package: 

 ![Screenshot of the Deviser UML view](https://raw.githubusercontent.com/fbergmann/CsDeviser/master/doc/uml-display.png)