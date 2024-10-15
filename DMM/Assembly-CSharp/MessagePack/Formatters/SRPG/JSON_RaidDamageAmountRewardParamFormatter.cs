// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidDamageAmountRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000629")]
  public sealed class JSON_RaidDamageAmountRewardParamFormatter : 
    IMessagePackFormatter<JSON_RaidDamageAmountRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010EA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010EB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BC9")]
    [Address(RVA = "0xBC3020", Offset = "0xBC1E20", VA = "0x10BC3020")]
    public JSON_RaidDamageAmountRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001BCA")]
    [Address(RVA = "0xBC2E80", Offset = "0xBC1C80", VA = "0x10BC2E80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidDamageAmountRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BCB")]
    [Address(RVA = "0xBC2B70", Offset = "0xBC1970", VA = "0x10BC2B70", Slot = "5")]
    public JSON_RaidDamageAmountRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidDamageAmountRewardParam) null;
    }
  }
}
