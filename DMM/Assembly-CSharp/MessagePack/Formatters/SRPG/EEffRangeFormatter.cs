// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EEffRangeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000561")]
  public sealed class EEffRangeFormatter : IMessagePackFormatter<EEffRange>, IMessagePackFormatter
  {
    [Token(Token = "0x6001971")]
    [Address(RVA = "0x69B540", Offset = "0x69A340", VA = "0x1069B540", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EEffRange value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001972")]
    [Address(RVA = "0x69B4F0", Offset = "0x69A2F0", VA = "0x1069B4F0", Slot = "5")]
    public EEffRange Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EEffRange();
    }

    [Token(Token = "0x6001973")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EEffRangeFormatter()
    {
    }
  }
}
