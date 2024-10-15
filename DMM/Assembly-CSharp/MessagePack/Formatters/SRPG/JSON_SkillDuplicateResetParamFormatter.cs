// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillDuplicateResetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006B0")]
  public sealed class JSON_SkillDuplicateResetParamFormatter : 
    IMessagePackFormatter<JSON_SkillDuplicateResetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011F8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011F9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D5E")]
    [Address(RVA = "0xC07820", Offset = "0xC06620", VA = "0x10C07820")]
    public JSON_SkillDuplicateResetParamFormatter()
    {
    }

    [Token(Token = "0x6001D5F")]
    [Address(RVA = "0xC07640", Offset = "0xC06440", VA = "0x10C07640", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillDuplicateResetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D60")]
    [Address(RVA = "0xC07300", Offset = "0xC06100", VA = "0x10C07300", Slot = "5")]
    public JSON_SkillDuplicateResetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillDuplicateResetParam) null;
    }
  }
}
