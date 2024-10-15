// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeSkillDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007D4")]
  public sealed class MultiPlayResumeSkillDataFormatter : 
    IMessagePackFormatter<MultiPlayResumeSkillData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001438")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001439")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020CA")]
    [Address(RVA = "0xD1B810", Offset = "0xD1A610", VA = "0x10D1B810")]
    public MultiPlayResumeSkillDataFormatter()
    {
    }

    [Token(Token = "0x60020CB")]
    [Address(RVA = "0xD1B650", Offset = "0xD1A450", VA = "0x10D1B650", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeSkillData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020CC")]
    [Address(RVA = "0xD1B2B0", Offset = "0xD1A0B0", VA = "0x10D1B2B0", Slot = "5")]
    public MultiPlayResumeSkillData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeSkillData) null;
    }
  }
}
