// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ParamPrioritiesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200057B")]
  public sealed class ParamPrioritiesFormatter : 
    IMessagePackFormatter<ParamPriorities>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019BF")]
    [Address(RVA = "0x6A80B0", Offset = "0x6A6EB0", VA = "0x106A80B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ParamPriorities value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019C0")]
    [Address(RVA = "0x6A8060", Offset = "0x6A6E60", VA = "0x106A8060", Slot = "5")]
    public ParamPriorities Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ParamPriorities();
    }

    [Token(Token = "0x60019C1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ParamPrioritiesFormatter()
    {
    }
  }
}
