// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildTrophyReward_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009BF")]
  public sealed class ReqGuildTrophyReward_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildTrophyReward.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400180E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400180F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600268B")]
    [Address(RVA = "0xE79C50", Offset = "0xE78A50", VA = "0x10E79C50")]
    public ReqGuildTrophyReward_ResponseFormatter()
    {
    }

    [Token(Token = "0x600268C")]
    [Address(RVA = "0xE797A0", Offset = "0xE785A0", VA = "0x10E797A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildTrophyReward.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600268D")]
    [Address(RVA = "0xE792C0", Offset = "0xE780C0", VA = "0x10E792C0", Slot = "5")]
    public ReqGuildTrophyReward.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildTrophyReward.Response) null;
    }
  }
}
