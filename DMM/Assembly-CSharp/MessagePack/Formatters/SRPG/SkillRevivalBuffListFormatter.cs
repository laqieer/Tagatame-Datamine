// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillRevivalBuffListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000758")]
  public sealed class SkillRevivalBuffListFormatter : 
    IMessagePackFormatter<SkillRevivalBuffList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001348")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001349")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F56")]
    [Address(RVA = "0xCA9950", Offset = "0xCA8750", VA = "0x10CA9950")]
    public SkillRevivalBuffListFormatter()
    {
    }

    [Token(Token = "0x6001F57")]
    [Address(RVA = "0xCA97E0", Offset = "0xCA85E0", VA = "0x10CA97E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillRevivalBuffList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F58")]
    [Address(RVA = "0xCA94B0", Offset = "0xCA82B0", VA = "0x10CA94B0", Slot = "5")]
    public SkillRevivalBuffList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillRevivalBuffList) null;
    }
  }
}
