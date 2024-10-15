// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_StaminaFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000716")]
  public sealed class Json_StaminaFormatter : 
    IMessagePackFormatter<Json_Stamina>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012C4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012C5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E90")]
    [Address(RVA = "0xC654C0", Offset = "0xC642C0", VA = "0x10C654C0")]
    public Json_StaminaFormatter()
    {
    }

    [Token(Token = "0x6001E91")]
    [Address(RVA = "0xC65390", Offset = "0xC64190", VA = "0x10C65390", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Stamina value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E92")]
    [Address(RVA = "0xC65050", Offset = "0xC63E50", VA = "0x10C65050", Slot = "5")]
    public Json_Stamina Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Stamina) null;
    }
  }
}
