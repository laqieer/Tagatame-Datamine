// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCollectEquipment_ReqCollectEquipmentResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B14")]
  public sealed class ReqCollectEquipment_ReqCollectEquipmentResponseFormatter : 
    IMessagePackFormatter<ReqCollectEquipment.ReqCollectEquipmentResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AB8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AB9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A8A")]
    [Address(RVA = "0xF442F0", Offset = "0xF430F0", VA = "0x10F442F0")]
    public ReqCollectEquipment_ReqCollectEquipmentResponseFormatter()
    {
    }

    [Token(Token = "0x6002A8B")]
    [Address(RVA = "0xF44000", Offset = "0xF42E00", VA = "0x10F44000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCollectEquipment.ReqCollectEquipmentResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A8C")]
    [Address(RVA = "0xF43BD0", Offset = "0xF429D0", VA = "0x10F43BD0", Slot = "5")]
    public ReqCollectEquipment.ReqCollectEquipmentResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCollectEquipment.ReqCollectEquipmentResponse) null;
    }
  }
}
