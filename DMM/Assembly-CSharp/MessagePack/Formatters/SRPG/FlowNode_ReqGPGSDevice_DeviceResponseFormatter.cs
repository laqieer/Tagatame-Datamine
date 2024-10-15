// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGPGSDevice_DeviceResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000945")]
  public sealed class FlowNode_ReqGPGSDevice_DeviceResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGPGSDevice.DeviceResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400171A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400171B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600251D")]
    [Address(RVA = "0xE0D000", Offset = "0xE0BE00", VA = "0x10E0D000")]
    public FlowNode_ReqGPGSDevice_DeviceResponseFormatter()
    {
    }

    [Token(Token = "0x600251E")]
    [Address(RVA = "0xE0CD10", Offset = "0xE0BB10", VA = "0x10E0CD10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGPGSDevice.DeviceResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600251F")]
    [Address(RVA = "0xE0C8E0", Offset = "0xE0B6E0", VA = "0x10E0C8E0", Slot = "5")]
    public FlowNode_ReqGPGSDevice.DeviceResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGPGSDevice.DeviceResponse) null;
    }
  }
}
