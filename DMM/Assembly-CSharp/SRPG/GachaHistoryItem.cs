// Decompiled with JetBrains decompiler
// Type: SRPG.GachaHistoryItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200242B")]
  [AddComponentMenu("UI/GachaHistoryItem")]
  public class GachaHistoryItem : MonoBehaviour
  {
    [Token(Token = "0x400A3D8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject UnitIconObj;
    [Token(Token = "0x400A3D9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemIconObj;
    [Token(Token = "0x400A3DA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ArtifactIconObj;
    [Token(Token = "0x400A3DB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ConceptCardIconObj;
    [Token(Token = "0x400A3DC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject CrystalIconObj;
    [Token(Token = "0x400A3DD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400A3DE")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform ListParent;
    [Token(Token = "0x400A3DF")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> mItems;

    [Token(Token = "0x6009DC0")]
    [Address(RVA = "0x602380", Offset = "0x601180", VA = "0x10602380")]
    private void Start()
    {
    }

    [Token(Token = "0x6009DC1")]
    [Address(RVA = "0x601CC0", Offset = "0x600AC0", VA = "0x10601CC0")]
    private void Initalize()
    {
    }

    [Token(Token = "0x6009DC2")]
    [Address(RVA = "0x602460", Offset = "0x601260", VA = "0x10602460")]
    public GachaHistoryItem()
    {
    }
  }
}
