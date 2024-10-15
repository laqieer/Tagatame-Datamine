// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_StandChara2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012B6")]
  [EventActionInfo("New/立ち絵2/配置2(2D)", "立ち絵2を配置します", 5592405, 4473992)]
  public class Event2dAction_StandChara2 : EventAction
  {
    [Token(Token = "0x40045AB")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;
    [Token(Token = "0x40045AC")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x40045AD")]
    [FieldOffset(Offset = "0x1C")]
    public bool Flip;
    [Token(Token = "0x40045AE")]
    [FieldOffset(Offset = "0x20")]
    public EventStandCharaController2.PositionTypes Position;
    [Token(Token = "0x40045AF")]
    [FieldOffset(Offset = "0x24")]
    public GameObject StandTemplate;
    [Token(Token = "0x40045B0")]
    [FieldOffset(Offset = "0x28")]
    public string Emotion;
    [Token(Token = "0x40045B1")]
    [FieldOffset(Offset = "0x2C")]
    public bool Async;
    [Token(Token = "0x40045B2")]
    [FieldOffset(Offset = "0x2D")]
    public bool Fade;
    [Token(Token = "0x40045B3")]
    [FieldOffset(Offset = "0x30")]
    [HideInInspector]
    public float FadeTime;
    [Token(Token = "0x40045B4")]
    [FieldOffset(Offset = "0x34")]
    private string DummyID;
    [Token(Token = "0x40045B5")]
    [FieldOffset(Offset = "0x38")]
    private GameObject mStandObject;
    [Token(Token = "0x40045B6")]
    [FieldOffset(Offset = "0x3C")]
    private EventStandChara2 mEventStandChara;
    [Token(Token = "0x40045B7")]
    [FieldOffset(Offset = "0x40")]
    private EventStandCharaController2 mEVCharaController;
    [Token(Token = "0x40045B8")]
    [FieldOffset(Offset = "0x44")]
    private LoadRequest mStandCharaResource;

    [Token(Token = "0x6004F54")]
    [Address(RVA = "0x1246440", Offset = "0x1245240", VA = "0x11246440", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004F55")]
    [Address(RVA = "0x1246140", Offset = "0x1244F40", VA = "0x11246140", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004F56")]
    [Address(RVA = "0x1245DC0", Offset = "0x1244BC0", VA = "0x11245DC0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F57")]
    [Address(RVA = "0x12460B0", Offset = "0x1244EB0", VA = "0x112460B0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004F58")]
    [Address(RVA = "0x1246490", Offset = "0x1245290", VA = "0x11246490", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004F59")]
    [Address(RVA = "0x12465B0", Offset = "0x12453B0", VA = "0x112465B0")]
    public Event2dAction_StandChara2()
    {
    }

    [Token(Token = "0x6004F5A")]
    [Address(RVA = "0x1246560", Offset = "0x1245360", VA = "0x11246560")]
    static Event2dAction_StandChara2()
    {
    }
  }
}
