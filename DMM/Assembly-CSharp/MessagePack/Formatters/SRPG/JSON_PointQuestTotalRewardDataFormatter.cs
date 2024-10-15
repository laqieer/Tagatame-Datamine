// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestTotalRewardDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A20")]
  public sealed class JSON_PointQuestTotalRewardDataFormatter : 
    IMessagePackFormatter<JSON_PointQuestTotalRewardData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018D0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018D1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027AE")]
    [Address(RVA = "0xEA2660", Offset = "0xEA1460", VA = "0x10EA2660")]
    public JSON_PointQuestTotalRewardDataFormatter()
    {
    }

    [Token(Token = "0x60027AF")]
    [Address(RVA = "0xEA2530", Offset = "0xEA1330", VA = "0x10EA2530", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestTotalRewardData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027B0")]
    [Address(RVA = "0xEA2220", Offset = "0xEA1020", VA = "0x10EA2220", Slot = "5")]
    public JSON_PointQuestTotalRewardData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestTotalRewardData) null;
    }
  }
}
