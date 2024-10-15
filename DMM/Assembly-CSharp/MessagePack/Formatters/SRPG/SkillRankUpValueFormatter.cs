// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillRankUpValueFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000753")]
  public sealed class SkillRankUpValueFormatter : 
    IMessagePackFormatter<SkillRankUpValue>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400133E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400133F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F47")]
    [Address(RVA = "0xCA8DC0", Offset = "0xCA7BC0", VA = "0x10CA8DC0")]
    public SkillRankUpValueFormatter()
    {
    }

    [Token(Token = "0x6001F48")]
    [Address(RVA = "0xCA8CC0", Offset = "0xCA7AC0", VA = "0x10CA8CC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillRankUpValue value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F49")]
    [Address(RVA = "0xCA89E0", Offset = "0xCA77E0", VA = "0x10CA89E0", Slot = "5")]
    public SkillRankUpValue Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillRankUpValue) null;
    }
  }
}
