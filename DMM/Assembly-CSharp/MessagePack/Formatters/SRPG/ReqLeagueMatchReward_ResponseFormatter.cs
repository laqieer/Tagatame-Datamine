// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchReward_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000836")]
  public sealed class ReqLeagueMatchReward_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchReward.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014FC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014FD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021F0")]
    [Address(RVA = "0xD7ED00", Offset = "0xD7DB00", VA = "0x10D7ED00")]
    public ReqLeagueMatchReward_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021F1")]
    [Address(RVA = "0xD7EAD0", Offset = "0xD7D8D0", VA = "0x10D7EAD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchReward.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021F2")]
    [Address(RVA = "0xD7E790", Offset = "0xD7D590", VA = "0x10D7E790", Slot = "5")]
    public ReqLeagueMatchReward.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchReward.Response) null;
    }
  }
}
