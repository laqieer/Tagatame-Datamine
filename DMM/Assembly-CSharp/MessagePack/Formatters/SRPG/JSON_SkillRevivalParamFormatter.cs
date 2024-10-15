// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillRevivalParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006A4")]
  public sealed class JSON_SkillRevivalParamFormatter : 
    IMessagePackFormatter<JSON_SkillRevivalParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011E0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011E1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D3A")]
    [Address(RVA = "0xC08610", Offset = "0xC07410", VA = "0x10C08610")]
    public JSON_SkillRevivalParamFormatter()
    {
    }

    [Token(Token = "0x6001D3B")]
    [Address(RVA = "0xC08360", Offset = "0xC07160", VA = "0x10C08360", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillRevivalParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D3C")]
    [Address(RVA = "0xC07F60", Offset = "0xC06D60", VA = "0x10C07F60", Slot = "5")]
    public JSON_SkillRevivalParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillRevivalParam) null;
    }
  }
}
