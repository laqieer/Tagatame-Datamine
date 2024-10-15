// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestRewardDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000712")]
  public sealed class JSON_PointQuestRewardDataFormatter : 
    IMessagePackFormatter<JSON_PointQuestRewardData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012BC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012BD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E84")]
    [Address(RVA = "0xC59160", Offset = "0xC57F60", VA = "0x10C59160")]
    public JSON_PointQuestRewardDataFormatter()
    {
    }

    [Token(Token = "0x6001E85")]
    [Address(RVA = "0xC59000", Offset = "0xC57E00", VA = "0x10C59000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestRewardData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E86")]
    [Address(RVA = "0xC58CA0", Offset = "0xC57AA0", VA = "0x10C58CA0", Slot = "5")]
    public JSON_PointQuestRewardData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestRewardData) null;
    }
  }
}
