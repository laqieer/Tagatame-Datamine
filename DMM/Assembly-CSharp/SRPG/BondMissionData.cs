// Decompiled with JetBrains decompiler
// Type: SRPG.BondMissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200209D")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondMissionData
  {
    [Token(Token = "0x17001330")]
    public string Iname
    {
      [Token(Token = "0x60087C2"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60087C3"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001331")]
    public bool IsReceived
    {
      [Token(Token = "0x60087C4"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x60087C5"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] private set
      {
      }
    }

    [Token(Token = "0x60087C6")]
    [Address(RVA = "0x49CDF0", Offset = "0x49BBF0", VA = "0x1049CDF0")]
    public bool Deserialize(JSON_BondMissionData json) => new bool();

    [Token(Token = "0x60087C7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondMissionData()
    {
    }
  }
}
