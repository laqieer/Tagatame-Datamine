// Decompiled with JetBrains decompiler
// Type: SRPG.RaidStagePoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028F1")]
  [AddComponentMenu("UI/Raid/RaidStagePoint")]
  public class RaidStagePoint : MonoBehaviour
  {
    [Token(Token = "0x400C4E3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private List<Transform> mStageList;
    [Token(Token = "0x400C4E4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mBossStage;

    [Token(Token = "0x17001959")]
    public List<Transform> StageList
    {
      [Token(Token = "0x600B94F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<Transform>) null;
      }
    }

    [Token(Token = "0x1700195A")]
    public Transform BossStage
    {
      [Token(Token = "0x600B950"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x600B951")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RaidStagePoint()
    {
    }
  }
}
