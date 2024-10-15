// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200084C")]
  public sealed class JSON_QuestParamFormatter : 
    IMessagePackFormatter<JSON_QuestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001528")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001529")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002232")]
    [Address(RVA = "0xD76370", Offset = "0xD75170", VA = "0x10D76370")]
    public JSON_QuestParamFormatter()
    {
    }

    [Token(Token = "0x6002233")]
    [Address(RVA = "0xD74970", Offset = "0xD73770", VA = "0x10D74970", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002234")]
    [Address(RVA = "0xD72D50", Offset = "0xD71B50", VA = "0x10D72D50", Slot = "5")]
    public JSON_QuestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestParam) null;
    }
  }
}
