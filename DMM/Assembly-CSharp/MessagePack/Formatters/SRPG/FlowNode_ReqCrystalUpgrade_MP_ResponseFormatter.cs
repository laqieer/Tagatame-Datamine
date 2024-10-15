// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCrystalUpgrade_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200073E")]
  public sealed class FlowNode_ReqCrystalUpgrade_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCrystalUpgrade.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001314")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001315")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F08")]
    [Address(RVA = "0xC818A0", Offset = "0xC806A0", VA = "0x10C818A0")]
    public FlowNode_ReqCrystalUpgrade_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6001F09")]
    [Address(RVA = "0xC815B0", Offset = "0xC803B0", VA = "0x10C815B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCrystalUpgrade.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F0A")]
    [Address(RVA = "0xC81180", Offset = "0xC7FF80", VA = "0x10C81180", Slot = "5")]
    public FlowNode_ReqCrystalUpgrade.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCrystalUpgrade.MP_Response) null;
    }
  }
}
