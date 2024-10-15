// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidTraining_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200093C")]
  public sealed class ReqGuildRaidTraining_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidTraining.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001708")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001709")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002502")]
    [Address(RVA = "0xE1A1B0", Offset = "0xE18FB0", VA = "0x10E1A1B0")]
    public ReqGuildRaidTraining_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002503")]
    [Address(RVA = "0xE1A040", Offset = "0xE18E40", VA = "0x10E1A040", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidTraining.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002504")]
    [Address(RVA = "0xE19D70", Offset = "0xE18B70", VA = "0x10E19D70", Slot = "5")]
    public ReqGuildRaidTraining.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidTraining.Response) null;
    }
  }
}
