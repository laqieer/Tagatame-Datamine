// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ProtectTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000539")]
  public sealed class ProtectTypesFormatter : 
    IMessagePackFormatter<ProtectTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60018F9")]
    [Address(RVA = "0x6A9A80", Offset = "0x6A8880", VA = "0x106A9A80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ProtectTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018FA")]
    [Address(RVA = "0x6A9A30", Offset = "0x6A8830", VA = "0x106A9A30", Slot = "5")]
    public ProtectTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ProtectTypes();
    }

    [Token(Token = "0x60018FB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ProtectTypesFormatter()
    {
    }
  }
}
