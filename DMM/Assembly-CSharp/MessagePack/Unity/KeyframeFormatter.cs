// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.KeyframeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000377")]
  public sealed class KeyframeFormatter : IMessagePackFormatter<Keyframe>, IMessagePackFormatter
  {
    [Token(Token = "0x60012E5")]
    [Address(RVA = "0x4DBFD0", Offset = "0x4DADD0", VA = "0x104DBFD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Keyframe value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012E6")]
    [Address(RVA = "0x4DBCD0", Offset = "0x4DAAD0", VA = "0x104DBCD0", Slot = "5")]
    public Keyframe Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Keyframe();
    }

    [Token(Token = "0x60012E7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public KeyframeFormatter()
    {
    }
  }
}
