// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvG_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007F5")]
  public sealed class ReqGvG_ResponseFormatter : 
    IMessagePackFormatter<ReqGvG.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400147A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400147B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600212D")]
    [Address(RVA = "0xD3C4D0", Offset = "0xD3B2D0", VA = "0x10D3C4D0")]
    public ReqGvG_ResponseFormatter()
    {
    }

    [Token(Token = "0x600212E")]
    [Address(RVA = "0xD3BBA0", Offset = "0xD3A9A0", VA = "0x10D3BBA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvG.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600212F")]
    [Address(RVA = "0xD3B3C0", Offset = "0xD3A1C0", VA = "0x10D3B3C0", Slot = "5")]
    public ReqGvG.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvG.Response) null;
    }
  }
}
