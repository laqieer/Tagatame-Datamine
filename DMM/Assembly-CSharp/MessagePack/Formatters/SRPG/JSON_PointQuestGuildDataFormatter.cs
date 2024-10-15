// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestGuildDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000710")]
  public sealed class JSON_PointQuestGuildDataFormatter : 
    IMessagePackFormatter<JSON_PointQuestGuildData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012B8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012B9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E7E")]
    [Address(RVA = "0xC55240", Offset = "0xC54040", VA = "0x10C55240")]
    public JSON_PointQuestGuildDataFormatter()
    {
    }

    [Token(Token = "0x6001E7F")]
    [Address(RVA = "0xC550E0", Offset = "0xC53EE0", VA = "0x10C550E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestGuildData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E80")]
    [Address(RVA = "0xC54D90", Offset = "0xC53B90", VA = "0x10C54D90", Slot = "5")]
    public JSON_PointQuestGuildData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestGuildData) null;
    }
  }
}
