// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.LayerMaskFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x200037F")]
  public sealed class LayerMaskFormatter : IMessagePackFormatter<LayerMask>, IMessagePackFormatter
  {
    [Token(Token = "0x60012FD")]
    [Address(RVA = "0x4DC240", Offset = "0x4DB040", VA = "0x104DC240", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LayerMask value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012FE")]
    [Address(RVA = "0x4DC0D0", Offset = "0x4DAED0", VA = "0x104DC0D0", Slot = "5")]
    public LayerMask Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new LayerMask();
    }

    [Token(Token = "0x60012FF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LayerMaskFormatter()
    {
    }
  }
}
