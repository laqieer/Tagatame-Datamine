// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AttackDetailTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200053B")]
  public sealed class AttackDetailTypesFormatter : 
    IMessagePackFormatter<AttackDetailTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60018FF")]
    [Address(RVA = "0x693880", Offset = "0x692680", VA = "0x10693880", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AttackDetailTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001900")]
    [Address(RVA = "0x693830", Offset = "0x692630", VA = "0x10693830", Slot = "5")]
    public AttackDetailTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new AttackDetailTypes();
    }

    [Token(Token = "0x6001901")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AttackDetailTypesFormatter()
    {
    }
  }
}
