// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillCriticalHealParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006A7")]
  public sealed class JSON_SkillCriticalHealParamFormatter : 
    IMessagePackFormatter<JSON_SkillCriticalHealParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011E6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011E7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D43")]
    [Address(RVA = "0xC06A20", Offset = "0xC05820", VA = "0x10C06A20")]
    public JSON_SkillCriticalHealParamFormatter()
    {
    }

    [Token(Token = "0x6001D44")]
    [Address(RVA = "0xC068C0", Offset = "0xC056C0", VA = "0x10C068C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillCriticalHealParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D45")]
    [Address(RVA = "0xC06570", Offset = "0xC05370", VA = "0x10C06570", Slot = "5")]
    public JSON_SkillCriticalHealParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillCriticalHealParam) null;
    }
  }
}
