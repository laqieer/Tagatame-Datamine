// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.DynamicEnumAsStringResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x200038E")]
  public sealed class DynamicEnumAsStringResolver : IFormatterResolver
  {
    [Token(Token = "0x4000DED")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;

    [Token(Token = "0x6001327")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private DynamicEnumAsStringResolver()
    {
    }

    [Token(Token = "0x6001328")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001329")]
    [Address(RVA = "0x4B86A0", Offset = "0x4B74A0", VA = "0x104B86A0")]
    static DynamicEnumAsStringResolver()
    {
    }

    [Token(Token = "0x200038F")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DEE")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x600132A")]
      static FormatterCache()
      {
      }
    }
  }
}
