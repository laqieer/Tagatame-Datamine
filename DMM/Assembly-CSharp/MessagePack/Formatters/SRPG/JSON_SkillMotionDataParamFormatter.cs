// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillMotionDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000647")]
  public sealed class JSON_SkillMotionDataParamFormatter : 
    IMessagePackFormatter<JSON_SkillMotionDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001126")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001127")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C23")]
    [Address(RVA = "0xBDE600", Offset = "0xBDD400", VA = "0x10BDE600")]
    public JSON_SkillMotionDataParamFormatter()
    {
    }

    [Token(Token = "0x6001C24")]
    [Address(RVA = "0xBDE3B0", Offset = "0xBDD1B0", VA = "0x10BDE3B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillMotionDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C25")]
    [Address(RVA = "0xBDDFA0", Offset = "0xBDCDA0", VA = "0x10BDDFA0", Slot = "5")]
    public JSON_SkillMotionDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillMotionDataParam) null;
    }
  }
}
