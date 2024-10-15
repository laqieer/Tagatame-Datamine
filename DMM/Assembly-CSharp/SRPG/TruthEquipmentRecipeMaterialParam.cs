// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentRecipeMaterialParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DB5")]
  [MessagePackObject(true)]
  [Serializable]
  public class TruthEquipmentRecipeMaterialParam
  {
    [Token(Token = "0x17001068")]
    public string Iname
    {
      [Token(Token = "0x6007998"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007999"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001069")]
    public int Num
    {
      [Token(Token = "0x600799A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600799B"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x600799C")]
    [Address(RVA = "0x3A4B40", Offset = "0x3A3940", VA = "0x103A4B40")]
    public void Deserialize(JSON_TruthEquipmentRecipeMaterialParam json)
    {
    }

    [Token(Token = "0x600799D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TruthEquipmentRecipeMaterialParam()
    {
    }
  }
}
