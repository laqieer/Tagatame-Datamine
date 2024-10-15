// Decompiled with JetBrains decompiler
// Type: SRPG.BondRecipeMatsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019BF")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondRecipeMatsParam
  {
    [Token(Token = "0x17000B27")]
    public string ItemIname
    {
      [Token(Token = "0x6006910"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006911"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000B28")]
    public int Num
    {
      [Token(Token = "0x6006912"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006913"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x6006914")]
    [Address(RVA = "0x34DD40", Offset = "0x34CB40", VA = "0x1034DD40")]
    public bool Deserialize(Json_BondRecipeMatsParam json) => new bool();

    [Token(Token = "0x6006915")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondRecipeMatsParam()
    {
    }
  }
}
