## Information

Most of the code in this repository is generated from OWL vocabularies using a 
[T4 template](http://www.hanselman.com/blog/T4TextTemplateTransformationToolkitCodeGenerationBestKeptVisualStudioSecret.aspx).

The template generates partial classes and they are not committed to the repository.

## Adding vocabulary

To add a new vocabulary to the solution follow these steps:

1. Add a `.owl` or `.rdf` file to the project

  The file must include the base namespace as prefix with matching the file name. For example `dc.owl` contains
  
  ``` xml
  <rdf:RDF xml:base="http://purl.org/dc/elements/1.1/" 
           xmlns:dc="http://purl.org/dc/elements/1.1/"></rdf:RDF>
  ```
  
1. Add a `.tt` file, with name matching the vocabulary. For example `foaf.rdf` => `foaf.tt`.

  It's contents are the same for each other template file, so just go ahead and copy one of them.
 
1. To keep the project tree clean, modify the `csproj` by adding the `DependentUpon` property

  ``` xml
  <Content Include="RDF.tt">
    <Generator>TextTemplatingFileGenerator</Generator>
    <LastGenOutput>RDF.cs</LastGenOutput>
    <DependentUpon>RDF.owl</DependentUpon>
  </Content>
  ```
  
  This way the template file will appear under the ontology file in the solution explorer.

## Extending the generated class

If a manual addition is necessary, please add/modify a partial class in the `NonGenerated` folder.
