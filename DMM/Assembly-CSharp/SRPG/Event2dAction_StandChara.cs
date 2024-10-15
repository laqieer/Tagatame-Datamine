// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_StandChara
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012B4")]
  [EventActionInfo("立ち絵2/配置(2D)", "立ち絵2を配置します", 5592405, 4473992)]
  public class Event2dAction_StandChara : EventAction
  {
    [Token(Token = "0x400459E")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;
    [Token(Token = "0x400459F")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x40045A0")]
    [FieldOffset(Offset = "0x1C")]
    public bool Flip;
    [Token(Token = "0x40045A1")]
    [FieldOffset(Offset = "0x20")]
    public EventStandCharaController2.PositionTypes Position;
    [Token(Token = "0x40045A2")]
    [FieldOffset(Offset = "0x24")]
    public GameObject StandTemplate;
    [Token(Token = "0x40045A3")]
    [FieldOffset(Offset = "0x28")]
    public string Emotion;
    [Token(Token = "0x40045A4")]
    [FieldOffset(Offset = "0x2C")]
    private string DummyID;
    [Token(Token = "0x40045A5")]
    [FieldOffset(Offset = "0x30")]
    private GameObject mStandObject;
    [Token(Token = "0x40045A6")]
    [FieldOffset(Offset = "0x34")]
    private EventStandChara2 mEventStandChara;
    [Token(Token = "0x40045A7")]
    [FieldOffset(Offset = "0x38")]
    private EventStandCharaController2 mEVCharaController;
    [Token(Token = "0x40045A8")]
    [FieldOffset(Offset = "0x3C")]
    private LoadRequest mStandCharaResource;

    [Token(Token = "0x6004F47")]
    [Address(RVA = "0x1247840", Offset = "0x1246640", VA = "0x11247840", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004F48")]
    [Address(RVA = "0x1247560", Offset = "0x1246360", VA = "0x11247560", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004F49")]
    [Address(RVA = "0x1247210", Offset = "0x1246010", VA = "0x11247210", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F4A")]
    [Address(RVA = "0x12474D0", Offset = "0x12462D0", VA = "0x112474D0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004F4B")]
    [Address(RVA = "0x1247890", Offset = "0x1246690", VA = "0x11247890", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004F4C")]
    [Address(RVA = "0x12479A0", Offset = "0x12467A0", VA = "0x112479A0")]
    public Event2dAction_StandChara()
    {
    }

    [Token(Token = "0x6004F4D")]
    [Address(RVA = "0x1247950", Offset = "0x1246750", VA = "0x11247950")]
    static Event2dAction_StandChara()
    {
    }
  }
}
