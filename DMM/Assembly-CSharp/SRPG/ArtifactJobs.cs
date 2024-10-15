// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactJobs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002005")]
  [AddComponentMenu("UI/ArtifactJobs")]
  public class ArtifactJobs : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x40088A5")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ListItem;
    [Token(Token = "0x40088A6")]
    [FieldOffset(Offset = "0x10")]
    public GameObject AnyJob;
    [Token(Token = "0x40088A7")]
    [FieldOffset(Offset = "0x14")]
    private List<JobParam> mCurrentJobs;
    [Token(Token = "0x40088A8")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> mJobListItems;
    [Token(Token = "0x40088A9")]
    [FieldOffset(Offset = "0x1C")]
    private bool mUpdated;

    [Token(Token = "0x600844E")]
    [Address(RVA = "0x44FFB0", Offset = "0x44EDB0", VA = "0x1044FFB0")]
    private void Start()
    {
    }

    [Token(Token = "0x600844F")]
    [Address(RVA = "0x450050", Offset = "0x44EE50", VA = "0x10450050", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6008450")]
    [Address(RVA = "0x450510", Offset = "0x44F310", VA = "0x10450510")]
    public ArtifactJobs()
    {
    }
  }
}
