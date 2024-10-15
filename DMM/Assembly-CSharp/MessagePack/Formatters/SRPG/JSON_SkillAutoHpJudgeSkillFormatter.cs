// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillAutoHpJudgeSkillFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006A5")]
  public sealed class JSON_SkillAutoHpJudgeSkillFormatter : 
    IMessagePackFormatter<JSON_SkillAutoHpJudgeSkill>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011E2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011E3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D3D")]
    [Address(RVA = "0xC063F0", Offset = "0xC051F0", VA = "0x10C063F0")]
    public JSON_SkillAutoHpJudgeSkillFormatter()
    {
    }

    [Token(Token = "0x6001D3E")]
    [Address(RVA = "0xC062C0", Offset = "0xC050C0", VA = "0x10C062C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillAutoHpJudgeSkill value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D3F")]
    [Address(RVA = "0xC05FB0", Offset = "0xC04DB0", VA = "0x10C05FB0", Slot = "5")]
    public JSON_SkillAutoHpJudgeSkill Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillAutoHpJudgeSkill) null;
    }
  }
}
