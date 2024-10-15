// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eTypeMhmDamageFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200057F")]
  public sealed class eTypeMhmDamageFormatter : 
    IMessagePackFormatter<Unit.eTypeMhmDamage>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019CB")]
    [Address(RVA = "0x6B1AC0", Offset = "0x6B08C0", VA = "0x106B1AC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.eTypeMhmDamage value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019CC")]
    [Address(RVA = "0x6B1A70", Offset = "0x6B0870", VA = "0x106B1A70", Slot = "5")]
    public Unit.eTypeMhmDamage Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Unit.eTypeMhmDamage();
    }

    [Token(Token = "0x60019CD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eTypeMhmDamageFormatter()
    {
    }
  }
}
