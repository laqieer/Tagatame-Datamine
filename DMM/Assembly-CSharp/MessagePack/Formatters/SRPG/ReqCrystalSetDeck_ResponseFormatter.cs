// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCrystalSetDeck_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000963")]
  public sealed class ReqCrystalSetDeck_ResponseFormatter : 
    IMessagePackFormatter<ReqCrystalSetDeck.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001756")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001757")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002577")]
    [Address(RVA = "0xE32410", Offset = "0xE31210", VA = "0x10E32410")]
    public ReqCrystalSetDeck_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002578")]
    [Address(RVA = "0xE322A0", Offset = "0xE310A0", VA = "0x10E322A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCrystalSetDeck.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002579")]
    [Address(RVA = "0xE31FD0", Offset = "0xE30DD0", VA = "0x10E31FD0", Slot = "5")]
    public ReqCrystalSetDeck.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCrystalSetDeck.Response) null;
    }
  }
}
