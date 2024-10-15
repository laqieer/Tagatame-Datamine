// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillMotionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000648")]
  public sealed class JSON_SkillMotionParamFormatter : 
    IMessagePackFormatter<JSON_SkillMotionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001128")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001129")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C26")]
    [Address(RVA = "0xBDEDF0", Offset = "0xBDDBF0", VA = "0x10BDEDF0")]
    public JSON_SkillMotionParamFormatter()
    {
    }

    [Token(Token = "0x6001C27")]
    [Address(RVA = "0xBDEC10", Offset = "0xBDDA10", VA = "0x10BDEC10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillMotionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C28")]
    [Address(RVA = "0xBDE8D0", Offset = "0xBDD6D0", VA = "0x10BDE8D0", Slot = "5")]
    public JSON_SkillMotionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillMotionParam) null;
    }
  }
}
