// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqJukeBoxPlaylistDel_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AA7")]
  public sealed class ReqJukeBoxPlaylistDel_ResponseFormatter : 
    IMessagePackFormatter<ReqJukeBoxPlaylistDel.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019DE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019DF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002943")]
    [Address(RVA = "0xEFF730", Offset = "0xEFE530", VA = "0x10EFF730")]
    public ReqJukeBoxPlaylistDel_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002944")]
    [Address(RVA = "0xEFF5C0", Offset = "0xEFE3C0", VA = "0x10EFF5C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqJukeBoxPlaylistDel.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002945")]
    [Address(RVA = "0xEFF2F0", Offset = "0xEFE0F0", VA = "0x10EFF2F0", Slot = "5")]
    public ReqJukeBoxPlaylistDel.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqJukeBoxPlaylistDel.Response) null;
    }
  }
}
