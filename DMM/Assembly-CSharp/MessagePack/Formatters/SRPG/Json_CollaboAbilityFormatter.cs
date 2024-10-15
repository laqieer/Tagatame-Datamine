// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_CollaboAbilityFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005AB")]
  public sealed class Json_CollaboAbilityFormatter : 
    IMessagePackFormatter<Json_CollaboAbility>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FEE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FEF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A4F")]
    [Address(RVA = "0x797FB0", Offset = "0x796DB0", VA = "0x10797FB0")]
    public Json_CollaboAbilityFormatter()
    {
    }

    [Token(Token = "0x6001A50")]
    [Address(RVA = "0x797D50", Offset = "0x796B50", VA = "0x10797D50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_CollaboAbility value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A51")]
    [Address(RVA = "0x797990", Offset = "0x796790", VA = "0x10797990", Slot = "5")]
    public Json_CollaboAbility Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_CollaboAbility) null;
    }
  }
}
