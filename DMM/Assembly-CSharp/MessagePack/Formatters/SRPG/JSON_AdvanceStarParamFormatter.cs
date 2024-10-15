// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdvanceStarParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A10")]
  public sealed class JSON_AdvanceStarParamFormatter : 
    IMessagePackFormatter<JSON_AdvanceStarParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018B0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018B1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600277E")]
    [Address(RVA = "0xE9E840", Offset = "0xE9D640", VA = "0x10E9E840")]
    public JSON_AdvanceStarParamFormatter()
    {
    }

    [Token(Token = "0x600277F")]
    [Address(RVA = "0xE9E660", Offset = "0xE9D460", VA = "0x10E9E660", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdvanceStarParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002780")]
    [Address(RVA = "0xE9E320", Offset = "0xE9D120", VA = "0x10E9E320", Slot = "5")]
    public JSON_AdvanceStarParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdvanceStarParam) null;
    }
  }
}
