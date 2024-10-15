// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eKnockBackDirFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200054B")]
  public sealed class eKnockBackDirFormatter : 
    IMessagePackFormatter<eKnockBackDir>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600192F")]
    [Address(RVA = "0x6B15C0", Offset = "0x6B03C0", VA = "0x106B15C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eKnockBackDir value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001930")]
    [Address(RVA = "0x6B1570", Offset = "0x6B0370", VA = "0x106B1570", Slot = "5")]
    public eKnockBackDir Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eKnockBackDir();
    }

    [Token(Token = "0x6001931")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eKnockBackDirFormatter()
    {
    }
  }
}
