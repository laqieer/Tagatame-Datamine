// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_FlipStandChara
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
  [Token(Token = "0x2001292")]
  [EventActionInfo("New/立ち絵2/反転(2D)", "立ち絵2を反転します", 5592405, 4473992)]
  public class Event2dAction_FlipStandChara : EventAction
  {
    [Token(Token = "0x40044B7")]
    [FieldOffset(Offset = "0x0")]
    public static List<EventStandCharaController2> InstancesForFlip;
    [Token(Token = "0x40044B8")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x40044B9")]
    [FieldOffset(Offset = "0x1C")]
    public float Time;
    [Token(Token = "0x40044BA")]
    [FieldOffset(Offset = "0x20")]
    public bool async;
    [Token(Token = "0x40044BB")]
    [FieldOffset(Offset = "0x24")]
    private GameObject mStandObjectFlip;
    [Token(Token = "0x40044BC")]
    [FieldOffset(Offset = "0x28")]
    private EventStandCharaController2 mEVCharaController;
    [Token(Token = "0x40044BD")]
    [FieldOffset(Offset = "0x2C")]
    private EventStandCharaController2 mEVCharaFlipController;
    [Token(Token = "0x40044BE")]
    [FieldOffset(Offset = "0x30")]
    private float offset;
    [Token(Token = "0x40044BF")]
    [FieldOffset(Offset = "0x34")]
    private Color InColor;
    [Token(Token = "0x40044C0")]
    [FieldOffset(Offset = "0x44")]
    private Color OutColor;
    [Token(Token = "0x40044C1")]
    [FieldOffset(Offset = "0x54")]
    private List<RawImage> fadeInList;
    [Token(Token = "0x40044C2")]
    [FieldOffset(Offset = "0x58")]
    private List<RawImage> fadeOutList;

    [Token(Token = "0x6004EAB")]
    [Address(RVA = "0x123E530", Offset = "0x123D330", VA = "0x1123E530")]
    public static void DiscardAll()
    {
    }

    [Token(Token = "0x6004EAC")]
    [Address(RVA = "0x123EE80", Offset = "0x123DC80", VA = "0x1123EE80", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004EAD")]
    [Address(RVA = "0x123E5A0", Offset = "0x123D3A0", VA = "0x1123E5A0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EAE")]
    [Address(RVA = "0x123F150", Offset = "0x123DF50", VA = "0x1123F150", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004EAF")]
    [Address(RVA = "0x123EDF0", Offset = "0x123DBF0", VA = "0x1123EDF0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004EB0")]
    [Address(RVA = "0x123F5A0", Offset = "0x123E3A0", VA = "0x1123F5A0")]
    public Event2dAction_FlipStandChara()
    {
    }

    [Token(Token = "0x6004EB1")]
    [Address(RVA = "0x123F520", Offset = "0x123E320", VA = "0x1123F520")]
    static Event2dAction_FlipStandChara()
    {
    }
  }
}
