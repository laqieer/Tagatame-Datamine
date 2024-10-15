// Decompiled with JetBrains decompiler
// Type: SRPG.UnitJobClassChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C41")]
  [AddComponentMenu("UI/UnitJobClassChange")]
  public class UnitJobClassChange : MonoBehaviour
  {
    [Token(Token = "0x400DB1B")]
    [FieldOffset(Offset = "0xC")]
    public string PrevJobID;
    [Token(Token = "0x400DB1C")]
    [FieldOffset(Offset = "0x10")]
    public string NextJobID;
    [Token(Token = "0x400DB1D")]
    [FieldOffset(Offset = "0x14")]
    public GameObject PrevJob;
    [Token(Token = "0x400DB1E")]
    [FieldOffset(Offset = "0x18")]
    public GameObject NextJob;
    [Token(Token = "0x400DB1F")]
    [FieldOffset(Offset = "0x1C")]
    [NonSerialized]
    public int CurrentRank;
    [Token(Token = "0x400DB20")]
    [FieldOffset(Offset = "0x20")]
    private int mCurrentJobRank;
    [Token(Token = "0x400DB21")]
    [FieldOffset(Offset = "0x24")]
    private int mNextJobRank;
    [Token(Token = "0x400DB22")]
    [FieldOffset(Offset = "0x28")]
    public Text NewRank;
    [Token(Token = "0x400DB23")]
    [FieldOffset(Offset = "0x2C")]
    public Text OldRank;

    [Token(Token = "0x17001B1F")]
    public int CurrentJobRank
    {
      [Token(Token = "0x600CCFC"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600CCFD"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] set
      {
      }
    }

    [Token(Token = "0x17001B20")]
    public int NextJobRank
    {
      [Token(Token = "0x600CCFE"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x600CCFF"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] set
      {
      }
    }

    [Token(Token = "0x600CD00")]
    [Address(RVA = "0x97C300", Offset = "0x97B100", VA = "0x1097C300")]
    private void Start()
    {
    }

    [Token(Token = "0x600CD01")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitJobClassChange()
    {
    }
  }
}
