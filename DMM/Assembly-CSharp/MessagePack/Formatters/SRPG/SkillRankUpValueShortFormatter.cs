// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillRankUpValueShortFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000756")]
  public sealed class SkillRankUpValueShortFormatter : 
    IMessagePackFormatter<SkillRankUpValueShort>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001344")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001345")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F50")]
    [Address(RVA = "0xCA9330", Offset = "0xCA8130", VA = "0x10CA9330")]
    public SkillRankUpValueShortFormatter()
    {
    }

    [Token(Token = "0x6001F51")]
    [Address(RVA = "0xCA9230", Offset = "0xCA8030", VA = "0x10CA9230", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillRankUpValueShort value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F52")]
    [Address(RVA = "0xCA8F40", Offset = "0xCA7D40", VA = "0x10CA8F40", Slot = "5")]
    public SkillRankUpValueShort Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillRankUpValueShort) null;
    }
  }
}
