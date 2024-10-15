// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RoleTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000557")]
  public sealed class RoleTypesFormatter : IMessagePackFormatter<RoleTypes>, IMessagePackFormatter
  {
    [Token(Token = "0x6001953")]
    [Address(RVA = "0x6A9B20", Offset = "0x6A8920", VA = "0x106A9B20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RoleTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001954")]
    [Address(RVA = "0x6A9AD0", Offset = "0x6A88D0", VA = "0x106A9AD0", Slot = "5")]
    public RoleTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new RoleTypes();
    }

    [Token(Token = "0x6001955")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RoleTypesFormatter()
    {
    }
  }
}
