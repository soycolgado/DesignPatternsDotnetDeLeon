using System;

namespace biblioteca.Generator;

public class GeneratorConcreteBuilder : IBuilderGenerator
{
    private Generator _generator;

    public GeneratorConcreteBuilder()
    {
        Reset();
    }

    public void SetContent(List<string> content) => this._generator.Content = content;

    public void SetPath(string path) => this._generator.Path = path;

    public void SetFormat(TypeFormat format) => this._generator.Format = format;

    public void SetCharacter(TypeCharacter character) => this._generator.Character = character;

    public void Reset() => _generator = new Generator();

    public Generator GetGenerator() => _generator;

}
