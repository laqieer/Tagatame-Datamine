// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TrophyStarMissionRewardParam_DataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000661")]
  public sealed class JSON_TrophyStarMissionRewardParam_DataFormatter : 
    IMessagePackFormatter<JSON_TrophyStarMissionRewardParam.Data>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400115A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400115B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C71")]
    [Address(RVA = "0xBF0A60", Offset = "0xBEF860", VA = "0x10BF0A60")]
    public JSON_TrophyStarMissionRewardParam_DataFormatter()
    {
    }

    [Token(Token = "0x6001C72")]
    [Address(RVA = "0xBF0900", Offset = "0xBEF700", VA = "0x10BF0900", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TrophyStarMissionRewardParam.Data value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C73")]
    [Address(RVA = "0xBF05B0", Offset = "0xBEF3B0", VA = "0x10BF05B0", Slot = "5")]
    public JSON_TrophyStarMissionRewardParam.Data Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TrophyStarMissionRewardParam.Data) null;
    }
  }
}
