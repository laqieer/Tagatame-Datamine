// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TruthEquipmentStatusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200091E")]
  public sealed class TruthEquipmentStatusParamFormatter : 
    IMessagePackFormatter<TruthEquipmentStatusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016CC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016CD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024A8")]
    [Address(RVA = "0xE09E20", Offset = "0xE08C20", VA = "0x10E09E20")]
    public TruthEquipmentStatusParamFormatter()
    {
    }

    [Token(Token = "0x60024A9")]
    [Address(RVA = "0xE09C40", Offset = "0xE08A40", VA = "0x10E09C40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TruthEquipmentStatusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024AA")]
    [Address(RVA = "0xE09930", Offset = "0xE08730", VA = "0x10E09930", Slot = "5")]
    public TruthEquipmentStatusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TruthEquipmentStatusParam) null;
    }
  }
}
