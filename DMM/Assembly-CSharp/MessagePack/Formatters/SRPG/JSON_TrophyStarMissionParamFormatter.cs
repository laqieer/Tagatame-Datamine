// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TrophyStarMissionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000664")]
  public sealed class JSON_TrophyStarMissionParamFormatter : 
    IMessagePackFormatter<JSON_TrophyStarMissionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001160")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001161")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C7A")]
    [Address(RVA = "0xBEF5A0", Offset = "0xBEE3A0", VA = "0x10BEF5A0")]
    public JSON_TrophyStarMissionParamFormatter()
    {
    }

    [Token(Token = "0x6001C7B")]
    [Address(RVA = "0xBEF2D0", Offset = "0xBEE0D0", VA = "0x10BEF2D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TrophyStarMissionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C7C")]
    [Address(RVA = "0xBEEEB0", Offset = "0xBEDCB0", VA = "0x10BEEEB0", Slot = "5")]
    public JSON_TrophyStarMissionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TrophyStarMissionParam) null;
    }
  }
}
