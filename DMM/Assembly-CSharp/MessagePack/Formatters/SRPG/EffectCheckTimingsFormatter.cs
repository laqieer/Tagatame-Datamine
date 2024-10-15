// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EffectCheckTimingsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200055F")]
  public sealed class EffectCheckTimingsFormatter : 
    IMessagePackFormatter<EffectCheckTimings>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600196B")]
    [Address(RVA = "0x69C440", Offset = "0x69B240", VA = "0x1069C440", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EffectCheckTimings value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600196C")]
    [Address(RVA = "0x69C3F0", Offset = "0x69B1F0", VA = "0x1069C3F0", Slot = "5")]
    public EffectCheckTimings Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EffectCheckTimings();
    }

    [Token(Token = "0x600196D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EffectCheckTimingsFormatter()
    {
    }
  }
}
