// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidBtlLog_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ABF")]
  public sealed class ReqGuildRaidBtlLog_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidBtlLog.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A0E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A0F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600298B")]
    [Address(RVA = "0xF129E0", Offset = "0xF117E0", VA = "0x10F129E0")]
    public ReqGuildRaidBtlLog_ResponseFormatter()
    {
    }

    [Token(Token = "0x600298C")]
    [Address(RVA = "0xF12870", Offset = "0xF11670", VA = "0x10F12870", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidBtlLog.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600298D")]
    [Address(RVA = "0xF125A0", Offset = "0xF113A0", VA = "0x10F125A0", Slot = "5")]
    public ReqGuildRaidBtlLog.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidBtlLog.Response) null;
    }
  }
}
