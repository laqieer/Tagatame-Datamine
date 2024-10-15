// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidDamageRatioRewardRatioParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000626")]
  public sealed class JSON_RaidDamageRatioRewardRatioParamFormatter : 
    IMessagePackFormatter<JSON_RaidDamageRatioRewardRatioParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010E4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010E5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BC0")]
    [Address(RVA = "0xBC3C10", Offset = "0xBC2A10", VA = "0x10BC3C10")]
    public JSON_RaidDamageRatioRewardRatioParamFormatter()
    {
    }

    [Token(Token = "0x6001BC1")]
    [Address(RVA = "0xBC3AE0", Offset = "0xBC28E0", VA = "0x10BC3AE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidDamageRatioRewardRatioParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BC2")]
    [Address(RVA = "0xBC37D0", Offset = "0xBC25D0", VA = "0x10BC37D0", Slot = "5")]
    public JSON_RaidDamageRatioRewardRatioParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidDamageRatioRewardRatioParam) null;
    }
  }
}
