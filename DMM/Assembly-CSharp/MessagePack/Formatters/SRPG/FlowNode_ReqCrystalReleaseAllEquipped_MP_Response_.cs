// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCrystalReleaseAllEquipped_MP_Response_BaseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B03")]
  public sealed class FlowNode_ReqCrystalReleaseAllEquipped_MP_Response_BaseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCrystalReleaseAllEquipped.MP_Response_Base>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A96")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A97")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A57")]
    [Address(RVA = "0xF1B0E0", Offset = "0xF19EE0", VA = "0x10F1B0E0")]
    public FlowNode_ReqCrystalReleaseAllEquipped_MP_Response_BaseFormatter()
    {
    }

    [Token(Token = "0x6002A58")]
    [Address(RVA = "0xF1ADF0", Offset = "0xF19BF0", VA = "0x10F1ADF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCrystalReleaseAllEquipped.MP_Response_Base value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A59")]
    [Address(RVA = "0xF1A9B0", Offset = "0xF197B0", VA = "0x10F1A9B0", Slot = "5")]
    public FlowNode_ReqCrystalReleaseAllEquipped.MP_Response_Base Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCrystalReleaseAllEquipped.MP_Response_Base) null;
    }
  }
}
