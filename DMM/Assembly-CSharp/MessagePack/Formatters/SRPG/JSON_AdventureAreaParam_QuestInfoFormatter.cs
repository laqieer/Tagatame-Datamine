// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureAreaParam_QuestInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A88")]
  public sealed class JSON_AdventureAreaParam_QuestInfoFormatter : 
    IMessagePackFormatter<JSON_AdventureAreaParam.QuestInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019A0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019A1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028E6")]
    [Address(RVA = "0xED69E0", Offset = "0xED57E0", VA = "0x10ED69E0")]
    public JSON_AdventureAreaParam_QuestInfoFormatter()
    {
    }

    [Token(Token = "0x60028E7")]
    [Address(RVA = "0xED66C0", Offset = "0xED54C0", VA = "0x10ED66C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureAreaParam.QuestInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028E8")]
    [Address(RVA = "0xED6200", Offset = "0xED5000", VA = "0x10ED6200", Slot = "5")]
    public JSON_AdventureAreaParam.QuestInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureAreaParam.QuestInfo) null;
    }
  }
}
