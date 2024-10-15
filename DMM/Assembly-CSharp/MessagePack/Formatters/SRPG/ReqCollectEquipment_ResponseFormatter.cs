// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCollectEquipment_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B13")]
  public sealed class ReqCollectEquipment_ResponseFormatter : 
    IMessagePackFormatter<ReqCollectEquipment.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AB6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AB7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A87")]
    [Address(RVA = "0xF44F80", Offset = "0xF43D80", VA = "0x10F44F80")]
    public ReqCollectEquipment_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A88")]
    [Address(RVA = "0xF44B00", Offset = "0xF43900", VA = "0x10F44B00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCollectEquipment.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A89")]
    [Address(RVA = "0xF44620", Offset = "0xF43420", VA = "0x10F44620", Slot = "5")]
    public ReqCollectEquipment.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCollectEquipment.Response) null;
    }
  }
}
