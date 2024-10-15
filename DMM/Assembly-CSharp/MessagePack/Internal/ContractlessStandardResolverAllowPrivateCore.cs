// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.ContractlessStandardResolverAllowPrivateCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000485")]
  internal sealed class ContractlessStandardResolverAllowPrivateCore : IFormatterResolver
  {
    [Token(Token = "0x4000F3B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IFormatterResolver Instance;
    [Token(Token = "0x4000F3C")]
    [FieldOffset(Offset = "0x4")]
    private static readonly IFormatterResolver[] resolvers;

    [Token(Token = "0x600165A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ContractlessStandardResolverAllowPrivateCore()
    {
    }

    [Token(Token = "0x600165B")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x600165C")]
    [Address(RVA = "0x697390", Offset = "0x696190", VA = "0x10697390")]
    static ContractlessStandardResolverAllowPrivateCore()
    {
    }

    [Token(Token = "0x2000486")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000F3D")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x600165D")]
      static FormatterCache()
      {
      }
    }
  }
}
