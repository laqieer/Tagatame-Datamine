// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RankingQuestScheduleParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A6B")]
  public sealed class JSON_RankingQuestScheduleParamFormatter : 
    IMessagePackFormatter<JSON_RankingQuestScheduleParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001966")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001967")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600288F")]
    [Address(RVA = "0xECC000", Offset = "0xECAE00", VA = "0x10ECC000")]
    public JSON_RankingQuestScheduleParamFormatter()
    {
    }

    [Token(Token = "0x6002890")]
    [Address(RVA = "0xECBD00", Offset = "0xECAB00", VA = "0x10ECBD00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RankingQuestScheduleParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002891")]
    [Address(RVA = "0xECB850", Offset = "0xECA650", VA = "0x10ECB850", Slot = "5")]
    public JSON_RankingQuestScheduleParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RankingQuestScheduleParam) null;
    }
  }
}
