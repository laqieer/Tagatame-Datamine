// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TrophyStarMissionParam_StarSetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000663")]
  public sealed class JSON_TrophyStarMissionParam_StarSetParamFormatter : 
    IMessagePackFormatter<JSON_TrophyStarMissionParam.StarSetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400115E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400115F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C77")]
    [Address(RVA = "0xBEFD20", Offset = "0xBEEB20", VA = "0x10BEFD20")]
    public JSON_TrophyStarMissionParam_StarSetParamFormatter()
    {
    }

    [Token(Token = "0x6001C78")]
    [Address(RVA = "0xBEFBC0", Offset = "0xBEE9C0", VA = "0x10BEFBC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TrophyStarMissionParam.StarSetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C79")]
    [Address(RVA = "0xBEF870", Offset = "0xBEE670", VA = "0x10BEF870", Slot = "5")]
    public JSON_TrophyStarMissionParam.StarSetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TrophyStarMissionParam.StarSetParam) null;
    }
  }
}
