// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CrystalSaleRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A9D")]
  public sealed class CrystalSaleRewardParamFormatter : 
    IMessagePackFormatter<CrystalSaleRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019CA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019CB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002925")]
    [Address(RVA = "0xEEAC70", Offset = "0xEE9A70", VA = "0x10EEAC70")]
    public CrystalSaleRewardParamFormatter()
    {
    }

    [Token(Token = "0x6002926")]
    [Address(RVA = "0xEEAAD0", Offset = "0xEE98D0", VA = "0x10EEAAD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CrystalSaleRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002927")]
    [Address(RVA = "0xEEA790", Offset = "0xEE9590", VA = "0x10EEA790", Slot = "5")]
    public CrystalSaleRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (CrystalSaleRewardParam) null;
    }
  }
}
