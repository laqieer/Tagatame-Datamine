// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayVersus_MapSelector
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
  [Token(Token = "0x20027A5")]
  [AddComponentMenu("UI/MultiPlayVersus_MapSelector")]
  public class MultiPlayVersus_MapSelector : SRPG_FixedList
  {
    [Token(Token = "0x400BB4E")]
    [FieldOffset(Offset = "0x64")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400BB4F")]
    [FieldOffset(Offset = "0x68")]
    public RectTransform ItemLayoutParent;
    [Token(Token = "0x400BB50")]
    [FieldOffset(Offset = "0x6C")]
    public GameObject SelectWindow;
    [Token(Token = "0x400BB51")]
    [FieldOffset(Offset = "0x70")]
    public Button ConfirmButton;
    [Token(Token = "0x400BB52")]
    [FieldOffset(Offset = "0x74")]
    private List<VersusMapParam> m_Param;

    [Token(Token = "0x600B1F6")]
    [Address(RVA = "0x761D30", Offset = "0x760B30", VA = "0x10761D30", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600B1F7")]
    [Address(RVA = "0x761860", Offset = "0x760660", VA = "0x10761860", Slot = "22")]
    protected override GameObject CreateItem() => (GameObject) null;

    [Token(Token = "0x1700188E")]
    public override RectTransform ListParent
    {
      [Token(Token = "0x600B1F8"), Address(RVA = "0x761F10", Offset = "0x760D10", VA = "0x10761F10", Slot = "17")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x600B1F9")]
    [Address(RVA = "0x761B20", Offset = "0x760920", VA = "0x10761B20")]
    protected void RefleshData()
    {
    }

    [Token(Token = "0x600B1FA")]
    [Address(RVA = "0x64FDE0", Offset = "0x64EBE0", VA = "0x1064FDE0", Slot = "20")]
    protected override void Update()
    {
    }

    [Token(Token = "0x600B1FB")]
    [Address(RVA = "0x761A70", Offset = "0x760870", VA = "0x10761A70", Slot = "25")]
    protected override void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600B1FC")]
    [Address(RVA = "0x761E20", Offset = "0x760C20", VA = "0x10761E20")]
    private void UpdateSelect()
    {
    }

    [Token(Token = "0x600B1FD")]
    [Address(RVA = "0x7618C0", Offset = "0x7606C0", VA = "0x107618C0")]
    private void OnConfirm()
    {
    }

    [Token(Token = "0x600B1FE")]
    [Address(RVA = "0x4F8E20", Offset = "0x4F7C20", VA = "0x104F8E20")]
    public MultiPlayVersus_MapSelector()
    {
    }
  }
}
