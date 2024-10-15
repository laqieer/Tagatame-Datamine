// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TrophyStarMissionRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000662")]
  public sealed class JSON_TrophyStarMissionRewardParamFormatter : 
    IMessagePackFormatter<JSON_TrophyStarMissionRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400115C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400115D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C74")]
    [Address(RVA = "0xBF0430", Offset = "0xBEF230", VA = "0x10BF0430")]
    public JSON_TrophyStarMissionRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001C75")]
    [Address(RVA = "0xBF0250", Offset = "0xBEF050", VA = "0x10BF0250", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TrophyStarMissionRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C76")]
    [Address(RVA = "0xBEFF10", Offset = "0xBEED10", VA = "0x10BEFF10", Slot = "5")]
    public JSON_TrophyStarMissionRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TrophyStarMissionRewardParam) null;
    }
  }
}
