// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.QuaternionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000371")]
  public sealed class QuaternionFormatter : IMessagePackFormatter<Quaternion>, IMessagePackFormatter
  {
    [Token(Token = "0x60012D3")]
    [Address(RVA = "0x4DCF50", Offset = "0x4DBD50", VA = "0x104DCF50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Quaternion value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012D4")]
    [Address(RVA = "0x4DCCC0", Offset = "0x4DBAC0", VA = "0x104DCCC0", Slot = "5")]
    public Quaternion Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Quaternion();
    }

    [Token(Token = "0x60012D5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public QuaternionFormatter()
    {
    }
  }
}
