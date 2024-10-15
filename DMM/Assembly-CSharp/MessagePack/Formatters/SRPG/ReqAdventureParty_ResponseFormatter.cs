// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAdventureParty_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AB1")]
  public sealed class ReqAdventureParty_ResponseFormatter : 
    IMessagePackFormatter<ReqAdventureParty.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019F2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019F3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002961")]
    [Address(RVA = "0xF10010", Offset = "0xF0EE10", VA = "0x10F10010")]
    public ReqAdventureParty_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002962")]
    [Address(RVA = "0xF0FF10", Offset = "0xF0ED10", VA = "0x10F0FF10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAdventureParty.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002963")]
    [Address(RVA = "0xF0FC40", Offset = "0xF0EA40", VA = "0x10F0FC40", Slot = "5")]
    public ReqAdventureParty.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAdventureParty.Response) null;
    }
  }
}
