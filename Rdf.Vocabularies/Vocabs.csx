#load "MakeVocab.csx"

CreateVocabulary(Output, "SKOS.rdf");
CreateVocabulary(Output, "SIOC.owl", ontologyId: "http://rdfs.org/sioc/ns#");
CreateVocabulary(Output, "Schema.owl", ontologyId: "http://schema.org/", skipDefinedByCheck: true);
CreateVocabulary(Output, "RDFS.owl", ontologyId: "http://www.w3.org/2000/01/rdf-schema#");
CreateVocabulary(Output, "RDF.owl", ontologyId: "http://www.w3.org/1999/02/22-rdf-syntax-ns#");
CreateVocabulary(Output, "owl.owl", ontologyId: "http://www.w3.org/2002/07/owl#");
CreateVocabulary(Output, "Opus.owl", ontologyId: "http://lsdis.cs.uga.edu/projects/semdis/opus#", skipDefinedByCheck: true);
CreateVocabulary(Output, "Hydra.rdf", ontologyId: "http://www.w3.org/ns/hydra/core#", skipDefinedByCheck: true);
CreateVocabulary(Output, "FOAF.owl", ontologyId: "http://xmlns.com/foaf/0.1/");
CreateVocabulary(Output, "DCTerms.owl", skipDefinedByCheck: true);
CreateVocabulary(Output, "DC.owl", skipDefinedByCheck: true);
CreateVocabulary(Output, "BIBO.owl", ontologyId: "http://purl.org/ontology/bibo/", skipDefinedByCheck: true);