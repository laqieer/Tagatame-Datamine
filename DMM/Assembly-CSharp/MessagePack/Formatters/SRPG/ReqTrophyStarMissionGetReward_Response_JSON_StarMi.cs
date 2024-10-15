// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqTrophyStarMissionGetReward_Response_JSON_StarMissionConceptCardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A49")]
  public sealed class ReqTrophyStarMissionGetReward_Response_JSON_StarMissionConceptCardFormatter : 
    IMessagePackFormatter<ReqTrophyStarMissionGetReward.Response.JSON_StarMissionConceptCard>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001922")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001923")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002829")]
    [Address(RVA = "0xEBDE40", Offset = "0xEBCC40", VA = "0x10EBDE40")]
    public ReqTrophyStarMissionGetReward_Response_JSON_StarMissionConceptCardFormatter()
    {
    }

    [Token(Token = "0x600282A")]
    [Address(RVA = "0xEBDC80", Offset = "0xEBCA80", VA = "0x10EBDC80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqTrophyStarMissionGetReward.Response.JSON_StarMissionConceptCard value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600282B")]
    [Address(RVA = "0xEBD8F0", Offset = "0xEBC6F0", VA = "0x10EBD8F0", Slot = "5")]
    public ReqTrophyStarMissionGetReward.Response.JSON_StarMissionConceptCard Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqTrophyStarMissionGetReward.Response.JSON_StarMissionConceptCard) null;
    }
  }
}
