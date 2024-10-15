// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_CollaboSkillFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005AA")]
  public sealed class Json_CollaboSkillFormatter : 
    IMessagePackFormatter<Json_CollaboSkill>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FEC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FED")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A4C")]
    [Address(RVA = "0x7985E0", Offset = "0x7973E0", VA = "0x107985E0")]
    public Json_CollaboSkillFormatter()
    {
    }

    [Token(Token = "0x6001A4D")]
    [Address(RVA = "0x7984E0", Offset = "0x7972E0", VA = "0x107984E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_CollaboSkill value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A4E")]
    [Address(RVA = "0x798210", Offset = "0x797010", VA = "0x10798210", Slot = "5")]
    public Json_CollaboSkill Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_CollaboSkill) null;
    }
  }
}
