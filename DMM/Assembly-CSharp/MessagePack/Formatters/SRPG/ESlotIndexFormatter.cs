// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ESlotIndexFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000570")]
  public sealed class ESlotIndexFormatter : 
    IMessagePackFormatter<CrystalData.ESlotIndex>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600199E")]
    [Address(RVA = "0x69BEA0", Offset = "0x69ACA0", VA = "0x1069BEA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CrystalData.ESlotIndex value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600199F")]
    [Address(RVA = "0x69BE50", Offset = "0x69AC50", VA = "0x1069BE50", Slot = "5")]
    public CrystalData.ESlotIndex Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new CrystalData.ESlotIndex();
    }

    [Token(Token = "0x60019A0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ESlotIndexFormatter()
    {
    }
  }
}
