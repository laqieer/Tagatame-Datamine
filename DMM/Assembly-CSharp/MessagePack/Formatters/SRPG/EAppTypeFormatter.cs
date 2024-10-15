// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EAppTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000560")]
  public sealed class EAppTypeFormatter : IMessagePackFormatter<EAppType>, IMessagePackFormatter
  {
    [Token(Token = "0x600196E")]
    [Address(RVA = "0x69B2C0", Offset = "0x69A0C0", VA = "0x1069B2C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EAppType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600196F")]
    [Address(RVA = "0x69B270", Offset = "0x69A070", VA = "0x1069B270", Slot = "5")]
    public EAppType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EAppType();
    }

    [Token(Token = "0x6001970")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EAppTypeFormatter()
    {
    }
  }
}
