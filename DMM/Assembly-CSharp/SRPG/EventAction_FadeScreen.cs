// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_FadeScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001203")]
  [EventActionInfo("カメラ/フェード", "画面をフェードイン・フェードアウトさせます", 5592405, 4473992)]
  public class EventAction_FadeScreen : EventAction
  {
    [Token(Token = "0x400418D")]
    [FieldOffset(Offset = "0x18")]
    public EventAction_FadeScreen.FadeModes Mode;
    [Token(Token = "0x400418E")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public bool FadeOut;
    [Token(Token = "0x400418F")]
    [FieldOffset(Offset = "0x1D")]
    public bool Async;
    [Token(Token = "0x4004190")]
    [FieldOffset(Offset = "0x20")]
    public float FadeTime;
    [Token(Token = "0x4004191")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public Color FadeColor;
    [Token(Token = "0x4004192")]
    [FieldOffset(Offset = "0x34")]
    [StringIsActorID]
    [SerializeField]
    private string[] ExcludeUnits;
    [Token(Token = "0x4004193")]
    [FieldOffset(Offset = "0x38")]
    [StringIsActorID]
    [SerializeField]
    private string[] IncludeUnits;

    [Token(Token = "0x6004C9C")]
    [Address(RVA = "0x121A0D0", Offset = "0x1218ED0", VA = "0x1121A0D0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C9D")]
    [Address(RVA = "0x121A0E0", Offset = "0x1218EE0", VA = "0x1121A0E0")]
    private void StartFade()
    {
    }

    [Token(Token = "0x6004C9E")]
    [Address(RVA = "0x121A3D0", Offset = "0x12191D0", VA = "0x1121A3D0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004C9F")]
    [Address(RVA = "0x1219E10", Offset = "0x1218C10", VA = "0x11219E10", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004CA0")]
    [Address(RVA = "0x121A460", Offset = "0x1219260", VA = "0x1121A460")]
    public EventAction_FadeScreen()
    {
    }

    [Token(Token = "0x2001204")]
    public enum FadeModes
    {
      [Token(Token = "0x4004195")] Screen,
      [Token(Token = "0x4004196")] Scene,
    }
  }
}
