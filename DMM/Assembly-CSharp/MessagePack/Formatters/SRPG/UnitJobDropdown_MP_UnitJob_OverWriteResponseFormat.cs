// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.UnitJobDropdown_MP_UnitJob_OverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B42")]
  public sealed class UnitJobDropdown_MP_UnitJob_OverWriteResponseFormatter : 
    IMessagePackFormatter<UnitJobDropdown.MP_UnitJob_OverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001B14")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001B15")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002B14")]
    [Address(RVA = "0xF70220", Offset = "0xF6F020", VA = "0x10F70220")]
    public UnitJobDropdown_MP_UnitJob_OverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x6002B15")]
    [Address(RVA = "0xF6FF30", Offset = "0xF6ED30", VA = "0x10F6FF30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      UnitJobDropdown.MP_UnitJob_OverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002B16")]
    [Address(RVA = "0xF6FB00", Offset = "0xF6E900", VA = "0x10F6FB00", Slot = "5")]
    public UnitJobDropdown.MP_UnitJob_OverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (UnitJobDropdown.MP_UnitJob_OverWriteResponse) null;
    }
  }
}
