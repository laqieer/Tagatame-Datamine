// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BtlRewardConceptCardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007E5")]
  public sealed class Json_BtlRewardConceptCardFormatter : 
    IMessagePackFormatter<Json_BtlRewardConceptCard>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400145A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400145B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020FD")]
    [Address(RVA = "0xD35C30", Offset = "0xD34A30", VA = "0x10D35C30")]
    public Json_BtlRewardConceptCardFormatter()
    {
    }

    [Token(Token = "0x60020FE")]
    [Address(RVA = "0xD35A20", Offset = "0xD34820", VA = "0x10D35A20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BtlRewardConceptCard value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020FF")]
    [Address(RVA = "0xD35650", Offset = "0xD34450", VA = "0x10D35650", Slot = "5")]
    public Json_BtlRewardConceptCard Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BtlRewardConceptCard) null;
    }
  }
}
