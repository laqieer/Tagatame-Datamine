// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.TypelessObjectResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x20003A0")]
  public sealed class TypelessObjectResolver : IFormatterResolver
  {
    [Token(Token = "0x4000E03")]
    [FieldOffset(Offset = "0x0")]
    public static IFormatterResolver Instance;

    [Token(Token = "0x600134B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private TypelessObjectResolver()
    {
    }

    [Token(Token = "0x600134C")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x600134D")]
    [Address(RVA = "0x4DE080", Offset = "0x4DCE80", VA = "0x104DE080")]
    static TypelessObjectResolver()
    {
    }

    [Token(Token = "0x20003A1")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000E04")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x600134E")]
      static FormatterCache()
      {
      }
    }
  }
}
