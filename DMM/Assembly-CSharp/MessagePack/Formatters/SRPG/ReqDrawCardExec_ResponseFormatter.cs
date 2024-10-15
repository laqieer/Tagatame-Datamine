// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqDrawCardExec_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AA1")]
  public sealed class ReqDrawCardExec_ResponseFormatter : 
    IMessagePackFormatter<ReqDrawCardExec.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019D2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019D3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002931")]
    [Address(RVA = "0xEFE8B0", Offset = "0xEFD6B0", VA = "0x10EFE8B0")]
    public ReqDrawCardExec_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002932")]
    [Address(RVA = "0xEFE1A0", Offset = "0xEFCFA0", VA = "0x10EFE1A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqDrawCardExec.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002933")]
    [Address(RVA = "0xEFDB30", Offset = "0xEFC930", VA = "0x10EFDB30", Slot = "5")]
    public ReqDrawCardExec.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqDrawCardExec.Response) null;
    }
  }
}
