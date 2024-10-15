// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.DynamicGenericResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x2000390")]
  public sealed class DynamicGenericResolver : IFormatterResolver
  {
    [Token(Token = "0x4000DEF")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;

    [Token(Token = "0x600132B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private DynamicGenericResolver()
    {
    }

    [Token(Token = "0x600132C")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x600132D")]
    [Address(RVA = "0x4B8700", Offset = "0x4B7500", VA = "0x104B8700")]
    static DynamicGenericResolver()
    {
    }

    [Token(Token = "0x2000391")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DF0")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x600132E")]
      static FormatterCache()
      {
      }
    }
  }
}
