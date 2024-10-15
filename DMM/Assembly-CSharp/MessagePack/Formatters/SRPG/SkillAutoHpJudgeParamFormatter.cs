// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillAutoHpJudgeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200075B")]
  public sealed class SkillAutoHpJudgeParamFormatter : 
    IMessagePackFormatter<SkillAutoHpJudgeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400134E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400134F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F5F")]
    [Address(RVA = "0xC9A660", Offset = "0xC99460", VA = "0x10C9A660")]
    public SkillAutoHpJudgeParamFormatter()
    {
    }

    [Token(Token = "0x6001F60")]
    [Address(RVA = "0xC9A430", Offset = "0xC99230", VA = "0x10C9A430", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillAutoHpJudgeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F61")]
    [Address(RVA = "0xC9A0F0", Offset = "0xC98EF0", VA = "0x10C9A0F0", Slot = "5")]
    public SkillAutoHpJudgeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillAutoHpJudgeParam) null;
    }
  }
}
