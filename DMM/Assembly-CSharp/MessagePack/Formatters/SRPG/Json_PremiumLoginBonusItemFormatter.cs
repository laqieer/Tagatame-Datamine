// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_PremiumLoginBonusItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200086B")]
  public sealed class Json_PremiumLoginBonusItemFormatter : 
    IMessagePackFormatter<Json_PremiumLoginBonusItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001566")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001567")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600228F")]
    [Address(RVA = "0xD96230", Offset = "0xD95030", VA = "0x10D96230")]
    public Json_PremiumLoginBonusItemFormatter()
    {
    }

    [Token(Token = "0x6002290")]
    [Address(RVA = "0xD96100", Offset = "0xD94F00", VA = "0x10D96100", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_PremiumLoginBonusItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002291")]
    [Address(RVA = "0xD95DF0", Offset = "0xD94BF0", VA = "0x10D95DF0", Slot = "5")]
    public Json_PremiumLoginBonusItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_PremiumLoginBonusItem) null;
    }
  }
}
