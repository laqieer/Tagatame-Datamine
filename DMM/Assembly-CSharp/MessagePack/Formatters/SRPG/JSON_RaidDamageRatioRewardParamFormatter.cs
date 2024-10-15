// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidDamageRatioRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000627")]
  public sealed class JSON_RaidDamageRatioRewardParamFormatter : 
    IMessagePackFormatter<JSON_RaidDamageRatioRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010E6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010E7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BC3")]
    [Address(RVA = "0xBC3650", Offset = "0xBC2450", VA = "0x10BC3650")]
    public JSON_RaidDamageRatioRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001BC4")]
    [Address(RVA = "0xBC34B0", Offset = "0xBC22B0", VA = "0x10BC34B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidDamageRatioRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BC5")]
    [Address(RVA = "0xBC31A0", Offset = "0xBC1FA0", VA = "0x10BC31A0", Slot = "5")]
    public JSON_RaidDamageRatioRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidDamageRatioRewardParam) null;
    }
  }
}
