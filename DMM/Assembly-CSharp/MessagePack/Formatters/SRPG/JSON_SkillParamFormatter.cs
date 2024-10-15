// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005DA")]
  public sealed class JSON_SkillParamFormatter : 
    IMessagePackFormatter<JSON_SkillParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400104C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400104D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001ADC")]
    [Address(RVA = "0xA65700", Offset = "0xA64500", VA = "0x10A65700")]
    public JSON_SkillParamFormatter()
    {
    }

    [Token(Token = "0x6001ADD")]
    [Address(RVA = "0xA62680", Offset = "0xA61480", VA = "0x10A62680", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001ADE")]
    [Address(RVA = "0xA5F1D0", Offset = "0xA5DFD0", VA = "0x10A5F1D0", Slot = "5")]
    public JSON_SkillParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillParam) null;
    }
  }
}
