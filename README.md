# Spdx3

A NuGet library (.NET 8) for creating, reading, and
writing [Software Bills of Materials](https://www.ntia.gov/page/software-bill-materials) files
in [SPDX 3](https://spdx.github.io/spdx-spec/v3.0.1/) format.

[![.NET 8](https://img.shields.io/badge/.NET-8.0.x-blue)]()
[![C#](https://custom-icon-badges.demolab.com/badge/C%23-%23239120.svg?logo=cshrp&logoColor=white)]()
[![NuGet](https://img.shields.io/badge/NuGet-004880?logo=nuget&logoColor=fff)]()
[![Linux](https://img.shields.io/badge/Linux-FCC624?logo=linux&logoColor=black)]()
[![macOS](https://img.shields.io/badge/macOS-000000?logo=apple&logoColor=F0F0F0)]()
[![Windows](https://custom-icon-badges.demolab.com/badge/Windows-0078D6?logo=windows11&logoColor=white)]()
[![GitHub Actions](https://img.shields.io/badge/GitHub_Actions-2088FF?logo=github-actions&logoColor=white)]()

[![license](https://img.shields.io/github/license/mharrah/Spdx3?style=flat-square)](https://github.com/mharrah/Spdx3/tree/main?tab=MIT-1-ov-file#)
[![build](https://img.shields.io/github/actions/workflow/status/mharrah/Spdx3/ci.yml?branch=main&style=flat-square)](https://github.com/mharrah/Spdx3/actions/workflows/ci.yml)
[![tests](https://img.shields.io/endpoint?style=flat-square&url=https://gist.githubusercontent.com/mharrah/e434f7b17274a026c153482b64e5cf91/raw/Spdx3-junit-tests.json)](https://github.com/mharrah/Spdx3/actions/workflows/ci.yml)
[![coverage](https://img.shields.io/endpoint?style=flat-square&url=https://gist.githubusercontent.com/mharrah/e434f7b17274a026c153482b64e5cf91/raw/Spdx3-cobertura-coverage.json)](https://mharrah.github.io/Spdx3/)
[![GitHub Issues or Pull Requests](https://img.shields.io/github/issues/mharrah/Spdx3)](https://github.com/mharrah/Spdx3/issues)

---

# Installation
Install like you would any other NuGet package.

# Catalogs and SpdxDocuments
The Spdx3 package uses a "Catalog" which contains all the various elements and 
objects in the document.  Every object you create is added to the Catalog (in fact,
the Catalog you're adding to is a parameter to the constructor for each object). Thus,
the Catalog is an object that relates very closely to the SpdxDocument, but is part
of the Spdx3 library implementation and not part of the Spdx 3 model.

SBOM's are one particular type of object in the Catalog - and is one of the most central
in the Catalog - but it's by no means the main one, and not even where you start.

The following is a *simplified* class diagram of some of the objects you're likely to 
work with -- ALL of which will be kept in the Catalog:
```mermaid
---
  config:
    class:
      hideEmptyMembersBox: true
---
classDiagram
direction RL

namespace Core {
    class ElementCollection {
        <<Abstract>>
    }
    class Element {
        <<Abstract>>
    }
    class Artifact {
        <<Abstract>>
    }
    class Bom { }
    class Bundle { }
    class SpdxDocument { }
    class Tool { }
    class IndividualElement { }
    class Agent { }
    class Person { }
    class Organization { }
    class LifeScopedRelationship { }
    class Relationship { }
    class SoftwareAgent { }
    class Sbom { }
}

Bom --|> Bundle : "is"
Bundle --|> ElementCollection : "is"
ElementCollection --o Element : "contains"
ElementCollection --o Element : "has root"
ElementCollection --|> Element : "is"
SpdxDocument --|> ElementCollection : "is"
Artifact --|> Element : "is"        
Tool --|> Element : "is"        
IndividualElement --|> Element : "is"        
Agent --|> Element : "is"        
Person --|> Agent : "is"    
Organization --|> Agent : "is"    
LifeScopedRelationship --|> Relationship : "is"
Relationship --|> Element : "is"
Relationship --o Element : "to"
Relationship -- Element : "from"
SoftwareAgent --|> Agent : "is"  
Sbom --|> Bom : "is"


namespace Software {
    class SoftwareArtifact {
        <<Abstract>>
    }
    class Package { }
    class Snippet { }
    class File { }
}

SoftwareArtifact --|> Artifact : "is"
Package --|> SoftwareArtifact : "is"
File --|> SoftwareArtifact : "is"
Snippet --|> SoftwareArtifact : "is"

namespace Build {
    class BuildClass["Build"]  {  } 
}

BuildClass --|> Element : "is"

```


