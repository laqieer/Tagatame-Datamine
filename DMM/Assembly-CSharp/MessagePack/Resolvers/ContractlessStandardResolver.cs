// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.ContractlessStandardResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x200039A")]
  public sealed class ContractlessStandardResolver : IFormatterResolver
  {
    [Token(Token = "0x4000DFA")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;
    [Token(Token = "0x4000DFB")]
    [FieldOffset(Offset = "0x4")]
    public static readonly IMessagePackFormatter<object> ObjectFallbackFormatter;

    [Token(Token = "0x600133F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ContractlessStandardResolver()
    {
    }

    [Token(Token = "0x6001340")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001341")]
    [Address(RVA = "0x4B8570", Offset = "0x4B7370", VA = "0x104B8570")]
    static ContractlessStandardResolver()
    {
    }

    [Token(Token = "0x200039B")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DFC")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001342")]
      static FormatterCache()
      {
      }
    }
  }
}
