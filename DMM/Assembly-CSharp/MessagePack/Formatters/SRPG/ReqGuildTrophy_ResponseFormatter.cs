// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildTrophy_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ADE")]
  public sealed class ReqGuildTrophy_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildTrophy.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A4C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A4D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029E8")]
    [Address(RVA = "0xF27F40", Offset = "0xF26D40", VA = "0x10F27F40")]
    public ReqGuildTrophy_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029E9")]
    [Address(RVA = "0xF27E40", Offset = "0xF26C40", VA = "0x10F27E40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildTrophy.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029EA")]
    [Address(RVA = "0xF27B70", Offset = "0xF26970", VA = "0x10F27B70", Slot = "5")]
    public ReqGuildTrophy.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildTrophy.Response) null;
    }
  }
}
