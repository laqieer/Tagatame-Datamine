// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneParamEnhEvo_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008E9")]
  public sealed class ReqRuneParamEnhEvo_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneParamEnhEvo.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001662")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001663")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002409")]
    [Address(RVA = "0xDDA8F0", Offset = "0xDD96F0", VA = "0x10DDA8F0")]
    public ReqRuneParamEnhEvo_ResponseFormatter()
    {
    }

    [Token(Token = "0x600240A")]
    [Address(RVA = "0xDDA660", Offset = "0xDD9460", VA = "0x10DDA660", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneParamEnhEvo.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600240B")]
    [Address(RVA = "0xDDA290", Offset = "0xDD9090", VA = "0x10DDA290", Slot = "5")]
    public ReqRuneParamEnhEvo.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneParamEnhEvo.Response) null;
    }
  }
}
