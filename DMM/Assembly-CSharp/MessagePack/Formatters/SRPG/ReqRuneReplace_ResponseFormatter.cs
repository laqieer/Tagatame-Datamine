// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneReplace_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009A1")]
  public sealed class ReqRuneReplace_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneReplace.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017D2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017D3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002631")]
    [Address(RVA = "0xE47D60", Offset = "0xE46B60", VA = "0x10E47D60")]
    public ReqRuneReplace_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002632")]
    [Address(RVA = "0xE47C60", Offset = "0xE46A60", VA = "0x10E47C60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneReplace.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002633")]
    [Address(RVA = "0xE47990", Offset = "0xE46790", VA = "0x10E47990", Slot = "5")]
    public ReqRuneReplace.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneReplace.Response) null;
    }
  }
}
