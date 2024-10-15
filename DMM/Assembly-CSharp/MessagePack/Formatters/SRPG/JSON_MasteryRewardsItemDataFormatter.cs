// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_MasteryRewardsItemDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007D7")]
  public sealed class JSON_MasteryRewardsItemDataFormatter : 
    IMessagePackFormatter<JSON_MasteryRewardsItemData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400143E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400143F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020D3")]
    [Address(RVA = "0xD1AA70", Offset = "0xD19870", VA = "0x10D1AA70")]
    public JSON_MasteryRewardsItemDataFormatter()
    {
    }

    [Token(Token = "0x60020D4")]
    [Address(RVA = "0xD1A910", Offset = "0xD19710", VA = "0x10D1A910", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_MasteryRewardsItemData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020D5")]
    [Address(RVA = "0xD1A5C0", Offset = "0xD193C0", VA = "0x10D1A5C0", Slot = "5")]
    public JSON_MasteryRewardsItemData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_MasteryRewardsItemData) null;
    }
  }
}
