// Decompiled with JetBrains decompiler
// Type: SRPG.UnitJobMasterWindow
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
  [Token(Token = "0x2002C55")]
  [AddComponentMenu("UI/UnitJobMasterWindow")]
  [FlowNode.Pin(100, "Close", FlowNode.PinTypes.Output, 100)]
  public class UnitJobMasterWindow : SRPG_FixedList, IFlowInterface
  {
    [Token(Token = "0x400DB72")]
    [FieldOffset(Offset = "0x64")]
    public GameObject StatusItemTemplate;
    [Token(Token = "0x400DB73")]
    [FieldOffset(Offset = "0x68")]
    public Button NextButton;
    [Token(Token = "0x400DB74")]
    [FieldOffset(Offset = "0x6C")]
    private List<JobMasterValue> mStatusValues;

    [Token(Token = "0x600CD60")]
    [Address(RVA = "0x980D10", Offset = "0x97FB10", VA = "0x10980D10", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600CD61")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "32")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CD62")]
    [Address(RVA = "0x980A70", Offset = "0x97F870", VA = "0x10980A70")]
    public void Refresh(BaseStatus old_status, BaseStatus new_status)
    {
    }

    [Token(Token = "0x600CD63")]
    [Address(RVA = "0x980700", Offset = "0x97F500", VA = "0x10980700", Slot = "22")]
    protected override GameObject CreateItem() => (GameObject) null;

    [Token(Token = "0x600CD64")]
    [Address(RVA = "0x9807A0", Offset = "0x97F5A0", VA = "0x109807A0", Slot = "24")]
    protected override void OnUpdateItem(GameObject go, int index)
    {
    }

    [Token(Token = "0x600CD65")]
    [Address(RVA = "0x980760", Offset = "0x97F560", VA = "0x10980760")]
    private void OnNextClick()
    {
    }

    [Token(Token = "0x600CD66")]
    [Address(RVA = "0x980E20", Offset = "0x97FC20", VA = "0x10980E20")]
    public UnitJobMasterWindow()
    {
    }
  }
}
