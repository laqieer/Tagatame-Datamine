// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.BigIntegerFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Numerics;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200050D")]
  public sealed class BigIntegerFormatter : IMessagePackFormatter<BigInteger>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F9C")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<BigInteger> Instance;

    [Token(Token = "0x6001864")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private BigIntegerFormatter()
    {
    }

    [Token(Token = "0x6001865")]
    [Address(RVA = "0x6939E0", Offset = "0x6927E0", VA = "0x106939E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BigInteger value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001866")]
    [Address(RVA = "0x693970", Offset = "0x692770", VA = "0x10693970", Slot = "5")]
    public BigInteger Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new BigInteger();
    }

    [Token(Token = "0x6001867")]
    [Address(RVA = "0x693AC0", Offset = "0x6928C0", VA = "0x10693AC0")]
    static BigIntegerFormatter()
    {
    }
  }
}
