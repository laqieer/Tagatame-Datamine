// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneEquip_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200098B")]
  public sealed class ReqRuneEquip_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneEquip.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017A6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017A7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025EF")]
    [Address(RVA = "0xE45D40", Offset = "0xE44B40", VA = "0x10E45D40")]
    public ReqRuneEquip_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025F0")]
    [Address(RVA = "0xE45B90", Offset = "0xE44990", VA = "0x10E45B90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneEquip.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025F1")]
    [Address(RVA = "0xE45880", Offset = "0xE44680", VA = "0x10E45880", Slot = "5")]
    public ReqRuneEquip.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneEquip.Response) null;
    }
  }
}
