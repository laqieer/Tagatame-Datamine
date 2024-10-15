// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGetRune_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200085D")]
  public sealed class ReqGetRune_ResponseFormatter : 
    IMessagePackFormatter<ReqGetRune.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400154A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400154B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002265")]
    [Address(RVA = "0xD97500", Offset = "0xD96300", VA = "0x10D97500")]
    public ReqGetRune_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002266")]
    [Address(RVA = "0xD972B0", Offset = "0xD960B0", VA = "0x10D972B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGetRune.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002267")]
    [Address(RVA = "0xD96F10", Offset = "0xD95D10", VA = "0x10D96F10", Slot = "5")]
    public ReqGetRune.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGetRune.Response) null;
    }
  }
}
