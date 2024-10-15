// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EffectCheckTargetsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200055E")]
  public sealed class EffectCheckTargetsFormatter : 
    IMessagePackFormatter<EffectCheckTargets>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001968")]
    [Address(RVA = "0x69C3A0", Offset = "0x69B1A0", VA = "0x1069C3A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EffectCheckTargets value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001969")]
    [Address(RVA = "0x69C350", Offset = "0x69B150", VA = "0x1069C350", Slot = "5")]
    public EffectCheckTargets Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EffectCheckTargets();
    }

    [Token(Token = "0x600196A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EffectCheckTargetsFormatter()
    {
    }
  }
}
