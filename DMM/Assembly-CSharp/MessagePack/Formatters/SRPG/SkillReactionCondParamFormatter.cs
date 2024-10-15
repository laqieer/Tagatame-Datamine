// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillReactionCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007A7")]
  public sealed class SkillReactionCondParamFormatter : 
    IMessagePackFormatter<SkillReactionCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013E2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013E3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002043")]
    [Address(RVA = "0xCFE0B0", Offset = "0xCFCEB0", VA = "0x10CFE0B0")]
    public SkillReactionCondParamFormatter()
    {
    }

    [Token(Token = "0x6002044")]
    [Address(RVA = "0xCFDCB0", Offset = "0xCFCAB0", VA = "0x10CFDCB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillReactionCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002045")]
    [Address(RVA = "0xCFD8B0", Offset = "0xCFC6B0", VA = "0x10CFD8B0", Slot = "5")]
    public SkillReactionCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillReactionCondParam) null;
    }
  }
}
