// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000868")]
  public sealed class JSON_PointQuestParamFormatter : 
    IMessagePackFormatter<JSON_PointQuestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001560")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001561")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002286")]
    [Address(RVA = "0xD8DC00", Offset = "0xD8CA00", VA = "0x10D8DC00")]
    public JSON_PointQuestParamFormatter()
    {
    }

    [Token(Token = "0x6002287")]
    [Address(RVA = "0xD8D8F0", Offset = "0xD8C6F0", VA = "0x10D8D8F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002288")]
    [Address(RVA = "0xD8D4A0", Offset = "0xD8C2A0", VA = "0x10D8D4A0", Slot = "5")]
    public JSON_PointQuestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestParam) null;
    }
  }
}
