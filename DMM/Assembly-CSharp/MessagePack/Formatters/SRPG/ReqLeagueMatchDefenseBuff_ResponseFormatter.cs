// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchDefenseBuff_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007DE")]
  public sealed class ReqLeagueMatchDefenseBuff_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchDefenseBuff.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400144C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400144D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020E8")]
    [Address(RVA = "0xD1BE40", Offset = "0xD1AC40", VA = "0x10D1BE40")]
    public ReqLeagueMatchDefenseBuff_ResponseFormatter()
    {
    }

    [Token(Token = "0x60020E9")]
    [Address(RVA = "0xD1BCD0", Offset = "0xD1AAD0", VA = "0x10D1BCD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchDefenseBuff.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020EA")]
    [Address(RVA = "0xD1BA00", Offset = "0xD1A800", VA = "0x10D1BA00", Slot = "5")]
    public ReqLeagueMatchDefenseBuff.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchDefenseBuff.Response) null;
    }
  }
}
