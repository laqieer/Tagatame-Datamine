// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.DamageTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000538")]
  public sealed class DamageTypesFormatter : 
    IMessagePackFormatter<DamageTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60018F6")]
    [Address(RVA = "0x6975C0", Offset = "0x6963C0", VA = "0x106975C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DamageTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018F7")]
    [Address(RVA = "0x697570", Offset = "0x696370", VA = "0x10697570", Slot = "5")]
    public DamageTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new DamageTypes();
    }

    [Token(Token = "0x60018F8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DamageTypesFormatter()
    {
    }
  }
}
