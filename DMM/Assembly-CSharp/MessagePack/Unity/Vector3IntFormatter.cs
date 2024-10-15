// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.Vector3IntFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000381")]
  public sealed class Vector3IntFormatter : IMessagePackFormatter<Vector3Int>, IMessagePackFormatter
  {
    [Token(Token = "0x6001303")]
    [Address(RVA = "0x4E2020", Offset = "0x4E0E20", VA = "0x104E2020", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Vector3Int value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001304")]
    [Address(RVA = "0x4E1E40", Offset = "0x4E0C40", VA = "0x104E1E40", Slot = "5")]
    public Vector3Int Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Vector3Int();
    }

    [Token(Token = "0x6001305")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Vector3IntFormatter()
    {
    }
  }
}
