// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactJobList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002004")]
  [AddComponentMenu("UI/ArtifactJobList")]
  public class ArtifactJobList : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x40088A1")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ListItem;
    [Token(Token = "0x40088A2")]
    [FieldOffset(Offset = "0x10")]
    public GameObject AnyJob;
    [Token(Token = "0x40088A3")]
    [FieldOffset(Offset = "0x14")]
    private List<JobParam> mCurrentJobs;
    [Token(Token = "0x40088A4")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> mJobListItems;

    [Token(Token = "0x600844A")]
    [Address(RVA = "0x44F870", Offset = "0x44E670", VA = "0x1044F870")]
    private void Start()
    {
    }

    [Token(Token = "0x600844B")]
    [Address(RVA = "0x44F810", Offset = "0x44E610", VA = "0x1044F810")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600844C")]
    [Address(RVA = "0x44F920", Offset = "0x44E720", VA = "0x1044F920", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600844D")]
    [Address(RVA = "0x44FEF0", Offset = "0x44ECF0", VA = "0x1044FEF0")]
    public ArtifactJobList()
    {
    }
  }
}
