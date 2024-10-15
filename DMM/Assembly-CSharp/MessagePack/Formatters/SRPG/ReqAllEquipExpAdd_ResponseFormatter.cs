// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAllEquipExpAdd_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AC9")]
  public sealed class ReqAllEquipExpAdd_ResponseFormatter : 
    IMessagePackFormatter<ReqAllEquipExpAdd.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A22")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A23")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029A9")]
    [Address(RVA = "0xF106B0", Offset = "0xF0F4B0", VA = "0x10F106B0")]
    public ReqAllEquipExpAdd_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029AA")]
    [Address(RVA = "0xF104E0", Offset = "0xF0F2E0", VA = "0x10F104E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAllEquipExpAdd.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029AB")]
    [Address(RVA = "0xF10130", Offset = "0xF0EF30", VA = "0x10F10130", Slot = "5")]
    public ReqAllEquipExpAdd.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAllEquipExpAdd.Response) null;
    }
  }
}
