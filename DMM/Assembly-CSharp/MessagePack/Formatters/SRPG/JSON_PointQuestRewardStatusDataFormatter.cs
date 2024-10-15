// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestRewardStatusDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200070C")]
  public sealed class JSON_PointQuestRewardStatusDataFormatter : 
    IMessagePackFormatter<JSON_PointQuestRewardStatusData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012B0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012B1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E72")]
    [Address(RVA = "0xC59790", Offset = "0xC58590", VA = "0x10C59790")]
    public JSON_PointQuestRewardStatusDataFormatter()
    {
    }

    [Token(Token = "0x6001E73")]
    [Address(RVA = "0xC59660", Offset = "0xC58460", VA = "0x10C59660", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestRewardStatusData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E74")]
    [Address(RVA = "0xC59350", Offset = "0xC58150", VA = "0x10C59350", Slot = "5")]
    public JSON_PointQuestRewardStatusData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestRewardStatusData) null;
    }
  }
}
