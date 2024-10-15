// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondPieceMatsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000967")]
  public sealed class BondPieceMatsParamFormatter : 
    IMessagePackFormatter<BondPieceMatsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400175E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400175F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002583")]
    [Address(RVA = "0xE24380", Offset = "0xE23180", VA = "0x10E24380")]
    public BondPieceMatsParamFormatter()
    {
    }

    [Token(Token = "0x6002584")]
    [Address(RVA = "0xE241F0", Offset = "0xE22FF0", VA = "0x10E241F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondPieceMatsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002585")]
    [Address(RVA = "0xE23F00", Offset = "0xE22D00", VA = "0x10E23F00", Slot = "5")]
    public BondPieceMatsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondPieceMatsParam) null;
    }
  }
}
