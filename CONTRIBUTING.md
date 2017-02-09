## Information

Most of the code in this repository is generated from RDF vocabularies using Roslyn script executed with 
[Scripty](https://github.com/daveaglick/Scripty).

The template generates partial classes and they are not to be committed to the repository.

## Adding vocabulary

To add a new vocabulary to the solution follow these steps:

1. Add an RDF file to the project

  The file name will be used as prefix. Any format supported by [dotNetRDF](https://github.com/dotnetrdf/dotnetrdf/wiki/UserGuide-Reading-RDF) can be used.
  (JSON-LD may be coming later).
  
  It is important that the `owl:Ontology` and the base namespaces are the same. So, in the case of hash URIs, you can't have
  ontology id `http://example.org/vocab` but the base `http://example.org/vocab#`. Both must include the trailing hash.
  
1. Add a command like below to `Vocabs.csx`

      CreateVocabulary(Output, "ex.rdf", ontologyId: "http://example.org/vocab#", skipDefinedByCheck: true);
     
    Depending on the vocabulary file, you may not need the `ontologyId` and `skipDefinedByCheck` parameters. The former
    is required if the input doesn't contain a graph named like the the vocabulary. The latter is necessary if the
    input triples don't include `rdfs:isDefinedBy` statements.
    
## Extending the generated class

If a manual addition is necessary, please add/modify a partial class in the `NonGenerated` folder.
