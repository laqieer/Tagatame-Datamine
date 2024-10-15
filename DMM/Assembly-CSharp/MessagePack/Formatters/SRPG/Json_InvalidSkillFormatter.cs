// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_InvalidSkillFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007DC")]
  public sealed class Json_InvalidSkillFormatter : 
    IMessagePackFormatter<Json_InvalidSkill>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001448")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001449")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020E2")]
    [Address(RVA = "0xD1B130", Offset = "0xD19F30", VA = "0x10D1B130")]
    public Json_InvalidSkillFormatter()
    {
    }

    [Token(Token = "0x60020E3")]
    [Address(RVA = "0xD1AF90", Offset = "0xD19D90", VA = "0x10D1AF90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_InvalidSkill value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020E4")]
    [Address(RVA = "0xD1AC60", Offset = "0xD19A60", VA = "0x10D1AC60", Slot = "5")]
    public Json_InvalidSkill Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_InvalidSkill) null;
    }
  }
}
