// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillAutoHpJudgeSkillFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200075A")]
  public sealed class SkillAutoHpJudgeSkillFormatter : 
    IMessagePackFormatter<SkillAutoHpJudgeSkill>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400134C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400134D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F5C")]
    [Address(RVA = "0xC9AC90", Offset = "0xC99A90", VA = "0x10C9AC90")]
    public SkillAutoHpJudgeSkillFormatter()
    {
    }

    [Token(Token = "0x6001F5D")]
    [Address(RVA = "0xC9AB60", Offset = "0xC99960", VA = "0x10C9AB60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillAutoHpJudgeSkill value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F5E")]
    [Address(RVA = "0xC9A850", Offset = "0xC99650", VA = "0x10C9A850", Slot = "5")]
    public SkillAutoHpJudgeSkill Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillAutoHpJudgeSkill) null;
    }
  }
}
