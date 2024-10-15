// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AttackTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000548")]
  public sealed class AttackTypesFormatter : 
    IMessagePackFormatter<AttackTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001926")]
    [Address(RVA = "0x693920", Offset = "0x692720", VA = "0x10693920", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AttackTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001927")]
    [Address(RVA = "0x6938D0", Offset = "0x6926D0", VA = "0x106938D0", Slot = "5")]
    public AttackTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new AttackTypes();
    }

    [Token(Token = "0x6001928")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AttackTypesFormatter()
    {
    }
  }
}
