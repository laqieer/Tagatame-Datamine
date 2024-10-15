// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eUnlockTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000599")]
  public sealed class eUnlockTypeFormatter : 
    IMessagePackFormatter<JukeBoxParam.eUnlockType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001A19")]
    [Address(RVA = "0x7A50A0", Offset = "0x7A3EA0", VA = "0x107A50A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JukeBoxParam.eUnlockType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A1A")]
    [Address(RVA = "0x7A5050", Offset = "0x7A3E50", VA = "0x107A5050", Slot = "5")]
    public JukeBoxParam.eUnlockType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new JukeBoxParam.eUnlockType();
    }

    [Token(Token = "0x6001A1B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eUnlockTypeFormatter()
    {
    }
  }
}
