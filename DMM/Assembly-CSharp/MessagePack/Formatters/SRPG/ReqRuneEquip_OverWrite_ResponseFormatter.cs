// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneEquip_OverWrite_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200098D")]
  public sealed class ReqRuneEquip_OverWrite_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneEquip_OverWrite.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017AA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017AB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025F5")]
    [Address(RVA = "0xE45180", Offset = "0xE43F80", VA = "0x10E45180")]
    public ReqRuneEquip_OverWrite_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025F6")]
    [Address(RVA = "0xE45080", Offset = "0xE43E80", VA = "0x10E45080", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneEquip_OverWrite.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025F7")]
    [Address(RVA = "0xE44DB0", Offset = "0xE43BB0", VA = "0x10E44DB0", Slot = "5")]
    public ReqRuneEquip_OverWrite.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneEquip_OverWrite.Response) null;
    }
  }
}
