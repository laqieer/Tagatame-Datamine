// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.BitArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200050C")]
  public sealed class BitArrayFormatter : IMessagePackFormatter<BitArray>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F9B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<BitArray> Instance;

    [Token(Token = "0x6001860")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private BitArrayFormatter()
    {
    }

    [Token(Token = "0x6001861")]
    [Address(RVA = "0x694390", Offset = "0x693190", VA = "0x10694390", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BitArray value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001862")]
    [Address(RVA = "0x6941E0", Offset = "0x692FE0", VA = "0x106941E0", Slot = "5")]
    public BitArray Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BitArray) null;
    }

    [Token(Token = "0x6001863")]
    [Address(RVA = "0x694500", Offset = "0x693300", VA = "0x10694500")]
    static BitArrayFormatter()
    {
    }
  }
}
