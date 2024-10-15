// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqJukeBoxPlaylistAdd_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200091F")]
  public sealed class ReqJukeBoxPlaylistAdd_ResponseFormatter : 
    IMessagePackFormatter<ReqJukeBoxPlaylistAdd.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016CE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016CF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024AB")]
    [Address(RVA = "0xE05DC0", Offset = "0xE04BC0", VA = "0x10E05DC0")]
    public ReqJukeBoxPlaylistAdd_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024AC")]
    [Address(RVA = "0xE05C50", Offset = "0xE04A50", VA = "0x10E05C50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqJukeBoxPlaylistAdd.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024AD")]
    [Address(RVA = "0xE05980", Offset = "0xE04780", VA = "0x10E05980", Slot = "5")]
    public ReqJukeBoxPlaylistAdd.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqJukeBoxPlaylistAdd.Response) null;
    }
  }
}
