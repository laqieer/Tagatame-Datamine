// Decompiled with JetBrains decompiler
// Type: SRPG.BondMaterialDatas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200209C")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondMaterialDatas
  {
    [Token(Token = "0x1700132E")]
    public string Iname
    {
      [Token(Token = "0x60087BC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60087BD"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x1700132F")]
    public int ItemNum
    {
      [Token(Token = "0x60087BE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x60087BF"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x60087C0")]
    [Address(RVA = "0x49B4B0", Offset = "0x49A2B0", VA = "0x1049B4B0")]
    public bool Deserialize(JSON_BondMaterialDatas json) => new bool();

    [Token(Token = "0x60087C1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondMaterialDatas()
    {
    }
  }
}
