// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EEventGimmickFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000588")]
  public sealed class EEventGimmickFormatter : 
    IMessagePackFormatter<EEventGimmick>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019E6")]
    [Address(RVA = "0x78DBF0", Offset = "0x78C9F0", VA = "0x1078DBF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EEventGimmick value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019E7")]
    [Address(RVA = "0x78DBA0", Offset = "0x78C9A0", VA = "0x1078DBA0", Slot = "5")]
    public EEventGimmick Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EEventGimmick();
    }

    [Token(Token = "0x60019E8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EEventGimmickFormatter()
    {
    }
  }
}
