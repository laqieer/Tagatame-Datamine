// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_WaitTap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200125B")]
  [EventActionInfo("New/待機/秒数(タップ)を指定", "指定した時間の間スクリプトの実行を停止します。", 5592405, 4473992)]
  public class EventAction_WaitTap : EventAction
  {
    [Token(Token = "0x40043A1")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public float WaitSeconds;
    [Token(Token = "0x40043A2")]
    [FieldOffset(Offset = "0x1C")]
    public bool waitTap;
    [Token(Token = "0x40043A3")]
    [FieldOffset(Offset = "0x20")]
    private float mTimer;

    [Token(Token = "0x6004DBD")]
    [Address(RVA = "0x1232840", Offset = "0x1231640", VA = "0x11232840", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004DBE")]
    [Address(RVA = "0x1232860", Offset = "0x1231660", VA = "0x11232860", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004DBF")]
    [Address(RVA = "0x1232820", Offset = "0x1231620", VA = "0x11232820", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004DC0")]
    [Address(RVA = "0x1232850", Offset = "0x1231650", VA = "0x11232850", Slot = "10")]
    public override void SkipImmediate()
    {
    }

    [Token(Token = "0x6004DC1")]
    [Address(RVA = "0x1232800", Offset = "0x1231600", VA = "0x11232800", Slot = "8")]
    public override bool Forward() => new bool();

    [Token(Token = "0x6004DC2")]
    [Address(RVA = "0x12327E0", Offset = "0x12315E0", VA = "0x112327E0")]
    public EventAction_WaitTap()
    {
    }
  }
}
