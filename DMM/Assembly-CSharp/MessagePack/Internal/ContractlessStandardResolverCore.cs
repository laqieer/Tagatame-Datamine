// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.ContractlessStandardResolverCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000481")]
  internal sealed class ContractlessStandardResolverCore : IFormatterResolver
  {
    [Token(Token = "0x4000F35")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;
    [Token(Token = "0x4000F36")]
    [FieldOffset(Offset = "0x4")]
    private static readonly IFormatterResolver[] resolvers;

    [Token(Token = "0x6001652")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ContractlessStandardResolverCore()
    {
    }

    [Token(Token = "0x6001653")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001654")]
    [Address(RVA = "0x697480", Offset = "0x696280", VA = "0x10697480")]
    static ContractlessStandardResolverCore()
    {
    }

    [Token(Token = "0x2000482")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000F37")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001655")]
      static FormatterCache()
      {
      }
    }
  }
}
