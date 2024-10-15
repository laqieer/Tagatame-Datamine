// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqBtlDuelExec_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B21")]
  public sealed class ReqBtlDuelExec_ResponseFormatter : 
    IMessagePackFormatter<ReqBtlDuelExec.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AD2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AD3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AB1")]
    [Address(RVA = "0xF435B0", Offset = "0xF423B0", VA = "0x10F435B0")]
    public ReqBtlDuelExec_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AB2")]
    [Address(RVA = "0xF43010", Offset = "0xF41E10", VA = "0x10F43010", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqBtlDuelExec.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AB3")]
    [Address(RVA = "0xF428E0", Offset = "0xF416E0", VA = "0x10F428E0", Slot = "5")]
    public ReqBtlDuelExec.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqBtlDuelExec.Response) null;
    }
  }
}
