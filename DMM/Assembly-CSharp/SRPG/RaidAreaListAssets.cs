// Decompiled with JetBrains decompiler
// Type: SRPG.RaidAreaListAssets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010CA")]
  public class RaidAreaListAssets : ScriptableObject
  {
    [Token(Token = "0x4003C84")]
    [FieldOffset(Offset = "0xC")]
    public List<RaidStagePoint> RaidStagePointList;
    [Token(Token = "0x4003C85")]
    [FieldOffset(Offset = "0x10")]
    [StringIsResourcePath(typeof (GameObject))]
    public string[] RaidAreaBG;

    [Token(Token = "0x6004719")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public RaidAreaListAssets()
    {
    }
  }
}
