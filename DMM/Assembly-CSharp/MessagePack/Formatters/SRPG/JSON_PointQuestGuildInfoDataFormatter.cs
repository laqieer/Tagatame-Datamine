// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestGuildInfoDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000713")]
  public sealed class JSON_PointQuestGuildInfoDataFormatter : 
    IMessagePackFormatter<JSON_PointQuestGuildInfoData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012BE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012BF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E87")]
    [Address(RVA = "0xC55A70", Offset = "0xC54870", VA = "0x10C55A70")]
    public JSON_PointQuestGuildInfoDataFormatter()
    {
    }

    [Token(Token = "0x6001E88")]
    [Address(RVA = "0xC55840", Offset = "0xC54640", VA = "0x10C55840", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestGuildInfoData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E89")]
    [Address(RVA = "0xC55430", Offset = "0xC54230", VA = "0x10C55430", Slot = "5")]
    public JSON_PointQuestGuildInfoData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestGuildInfoData) null;
    }
  }
}
