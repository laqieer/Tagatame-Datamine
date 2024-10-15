// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqTrophyStarMissionGetReward_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A4A")]
  public sealed class ReqTrophyStarMissionGetReward_ResponseFormatter : 
    IMessagePackFormatter<ReqTrophyStarMissionGetReward.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001924")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001925")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600282C")]
    [Address(RVA = "0xEBD4E0", Offset = "0xEBC2E0", VA = "0x10EBD4E0")]
    public ReqTrophyStarMissionGetReward_ResponseFormatter()
    {
    }

    [Token(Token = "0x600282D")]
    [Address(RVA = "0xEBCE90", Offset = "0xEBBC90", VA = "0x10EBCE90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqTrophyStarMissionGetReward.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600282E")]
    [Address(RVA = "0xEBC900", Offset = "0xEBB700", VA = "0x10EBC900", Slot = "5")]
    public ReqTrophyStarMissionGetReward.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqTrophyStarMissionGetReward.Response) null;
    }
  }
}
