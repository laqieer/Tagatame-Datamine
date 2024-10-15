// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CD6")]
  [AddComponentMenu("UI/UnitPicker")]
  public class UnitPicker : UIBehaviour
  {
    [Token(Token = "0x400DED2")]
    [FieldOffset(Offset = "0xC")]
    private Animator mAnimator;
    [Token(Token = "0x400DED3")]
    [FieldOffset(Offset = "0x10")]
    public string OpenTrigger;
    [Token(Token = "0x400DED4")]
    [FieldOffset(Offset = "0x14")]
    public string CloseTrigger;
    [Token(Token = "0x400DED5")]
    [FieldOffset(Offset = "0x18")]
    public float CloseDelay1;
    [Token(Token = "0x400DED6")]
    [FieldOffset(Offset = "0x1C")]
    public float CloseDelay2;
    [Token(Token = "0x400DED7")]
    [FieldOffset(Offset = "0x20")]
    public ListItemEvents Item_Remove;
    [Token(Token = "0x400DED8")]
    [FieldOffset(Offset = "0x24")]
    public ListItemEvents Item_Inactive;
    [Token(Token = "0x400DED9")]
    [FieldOffset(Offset = "0x28")]
    public ListItemEvents Item_Active;

    [Token(Token = "0x600D092")]
    [Address(RVA = "0x9BC720", Offset = "0x9BB520", VA = "0x109BC720", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600D093")]
    [Address(RVA = "0x9BC770", Offset = "0x9BB570", VA = "0x109BC770", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600D094")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Refresh(List<UnitData> inactive, List<UnitData> active)
    {
    }

    [Token(Token = "0x600D095")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0", Slot = "10")]
    protected override void OnRectTransformDimensionsChange()
    {
    }

    [Token(Token = "0x600D096")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitPicker()
    {
    }
  }
}
