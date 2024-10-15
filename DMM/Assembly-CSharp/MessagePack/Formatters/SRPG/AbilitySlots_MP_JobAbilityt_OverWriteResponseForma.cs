// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AbilitySlots_MP_JobAbilityt_OverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009EA")]
  public sealed class AbilitySlots_MP_JobAbilityt_OverWriteResponseFormatter : 
    IMessagePackFormatter<AbilitySlots.MP_JobAbilityt_OverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001864")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001865")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600270C")]
    [Address(RVA = "0xE7BB50", Offset = "0xE7A950", VA = "0x10E7BB50")]
    public AbilitySlots_MP_JobAbilityt_OverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x600270D")]
    [Address(RVA = "0xE7B860", Offset = "0xE7A660", VA = "0x10E7B860", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AbilitySlots.MP_JobAbilityt_OverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600270E")]
    [Address(RVA = "0xE7B430", Offset = "0xE7A230", VA = "0x10E7B430", Slot = "5")]
    public AbilitySlots.MP_JobAbilityt_OverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AbilitySlots.MP_JobAbilityt_OverWriteResponse) null;
    }
  }
}
