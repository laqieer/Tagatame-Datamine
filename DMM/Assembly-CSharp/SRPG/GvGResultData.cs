// Decompiled with JetBrains decompiler
// Type: SRPG.GvGResultData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025BE")]
  public class GvGResultData
  {
    [Token(Token = "0x1700178A")]
    public int Rank
    {
      [Token(Token = "0x600A79B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A79C"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x1700178B")]
    public int Point
    {
      [Token(Token = "0x600A79D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A79E"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x1700178C")]
    public List<int> CaptureNodes
    {
      [Token(Token = "0x600A79F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600A7A0"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x600A7A1")]
    [Address(RVA = "0x6C26B0", Offset = "0x6C14B0", VA = "0x106C26B0")]
    public bool Deserialize(JSON_GvGResult json) => new bool();

    [Token(Token = "0x600A7A2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGResultData()
    {
    }
  }
}
