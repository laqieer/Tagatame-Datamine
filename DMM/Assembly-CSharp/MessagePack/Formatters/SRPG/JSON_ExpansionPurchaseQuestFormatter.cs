// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ExpansionPurchaseQuestFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200069E")]
  public sealed class JSON_ExpansionPurchaseQuestFormatter : 
    IMessagePackFormatter<JSON_ExpansionPurchaseQuest>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011D4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011D5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D28")]
    [Address(RVA = "0xBF8BE0", Offset = "0xBF79E0", VA = "0x10BF8BE0")]
    public JSON_ExpansionPurchaseQuestFormatter()
    {
    }

    [Token(Token = "0x6001D29")]
    [Address(RVA = "0xBF8A90", Offset = "0xBF7890", VA = "0x10BF8A90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ExpansionPurchaseQuest value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D2A")]
    [Address(RVA = "0xBF8760", Offset = "0xBF7560", VA = "0x10BF8760", Slot = "5")]
    public JSON_ExpansionPurchaseQuest Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ExpansionPurchaseQuest) null;
    }
  }
}
