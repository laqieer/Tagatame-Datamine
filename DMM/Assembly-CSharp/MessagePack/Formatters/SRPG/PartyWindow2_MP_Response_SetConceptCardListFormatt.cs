// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.PartyWindow2_MP_Response_SetConceptCardListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200094A")]
  public sealed class PartyWindow2_MP_Response_SetConceptCardListFormatter : 
    IMessagePackFormatter<PartyWindow2.MP_Response_SetConceptCardList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001724")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001725")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600252C")]
    [Address(RVA = "0xE17920", Offset = "0xE16720", VA = "0x10E17920")]
    public PartyWindow2_MP_Response_SetConceptCardListFormatter()
    {
    }

    [Token(Token = "0x600252D")]
    [Address(RVA = "0xE17630", Offset = "0xE16430", VA = "0x10E17630", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      PartyWindow2.MP_Response_SetConceptCardList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600252E")]
    [Address(RVA = "0xE17200", Offset = "0xE16000", VA = "0x10E17200", Slot = "5")]
    public PartyWindow2.MP_Response_SetConceptCardList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (PartyWindow2.MP_Response_SetConceptCardList) null;
    }
  }
}
