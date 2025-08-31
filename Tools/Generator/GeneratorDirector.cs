using System;

namespace biblioteca.Generator;

public class GeneratorDirector
{
    private IBuilderGenerator _builderGenerator;

    public GeneratorDirector(IBuilderGenerator builderGenerator)
    {
        this.SetBuiler(builderGenerator);
    }

    public void SetBuiler(IBuilderGenerator builderGenerator) => _builderGenerator = builderGenerator;

    public void CreateSimpleJsonGenerator(List<string> content, string path)
    {
        _builderGenerator.Reset();
        _builderGenerator.SetContent(content);
        _builderGenerator.SetPath(path);
        _builderGenerator.SetFormat(TypeFormat.Json);

    }

    public void CreateSimplePipeGenerator(List<string> content, string path)
    {
        _builderGenerator.Reset();
        _builderGenerator.SetContent(content);
        _builderGenerator.SetPath(path);
        _builderGenerator.SetFormat(TypeFormat.Pipes);
        _builderGenerator.SetCharacter(TypeCharacter.Uppercase);
    }

}
