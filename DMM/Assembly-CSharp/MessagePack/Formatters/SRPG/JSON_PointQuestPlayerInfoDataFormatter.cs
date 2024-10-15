// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestPlayerInfoDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000711")]
  public sealed class JSON_PointQuestPlayerInfoDataFormatter : 
    IMessagePackFormatter<JSON_PointQuestPlayerInfoData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012BA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012BB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E81")]
    [Address(RVA = "0xC57CB0", Offset = "0xC56AB0", VA = "0x10C57CB0")]
    public JSON_PointQuestPlayerInfoDataFormatter()
    {
    }

    [Token(Token = "0x6001E82")]
    [Address(RVA = "0xC579B0", Offset = "0xC567B0", VA = "0x10C579B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestPlayerInfoData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E83")]
    [Address(RVA = "0xC57570", Offset = "0xC56370", VA = "0x10C57570", Slot = "5")]
    public JSON_PointQuestPlayerInfoData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestPlayerInfoData) null;
    }
  }
}
