// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillAutoHpJudgeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006A6")]
  public sealed class JSON_SkillAutoHpJudgeParamFormatter : 
    IMessagePackFormatter<JSON_SkillAutoHpJudgeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011E4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011E5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D40")]
    [Address(RVA = "0xC05DB0", Offset = "0xC04BB0", VA = "0x10C05DB0")]
    public JSON_SkillAutoHpJudgeParamFormatter()
    {
    }

    [Token(Token = "0x6001D41")]
    [Address(RVA = "0xC05B90", Offset = "0xC04990", VA = "0x10C05B90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillAutoHpJudgeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D42")]
    [Address(RVA = "0xC05810", Offset = "0xC04610", VA = "0x10C05810", Slot = "5")]
    public JSON_SkillAutoHpJudgeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillAutoHpJudgeParam) null;
    }
  }
}
