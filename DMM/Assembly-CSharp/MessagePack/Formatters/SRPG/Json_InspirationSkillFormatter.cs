// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_InspirationSkillFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005A7")]
  public sealed class Json_InspirationSkillFormatter : 
    IMessagePackFormatter<Json_InspirationSkill>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FE6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FE7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A43")]
    [Address(RVA = "0x79A9F0", Offset = "0x7997F0", VA = "0x1079A9F0")]
    public Json_InspirationSkillFormatter()
    {
    }

    [Token(Token = "0x6001A44")]
    [Address(RVA = "0x79A810", Offset = "0x799610", VA = "0x1079A810", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_InspirationSkill value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A45")]
    [Address(RVA = "0x79A440", Offset = "0x799240", VA = "0x1079A440", Slot = "5")]
    public Json_InspirationSkill Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_InspirationSkill) null;
    }
  }
}
