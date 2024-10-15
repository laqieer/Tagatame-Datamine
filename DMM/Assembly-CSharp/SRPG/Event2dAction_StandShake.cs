// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_StandShake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012BA")]
  [EventActionInfo("New/立ち絵2/シェイク", "立ち絵2を揺らします", 5592405, 4473992)]
  public class Event2dAction_StandShake : EventAction
  {
    [Token(Token = "0x40045CB")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x40045CC")]
    [FieldOffset(Offset = "0x1C")]
    public float Duration;
    [Token(Token = "0x40045CD")]
    [FieldOffset(Offset = "0x20")]
    public float FrequencyX;
    [Token(Token = "0x40045CE")]
    [FieldOffset(Offset = "0x24")]
    public float FrequencyY;
    [Token(Token = "0x40045CF")]
    [FieldOffset(Offset = "0x28")]
    public float AmplitudeX;
    [Token(Token = "0x40045D0")]
    [FieldOffset(Offset = "0x2C")]
    public float AmplitudeY;
    [Token(Token = "0x40045D1")]
    [FieldOffset(Offset = "0x30")]
    public bool Async;
    [Token(Token = "0x40045D2")]
    [FieldOffset(Offset = "0x34")]
    private EventStandCharaController2 mStandChara;
    [Token(Token = "0x40045D3")]
    [FieldOffset(Offset = "0x38")]
    private RectTransform mStandCharaTransform;
    [Token(Token = "0x40045D4")]
    [FieldOffset(Offset = "0x3C")]
    private float mSeedX;
    [Token(Token = "0x40045D5")]
    [FieldOffset(Offset = "0x40")]
    private float mSeedY;
    [Token(Token = "0x40045D6")]
    [FieldOffset(Offset = "0x44")]
    private float mTime;
    [Token(Token = "0x40045D7")]
    [FieldOffset(Offset = "0x48")]
    private Vector2 originalPvt;

    [Token(Token = "0x6004F6B")]
    [Address(RVA = "0x1247D40", Offset = "0x1246B40", VA = "0x11247D40", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004F6C")]
    [Address(RVA = "0x1247C50", Offset = "0x1246A50", VA = "0x11247C50", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F6D")]
    [Address(RVA = "0x1247DD0", Offset = "0x1246BD0", VA = "0x11247DD0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004F6E")]
    [Address(RVA = "0x1247F50", Offset = "0x1246D50", VA = "0x11247F50")]
    public Event2dAction_StandShake()
    {
    }
  }
}
