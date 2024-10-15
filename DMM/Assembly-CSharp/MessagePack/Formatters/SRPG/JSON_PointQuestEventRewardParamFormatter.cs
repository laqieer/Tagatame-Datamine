// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestEventRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A26")]
  public sealed class JSON_PointQuestEventRewardParamFormatter : 
    IMessagePackFormatter<JSON_PointQuestEventRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018DC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018DD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027C0")]
    [Address(RVA = "0xEA20A0", Offset = "0xEA0EA0", VA = "0x10EA20A0")]
    public JSON_PointQuestEventRewardParamFormatter()
    {
    }

    [Token(Token = "0x60027C1")]
    [Address(RVA = "0xEA1EC0", Offset = "0xEA0CC0", VA = "0x10EA1EC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestEventRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027C2")]
    [Address(RVA = "0xEA1B80", Offset = "0xEA0980", VA = "0x10EA1B80", Slot = "5")]
    public JSON_PointQuestEventRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestEventRewardParam) null;
    }
  }
}
