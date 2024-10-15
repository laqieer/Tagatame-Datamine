// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidTrainingBtlLog_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200092B")]
  public sealed class ReqGuildRaidTrainingBtlLog_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidTrainingBtlLog.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016E6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016E7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024CF")]
    [Address(RVA = "0xE05300", Offset = "0xE04100", VA = "0x10E05300")]
    public ReqGuildRaidTrainingBtlLog_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024D0")]
    [Address(RVA = "0xE05190", Offset = "0xE03F90", VA = "0x10E05190", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidTrainingBtlLog.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024D1")]
    [Address(RVA = "0xE04EC0", Offset = "0xE03CC0", VA = "0x10E04EC0", Slot = "5")]
    public ReqGuildRaidTrainingBtlLog.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidTrainingBtlLog.Response) null;
    }
  }
}
