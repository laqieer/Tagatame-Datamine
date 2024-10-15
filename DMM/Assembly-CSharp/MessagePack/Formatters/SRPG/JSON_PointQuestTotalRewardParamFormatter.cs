// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestTotalRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A21")]
  public sealed class JSON_PointQuestTotalRewardParamFormatter : 
    IMessagePackFormatter<JSON_PointQuestTotalRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018D2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018D3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027B1")]
    [Address(RVA = "0xEA2D00", Offset = "0xEA1B00", VA = "0x10EA2D00")]
    public JSON_PointQuestTotalRewardParamFormatter()
    {
    }

    [Token(Token = "0x60027B2")]
    [Address(RVA = "0xEA2B20", Offset = "0xEA1920", VA = "0x10EA2B20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestTotalRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027B3")]
    [Address(RVA = "0xEA27E0", Offset = "0xEA15E0", VA = "0x10EA27E0", Slot = "5")]
    public JSON_PointQuestTotalRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestTotalRewardParam) null;
    }
  }
}
