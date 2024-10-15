// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidReportSelf_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000739")]
  public sealed class ReqGuildRaidReportSelf_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidReportSelf.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400130A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400130B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EF9")]
    [Address(RVA = "0xC95770", Offset = "0xC94570", VA = "0x10C95770")]
    public ReqGuildRaidReportSelf_ResponseFormatter()
    {
    }

    [Token(Token = "0x6001EFA")]
    [Address(RVA = "0xC955C0", Offset = "0xC943C0", VA = "0x10C955C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidReportSelf.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EFB")]
    [Address(RVA = "0xC952B0", Offset = "0xC940B0", VA = "0x10C952B0", Slot = "5")]
    public ReqGuildRaidReportSelf.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidReportSelf.Response) null;
    }
  }
}
