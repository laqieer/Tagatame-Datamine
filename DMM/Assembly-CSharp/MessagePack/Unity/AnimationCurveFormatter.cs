// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.AnimationCurveFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000378")]
  public sealed class AnimationCurveFormatter : 
    IMessagePackFormatter<AnimationCurve>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60012E8")]
    [Address(RVA = "0x4B6F10", Offset = "0x4B5D10", VA = "0x104B6F10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AnimationCurve value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012E9")]
    [Address(RVA = "0x4B6CE0", Offset = "0x4B5AE0", VA = "0x104B6CE0", Slot = "5")]
    public AnimationCurve Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AnimationCurve) null;
    }

    [Token(Token = "0x60012EA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AnimationCurveFormatter()
    {
    }
  }
}
